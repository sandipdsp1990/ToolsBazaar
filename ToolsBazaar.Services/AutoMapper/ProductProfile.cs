using AutoMapper;
using ToolsBazaar.Domain.CustomerAggregate;
using ToolsBazaar.Domain.ProductAggregate;
using ToolsBazaar.Services.Contracts.Customers.Dto;
using ToolsBazaar.Services.Contracts.Products.Dtos;

namespace ToolsBazaar.Services.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Customer, CustomerDto > ();
        }
    }
}
