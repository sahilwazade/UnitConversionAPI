namespace UnitConversion.Application.DTOs
{
    public class ConversionRequestDto
    {
        public string? Category { get; set; }
        public string? FromUnit { get; set; }
        public string? ToUnit { get; set; }
        public double Value { get; set; }
    }
}
