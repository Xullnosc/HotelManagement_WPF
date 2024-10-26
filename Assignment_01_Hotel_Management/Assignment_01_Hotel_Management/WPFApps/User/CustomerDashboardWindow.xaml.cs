using Assignment_01_Hotel_Management.Entities;
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

namespace Assignment_01_Hotel_Management.WPFApps.User
{
    /// <summary>
    /// Interaction logic for CustomerDashboardWindow.xaml
    /// </summary>
    public partial class CustomerDashboardWindow : Window
    {
        private readonly Customer loggedInCustomer;
        public CustomerDashboardWindow(Customer loggedInCustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
        }

        private void ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            var profileWindow = new CustomerProfileWindow(loggedInCustomer);
            profileWindow.Show();
            this.Close();
        }

        private void ViewBooking_Click(object sender, RoutedEventArgs e)
        {
            var bookingWindow = new CustomerBookingWindow(loggedInCustomer);
            bookingWindow.Show();
            this.Close();

        }

        private void ViewHistoryBooking_Click(object sender, RoutedEventArgs e)
        {
            var historyBooking = new ViewHistoryBookingWindow(loggedInCustomer);
            historyBooking.Show();
            this.Close();

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show(); 
            this.Close();
        }
    }
}
