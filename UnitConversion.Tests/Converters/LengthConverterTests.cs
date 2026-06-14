using UnitConversion.Infrastructure.Converters;

namespace UnitConversion.Tests.Converters
{
    public class LengthConverterTests
    {
        private readonly LengthConverter _converter = new();

        [Fact]
        public void Convert_MeterToFeet_ReturnsExpectedValue()
        {
            // Arrange
            double value = 10;

            // Act
            double result = _converter.Convert("meter", "feet", value);

            // Assert
            Assert.Equal(32.8084, result, 4);
        }

        [Fact]
        public void Convert_FeetToMeter_ReturnsExpectedValue()
        {
            double result = _converter.Convert("feet", "meter", 32.8084);

            Assert.Equal(10, result, 4);
        }
    }
}
