using UnitConversion.Domain.Enums;
using UnitConversion.Domain.Exceptions;
using UnitConversion.Domain.Interfaces;

namespace UnitConversion.Infrastructure.Converters
{
    public class WeightConverter : IUnitConverter
    {
        public ConversionCategory Category => ConversionCategory.Weight;

        public double Convert(string fromUnit, string toUnit, double value)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            if (fromUnit == toUnit)
                return value;

            return (fromUnit, toUnit) switch
            {
                ("kilogram", "pound") => value * 2.20462,
                ("pound", "kilogram") => value / 2.20462,

                ("gram", "kilogram") => value / 1000,
                ("kilogram", "gram") => value * 1000,

                _ => throw new InvalidConversionException(
                    $"Conversion from {fromUnit} to {toUnit} is not supported.")
            };
        }

    }
}
