using Mercadinho.Application.ProductContext.Repositories;
using Mercadinho.Domain.Entities;
using Mercadinho.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.Infrastructure.Repositories;

public class ProductRepository(
    AppDbContext dbContext
) : IProductRepository
{
    public async Task CreateProductAsync(Product product) =>
        await dbContext.Products.AddAsync(product);

    public async Task<Product?> GetProductByIdAsync(int id) =>
        await dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<Product?> UpdateProductAsync(Product product)
    {
        Product? trackedEntity = await GetProductByIdAsync(id: product.Id);

        if (trackedEntity is null) return null;

        dbContext.Entry(trackedEntity).CurrentValues.SetValues(product);
        return trackedEntity;
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        Product? dbProduct = await GetProductByIdAsync(id: id);

        if (dbProduct is null) return false;

        dbContext.Products.Remove(dbProduct);
        return true;
    }
}