using Microsoft.AspNetCore.Mvc;
using ToolsBazaar.Services.Contracts.Products;

namespace ToolsBazaar.Web.Controllers;

public record CustomerDto(string Name);

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly ILogger<CustomersController> _logger;

    public CustomersController(ILogger<CustomersController> logger, ICustomerService customerService)
    {
        _logger = logger;
        _customerService = customerService;
    }

    [HttpPut("{customerId:int}")]
    public IActionResult UpdateCustomerName(int customerId, [FromBody] CustomerDto dto)
    {
        _logger.LogInformation($"Updating customer #{customerId} name.");
        var customer = _customerService.GetCustomerById(customerId);
        if (customer != null)
        {
            _customerService.UpdateCustomerName(customerId, dto.Name);
            return Ok();
        }
        else
        {
            _logger.LogWarning("Customer with id {customerId} not found.", customerId);

            return NotFound();
        }
    }

    [HttpGet("top")]
    public IActionResult GetTopCustomers()
    {
        _logger.LogInformation($"Getting top customer By spending.");
        var topCustomers = _customerService.GetTopCustomerByDateRange(new DateTime(2015, 1, 1), new DateTime(2022, 12, 31));
        return Ok(topCustomers);

    }


}