using Mercadinho.Domain.EmployeeContext.Enums;

namespace Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;

public record GetEmployeeByIdResponse(string Name, EmployeeRoleEnum Role);