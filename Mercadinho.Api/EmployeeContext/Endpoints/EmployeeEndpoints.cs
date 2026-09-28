using Mercadinho.Application.EmployeeContext.UseCases.CreateEmployee;
using Mercadinho.Application.EmployeeContext.UseCases.DeleteEmployee;
using Mercadinho.Application.EmployeeContext.UseCases.GetEmployeeById;
using Mercadinho.Application.EmployeeContext.UseCases.UpdateEmployee;
using Mercadinho.Application.SharedContext;
using Microsoft.AspNetCore.Mvc;

namespace Mercadinho.Api.EmployeeContext.Endpoints;

public static class EmployeeEndpoints
{
    extension(IEndpointRouteBuilder endpoints)
    {
        public IEndpointRouteBuilder MapEmployeeEndpoints()
        {
            RouteGroupBuilder groupBuilder = endpoints.MapGroup("api/employee");
            
            groupBuilder.MapGet("get-employee-by-id", GetEmployeeById);
            groupBuilder.MapPost("create-employee", CreateEmployee);
            groupBuilder.MapPut("update-employee", UpdateEmployee);
            groupBuilder.MapDelete("delete-employee", DeleteEmployee);

            return endpoints;
        }
    }

    private static async Task<IResult> GetEmployeeById(
        [FromServices] HandlerAsync<GetEmployeeByIdQuery, GetEmployeeByIdResponse> handler,
        [AsParameters] GetEmployeeByIdQuery request
    )
    {
        Result<GetEmployeeByIdResponse> response = await handler.HandleAsync(request);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> CreateEmployee(
        [FromServices] HandlerAsync<CreateEmployeeCommand, CreateEmployeeResponse> handler,
        [FromBody] CreateEmployeeCommand request
    )
    {
        Result<CreateEmployeeResponse> response = await handler.HandleAsync(request);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> UpdateEmployee(
        [FromServices] HandlerAsync<UpdateEmployeeCommand, UpdateEmployeeResponse> handler,
        [FromBody] UpdateEmployeeCommand request
    )
    {
        Result<UpdateEmployeeResponse> response = await handler.HandleAsync(request);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }

    private static async Task<IResult> DeleteEmployee(
        [FromServices] HandlerAsync<DeleteEmployeeCommand, DeleteEmployeeResponse> handler,
        [FromBody] DeleteEmployeeCommand request
    )
    {
        Result<DeleteEmployeeResponse> response = await handler.HandleAsync(request);
        return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    }
}