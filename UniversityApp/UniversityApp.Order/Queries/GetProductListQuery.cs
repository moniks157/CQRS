using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDemo.Product.Models;

namespace ShopDemo.Product.Queries
{
    public record GetProductListQuery() : IRequest<List<ProductModel>>;
}
