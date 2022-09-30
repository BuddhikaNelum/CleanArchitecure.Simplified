using CleanArchitecure.Domain.Entities;

namespace CleanArchitecure.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomer(int id);
    }
}
