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
/// Interaction logic for EditCustomerWindow.xaml
/// </summary>
public partial class EditCustomerWindow : Window
{
    private Customer _customer;

    public EditCustomerWindow(Customer customer)
    {
        InitializeComponent();
        _customer = customer;

        // Load customer data into the fields
        FullNameTextBox.Text = _customer.CustomerFullName;
        EmailTextBox.Text = _customer.EmailAddress;
        TelephoneTextBox.Text = _customer.Telephone;
        BirthdayPicker.SelectedDate = _customer.CustomerBirthday;
        PasswordBox.Password = _customer.Password;
    }

    private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
    {
        // Update customer properties
        _customer.CustomerFullName = FullNameTextBox.Text;
        _customer.EmailAddress = EmailTextBox.Text;
        _customer.Telephone = TelephoneTextBox.Text;
        _customer.CustomerBirthday = BirthdayPicker.SelectedDate.Value;
        _customer.Password = PasswordBox.Password;

        // Save changes to repository
        CustomerRepository.UpdateCustomer(_customer);

        MessageBox.Show("Customer details updated successfully.");

        // Close the window
        this.Close();
    }

    private void TelephoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void UpdateRoomButton_Click(object sender, RoutedEventArgs e)
    {

    }
}

