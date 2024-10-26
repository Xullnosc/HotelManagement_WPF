using Assignment_01_Hotel_Management.Entities;
using Assignment_01_Hotel_Management.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ViewHistoryBookingWindow.xaml
    /// </summary>
    public partial class ViewHistoryBookingWindow : Window
    {

        private readonly Customer loggedInCustomer;
        public ViewHistoryBookingWindow(Customer loggedInCustomer)
        {
            InitializeComponent();
            this.loggedInCustomer = loggedInCustomer;
            LoadBookingData();

        }

        private void LoadBookingData()
        {
            BookingDataGrid.ItemsSource = BookingRepository.GetAllBookings().Where(booking => booking.CustomerID == loggedInCustomer.CustomerID);
        }

        private void BookingDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void viewDashboard_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new CustomerDashboardWindow(loggedInCustomer);
            dashboard.Show();
            this.Close();
        }
    }
}
