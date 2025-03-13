/* 
 * LobbyRoom.xaml.cs 
 * 
 * Logic for the LobbyRoom user control. Used to display the lobby room that the user is currently in. 
 * Displays the players in the room, allows the user to send group chat messages, send private messages to other players, and share files with other players in the room. 
 * Also allows the user to view shared files and text messages and delete ones they have shared.
 * 
 */

using Library;
using Microsoft.Win32;
using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GameLobbyClient
{
    public partial class LobbyRoom : UserControl
    {
        private MainWindow _mainWindow;
        private IGameLobbyService gameLobbyService;

        private MediaPlayer mediaPlayer; // Media player for audio
        private string tempFilePath; // Temporary file path for audio

        private string _username;
        private string currentRoom;
        private string currentPrivateTextPlayer;
        
        private string filePath;
        private string fileType;
        private float fileSize;
        private string fileSizeString;
        private object lockobject = new object();

        private Thread updatePlayerListThread; // Thread to update the player list
        private Thread updateMessagesThread; // Thread to update the messages
        private Thread updateFilesThread; // Thread to update the file sharing list
        private bool isUpdating = true; // Flag to signal the threads to stop
        
        //Dictionary to store private texts <receipient, concatenated text message>
        private Dictionary<string, string> privateTexts = new Dictionary<string, string>();

        // List to store group chat messages
        private List<string> groupText = new List<string>();

        public LobbyRoom(MainWindow mainWindow, string username, string selectedRoom, IGameLobbyService foob)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _username = username;
            gameLobbyService = foob;

            currentRoom = selectedRoom;
            RoomTitle.Content = currentRoom;

            PlayAudio();

            //Start background threads
            StartUpdatingPlayerList();
            StartUpdatingMessages();
            StartUpdatingFiles();

            // Event handler for ending login window and stopping music stream 
            this.Unloaded += Lobby_End;
        }

        // Play audio when the lobby window is loaded
        private void PlayAudio()
        {
            mediaPlayer = new MediaPlayer();

            // Load the wav file as a stream from the application resources
            var uri = new Uri("pack://application:,,,/Sounds/lobby.wav");
            var streamInfo = Application.GetResourceStream(uri);

            if (streamInfo != null)
            {
                // Write the stream to a temporary file
                tempFilePath = Path.GetTempFileName() + ".wav";
                using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    streamInfo.Stream.CopyTo(fileStream);
                }

                // Use MediaPlayer to play the temporary file
                mediaPlayer.Open(new Uri(tempFilePath));
                mediaPlayer.Volume = 0.05; // Adjust volume
                mediaPlayer.Play(); // Play sound
                mediaPlayer.MediaEnded += (s, e) => mediaPlayer.Play(); // Loop audio
            }
        }

        // Event handler for the end of the lobby window
        private void Lobby_End(object sender, RoutedEventArgs e)
        {
            // Stop the audio playback and delete temporary file
            if (mediaPlayer != null)
            {
                mediaPlayer.Stop();
            }
            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
        }

        // Event handler for the group chat post button
        private void GCSendButton_Click(object sender, RoutedEventArgs e)
        {
            string groupText = GroupChatText.Text;
            //check if the message going to be sent is not empty
            if (!string.IsNullOrEmpty(groupText))
            {
                GroupChatListBox.Items.Add(_username + ": " + groupText); //display on chat box
                gameLobbyService.SendGCMessages(currentRoom, _username, groupText);
            }
        }

        // Event handler for the private message send button
        private void DMSendButton_Click(object sender, RoutedEventArgs e)
        {
            string privTextToSend = DMText.Text;

            if (currentPrivateTextPlayer != null) //if receipient not selected
            {
                if (!string.IsNullOrEmpty(privTextToSend))
                {
                    DMListBox.Items.Add(_username + ": " + privTextToSend); //display on DM box
                    gameLobbyService.SendDMs(currentRoom, _username, currentPrivateTextPlayer, privTextToSend);

                    //if previous texts exist, append new text to existing text
                    if (privateTexts.ContainsKey(currentPrivateTextPlayer))
                    {
                        privTextToSend += _username + ": ";
                        privTextToSend = privateTexts[currentPrivateTextPlayer] + privTextToSend;
                        privateTexts.Remove(currentPrivateTextPlayer);
                    }
                    privateTexts.Add(currentPrivateTextPlayer, privTextToSend);
                }
            }
            else
            {
                MessageBox.Show("Select The Text Recepient");
            }
        }

        // Event handler for the Share File button
        private void ShareFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if the file limit has been reached
            if (!ShareFileButton.IsEnabled)
            {
                MessageBox.Show("File sharing limit reached. Please delete a file before sharing a new one");
                return;
            }

            // Open up file explorer for user
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == true)
            {
                // Get path of the chosen file
                filePath = openFileDialog.FileName;
                
                // Get number of bytes of the file
                long bytes = new FileInfo(filePath).Length;
                string[] sizes = { "Bytes", "Kb", "Mb", "Gb", "Tb" };
                if (bytes == 0)
                {
                    fileSize = 0;
                    fileSizeString = "0 Bytes";
                }
                else
                {
                    // This determines how many "orders of magnitude" the bytes value represents in terms of powers of 1024.
                    // Will also round it down to the nearest whole number
                    int i = (int)(Math.Floor(Math.Log(bytes) / Math.Log(1024)));
                    
                    // This divides the bytes value by the calculated power of 1024 to convert the file size into the
                    // corresponding unit determined by i.
                    fileSize = (float)Math.Round(bytes / Math.Pow(1024, i), 2);
                    fileSizeString = fileSize + " " + sizes[i];
                }

                // Check if file size is less than 100 (assuming KB)
                if (fileSize <= 100)
                {
                    try
                    {
                        byte[] fileData = File.ReadAllBytes(filePath);
                        fileType = System.IO.Path.GetExtension(filePath);
                        gameLobbyService.ShareFile(currentRoom, _username, fileData, fileType, filePath);
                        
                        // Display the message that a file has been shared
                        MessageBox.Show($"File '{filePath}' shared successfully by {_username}");

                        FileSharingListBox.Items.Add(_username + " shared: " + filePath);
                    }
                    catch (CommunicationException ex)
                    { 
                        Console.WriteLine("Error sharing the file: " + ex.Message); 
                    }
                }
                else
                {
                    MessageBox.Show("The file size is too big");
                }
            }
        }

        // Event handler for the Open File button
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            var selectedFileItem = (FileItem)FileSharingListBox.SelectedItem;
            
            if (selectedFileItem != null)
            {
                filePath = selectedFileItem.FilePath;
                fileType = selectedFileItem.FileType;

                // If text file
                if (fileType != null && fileType.Equals(".txt"))
                {
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);

                        // Write to terminal
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Reading the text file");
                            Console.WriteLine(temp.GetString(b));
                        }
                    }
                }
                // If image file
                else if (fileType != null && (fileType.Equals(".jpg") || fileType.Equals(".png") || fileType.Equals(".jpeg")))
                {
                    // Display in image box on UI
                    SharedImage.Source = new BitmapImage(new Uri(filePath));
                    CloseFileButton.Visibility = Visibility.Visible;
                }
            }
        }

        // Event handler for the Delete File button
        private void DeleteFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected file item
            var selectedFileItem = (FileItem)FileSharingListBox.SelectedItem;

            if (selectedFileItem != null)
            {
                // Check if the selected file was shared by the current user
                if (selectedFileItem.Username == _username)
                {
                    // Remove the file from the server
                    gameLobbyService.DeleteFile(currentRoom, _username, selectedFileItem.FilePath);

                    // Remove the file from the UI list
                    FileSharingListBox.Items.Remove(selectedFileItem);
                    MessageBox.Show($"File '{selectedFileItem.FilePath}' deleted successfully");
                    DisplaySharedFiles();
                }
                else
                {
                    // If the file was shared by another user, show an error message
                    MessageBox.Show("You can only delete files you have shared");
                }
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        // Event handler for the Close File button
        private void CloseFileButton_Click(object sender, RoutedEventArgs e)
        {
            SharedImage.Source = null;
            CloseFileButton.Visibility = Visibility.Hidden;
        }

        // Event handler for the Exit Room button
        private void ExitRoomButton_Click(object sender, RoutedEventArgs e)
        {
            isUpdating = false; // Signal the thread to stop

            // Wait for the update threads to stop, with a timeout 
            if (!updatePlayerListThread.Join(2000))
            {
                Console.WriteLine("Update PlayerList thread did not stop in time");
            }
            if (!updateMessagesThread.Join(2000))
            {
                Console.WriteLine("Update Messages thread did not stop in time");
            }
            if (!updateFilesThread.Join(2000)) 
            {
                Console.WriteLine("Update Files thread did not stop in time");
            }

            gameLobbyService.LeaveRoom(currentRoom, _username);
            privateTexts.Clear();
            _mainWindow.SwitchToLobby(_username);
        }

        // Display group chat messages
        private void DisplayGroupText()
        {
            groupText = gameLobbyService.GetGroupMessages(currentRoom);
            GroupChatListBox.Items.Clear(); //clear list box

            foreach (var str in groupText)
            {
                GroupChatListBox.Items.Add($"{str}"); //add items to list box
            }
        }

        // Display private messages
        private void DisplayPrivateDMs()
        {
            DMListBox.Items.Clear();

            if (!string.IsNullOrEmpty(currentPrivateTextPlayer))
            {
                privateTexts = gameLobbyService.getDMs(_username);

                if (privateTexts.ContainsKey(currentPrivateTextPlayer))
                {
                    // Get conversation with current selected player
                    string conversation = privateTexts[currentPrivateTextPlayer]; 
                    string[] messages = conversation.Split('\n'); // Split appended message into individual texts

                    foreach (string message in messages)
                    {
                        DMListBox.Items.Add(message); // Display each text
                    }
                }
            }
        }

        // Display players in the room 
        private void DisplayPlayersList()
        {
            Dictionary<string, List<Player>> activeLobbyRooms = gameLobbyService.GetActiveLobbyRooms();
            PlayersListBox.Items.Clear(); //cler list box
            
            if (activeLobbyRooms[currentRoom] != null)
            {
                foreach (Player player in activeLobbyRooms[currentRoom])
                {
                    //Display every player
                    //Add (Me) to indicate the user's player
                    if (!player.Username.Equals(_username)) 
                    {
                        PlayersListBox.Items.Add(player.Username);
                    }
                    else
                    {
                        PlayersListBox.Items.Add(_username + " (Me)");
                    }
                }
            }
        }

        // Display shared files
        private void DisplaySharedFiles()
        {
            var sharedFiles = gameLobbyService.GetSharedFiles(currentRoom);
            FileSharingListBox.Items.Clear();

            // Limit the number of items displayed to 3
            int fileCount = 0;
            foreach (var file in sharedFiles)
            {
                if (fileCount >= 3)
                {
                    break;
                }

                var fileItem = new FileItem
                {
                    DisplayText = $"{file.Username} shared: {file.FileType}",
                    FilePath = file.FilePath,
                    FileType = file.FileType,
                    Username = file.Username
                };

                FileSharingListBox.Items.Add(fileItem);
                fileCount++;
            }

            // Disable the Share File button if there are 3 or more files
            ShareFileButton.IsEnabled = fileCount < 3;
        }

        // Check if the user has selected a player to send a private message to
        private void PlayersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PlayersListBox.SelectedItem != null)
            {
                string player = PlayersListBox.SelectedItem.ToString(); //get selected player to text

                if (DMListBox.Items.Count != 0 && !privateTexts.ContainsKey(player))
                {
                    //Display previous texts, if any
                    string existingTextMessage = GetExistingTextMessage();
                    privateTexts.Add(player, existingTextMessage);
                }
                currentPrivateTextPlayer = player; 

                DMListBox.Items.Clear(); //clear DM list box
            }
        }

        // Get existing text messages
        private string GetExistingTextMessage()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            //Append displayed DM into a single string
            foreach (var item in DMListBox.Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            
            return stringBuilder.ToString();
        }

        // Start the threads to update the player list
        private void StartUpdatingPlayerList()
        {
            updatePlayerListThread = new Thread(() =>
            {
                while (isUpdating)
                {
                    // Periodically request player lists from the server every 3 seconds
                    Thread.Sleep(3000);
                    Dispatcher.Invoke(() =>
                    {
                        DisplayPlayersList();
                    });
                }
            });

            // Set the thread to run in the background
            updatePlayerListThread.IsBackground = true;
            updatePlayerListThread.Start();
        }

        // Start the threads to update the messages
        private void StartUpdatingMessages()
        {
            updateMessagesThread = new Thread(() =>
            {
                while (isUpdating)
                {
                    // Periodically request messages from the server every 2 seconds
                    Thread.Sleep(2000);
                    Dispatcher.Invoke(() =>
                    {
                        DisplayGroupText();
                        DisplayPrivateDMs();
                    });
                }
            });

            // Set the thread to run in the background
            updateMessagesThread.IsBackground = true;
            updateMessagesThread.Start();
        }

        // Start the threads to update the files
        private void StartUpdatingFiles()
        {
            updateFilesThread = new Thread(() =>
            {
                while (isUpdating)
                {
                    // Periodically request file list from the server every 3 seconds
                    Thread.Sleep(3000);
                    Dispatcher.Invoke(() =>
                    {
                        DisplaySharedFiles();
                    });
                }
            });

            // Set the thread to run in the background
            updateFilesThread.IsBackground = true;
            updateFilesThread.Start();
        }
    }
}