using Assignment_01_Hotel_Management.Entities;
using Assignment_01_Hotel_Management.Repositories;
using Assignment_01_Hotel_Management.WPFApps.User;
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
/// Interaction logic for CustomerBookingWindow.xaml
/// </summary>
public partial class CustomerBookingWindow : Window
{
    private Customer _loggedInCustomer;

    // Constructor accepting the logged-in customer
    public CustomerBookingWindow(Customer loggedInCustomer)
    {
        InitializeComponent();
        _loggedInCustomer = loggedInCustomer;

        // Load available rooms
        LoadAvailableRooms();
    }

    // Method to load available rooms from RoomRepository
    private void LoadAvailableRooms()
    {
        // Filter for available rooms (RoomStatus = Active, and possibly other criteria)
        var availableRooms = RoomRepository.GetAllRooms().Where(r => r.RoomStatus == 1)
            .ToList();
        RoomForBookingDataGrid.ItemsSource = availableRooms;
    }

    // Event handler for Book Room button
    private void BookRoomButton_Click(object sender, RoutedEventArgs e)
    {
        // Validate input
        if (RoomForBookingDataGrid.SelectedItem == null)
        {
            MessageBox.Show("Please select a room.");
            return;
        }

        if (CheckInDatePicker.SelectedDate == null || CheckOutDatePicker.SelectedDate == null)
        {
            MessageBox.Show("Please select check-in and check-out dates.");
            return;
        }

        DateTime checkInDate = CheckInDatePicker.SelectedDate.Value;
        DateTime checkOutDate = CheckOutDatePicker.SelectedDate.Value;

        if (checkInDate >= checkOutDate)
        {
            MessageBox.Show("Check-out date must be after check-in date.");
            return;
        }

        // Get selected room
        Room selectedRoom = (Room)RoomForBookingDataGrid.SelectedItem;

        // Create a booking record
        Booking newBooking = new Booking
        {
            BookingID = BookingRepository.GetNextBookingID(),
            CustomerID = _loggedInCustomer.CustomerID,
            RoomID = selectedRoom.RoomID,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate,
            BookingStatus = "Pending",  // Booking can be pending initially
            TotalPrice = CalculateTotalPrice(checkInDate, checkOutDate, selectedRoom)
        };

        // Add booking to repository
        BookingRepository.AddBooking(newBooking);

        // Optionally, update room status to "Booked"
        selectedRoom.RoomStatus = 2; 
        RoomRepository.UpdateRoom(selectedRoom);

        // Inform the user
        MessageBox.Show("Room booked successfully!");

        // Close the booking window
        //this.Close();
        ViewHistoryBookingWindow viewHistoryBookingWindow = new ViewHistoryBookingWindow(_loggedInCustomer);
        viewHistoryBookingWindow.Show();    
        this.Close();
    }

    private decimal CalculateTotalPrice(DateTime checkInDate, DateTime checkOutDate, Room selectedRoom)
    {
        var days = (checkOutDate - checkInDate).Days;
        return selectedRoom.RoomPricePerDate * days;
    }

    private void viewDashboard_Click(object sender, RoutedEventArgs e)
    {
        var dashboard = new CustomerDashboardWindow(_loggedInCustomer);
        dashboard.Show();
        this.Close();
    }
}
