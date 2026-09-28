using Mercadinho.Domain.ProductContext.Entities;

namespace Mercadinho.Application.ProductContext.Repositories;

public interface IProductRepository
{
    public Task<Product?> GetProductByIdAsync(int id);
    public Task CreateProductAsync(Product product);
    public Task UpdateProductAsync(Product product);
    public Task DeleteProductAsync(int id);
}