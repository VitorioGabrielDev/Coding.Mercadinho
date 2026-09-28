namespace Mercadinho.Application.SharedContext;

public interface IRequest<TResponse>
{
    public bool Validate();
}