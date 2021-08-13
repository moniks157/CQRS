using System.Collections.Generic;
using System.Linq;
using ShopDemo.Customer.DataAccess.Interfaces;
using ShopDemo.Customer.Models;

namespace ShopDemo.Customer.DataAccess
{
    public class CustomerDemoDataAccess : ICustomerDataAccess
    {
        private List<CustomerModel> customers = new();

        public CustomerDemoDataAccess()
        {
            customers.Add(new CustomerModel { Id = 1, FirstName = "Ala", LastName = "Makota" });
            customers.Add(new CustomerModel { Id = 2, FirstName = "John", LastName = "Snow" });
        }

        public List<CustomerModel> GetCustomers()
        {
            return customers;
        }

        public CustomerModel GetCustomer(int id)
        {
            var result = customers.FirstOrDefault(x => x.Id == id);

            return result;
        }

        public CustomerModel InsertCustomer(string firstName, string lastName)
        {
            CustomerModel c = new() { FirstName = firstName, LastName = lastName };
            c.Id = customers.Max(x => x.Id) + 1;
            customers.Add(c);
            return c;
        }
    }
}
