using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.ProductContext.UseCases.DeleteProduct;

public class DeleteProductCommand : Request<DeleteProductResponse>
{
    public int Id { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}