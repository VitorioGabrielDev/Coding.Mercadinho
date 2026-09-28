namespace Mercadinho.Application.SharedContext;

public interface IHandlerAsync<in TRequest, TResult> where TRequest : Request<TResult>, IRequest<TResult>
{
    public Task<Result<TResult>> HandleAsync(TRequest request);
}