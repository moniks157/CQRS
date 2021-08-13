using MediatR;
using ShopDemo.Customer.DataAccess.Interfaces;
using ShopDemo.Customer.Models;
using ShopDemo.Customer.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace ShopDemo.Customer.Handlers
{
    class GeCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, CustomerModel>
    {
        private readonly ICustomerDataAccess _data;

        public GeCustomerByIdHandler(ICustomerDataAccess data)
        {
            _data = data;
        }

        public Task<CustomerModel> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetCustomer(request.Id));
        }
    }
}
