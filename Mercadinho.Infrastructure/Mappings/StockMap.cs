using Mercadinho.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercadinho.Infrastructure.Mappings;

public class StockMap : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.ToTable("Stocks");

        builder.Property(x => x.ProductId)
            .HasColumnName("ProductId")
            .HasColumnType("INT")
            .IsRequired();

        builder.Property(x => x.PhysicalQuantity)
            .HasColumnName("PhysicalQuantity")
            .HasColumnType("INT")
            .IsRequired();
    }
}