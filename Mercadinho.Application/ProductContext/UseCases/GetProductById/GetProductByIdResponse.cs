namespace Mercadinho.Application.ProductContext.UseCases.GetProductById;

public record GetProductByIdResponse(
    int Id,
    string Name,
    string Description,
    int Value
);