using Mercadinho.Application.EmployeeContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.EmployeeContext.Entities;

namespace Mercadinho.Application.EmployeeContext.UseCases.UpdateEmployee;

public class UpdateEmployeeHandler(
    IEmployeeRepository employeeRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<UpdateEmployeeCommand, UpdateEmployeeResponse>
{
    public override async Task<Result<UpdateEmployeeResponse>> HandleAsync(UpdateEmployeeCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<UpdateEmployeeResponse>.BusinessRuleViolation("");

            Employee? employee = await employeeRepository.GetEmployeeByIdAsync(request.Id);

            if (employee is null)
                return Result<UpdateEmployeeResponse>.ValidationError("O funcionário informado não foi encontrado!");

            employee.Update(name: request.Name, email: request.Email, phone: request.Phone, nationalId: request.NationalId, role: request.Role);

            await employeeRepository.UpdateEmployeeAsync(employee);
            await unitOfWork.CommitAsync();

            UpdateEmployeeResponse response = new();
            return Result.Successfully(response);
        }
        catch (Exception e)
        {
            return Result<UpdateEmployeeResponse>.InternalError(e.Message);
        }
    }
}