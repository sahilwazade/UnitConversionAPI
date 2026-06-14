using UnitConversion.Application.Interfaces;
using UnitConversion.Application.Services;

namespace UnitConversion.API.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IConversionService, ConversionService>();
            return services;
        }
    }
}
