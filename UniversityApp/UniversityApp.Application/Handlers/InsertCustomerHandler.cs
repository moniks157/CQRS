using MediatR;
using ShopDemo.Customer.Commands;
using ShopDemo.Customer.DataAccess.Interfaces;
using ShopDemo.Customer.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ShopDemo.Customer.Handlers
{
    public class InsertCustomerHandler : IRequestHandler<InsertCustomerCommand, CustomerModel>
    {
        private readonly ICustomerDataAccess _data;

        public InsertCustomerHandler(ICustomerDataAccess data)
        {
            _data = data;
        }

        public Task<CustomerModel> Handle(InsertCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = _data.InsertCustomer(request.FirstName, request.LastName);
            return Task.FromResult(result);
        }
    }
}
