using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UnitConversion.Application.Common.Responses;
using UnitConversion.Application.DTOs;
using UnitConversion.Application.Interfaces;

namespace UnitConversion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;
        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpPost]
        public async Task<ActionResult<ConversionResponseDto>> Convert(ConversionRequestDto request)
        {
            var response = await _conversionService.Convert(request);

            return Ok(new ApiResponse<ConversionResponseDto>
            {
                Success = true,
                Message = "Conversion successful.",
                Data = response
            });
        }
    }
}
