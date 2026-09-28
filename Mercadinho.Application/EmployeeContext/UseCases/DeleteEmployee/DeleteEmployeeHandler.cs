using Mercadinho.Application.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.Entities;

namespace Mercadinho.Application.EmployeeContext.UseCases.DeleteEmployee;

public class DeleteEmployeeHandler(
    IEmployeeRepository employeeRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<DeleteEmployeeCommand, DeleteEmployeeResponse>
{
    public override async Task<Result<DeleteEmployeeResponse>> HandleAsync(DeleteEmployeeCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<DeleteEmployeeResponse>.BusinessRuleViolation("");

            Employee? employee = await employeeRepository.GetEmployeeByIdAsync(request.Id);

            if (employee is null)
                return Result<DeleteEmployeeResponse>.ValidationError("O funcionário informado não foi encontrado!");

            await employeeRepository.DeleteEmployeeAsync(employee.Id);
            await unitOfWork.CommitAsync();

            DeleteEmployeeResponse response = new();
            return Result<DeleteEmployeeResponse>.Successfully(response);
        } 
        catch (Exception e)
        {
            return Result<DeleteEmployeeResponse>.InternalError(e.Message);
        }
    }
}