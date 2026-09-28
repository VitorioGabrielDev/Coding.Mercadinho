using Mercadinho.Application.EmployeeContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.EmployeeContext.Entities;

namespace Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;

public class GetEmployeeByIdHandler(
    IEmployeeRepository employeeRepository
) : HandlerAsync<GetEmployeeByIdQuery, GetEmployeeByIdResponse>
{
    public override async Task<Result<GetEmployeeByIdResponse>> HandleAsync(GetEmployeeByIdQuery request)
    {
        try
        {
            if (!request.Validate())
                return Result<GetEmployeeByIdResponse>.BusinessRuleViolation("");

            Employee? employee = await employeeRepository.GetEmployeeByIdAsync(request.Id);

            if (employee is null)
                return Result<GetEmployeeByIdResponse>.ValidationError("O funcionário informado não foi encontrado!");

            GetEmployeeByIdResponse response = new(Name: employee.Name, Role: employee.Role);
            return Result.Successfully(response);
        }
        catch (Exception e)
        {
            return Result<GetEmployeeByIdResponse>.InternalError(e.Message);
        }
    }
}