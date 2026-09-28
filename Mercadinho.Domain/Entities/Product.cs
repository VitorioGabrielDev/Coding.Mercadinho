namespace Mercadinho.Domain.Entities;

public class Product : Entity
{
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public int Value { get; private set; }

    private Product() { }

    public Product(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    public void Update(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }
}