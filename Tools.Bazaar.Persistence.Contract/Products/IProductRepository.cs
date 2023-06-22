using ToolsBazaar.Domain.ProductAggregate;

namespace Tools.Bazaar.Persistence.Contract.Products;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    IEnumerable<Product> GetMostExpensiveProducts();
}