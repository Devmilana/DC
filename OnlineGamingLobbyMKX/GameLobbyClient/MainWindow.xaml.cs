/*
 * MainWindow.xaml.cs
 * 
 * Contains the logic for switching between the login screen, lobby room selection screen, and the lobby room screen.
 * 
 */

using System.Windows;
using System.ServiceModel;
using Server;

namespace GameLobbyClient
{
    public partial class MainWindow : Window
    {
        private IGameLobbyService foob;
        private string username;
        public MainWindow()
        {
            InitializeComponent();

            // Set the window size to 1280x720
            this.Width = 1280;
            this.Height = 720;

            // Bind the client to the server
            var tcp = new NetTcpBinding();
            var URL = "net.tcp://localhost:8100/MortalXGamingService";
            var channelFactory = new ChannelFactory<IGameLobbyService>(tcp, URL);
            foob = channelFactory.CreateChannel();

            SwitchToLogin();
        }

        // Switches the main content of the window to the login screen
        public void SwitchToLogin()
        {
            MainContent.Content = new LoginWindow(this, foob);
        }

        // Switches the main content of the window to the lobby room selection screen
        public void SwitchToLobby(string username)
        {
            this.username = username;
            MainContent.Content = new LobbyRoomSelectionWindow(this, username, foob);
        }

        // Switches the main content of the window to the lobby room screen
        public void SwitchToRoom(string selectedRoom)
        {
            MainContent.Content = new LobbyRoom(this, username, selectedRoom, foob);
        }
    }
}