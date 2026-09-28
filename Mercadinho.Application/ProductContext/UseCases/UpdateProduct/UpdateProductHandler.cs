using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.Entities;

namespace Mercadinho.Application.ProductContext.UseCases.UpdateProduct;

public class UpdateProductHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<UpdateProductCommand, UpdateProductResponse>
{
    public override async Task<Result<UpdateProductResponse>> HandleAsync(UpdateProductCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<UpdateProductResponse>.BusinessRuleViolation("");

            Product? product = await productRepository.GetProductByIdAsync(request.Id);

            if (product is null)
                return Result<UpdateProductResponse>.ValidationError("O produto informado não foi encontrado!");

            product.Update(request.Name, request.Description, request.Value);

            await productRepository.UpdateProductAsync(product);
            await unitOfWork.CommitAsync();
            
            UpdateProductResponse response = new(product.Name, product.Description, product.Value);
            return Result<UpdateProductResponse>.Successfully(response);
        }
        catch (Exception e)
        {
            return Result<UpdateProductResponse>.InternalError(e.Message);
        }
    }
}