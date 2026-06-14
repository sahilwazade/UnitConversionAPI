using UnitConversion.Application.DTOs;

namespace UnitConversion.Application.Interfaces
{
    public interface IConversionService
    {
        Task<ConversionResponseDto> Convert(ConversionRequestDto request);
    }
}
