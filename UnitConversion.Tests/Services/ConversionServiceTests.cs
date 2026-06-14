using UnitConversion.Application.DTOs;
using UnitConversion.Application.Services;
using UnitConversion.Domain.Interfaces;
using UnitConversion.Infrastructure.Converters;

namespace UnitConversion.Tests.Services
{
    public class ConversionServiceTests
    {
        private readonly ConversionService _service;

        public ConversionServiceTests()
        {
            IEnumerable<IUnitConverter> converters =
                [
                    new LengthConverter(),
                    new TemperatureConverter(),
                    new WeightConverter()
                ];

            _service = new ConversionService(converters);
        }

        [Fact]
        public async Task Convert_LengthRequest_ReturnsExpectedResult()
        {
            // Arrange
            var request = new ConversionRequestDto
            {
                Category = "Length",
                FromUnit = "meter",
                ToUnit = "feet",
                Value = 10
            };

            // Act
            var response = await _service.Convert(request);

            // Assert
            Assert.Equal(32.8084, response.ConvertedValue, 4);
        }
    }
}
