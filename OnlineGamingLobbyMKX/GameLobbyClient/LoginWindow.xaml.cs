/* 
 * LoginWindow.xaml.cs
 * 
 * Login window that allows the user to enter their username and password to login to the game lobby.
 * 
 */

using Server;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GameLobbyClient
{
    public partial class LoginWindow : UserControl
    {
        private IGameLobbyService gameLobbyService;
        private MainWindow _mainWindow;
        private MediaPlayer mediaPlayer; // Media player for audio
        private string tempFilePath; // Temporary file path for audio

        public LoginWindow(MainWindow mainWindow, IGameLobbyService foob)
        {
            InitializeComponent();

            gameLobbyService = foob;
            _mainWindow = mainWindow;

            // Event handler for ending login window and stopping music stream 
            this.Unloaded += LoginWindow_End;

            PlayAudio();
        }

        // Play audio when the login window is loaded
        private void PlayAudio()
        {
            mediaPlayer = new MediaPlayer();

            // Load the wav file as a stream from the application resources
            var uri = new Uri("pack://application:,,,/Sounds/loginSound.wav");
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
                mediaPlayer.Volume = 0.1; // Adjust volume
                mediaPlayer.Play(); // Play sound
                mediaPlayer.MediaEnded += (s, e) => mediaPlayer.Play(); // Loop audio
            }
        }

        // Event handler for the login button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            // Check if the username and password are not empty
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Switch to the lobby window if the login is successful
                if (gameLobbyService.Login(username, password)) 
                {
                    _mainWindow.SwitchToLobby(username);
                }
                else
                {
                    StatusLabel.Content = "Login Unsuccessful";
                    MessageBox.Show("Username Already Taken");
                }
            }
            else
            {
                StatusLabel.Content = "Login Unsuccessful";
                MessageBox.Show("Invalid Credentials");
            }
        }

        // Event handler for the end of the login window
        private void LoginWindow_End(object sender, RoutedEventArgs e)
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
    }
}