using Tools.Bazaar.Persistence.Contract.Customers;
using ToolsBazaar.Domain.CustomerAggregate;

namespace ToolsBazaar.Persistence;

public class CustomerRepository : ICustomerRepository
{
    public IQueryable<Customer> GetAll() => DataSet.AllCustomers.AsQueryable();

    public Customer GetCustomerById(int customerId)
    {
        return DataSet.AllCustomers.FirstOrDefault(c => c.Id == customerId);
    }

    public void UpdateCustomerName(int customerId, string name)
    {
        var customer = DataSet.AllCustomers.FirstOrDefault(c => c.Id == customerId);

        if (customer == null)
        {
            throw new InvalidOperationException($"No Customer found with Id {customerId}");
        }

        customer.UpdateName(name);
    }
}