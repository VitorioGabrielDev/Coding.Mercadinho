using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.ProductContext.Entities;

namespace Mercadinho.Application.ProductContext.UseCases.CreateProduct;

public class CreateProductHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<CreateProductCommand, CreateProductResponse>
{
    public override async Task<Result<CreateProductResponse>> HandleAsync(CreateProductCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<CreateProductResponse>.BusinessRuleViolation("");

            Product product = new(name: request.Name, description: request.Description, value: request.Value);

            await productRepository.CreateProductAsync(product);
            await unitOfWork.CommitAsync();

            CreateProductResponse response = new(product.Id, product.Name, product.Description, product.Value);
            return Result.Successfully(response);
        }
        catch (Exception e)
        {
            return Result<CreateProductResponse>.InternalError(e.Message);
        }
    }
}