using Flunt.Notifications;

namespace Mercadinho.Domain.Entities;

public abstract class Entity : Notifiable<Notification>
{
    public int Id { get; protected set; }
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; protected set; }
    public DateTime? DeletedAt { get; protected set; }

    public void Update() => UpdatedAt = DateTime.UtcNow;
    public void Delete() => DeletedAt = DateTime.UtcNow;
}