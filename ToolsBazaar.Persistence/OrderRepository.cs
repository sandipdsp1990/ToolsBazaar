using Tools.Bazaar.Persistence.Contract.Orders;
using ToolsBazaar.Domain.OrderAggregate;

namespace ToolsBazaar.Persistence;

public class OrderRepository : IOrderRepository
{
    public IQueryable<Order> GetAll() => DataSet.AllOrders.AsQueryable();
}