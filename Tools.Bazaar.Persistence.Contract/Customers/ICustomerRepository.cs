using ToolsBazaar.Domain.CustomerAggregate;

namespace Tools.Bazaar.Persistence.Contract.Customers;

public interface ICustomerRepository
{
    void UpdateCustomerName(int customerId, string name);
    IQueryable<Customer> GetAll();
    Customer GetCustomerById(int customerId);
}