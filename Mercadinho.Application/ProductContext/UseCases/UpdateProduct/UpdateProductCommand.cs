using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.ProductContext.UseCases.UpdateProduct;

public class UpdateProductCommand : Request<UpdateProductResponse>
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int Value { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}