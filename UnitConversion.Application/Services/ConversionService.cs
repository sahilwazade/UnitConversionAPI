using UnitConversion.Application.DTOs;
using UnitConversion.Application.Interfaces;
using UnitConversion.Domain.Enums;
using UnitConversion.Domain.Exceptions;
using UnitConversion.Domain.Interfaces;

namespace UnitConversion.Application.Services
{
    public class ConversionService : IConversionService
    {
        private readonly IEnumerable<IUnitConverter> _converters;
        public ConversionService(IEnumerable<IUnitConverter> converters)
        {
            _converters = converters;
        }

        public async Task<ConversionResponseDto> Convert(ConversionRequestDto request)
        {
            if (!Enum.TryParse<ConversionCategory>(request.Category, true, out var category))
            {
                throw new UnsupportedUnitException($"Unsupported category: {request.Category}");
            }

            var converter = _converters.FirstOrDefault(x => x.Category == category);
            if (converter is null)
            {
                throw new UnsupportedUnitException($"No converter found for category {request.Category}");
            }

            var result = converter.Convert(
                request.FromUnit,
                request.ToUnit,
                request.Value);

            return new ConversionResponseDto
            {
                ConvertedValue = result
            };
        }
    }
}
