using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.Enums;

namespace Mercadinho.Application.EmployeeContext.UseCases.CreateEmployee;

public class CreateEmployeeCommand : Request<CreateEmployeeResponse>
{
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string NationalId { get; init; } = string.Empty;
    public EmployeeRoleEnum Role { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}