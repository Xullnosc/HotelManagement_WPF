using Assignment_01_Hotel_Management.Repositories;
using Assignment_01_Hotel_Management.WPFApps.Admin;
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
/// Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string email = EmailTextBox.Text;
        string password = PasswordBox.Password;

        if (email == "admin@FUMiniHotelSystem.com" && password == "@@abc123@@")
        {
            MessageBox.Show("Admin logged in!");
            // Navigate to Admin window
            var adminDashboardWindow = new AdminDashboardWindow();
            adminDashboardWindow.Show();
            this.Close();
        }
        else
        {
            var customer = CustomerRepository.GetAllCustomers().FirstOrDefault(c => c.EmailAddress == email && c.Password == password);
            if (customer != null)
            {
                MessageBox.Show("Customer logged in!");
                // Navigate to Customer profile window
                var customerDashboard = new CustomerDashboardWindow(customer);
                customerDashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
