using Assignment_01_Hotel_Management.Entities;
using Assignment_01_Hotel_Management.Repositories;
using Assignment_01_Hotel_Management.WPFApps.Admin;
using System.Windows;


namespace Assignment_01_Hotel_Management.WPFApps
{
    /// <summary>
    /// Interaction logic for AdminManageCustomerWindow.xaml
    /// </summary>
    public partial class AdminManageCustomerWindow : Window
    {
        public AdminManageCustomerWindow()
        {
            InitializeComponent();
            LoadCustomerData();

        }

        // Load all customer data into DataGrid
        private void LoadCustomerData()
        {
            CustomerDataGrid.ItemsSource = CustomerRepository.GetAllCustomers();
        }

        // Search customers by name or email
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchTextBox.Text;
            CustomerDataGrid.ItemsSource = CustomerRepository.SearchCustomers(searchText);
        }

        // Add a new customer
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Open a new window to add a customer (you can create a separate AddCustomerWindow)
            AddCustomerWindow addCustomerWindow = new AddCustomerWindow();
            addCustomerWindow.ShowDialog();

            // Reload the customer data after adding
            LoadCustomerData();
        }

        // Edit selected customer
        private void EditCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                // Open a new window to edit customer details (you can create a separate EditCustomerWindow)
                EditCustomerWindow editCustomerWindow = new EditCustomerWindow(selectedCustomer);
                editCustomerWindow.ShowDialog();

                // Reload the customer data after editing
                LoadCustomerData();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        // Delete selected customer
        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    CustomerRepository.DeleteCustomer(selectedCustomer.CustomerID);

                    // Reload the customer data after deletion
                    LoadCustomerData();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void ManageRoom_Click(object sender, RoutedEventArgs e)
        {
            var adminDashboard = new AdminDashboardWindow();
            adminDashboard.Show();
            this.Close();
        }
    }
}
