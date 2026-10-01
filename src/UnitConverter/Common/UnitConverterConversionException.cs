namespace UnitConverter
{
    using System;

    public sealed class UnitConverterConversionException : Exception
    {
        public UnitConverterConversionException(string message) : base(message)
        {
        }
    }
}
