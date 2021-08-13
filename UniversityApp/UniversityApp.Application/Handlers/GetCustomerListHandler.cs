using MediatR;
using ShopDemo.Customer.DataAccess.Interfaces;
using ShopDemo.Customer.Models;
using ShopDemo.Customer.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopDemo.Customer.Handlers
{
    public class GetCustomerListHandler : IRequestHandler<GetCustomerListQuery, List<CustomerModel>>
    {
        private readonly ICustomerDataAccess _data;

        public GetCustomerListHandler(ICustomerDataAccess data)
        {
            _data = data;
        }

        public Task<List<CustomerModel>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetCustomers());
        }
    }
}
