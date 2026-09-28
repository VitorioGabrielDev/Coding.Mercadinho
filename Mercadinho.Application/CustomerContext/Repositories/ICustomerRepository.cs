using Mercadinho.Domain.CustomerContext.Entities;

namespace Mercadinho.Application.CustomerContext.Repositories;

public interface ICustomerRepository
{
    public Task<Customer?> GetCustomerByIdAsync(int id);
    public Task CreateCustomerAsync(Customer customer);
    public Task UpdateCustomerAsync(Customer customer);
    public Task DeleteCustomerAsync(int id);
}