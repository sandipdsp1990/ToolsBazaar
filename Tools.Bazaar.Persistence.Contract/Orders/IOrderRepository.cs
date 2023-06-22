using ToolsBazaar.Domain.OrderAggregate;

namespace Tools.Bazaar.Persistence.Contract.Orders;

public interface IOrderRepository
{
    IQueryable<Order> GetAll();
}