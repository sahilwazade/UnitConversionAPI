namespace UnitConversion.Domain.Exceptions
{
    public class InvalidConversionException : Exception
    { 
        public InvalidConversionException(string msg) : base(msg) { }
    }
}
