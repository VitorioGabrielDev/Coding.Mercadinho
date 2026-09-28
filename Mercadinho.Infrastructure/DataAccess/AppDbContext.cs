using Flunt.Notifications;
using Mercadinho.Domain.CustomerContext.Entities;
using Mercadinho.Domain.EmployeeContext.Entities;
using Mercadinho.Domain.ProductContext.Entities;
using Mercadinho.Domain.SharedContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.Infrastructure.DataAccess;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        
        modelBuilder.Ignore<Notification>();

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(Entity).IsAssignableFrom(entityType.ClrType))
            {
                modelBuilder
                    .Entity(entityType.ClrType)
                    .HasKey(nameof(Entity.Id))
                    .HasName($"{entityType.ClrType.Name.ToUpper()}_PK");

                modelBuilder
                    .Entity(entityType.ClrType)
                    .Property(nameof(Entity.CreatedAt))
                    .HasColumnName("CREATED_AT")
                    .HasColumnType("TIMESTAMP WITH TIME ZONE")
                    .IsRequired();

                modelBuilder
                    .Entity(entityType.ClrType)
                    .Property(nameof(Entity.UpdatedAt))
                    .HasColumnName("UPDATED_AT")
                    .HasColumnType("TIMESTAMP WITH TIME ZONE");

                modelBuilder
                    .Entity(entityType.ClrType)
                    .Property(nameof(Entity.DeletedAt))
                    .HasColumnName("DELETED_AT")
                    .HasColumnType("TIMESTAMP WITH TIME ZONE");
            }
        }

        base.OnModelCreating(modelBuilder);
    }
}