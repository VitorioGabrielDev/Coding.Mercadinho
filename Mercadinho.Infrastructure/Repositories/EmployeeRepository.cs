using Mercadinho.Application.Repositories;
using Mercadinho.Domain.Entities;
using Mercadinho.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.Infrastructure.Repositories;

public class EmployeeRepository(
    AppDbContext dbContext
) : IEmployeeRepository
{
    public async Task CreateEmployeeAsync(Employee employee) =>
        await dbContext.Employees.AddAsync(employee);

    public async Task<Employee?> GetEmployeeByIdAsync(int id) =>
        await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<Employee?> UpdateEmployeeAsync(Employee employee)
    {
        Employee? trackedEntity = await GetEmployeeByIdAsync(id: employee.Id);
    
        if (trackedEntity is null) return null;

        dbContext.Entry(trackedEntity).CurrentValues.SetValues(employee);
        return trackedEntity;
    }

    public async Task<bool> DeleteEmployeeAsync(int id)
    {
        Employee? dbProduct = await GetEmployeeByIdAsync(id: id);

        if (dbProduct is null) return false;

        dbContext.Employees.Remove(dbProduct);
        return true;
    }
}