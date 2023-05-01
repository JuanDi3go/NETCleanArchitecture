

namespace NorthWind.Sales.IOC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSalesServices(this IServiceCollection services, IConfiguration configuration, string conectionstringName)
        {

            services.AddRepositories(configuration, conectionstringName).AddUseCasesServices().AddPresenters().AddControllers();

            return services;
        }
    }
}
