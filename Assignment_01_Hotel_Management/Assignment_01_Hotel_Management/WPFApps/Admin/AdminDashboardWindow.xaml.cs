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

namespace Assignment_01_Hotel_Management.WPFApps.Admin
{
    /// <summary>
    /// Interaction logic for AdminDashboardWindow.xaml
    /// </summary>
    public partial class AdminDashboardWindow : Window
    {
        public AdminDashboardWindow()
        {
            InitializeComponent();
        }

        private void manageCustomer_Click(object sender, RoutedEventArgs e)
        {
            var manageCustomer = new AdminManageCustomerWindow();
            manageCustomer.Show();
            this.Close();
        }

        private void manageRoom_Click(object sender, RoutedEventArgs e)
        {
            var manageRoom = new AdminManageRoomWindow();
            manageRoom.Show();
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
