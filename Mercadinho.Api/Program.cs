using Mercadinho.Api.SharedContext;
using Mercadinho.Application.EmployeeContext.UseCases.CreateEmployee;
using Mercadinho.Application.EmployeeContext.UseCases.DeleteEmployee;
using Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;
using Mercadinho.Application.EmployeeContext.UseCases.UpdateEmployee;
using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Application.ProductContext.UseCases.CreateProduct;
using Mercadinho.Application.ProductContext.UseCases.DeleteProduct;
using Mercadinho.Application.ProductContext.UseCases.GetProductById;
using Mercadinho.Application.ProductContext.UseCases.UpdateProduct;
using Mercadinho.Application.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Infrastructure.DataAccess;
using Mercadinho.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddScoped<HandlerAsync<GetProductByIdQuery, GetProductByIdResponse>, GetProductByIdHandler>();
builder.Services.AddScoped<HandlerAsync<CreateProductCommand, CreateProductResponse>, CreateProductHandler>();
builder.Services.AddScoped<HandlerAsync<UpdateProductCommand, UpdateProductResponse>, UpdateProductHandler>();
builder.Services.AddScoped<HandlerAsync<DeleteProductCommand, DeleteProductResponse>, DeleteProductHandler>();

builder.Services.AddScoped<HandlerAsync<GetEmployeeByIdQuery, GetEmployeeByIdResponse>, GetEmployeeByIdHandler>();
builder.Services.AddScoped<HandlerAsync<CreateEmployeeCommand, CreateEmployeeResponse>, CreateEmployeeHandler>();
builder.Services.AddScoped<HandlerAsync<UpdateEmployeeCommand, UpdateEmployeeResponse>, UpdateEmployeeHandler>();
builder.Services.AddScoped<HandlerAsync<DeleteEmployeeCommand, DeleteEmployeeResponse>, DeleteEmployeeHandler>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

WebApplication app = builder.Build();
app.MapEndpoints();

app.UseHttpsRedirection();
app.Run();