using MediatR;
using ShopDemo.Product.Models;

namespace ShopDemo.Product.Commands
{
    public record InsertProductCommand(string Name) : IRequest<ProductModel>;
}
