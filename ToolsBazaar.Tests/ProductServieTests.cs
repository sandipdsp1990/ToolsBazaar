using AutoMapper;
using FluentAssertions;
using NSubstitute;
using Tools.Bazaar.Persistence.Contract.Customers;
using Tools.Bazaar.Persistence.Contract.Orders;
using ToolsBazaar.Services.AutoMapper;
using ToolsBazaar.Services.Contracts.Products;
using ToolsBazaar.Services.Customers;

namespace ToolsBazaar.Tests;

public class ProductServieTests
{
    private ICustomerService customerService { get; }
    private readonly IOrderRepository orderRepository;
    protected readonly ICustomerRepository customerRepository;
    protected readonly IMapper mapper;

    public ProductServieTests()
    {
        customerRepository = Substitute.For<ICustomerRepository>();
        orderRepository = Substitute.For<IOrderRepository>();
        var myProfile = new ProductProfile();
        var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));
        var mapper = new Mapper(configuration);
        customerService = new CustomerService(customerRepository, orderRepository, mapper, null);
    }

    // Aplologies for the less testes was in time crunch so did it quickly
    [Fact]
    public void WhenOrdersPresent_ThenReceiveTop5Cusotmers()
    {

        orderRepository.GetAll().Returns(TestData.TopOrdersListVersion1.AsQueryable());
        var result = customerService.GetTopCustomerByDateRange(new DateTime(2015, 1, 1), new DateTime(2022, 12, 31)).ToList();

        result.Count.Should().Be(5);
        result[0].Id.Should().Be(5);
        result[1].Id.Should().Be(3);
        result[2].Id.Should().Be(11);
        result[3].Id.Should().Be(9);
        result[4].Id.Should().Be(13);
    }

    [Fact]
    public void WhenLessOrdersPresent_ThenReceiveTop4Cusotmers()
    {

        orderRepository.GetAll().Returns(TestData.TopOrdersListVersion2.AsQueryable());
        var result = customerService.GetTopCustomerByDateRange(new DateTime(2015, 1, 1), new DateTime(2022, 12, 31)).ToList();

        result.Count.Should().Be(4);
        result[0].Id.Should().Be(5);
        result[1].Id.Should().Be(3);
        result[2].Id.Should().Be(1);
        result[3].Id.Should().Be(7); ;
    }
}