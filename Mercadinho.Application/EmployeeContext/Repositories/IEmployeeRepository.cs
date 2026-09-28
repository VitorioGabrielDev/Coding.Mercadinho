using Mercadinho.Domain.Entities;

namespace Mercadinho.Application.Repositories;

public interface IEmployeeRepository
{
    public Task CreateEmployeeAsync(Employee employee);
    public Task<Employee?> GetEmployeeByIdAsync(int id);
    public Task<Employee?> UpdateEmployeeAsync(Employee employee);
    public Task<bool> DeleteEmployeeAsync(int id);
}