using UnitConversion.Infrastructure.Converters;

namespace UnitConversion.Tests.Converters
{
    public class WeightConverterTests
    {
        private readonly WeightConverter _converter = new();

        [Fact]
        public void Convert_KilogramToPound_ReturnsExpectedValue()
        {
            double result = _converter.Convert("kilogram", "pound", 5);

            Assert.Equal(11.0231, result, 4);
        }
    }
}
