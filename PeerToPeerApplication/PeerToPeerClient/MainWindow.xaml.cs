using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using IronPython.Hosting;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using System.Security.Cryptography;

namespace PeerToPeerClient
{
    public partial class MainWindow : Window
    {
        private string webServiceUrl = "http://localhost:5000";
        private int clientId;
        private string ipAddress;

        private int remotingPort;
        private Thread serverThread;
        
        private JobService jobService;
        public static string PythonCode = string.Empty;
        public static bool IsWorking = false;
        public static int JobsCompleted = 0;

        // CancellationTokenSource for stopping threads
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        // Timer for sending heartbeats
        private System.Timers.Timer heartbeatTimer;

        public MainWindow()
        {
            InitializeComponent();

            remotingPort = SelectAvailablePort(9000, 9100);

            // Get the local IP address
            ipAddress = GetLocalIPAddress();

            // Register with the web service
            RegisterWithWebService();

            // Start the server thread
            StartServerThread();

            // Start the heartbeat
            StartHeartbeat();

            // Start the networking thread
            Task.Run(() => NetworkingThread(cancellationTokenSource.Token));
        }

        // Select an available port in the specified range
        private int SelectAvailablePort(int minPort, int maxPort)
        {
            var rnd = new Random();
            while (true)
            {
                int port = rnd.Next(minPort, maxPort);
                if (IsPortAvailable(port))
                {
                    return port;
                }
            }
        }

        // Check if a port is available
        private bool IsPortAvailable(int port)
        {
            bool isAvailable = true;
            System.Net.Sockets.TcpListener listener = null;
            try
            {
                listener = new System.Net.Sockets.TcpListener(IPAddress.Any, port);
                listener.Start();
            }
            catch
            {
                isAvailable = false;
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
            return isAvailable;
        }

        // Start the heartbeat timer
        private void StartHeartbeat()
        {
            heartbeatTimer = new System.Timers.Timer(60000);
            heartbeatTimer.Elapsed += (sender, e) => SendHeartbeat();
            heartbeatTimer.AutoReset = true;
            heartbeatTimer.Start();

            SendHeartbeat();
        }

        // Send a heartbeat to the web service
        private void SendHeartbeat()
        {
            var client = new RestClient(webServiceUrl);

            var request = new RestRequest("/api/Clients/Heartbeat", Method.Post);
            request.AddJsonBody(new
            {
                ClientId = clientId
            });

            RestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Failed to send heartbeat to the web service", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                });
            }
        }

        // Start the remoting server thread
        private void StartServerThread()
        {
            serverThread = new Thread(() =>
            {
                // Start the remoting server
                StartRemotingServer();

                // Keep the thread alive
                Thread.Sleep(Timeout.Infinite);
            });
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        // Start the remoting server
        private void StartRemotingServer()
        {
            // Register the TCP channel
            TcpChannel channel = new TcpChannel(remotingPort);
            ChannelServices.RegisterChannel(channel, false);

            // Instantiate the JobService
            jobService = new JobService();

            // Register the remote object with synchronization
            RemotingServices.Marshal(jobService, "JobService");
        }

        // Start the networking thread
        private async Task NetworkingThread(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                // Check if we have a pending job and update the UI accordingly
                Dispatcher.Invoke(() =>
                {
                    if (jobService.HasPendingJob())
                    {
                        JobStatusTextBlock.Text = "Job Submitted. Waiting for execution";
                    }
                    else
                    {
                        JobStatusTextBlock.Text = "Idle";
                    }

                    JobsCompletedTextBlock.Text = JobsCompleted.ToString();
                });

                // Check for jobs from other clients
                await CheckForJobsFromOtherClients();

                await Task.Delay(5000);
            }
        }

        // Register client with the web service
        private void RegisterWithWebService()
        {
            var client = new RestClient(webServiceUrl);

            var request = new RestRequest("/api/Clients/Register", Method.Post);
            request.AddJsonBody(new
            {
                IPAddress = ipAddress,
                Port = remotingPort
            });

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var responseData = JsonConvert.DeserializeObject<dynamic>(response.Content);
                clientId = responseData.id;
            }
            else
            {
                MessageBox.Show("Failed to register with the web service", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Get the local IP address from machine
        private string GetLocalIPAddress()
        {
            string localIP = "";
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private void LoadFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Python files (*.py)|*.py|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                string code = File.ReadAllText(openFileDialog.FileName);
                PythonCodeTextBox.Text = code;
            }
        }

        private void SubmitCodeButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PythonCodeTextBox.Text))
            {
                MessageBox.Show("Please enter Python code or load from a file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Base64 encode the job code
                string encodedJobCode = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(PythonCodeTextBox.Text));

                // Compute the SHA256 hash of the encoded job code
                byte[] hashBytes = ComputeSHA256Hash(encodedJobCode);

                // Convert hash bytes to Base64 string
                string hashString = Convert.ToBase64String(hashBytes);

                // Submit the job to our own JobService
                jobService.SubmitJob(encodedJobCode, hashString);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Job Submission Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private byte[] ComputeSHA256Hash(string data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
            }
        }

        // Check for jobs from other clients
        private async Task CheckForJobsFromOtherClients()
        {
            try
            {
                // Get the list of clients from the web service
                var clients = await GetClientsFromWebService();

                // Exclude the current client
                clients = clients.Where(c => c.Id != clientId).ToList();

                foreach (var clientInfo in clients)
                {
                    try
                    {
                        // Connect to the client's remoting server
                        string url = $"tcp://{clientInfo.IPAddress}:{clientInfo.Port}/JobService";

                        IJobService remoteJobService = (IJobService)Activator.GetObject(
                            typeof(IJobService),
                            url);

                        // Check if the client has a pending job
                        if (remoteJobService.HasPendingJob())
                        {
                            // Get the pending job's encoded code and hash
                            var (encodedJobCode, receivedHashString) = remoteJobService.GetPendingJob();

                            if (!string.IsNullOrEmpty(encodedJobCode) && !string.IsNullOrEmpty(receivedHashString))
                            {
                                // Compute the SHA256 hash of the received encoded job code
                                byte[] computedHashBytes = ComputeSHA256Hash(encodedJobCode);

                                // Convert received hash string back to bytes
                                byte[] receivedHashBytes = Convert.FromBase64String(receivedHashString);

                                // Compare the hashes
                                if (computedHashBytes.SequenceEqual(receivedHashBytes))
                                {
                                    // Decode the Base64 encoded job code
                                    string jobCode = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encodedJobCode));

                                    // Execute the job
                                    string result = await ExecutePythonCode(jobCode);

                                    // Send the result back to the originating client
                                    remoteJobService.ReceiveJobResult(result);

                                    // Report job completion to the web service
                                    ReportJobCompletion();

                                    // Increment jobs completed
                                    JobsCompleted++;

                                    // Update the UI from the UI thread
                                    Dispatcher.Invoke(() =>
                                    {
                                        JobsCompletedTextBlock.Text = JobsCompleted.ToString();
                                    });
                                }
                                else
                                {
                                    //  If hashes do not match
                                    Dispatcher.Invoke(() =>
                                    {
                                        MessageBox.Show("Received job code hash does not match. Job will not be executed", "Hash Mismatch", MessageBoxButton.OK, MessageBoxImage.Warning);
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Dispatcher.Invoke(() =>
                        {
                            MessageBox.Show($"Error connecting to client {clientInfo.IPAddress}:{clientInfo.Port} - {ex.Message}", "Client Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show($"Error checking for jobs: {ex.Message}", "Networking Error", MessageBoxButton.OK, MessageBoxImage.Error);
                });
            }
        }

        private async Task<string> ExecutePythonCode(string code)
        {
            return await Task.Run(() =>
            {
                try
                {
                    // Initialize IronPython engine
                    var engine = Python.CreateEngine();
                    var scope = engine.CreateScope();

                    // Redirect standard output
                    var outputStream = new MemoryStream();
                    var streamWriter = new StreamWriter(outputStream);
                    engine.Runtime.IO.SetOutput(outputStream, streamWriter);

                    // Execute the Python code
                    engine.Execute(code, scope);

                    // Flush and read the output
                    streamWriter.Flush();
                    outputStream.Seek(0, SeekOrigin.Begin);
                    var reader = new StreamReader(outputStream);
                    string output = reader.ReadToEnd();

                    // Update the UI with the output
                    if (IsWorking)
                    {
                        Dispatcher.Invoke(() =>
                        {
                            MessageBox.Show($"Output:\n{output}", "Python Output", MessageBoxButton.OK, MessageBoxImage.Information);
                        });
                    }

                    return output;
                }
                catch (Exception ex)
                {
                    Dispatcher.Invoke(() =>
                    {
                        MessageBox.Show($"Error executing Python code: {ex.Message}", "Execution Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    });

                    return $"Error executing Python code: {ex.Message}";
                }
            });
        }

        // Get the list of clients from the web service
        private async Task<List<ClientInfo>> GetClientsFromWebService()
        {
            var client = new RestClient(webServiceUrl);

            var request = new RestRequest("/api/Clients/List", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var clients = JsonConvert.DeserializeObject<List<ClientInfo>>(response.Content);
                return clients;
            }
            else
            {
                return new List<ClientInfo>();
            }
        }

        // Report job completion to the web service
        private void ReportJobCompletion()
        {
            var client = new RestClient(webServiceUrl);

            var request = new RestRequest("/api/Clients/JobComplete", Method.Post);
            request.AddJsonBody(new
            {
                ClientId = clientId,
                JobDescription = "Completed a job."
            });

            RestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Failed to report job completion to the web service", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                });
            }
        }

        // Handle window closing
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            cancellationTokenSource.Cancel();
            heartbeatTimer?.Stop();
            DeregisterFromWebService();
        }

        // Remove client from the web service
        private void DeregisterFromWebService()
        {
            var client = new RestClient(webServiceUrl);

            var request = new RestRequest("/api/Clients/Deregister", Method.Post);
            request.AddJsonBody(new
            {
                ClientId = clientId
            });

            RestResponse response = client.Execute(request);
        }

        public class ClientInfo
        {
            public int Id { get; set; }
            public string IPAddress { get; set; }
            public int Port { get; set; }
            public DateTime LastUpdated { get; set; }
        }
    }
}
