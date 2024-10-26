using Assignment_01_Hotel_Management.Entities;
using Assignment_01_Hotel_Management.Repositories;
using Assignment_01_Hotel_Management.WPFApps.Admin;
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
using System.Windows.Shapes;

namespace Assignment_01_Hotel_Management.WPFApps;

/// <summary>
/// Interaction logic for AdminManageRoomWindow.xaml
/// </summary>
public partial class AdminManageRoomWindow : Window
{
    public AdminManageRoomWindow()
    {
        InitializeComponent();
        LoadRoomData();
    }

    // Load all room data into DataGrid
    private void LoadRoomData()
    {
        RoomDataGrid.ItemsSource = RoomRepository.GetAllRooms();
    }

    // Search rooms by room number or type
    private void SearchButton_Click(object sender, RoutedEventArgs e)
    {
        string searchText = SearchTextBox.Text;
        RoomDataGrid.ItemsSource = RoomRepository.SearchRooms(searchText);
    }

    // Add a new room
    private void AddRoomButton_Click(object sender, RoutedEventArgs e)
    {
        // Open a new window to add a room (you can create a separate AddRoomWindow)
        AddRoomWindow addRoomWindow = new AddRoomWindow();
        addRoomWindow.ShowDialog();

        // Reload the room data after adding
        LoadRoomData();
    }

    // Edit selected room
    private void EditRoomButton_Click(object sender, RoutedEventArgs e)
    {
        if (RoomDataGrid.SelectedItem is Room selectedRoom)
        {
            // Open a new window to edit room details (you can create a separate EditRoomWindow)
            EditRoomWindow editRoomWindow = new EditRoomWindow(selectedRoom);
            editRoomWindow.ShowDialog();
            RoomDataGrid.ItemsSource = RoomRepository.GetAllRooms();  // Refresh the grid

            // Reload the room data after editing
            LoadRoomData();
        }
        else
        {
            MessageBox.Show("Please select a room to edit.");
        }
    }

    // Delete selected room
    private void DeleteRoomButton_Click(object sender, RoutedEventArgs e)
    {
        if (RoomDataGrid.SelectedItem is Room selectedRoom)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this room?", "Delete Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                RoomRepository.DeleteRoom(selectedRoom.RoomID);

                // Reload the room data after deletion
                LoadRoomData();
            }
        }
        else
        {
            MessageBox.Show("Please select a room to delete.");
        }
    }

    private void ManageCustomer_Click(object sender, RoutedEventArgs e)
    {
        var adminDashboard = new AdminDashboardWindow();
        adminDashboard.Show();
        this.Close();
    }
}
