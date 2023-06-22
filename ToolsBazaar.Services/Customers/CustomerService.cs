using AutoMapper;
using Microsoft.Extensions.Logging;
using Tools.Bazaar.Persistence.Contract.Customers;
using Tools.Bazaar.Persistence.Contract.Orders;
using ToolsBazaar.Domain.CustomerAggregate;
using ToolsBazaar.Services.Contracts.Customers.Dto;
using ToolsBazaar.Services.Contracts.Products;

namespace ToolsBazaar.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<CustomerService> _logger;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IOrderRepository orderRepository, IMapper mapper, ILogger<CustomerService> logger)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public CustomerDto GetCustomerById(int customerId)
        {
            return _mapper.Map<CustomerDto>(_customerRepository.GetCustomerById(customerId));
        }

        public void UpdateCustomerName(int customerId, string name)
        {
            _logger.LogInformation("Updating customer #{customerId}", customerId);
            _customerRepository.UpdateCustomerName(customerId, name);
        }

        public IEnumerable<CustomerDto> GetTopCustomerByDateRange(DateTime startDate, DateTime endDate)
        {
            var allOrders = _orderRepository.GetAll();
            var top5Customers = allOrders.Where(x => x.Date >= startDate && x.Date <= endDate).GroupBy(x => x.Customer).OrderByDescending(y => y.Sum(z => z.Items.Select(a => a.Price).Sum())).Select(x => x.Key).Take(5);
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(top5Customers);
        }


    }
}
