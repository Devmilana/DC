/* 
 * LobbyRoomSelectionWindow.xaml.cs 
 * 
 * Handles user interaction with the lobby room selection window.
 * The user can join a room, create a room, log out, and view the available rooms
 * 
 */

using Server;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using Library;

namespace GameLobbyClient
{
    public partial class LobbyRoomSelectionWindow : UserControl
    {
        private MainWindow _mainWindow;
        private IGameLobbyService gameLobbyService;
        private string _username;

        private Thread updateThread; // Thread for updating the lobby rooms
        private bool isUpdating = true; // Flag to signal the thread to stop

        public LobbyRoomSelectionWindow(MainWindow mainWindow, string username, IGameLobbyService foob)
        {
            InitializeComponent();

            gameLobbyService = foob;
            _mainWindow = mainWindow;
            _username = username;

            StartUpdatingLobbyRooms();
        }

        // Event handler for join room button click
        private void JoinRoomButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if a room is selected
            if (LobbyRoomsListBox.SelectedItem != null)
            {
                string selectedRoom = LobbyRoomsListBox.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedRoom))
                {
                    gameLobbyService.JoinRoom(selectedRoom, _username);
                    _mainWindow.SwitchToRoom(selectedRoom);
                }
            }
            else
            {
                MessageBox.Show("Select A Room");
            }
        }

        // Event handler for create room button click
        private void CreateRoomButton_Click(object sender, RoutedEventArgs e)
        {
            string newLobbyRoom = NewLobbyRoomTextBox.Text;

            // Check if the room name is not empty
            if (!string.IsNullOrEmpty(newLobbyRoom))
            {
                // Check if the room name is not already in use
                if (gameLobbyService.CreateRoom(newLobbyRoom))
                {
                    DisplayLobbyRooms();
                }
                else
                {
                    MessageBox.Show($"{newLobbyRoom} Already Exists!");
                }
            }
        }

        // Event handler for log out button click
        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            isUpdating = false; // Signal the thread to stop

            // Wait for the update thread to stop, with a timeout 
            if (!updateThread.Join(5000)) 
            {
                Console.WriteLine("Update thread did not stop in time.");
            }

            gameLobbyService.Logout(_username);
            _mainWindow.SwitchToLogin();
        }

        // Display the available lobby rooms
        private void DisplayLobbyRooms()
        {
            Dictionary<string, List<Player>> activeLobbyRooms = gameLobbyService.GetActiveLobbyRooms();
            
            LobbyRoomsListBox.Items.Clear();

            // Add the lobby rooms to the list box
            foreach (string str in activeLobbyRooms.Keys)
            {
                LobbyRoomsListBox.Items.Add(str);
            }
        }

        // Start the thread for updating the lobby rooms
        private void StartUpdatingLobbyRooms()
        {
            updateThread = new Thread(() =>
            {
                while (isUpdating)
                {
                    // Periodically request lobby rooms from the server every 5 seconds
                    Thread.Sleep(5000);

                    // Call the DisplayLobbyRooms method on the UI thread
                    Dispatcher.Invoke(() =>
                    {
                        DisplayLobbyRooms();
                    });
                }
            });

            // Set the thread to run in the background
            updateThread.IsBackground = true;
            updateThread.Start();
        }
    }
}