using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDemo.DataAccess.Entities;

namespace ShopDemo.DataAccess.Interfaces
{
    public interface ICustomerDataAccess
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        Customer InsertCustomer(string firstName, string lastName);
    }
}
