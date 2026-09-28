namespace Mercadinho.Application.ProductContext.UseCases.CreateProduct;

public record CreateProductResponse(
    int Id,
    string Name,
    string Description,
    int Value
);