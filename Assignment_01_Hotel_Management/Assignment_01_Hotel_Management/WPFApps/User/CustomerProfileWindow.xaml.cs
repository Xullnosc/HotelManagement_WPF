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
/// Interaction logic for CustomerProfileWindow.xaml
/// </summary>
public partial class CustomerProfileWindow : Window
{
    private Customer customer;

    public CustomerProfileWindow(Customer customer)
    {
        InitializeComponent();
        this.customer = customer;
        FullNameTextBox.Text = customer.CustomerFullName;
        TelephoneTextBox.Text = customer.Telephone;
        EmailTextBox.Text = customer.EmailAddress;
        BirthdayPicker.SelectedDate = customer.CustomerBirthday;
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        customer.CustomerFullName = FullNameTextBox.Text;
        customer.Telephone = TelephoneTextBox.Text;
        customer.EmailAddress = EmailTextBox.Text;
        customer.CustomerBirthday = BirthdayPicker.SelectedDate.Value;

        // Save the updated customer information
        CustomerRepository.UpdateCustomer(customer);
        MessageBox.Show("Profile updated successfully.");
    }

    private void ViewBooking(object sender, RoutedEventArgs e)
    {
        CustomerBookingWindow customerBookingWindow = new CustomerBookingWindow(customer);
        customerBookingWindow.Show();
        this.Close();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void viewDashboard_Click(object sender, RoutedEventArgs e)
    {
        var dashboard = new CustomerDashboardWindow(customer);
        dashboard.Show();
        this.Close();
    }
}
