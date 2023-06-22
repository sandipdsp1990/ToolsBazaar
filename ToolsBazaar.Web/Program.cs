using Microsoft.AspNetCore.Localization;
using Tools.Bazaar.Persistence.Contract.Customers;
using Tools.Bazaar.Persistence.Contract.Orders;
using Tools.Bazaar.Persistence.Contract.Products;
using ToolsBazaar.Persistence;
using ToolsBazaar.Services.AutoMapper;
using ToolsBazaar.Services.Contracts.Products;
using ToolsBazaar.Services.Customers;
using ToolsBazaar.Services.Products;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddAutoMapper(typeof(ProductProfile));

var app = builder.Build();

app.UseRouting();

var requestCulture = new RequestCulture("en-US");
requestCulture.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy";
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = requestCulture
});

app.MapControllerRoute("default",
                       "{controller}/{action=Index}/{id?}");

app.Run();