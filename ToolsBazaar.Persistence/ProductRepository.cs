using Tools.Bazaar.Persistence.Contract.Products;
using ToolsBazaar.Domain.ProductAggregate;

namespace ToolsBazaar.Persistence;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetAll() => DataSet.AllProducts;

    public IEnumerable<Product> GetMostExpensiveProducts()
    {
        return DataSet.AllProducts.OrderByDescending(x => x.Price).ThenBy(x => x.Name);
    }
}