using Mercadinho.Application.SharedContext;

namespace Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;

public class GetEmployeeByIdQuery : Request<GetEmployeeByIdResponse>
{
    public int Id { get; init; }

    public override bool Validate()
    {
        return IsValid;
    }
}