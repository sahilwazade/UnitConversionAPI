using Microsoft.AspNetCore.Mvc;
using Moq;
using UnitConversion.API.Controllers;
using UnitConversion.Application.Common.Responses;
using UnitConversion.Application.DTOs;
using UnitConversion.Application.Interfaces;

namespace UnitConversion.Tests.Controllers
{
    public class ConversionControllerTests
    {
        [Fact]
        public async Task Convert_ReturnsOkResult()
        {
            // Arrange
            var mockService = new Mock<IConversionService>();

            var request = new ConversionRequestDto
            {
                Category = "Length",
                FromUnit = "meter",
                ToUnit = "feet",
                Value = 10
            };

            var expectedResponse = new ConversionResponseDto
            {
                ConvertedValue = 32.8084
            };  
            mockService.Setup(x => x.Convert(It.IsAny<ConversionRequestDto>())).ReturnsAsync(expectedResponse);

            var controller = new ConversionController(mockService.Object);

            // Act
            var result = await controller.Convert(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);

            var response = Assert.IsType<ApiResponse<ConversionResponseDto>>(okResult.Value);

            Assert.True(response.Success);
            Assert.Equal("Conversion successful.", response.Message);
            Assert.NotNull(response.Data);
            Assert.Equal(32.8084, response.Data.ConvertedValue, 4);
        }
    }
}
