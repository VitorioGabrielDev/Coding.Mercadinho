using Mercadinho.Domain.Entities;

namespace Mercadinho.Application.ProductContext.Repositories;

public interface IProductRepository
{
    public Task CreateProductAsync(Product product);
    public Task<Product?> GetProductByIdAsync(int id);
    public Task<Product?> UpdateProductAsync(Product product);
    public Task<bool> DeleteProductAsync(int id);
}