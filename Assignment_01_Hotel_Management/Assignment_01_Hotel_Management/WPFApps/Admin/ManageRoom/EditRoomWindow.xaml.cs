using Assignment_01_Hotel_Management.Entities;
using Assignment_01_Hotel_Management.Repositories;
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
/// Interaction logic for EditRoomWindow.xaml
/// </summary>
public partial class EditRoomWindow : Window
{
    private Room _roomToEdit;

    // Constructor accepting the room to edit
    public EditRoomWindow(Room room)
    {
        InitializeComponent();

        _roomToEdit = room;

        // Load existing room details into the form fields
        RoomNumberTextBox.Text = room.RoomNumber;
        RoomDescriptionTextBox.Text = room.RoomDescription;
        RoomCapacityTextBox.Text = room.RoomMaxCapacity.ToString();
        RoomPriceTextBox.Text = room.RoomPricePerDate.ToString();

        // Load Room Types into ComboBox
        RoomTypeComboBox.ItemsSource = RoomRepository.GetRoomTypes();
        RoomTypeComboBox.DisplayMemberPath = "RoomTypeName";
        RoomTypeComboBox.SelectedValuePath = "RoomTypeID";

        // Set the current RoomType as selected
        RoomTypeComboBox.SelectedValue = room.RoomTypeID;

        // Set the current status
        var currentStatus = room.RoomStatus == 1 ? "Active" : "Deleted";
        foreach (ComboBoxItem item in RoomStatusComboBox.Items)
        {
            if (item.Content.ToString() == currentStatus)
            {
                item.IsSelected = true;
                break;
            }
        }
    }

    // Click event to save updates to the room
    private void UpdateRoomButton_Click(object sender, RoutedEventArgs e)
    {
        // Validate input
        if (string.IsNullOrWhiteSpace(RoomNumberTextBox.Text) ||
            string.IsNullOrWhiteSpace(RoomDescriptionTextBox.Text) ||
            string.IsNullOrWhiteSpace(RoomCapacityTextBox.Text) ||
            string.IsNullOrWhiteSpace(RoomPriceTextBox.Text))
        {
            MessageBox.Show("All fields are required!");
            return;
        }

        // Parse inputs
        int roomID = _roomToEdit.RoomID;
        string roomNumber = RoomNumberTextBox.Text;
        string roomDescription = RoomDescriptionTextBox.Text;
        int roomMaxCapacity = int.Parse(RoomCapacityTextBox.Text);
        decimal roomPricePerDate = decimal.Parse(RoomPriceTextBox.Text);
        int roomTypeID = (int)RoomTypeComboBox.SelectedValue;
        int roomStatus = (RoomStatusComboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Active" ? 1 : 2;

        // Create a new Room object with updated values
        var updatedRoom = new Room
        {
            RoomID = roomID,
            RoomNumber = roomNumber,
            RoomDescription = roomDescription,
            RoomMaxCapacity = roomMaxCapacity,
            RoomPricePerDate = roomPricePerDate,
            RoomTypeID = roomTypeID,
            RoomStatus = roomStatus
        };

        // Update the room in the repository
        RoomRepository.UpdateRoom(updatedRoom);

        MessageBox.Show("Room updated successfully.");
        this.Close();
    }
}
