using Mercadinho.Domain.CustomerContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercadinho.Infrastructure.CustomerContext.Mappings;

public class CustomerMap : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(x => x.NationalId)
            .HasColumnName("national_id")
            .HasColumnType("VARCHAR")
            .HasMaxLength(14)
            .IsRequired();

        builder.Property(x => x.BirthDate)
            .HasColumnName("birth_date")
            .HasColumnType("DATE")
            .IsRequired();
    }
}