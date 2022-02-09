using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TextbookManagement.Core.Interfaces;

namespace TextbookManagement.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var serverVersion = new MariaDbServerVersion("10.6.5");
            services.AddDbContext<TextbookManagementDbContext>(options =>
                options.UseMySql(configuration.GetConnectionString("Default"), serverVersion));
                //options.UseInMemoryDatabase("textbook-management-db"));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<TextbookManagementDbContext>());
            
            return services;
        }
    }
}