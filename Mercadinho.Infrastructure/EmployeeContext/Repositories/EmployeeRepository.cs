using Mercadinho.Application.EmployeeContext.Repositories;
using Mercadinho.Domain.EmployeeContext.Entities;
using Mercadinho.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.Infrastructure.EmployeeContext.Repositories;

public class EmployeeRepository(
    AppDbContext dbContext
) : IEmployeeRepository
{
    public async Task CreateEmployeeAsync(Employee employee) =>
        await dbContext.Employees.AddAsync(employee);

    public async Task<Employee?> GetEmployeeByIdAsync(int id) =>
        await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        Employee? trackedEntity = await GetEmployeeByIdAsync(id: employee.Id);
        if (trackedEntity is null) return;
        dbContext.Entry(trackedEntity).CurrentValues.SetValues(employee);
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        Employee? dbProduct = await GetEmployeeByIdAsync(id: id);
        if (dbProduct is null) return;
        dbContext.Employees.Remove(dbProduct);
    }
}