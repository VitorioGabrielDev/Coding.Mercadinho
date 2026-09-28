using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.ProductContext.UseCases.GetProductById;

public class GetProductByIdQuery : Request<GetProductByIdResponse>
{
    public int Id { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}