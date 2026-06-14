using UnitConversion.Domain.Enums;
using UnitConversion.Domain.Exceptions;
using UnitConversion.Domain.Interfaces;

namespace UnitConversion.Infrastructure.Converters
{
    public class LengthConverter : IUnitConverter
    {
        public ConversionCategory Category => ConversionCategory.Length;
        public double Convert(string fromUnit, string toUnit, double value)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            if (fromUnit == toUnit)
                return value;

            return (fromUnit, toUnit) switch
            {
                ("meter", "kilometer") => value / 1000,
                ("kilometer", "meter") => value * 1000,

                ("meter", "feet") => value * 3.28084,
                ("feet", "meter") => value / 3.28084,

                ("feet", "inch") => value * 12,
                ("inch", "feet") => value / 12,

                _ => throw new InvalidConversionException(
                    $"Conversion from {fromUnit} to {toUnit} is not supported.")
            };
        }
    }
}
