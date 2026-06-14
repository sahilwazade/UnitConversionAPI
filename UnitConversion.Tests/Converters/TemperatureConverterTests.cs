using UnitConversion.Infrastructure.Converters;

namespace UnitConversion.Tests.Converters
{
    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter _converter = new();

        [Fact]
        public void Convert_CelsiusToFahrenheit_ReturnsExpectedValue()
        {
            double result = _converter.Convert("celsius", "fahrenheit", 100);

            Assert.Equal(212, result);
        }
    }
}
