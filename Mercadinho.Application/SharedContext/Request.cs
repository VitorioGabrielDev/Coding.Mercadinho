using Flunt.Notifications;

namespace Mercadinho.Application.SharedContext;

public abstract class Request<TResponse> : Notifiable<Notification>, IRequest<TResponse>
{
    public abstract bool Validate();
}