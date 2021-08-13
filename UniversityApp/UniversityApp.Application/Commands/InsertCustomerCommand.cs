using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDemo.Customer.Models;

namespace ShopDemo.Customer.Commands
{
    public record InsertCustomerCommand(string FirstName, string LastName) : IRequest<CustomerModel>;
}
