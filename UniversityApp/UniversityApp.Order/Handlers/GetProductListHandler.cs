using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ShopDemo.Product.Models;
using ShopDemo.Product.Queries;

namespace ShopDemo.Product.Handlers
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<ProductModel>>
    {
        public Task<List<ProductModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
