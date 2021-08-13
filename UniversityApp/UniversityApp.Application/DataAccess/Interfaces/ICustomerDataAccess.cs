using ShopDemo.Customer.Models;
using System.Collections.Generic;

namespace ShopDemo.Customer.DataAccess.Interfaces
{
    public interface ICustomerDataAccess
    {
        List<CustomerModel> GetCustomers();
        CustomerModel GetCustomer(int id);
        CustomerModel InsertCustomer(string firstName, string lastName);
    }
}
