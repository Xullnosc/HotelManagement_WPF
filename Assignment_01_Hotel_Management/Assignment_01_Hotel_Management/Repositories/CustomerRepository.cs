using Assignment_01_Hotel_Management.Entities;


namespace Assignment_01_Hotel_Management.Repositories;

public class CustomerRepository
{
    private static List<Customer> _customers = new List<Customer>();

    static CustomerRepository()
    {
        _customers.Add(new Customer()
        {
            CustomerID = 0,
            CustomerFullName = "Dat",
            CustomerBirthday = new DateTime(2000, 11, 20),
            EmailAddress = "dat@gmail.com",
            Password = "123",
            Telephone = "0905111222"
        });
    }

    public static List<Customer> GetAllCustomers() => _customers;

    public static void AddCustomer(Customer customer)
    {
        var lastIndex = _customers.Count - 1;
        customer.CustomerID = lastIndex + 1;
        _customers.Add(customer);
    }

    public static void UpdateCustomer(Customer customer)
    {
        var existingCustomer = _customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
        if (existingCustomer != null)
        {
            existingCustomer.CustomerFullName = customer.CustomerFullName;
            existingCustomer.Telephone = customer.Telephone;
            existingCustomer.EmailAddress = customer.EmailAddress;
            existingCustomer.CustomerBirthday = customer.CustomerBirthday;
            existingCustomer.Password = customer.Password;
        }
    }

    public static void DeleteCustomer(int customerId)
    {
        var customerToDelete = _customers.FirstOrDefault(c => c.CustomerID == customerId);
        if (customerToDelete != null)
        {
            _customers.Remove(customerToDelete);
        }
    }

    //public static Customer GetCustomerById(int customerId)
    //{
    //    return _customers.FirstOrDefault(c => c.CustomerID == customerId);
    //}

    public static List<Customer> SearchCustomers(string searchText)
    {
        return _customers.Where(c => c.CustomerFullName.Contains(searchText) || c.EmailAddress.Contains(searchText)).ToList();
    }
}

