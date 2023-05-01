

namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CreateOrderPresesnter>();
            services.AddScoped<ICreateOrderPresenter>(provider => provider.GetService<CreateOrderPresesnter>());
            services.AddScoped<ICreateOrderOutputPort>(provider => provider.GetService<CreateOrderPresesnter>());


            return services;
        }
    }
}
