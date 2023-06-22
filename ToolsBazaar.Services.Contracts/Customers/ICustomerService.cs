using ToolsBazaar.Services.Contracts.Customers.Dto;

namespace ToolsBazaar.Services.Contracts.Products
{
    public interface ICustomerService
    {
        void UpdateCustomerName(int customerId, string name);
        CustomerDto GetCustomerById(int customerId);
        IEnumerable<CustomerDto> GetTopCustomerByDateRange(DateTime startDate, DateTime endDate);
    }
}
