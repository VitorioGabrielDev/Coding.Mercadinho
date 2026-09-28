using Mercadinho.Domain.Enums;

namespace Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;

public record GetEmployeeByIdResponse(string Name, EmployeeRoleEnum Role);