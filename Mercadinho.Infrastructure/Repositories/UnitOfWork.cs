using Mercadinho.Application.SharedContext;
using Mercadinho.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore.Storage;

namespace Mercadinho.Infrastructure.Repositories;

public class UnitOfWork(
    AppDbContext dbContext    
) : IUnitOfWork
{
    private IDbContextTransaction? _transaction;
    
    public async Task CommitAsync()
    {
        await dbContext.SaveChangesAsync();

        if (_transaction is not null) 
            await _transaction.CommitAsync();
        
        _transaction?.Dispose();
        _transaction = null;
    }
}