using AutoMapper;
using Microsoft.Extensions.Logging;
using Tools.Bazaar.Persistence.Contract.Products;
using ToolsBazaar.Domain.ProductAggregate;
using ToolsBazaar.Services.Contracts.Products;
using ToolsBazaar.Services.Contracts.Products.Dtos;

namespace ToolsBazaar.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger, IMapper mapper)
        {
            _productRepository = productRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<ProductDto> GetMostExpensiveProducts()
        {
            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(_productRepository.GetMostExpensiveProducts());
        }

    }
}
