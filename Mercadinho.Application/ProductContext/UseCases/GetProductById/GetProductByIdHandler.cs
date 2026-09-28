using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.ProductContext.Entities;

namespace Mercadinho.Application.ProductContext.UseCases.GetProductById;

public class GetProductByIdHandler(
    IProductRepository productRepository
) : HandlerAsync<GetProductByIdQuery, GetProductByIdResponse>
{
    public override async Task<Result<GetProductByIdResponse>> HandleAsync(GetProductByIdQuery request)
    {
        try
        {
            if (!request.Validate())
                return Result<GetProductByIdResponse>.BusinessRuleViolation("");

            Product? product = await productRepository.GetProductByIdAsync(request.Id);

            if (product is null)
                return Result<GetProductByIdResponse>.ValidationError("O produto não foi encontrado com o identificador informado!");
            
            GetProductByIdResponse response = new(product.Id, product.Name, product.Description, product.Value);
            return Result.Successfully(response);
        } catch (Exception e)
        {
            return Result<GetProductByIdResponse>.InternalError(e.Message);
        }
    }
}