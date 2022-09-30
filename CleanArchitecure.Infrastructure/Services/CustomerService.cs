using CleanArchitecure.Application.Interfaces;
using CleanArchitecure.Domain.Entities;

namespace CleanArchitecure.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<Customer> GetCustomer(int id)
        {
           return await Task.FromResult(new Customer { Id = 1, Name = "Buddhika Nelum"});
        }
    }
}
