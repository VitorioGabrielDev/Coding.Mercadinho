using Mercadinho.Domain.SharedContext.Entities;

namespace Mercadinho.Domain.ProductContext.Entities;

public class Stock : Entity
{
    public int ProductId { get; private set; }
    public int PhysicalQuantity { get; private set; }
    
    private Stock() { }

    public Stock(int productId, int physicalQuantity)
    {
        ProductId = productId;
        PhysicalQuantity = physicalQuantity;
    }
}