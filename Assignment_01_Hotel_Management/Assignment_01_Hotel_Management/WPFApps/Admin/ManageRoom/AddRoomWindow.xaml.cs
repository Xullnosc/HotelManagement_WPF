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
/// Interaction logic for AddRoomWindow.xaml
/// </summary>
public partial class AddRoomWindow : Window
{
    public AddRoomWindow()
    {
        InitializeComponent();
        // Load room types into the ComboBox
        RoomTypeComboBox.ItemsSource = RoomRepository.GetRoomTypes();
        RoomTypeComboBox.DisplayMemberPath = "RoomTypeName";
        RoomTypeComboBox.SelectedValuePath = "RoomTypeID";
    }

    private void SaveRoomButton_Click(object sender, RoutedEventArgs e)
    {
        var newRoom = new Room();
        // Create and validate new room

        newRoom.RoomNumber = RoomNumberTextBox.Text;
        newRoom.RoomDescription = RoomDescriptionTextBox.Text;
        newRoom.RoomMaxCapacity = int.Parse(RoomCapacityTextBox.Text);
        newRoom.RoomPricePerDate = decimal.Parse(RoomPriceTextBox.Text);
        try
        {
            newRoom.RoomStatus = (RoomStatusComboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Active" ? 1 : 2; // Active or Deleted
        }
        catch (Exception)
        {
            MessageBox.Show("Select status !!!");
        }
        newRoom.RoomTypeID = (int)RoomTypeComboBox.SelectedValue; // Get the selected room type ID


        // Add the new room to the repository
        RoomRepository.AddRoom(newRoom);

        MessageBox.Show("Room added successfully.");

        // Close the window
        this.Close();
    }
}

