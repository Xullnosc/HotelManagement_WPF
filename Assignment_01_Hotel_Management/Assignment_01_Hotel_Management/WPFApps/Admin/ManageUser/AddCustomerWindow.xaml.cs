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

namespace Assignment_01_Hotel_Management.WPFApps
{
    /// <summary>
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void SaveCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Create and validate new customer
            var newCustomer = new Customer
            {
                CustomerFullName = FullNameTextBox.Text,
                EmailAddress = EmailTextBox.Text,
                Telephone = TelephoneTextBox.Text,
                CustomerBirthday = BirthdayPicker.SelectedDate.Value,
                Password = PasswordBox.Password,
                CustomerStatus = 1 // Default to Active
            };

            // Add the new customer to the repository
            CustomerRepository.AddCustomer(newCustomer);

            MessageBox.Show("Customer added successfully.");

            // Close the window
            this.Close();
        }
    }
}
