using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDemo.DataAccess.Interfaces;
using ShopDemo.DataAccess.Entities;

namespace ShopDemo.DataAccess
{
    public class CustomerDemoDataAccess : ICustomerDataAccess
    {
        private List<Customer> customers = new();

        public CustomerDemoDataAccess()
        {
            customers.Add(new Customer { Id = 1, FirstName = "Ala", LastName = "Makota" });
            customers.Add(new Customer { Id = 2, FirstName = "John", LastName = "Snow" });
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            var result = customers.FirstOrDefault(x => x.Id == id);

            return result;
        }

        public Customer InsertCustomer(string firstName, string lastName)
        {
            Customer c = new() { FirstName = firstName, LastName = lastName };
            c.Id = customers.Max(x => x.Id) + 1;
            customers.Add(c);
            return c;
        }
    }
}
