using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.Enums;

namespace Mercadinho.Application.EmployeeContext.UseCases.UpdateEmployee;

public class UpdateEmployeeCommand : Request<UpdateEmployeeResponse>
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; protected set; } = string.Empty;
    public string NationalId { get; protected set; } = string.Empty;
    public EmployeeRoleEnum Role { get; protected set; }

    public override bool Validate()
    {
        return IsValid;
    }
}