using UnitConversion.Domain.Enums;
using UnitConversion.Domain.Exceptions;
using UnitConversion.Domain.Interfaces;

namespace UnitConversion.Infrastructure.Converters
{
    public class TemperatureConverter : IUnitConverter
    {
        public ConversionCategory Category => ConversionCategory.Temperature;

        public double Convert(string fromUnit, string toUnit, double value)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            if (fromUnit == toUnit)
                return value;

            return (fromUnit, toUnit) switch
            {
                ("celsius", "fahrenheit") => (value * 9 / 5) + 32,
                ("fahrenheit", "celsius") => (value - 32) * 5 / 9,

                ("celsius", "kelvin") => value + 273.15,
                ("kelvin", "celsius") => value - 273.15,

                _ => throw new InvalidConversionException(
                    $"Conversion from {fromUnit} to {toUnit} is not supported.")
            };
        }

    }
}
