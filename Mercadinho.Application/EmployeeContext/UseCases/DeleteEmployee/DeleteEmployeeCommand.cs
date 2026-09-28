using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.EmployeeContext.UseCases.DeleteEmployee;

public class DeleteEmployeeCommand : Request<DeleteEmployeeResponse>
{
    public int Id { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}