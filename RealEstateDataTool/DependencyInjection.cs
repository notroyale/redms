using RealEstateDataTool.Service;

namespace RealEstateDataTool
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddScrapers(this IServiceCollection services)
        {
            services.AddScoped<IWebScraperService, WebScraperService>();
            return services;   
        }
    }
}
