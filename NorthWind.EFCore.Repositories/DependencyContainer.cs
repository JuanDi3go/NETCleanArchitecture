
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.EFCore.Repositories.Context;
using NorthWind.EFCore.Repositories.Repositories;
using NorthWind.Sales.BusinessObjects.Interfaces.Repositories;

namespace NorthWind.EFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthWindSalesContext>(op => op.UseSqlServer(configuration.GetConnectionString("")))

            services.AddScoped<INorthWindSalesCommandsRepository, NothWindSalesCommandsRepository>();


            return services;
        }
    }
}
