using ToolsBazaar.Domain.ProductAggregate;
using ToolsBazaar.Services.Contracts.Products.Dtos;

namespace ToolsBazaar.Services.Contracts.Products
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetMostExpensiveProducts();
    }
}
