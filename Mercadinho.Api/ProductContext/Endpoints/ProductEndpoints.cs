using Mercadinho.Application.ProductContext.UseCases.CreateProduct;
using Mercadinho.Application.ProductContext.UseCases.DeleteProduct;
using Mercadinho.Application.ProductContext.UseCases.GetProductById;
using Mercadinho.Application.ProductContext.UseCases.UpdateProduct;
using Mercadinho.Application.SharedContext;
using Microsoft.AspNetCore.Mvc;

namespace Mercadinho.Api.ProductContext.Endpoints;

public static class ProductEndpoints
{
    extension(IEndpointRouteBuilder endpoints)
    {
        public IEndpointRouteBuilder MapProductEndpoints()
        {
            RouteGroupBuilder groupBuilder = endpoints.MapGroup("api/product");

            groupBuilder.MapGet("get-product-by-id", GetProductById);
            groupBuilder.MapPost("create-product", CreateProduct);
            groupBuilder.MapPut("update-product", UpdateProduct);
            groupBuilder.MapDelete("delete-product", DeleteProduct);
            
            return endpoints;
        }
    }

    private static async Task<IResult> GetProductById(
        [AsParameters] GetProductByIdQuery query,
        [FromServices] HandlerAsync<GetProductByIdQuery, GetProductByIdResponse> handler
    )
    {
        Result<GetProductByIdResponse> response = await handler.HandleAsync(query);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> CreateProduct(
        [FromBody] CreateProductCommand command,
        [FromServices] HandlerAsync<CreateProductCommand, CreateProductResponse> handler
    )
    {
        Result<CreateProductResponse> response = await handler.HandleAsync(command);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> UpdateProduct(
        [FromBody] UpdateProductCommand command,
        [FromServices] HandlerAsync<UpdateProductCommand, UpdateProductResponse> handler
    )
    {
        Result<UpdateProductResponse> response = await handler.HandleAsync(command);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> DeleteProduct(
        [AsParameters] DeleteProductCommand command,
        [FromServices] HandlerAsync<DeleteProductCommand, DeleteProductResponse> handler
    )
    {
        Result<DeleteProductResponse> response = await handler.HandleAsync(command);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }
}