using Mercadinho.Domain.Enums;

namespace Mercadinho.Domain.Entities;

public class Employee : Entity
{
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string NationalId { get; private set; } = string.Empty;
    public EmployeeRoleEnum Role { get; private set; }

    private Employee() { }

    public Employee(string name, string email, string phone, string nationalId, EmployeeRoleEnum role)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Role = role;
        NationalId = nationalId;
    }

    public void Update(string name, string email, string phone, string nationalId, EmployeeRoleEnum role)
    {
        Name = name;
        Email = email;
        Phone = phone;
        NationalId = nationalId;   
        Role = role;
    }
}