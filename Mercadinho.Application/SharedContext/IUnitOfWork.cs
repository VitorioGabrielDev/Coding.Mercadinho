namespace Mercadinho.Application.SharedContext;

public interface IUnitOfWork
{
    public Task CommitAsync();
}