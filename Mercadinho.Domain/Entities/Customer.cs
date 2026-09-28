namespace Mercadinho.Domain.Entities;

public class Customer : Entity
{
    public string Name { get; private set; } = string.Empty;
    public string NationalId { get; private set; } = string.Empty;
    public DateTime BirthDate { get; private set; }
    
    
    private Customer() { }

    public Customer(string name, string nationalId)
    {
        Name = name;
        NationalId = nationalId;
    }
}