using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDemo.Customer.Models;

namespace ShopDemo.Customer.Queries
{
    public record GetCustomerListQuery : IRequest<List<CustomerModel>>;

}
