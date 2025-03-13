using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Windows;

namespace PeerToPeerClient
{
    [Synchronization]
    public class JobService : ContextBoundObject, IJobService
    {
        private string pendingEncodedJobCode = null;
        private string pendingJobHash = null; 

        // Method to check if there's a pending job
        public bool HasPendingJob()
        {
            {
                return pendingEncodedJobCode != null;
            }
        }

        // Method to get the pending job's Base64 encoded code and its SHA256 hash
        public (string EncodedJobCode, string Hash) GetPendingJob()
        {
            {
                var job = (pendingEncodedJobCode, pendingJobHash);
                pendingEncodedJobCode = null; // Clear the job after fetching
                pendingJobHash = null;
                return job;
            }
        }

        // Method to submit a job (Base64 encoded code and hash)
        public void SubmitJob(string encodedJobCode, string hash)
        {
            {
                if (pendingEncodedJobCode == null)
                {
                    pendingEncodedJobCode = encodedJobCode;
                    pendingJobHash = hash;
                }
                else
                {
                    // Job already exists
                    throw new InvalidOperationException("A job is already pending");
                }
            }
        }

        // Method to receive job result
        public void ReceiveJobResult(string result)
        {
            try
            {
                {
                    // Clear the pending job
                    pendingEncodedJobCode = null;
                    pendingJobHash = null;
                }

                // Use BeginInvoke outside the lock
                System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        MessageBox.Show($"Job completed! Result:\n{result}", "Job Completed!", MessageBoxButton.OK, MessageBoxImage.Information);
                        // Update the job status
                        var mainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;
                        mainWindow.JobStatusTextBlock.Text = "Idle";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating UI: {ex.Message}", "UI Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ReceiveJobResult: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Override InitializeLifetimeService to make the object live indefinitely
        public override object InitializeLifetimeService()
        {
            return null; // Remoting object will live indefinitely
        }
    }
}
