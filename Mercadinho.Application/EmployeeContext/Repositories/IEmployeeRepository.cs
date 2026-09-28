using Mercadinho.Domain.EmployeeContext.Entities;

namespace Mercadinho.Application.EmployeeContext.Repositories;

public interface IEmployeeRepository
{
    public Task<Employee?> GetEmployeeByIdAsync(int id);
    public Task CreateEmployeeAsync(Employee employee);
    public Task UpdateEmployeeAsync(Employee employee);
    public Task DeleteEmployeeAsync(int id);
}