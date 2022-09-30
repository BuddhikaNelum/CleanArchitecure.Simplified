using CleanArchitecure.Application.Interfaces;
using CleanArchitecure.Infrastructure.Services;

namespace CleanArchitecure.WebApi
{
    public static class ServiceCollection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}
