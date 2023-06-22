using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToolsBazaar.Services.Contracts.Products;

namespace ToolsBazaar.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(ILogger<ProductsController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet("most-expensive")]
    public IActionResult MostExpensive()
    {
        _logger.LogDebug($"Getting Most Expensive Products...");
        return Ok(_productService.GetMostExpensiveProducts());
    }

}