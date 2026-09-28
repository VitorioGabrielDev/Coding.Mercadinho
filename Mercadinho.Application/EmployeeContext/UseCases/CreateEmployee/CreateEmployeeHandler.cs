using Mercadinho.Application.EmployeeContext.Repositories;
using Mercadinho.Application.SharedContext;
using Mercadinho.Domain.EmployeeContext.Entities;

namespace Mercadinho.Application.EmployeeContext.UseCases.CreateEmployee;

public class CreateEmployeeHandler(
    IEmployeeRepository employeeRepository,
    IUnitOfWork unitOfWork
) : HandlerAsync<CreateEmployeeCommand, CreateEmployeeResponse>
{
    public override async Task<Result<CreateEmployeeResponse>> HandleAsync(CreateEmployeeCommand request)
    {
        try
        {
            if (!request.Validate())
                return Result<CreateEmployeeResponse>.ValidationError("");

            Employee employee = new(name: request.Name, email: request.Email, phone: request.Phone, role: request.Role, nationalId: request.NationalId);

            await employeeRepository.CreateEmployeeAsync(employee);
            await unitOfWork.CommitAsync();

            CreateEmployeeResponse response = new();
            return Result.Successfully(response);
        }
        catch (Exception e)
        {
            return Result<CreateEmployeeResponse>.InternalError(e.Message);
        }
    }
}