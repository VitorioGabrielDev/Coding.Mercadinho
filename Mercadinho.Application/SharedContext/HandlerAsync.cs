using Flunt.Notifications;

namespace Mercadinho.Application.SharedContext;

public abstract class HandlerAsync<TRequest, TResult> : Notifiable<Notification>, IHandlerAsync<TRequest, TResult> where TRequest : Request<TResult>
{
    public abstract Task<Result<TResult>> HandleAsync(TRequest request);
}