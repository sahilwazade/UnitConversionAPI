using UnitConversion.Domain.Enums;

namespace UnitConversion.Domain.Interfaces
{
    public interface IUnitConverter
    {
        ConversionCategory Category { get; }
        double Convert(string fromUnit, string toUnit, double value);
    }
}
