using Microsoft.Extensions.DependencyInjection;
using UnitConversion.Domain.Interfaces;
using UnitConversion.Infrastructure.Converters;

namespace UnitConversion.Infrastructure.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IUnitConverter, LengthConverter>();
            services.AddSingleton<IUnitConverter, TemperatureConverter>();
            services.AddSingleton<IUnitConverter, WeightConverter>();

            return services;
        }
    }
}
