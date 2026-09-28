using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.ProductContext.UseCases.CreateProduct;

public class CreateProductCommand : Request<CreateProductResponse>
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public int Value { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}