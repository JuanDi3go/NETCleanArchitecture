
namespace NortWind.Sales.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebAppliaction(this WebApplicationBuilder builder)
        {

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddNorthWindSalesServices(builder.Configuration, "NorthWindDbNet20");


            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseNorthWindSalesEndPoints();

            return app;
        }
    }
}
