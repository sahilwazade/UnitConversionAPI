namespace UnitConversion.Domain.Exceptions
{
    public class UnsupportedUnitException : Exception
    {
        public UnsupportedUnitException(string msg): base(msg) {}
    }
}
