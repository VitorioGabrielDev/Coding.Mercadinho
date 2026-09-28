using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.Entities;

namespace Mercadinho.Application.ProductContext.UseCases.DeleteProduct;

public class DeleteProductHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<DeleteProductCommand, DeleteProductResponse>
{
    public override async Task<Result<DeleteProductResponse>> HandleAsync(DeleteProductCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<DeleteProductResponse>.BusinessRuleViolation("");

            Product? product = await productRepository.GetProductByIdAsync(request.Id);

            if (product is null)
                return Result<DeleteProductResponse>.ValidationError("O produto informado não foi encontrado!");

            await productRepository.DeleteProductAsync(product.Id);
            await unitOfWork.CommitAsync();

            DeleteProductResponse response = new("O produto foi deletado com sucesso!");
            return Result<DeleteProductResponse>.Successfully(response);

        } catch (Exception e)
        {
            return Result<DeleteProductResponse>.InternalError(e.Message);
        }
    }
}