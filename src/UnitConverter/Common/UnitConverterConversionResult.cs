namespace UnitConverter
{
    public readonly struct UnitConverterConversionResult
    {
        public readonly bool Success;
        public readonly double Value;
        public readonly string ErrorMessage;

        private UnitConverterConversionResult(bool success, double value, string errorMessage)
        {
            Success = success;
            Value = value;
            ErrorMessage = errorMessage;
        }

        public static UnitConverterConversionResult Ok(double value)
        {
            return new UnitConverterConversionResult(true, value, null);
        }

        public static UnitConverterConversionResult Fail(string errorMessage)
        {
            return new UnitConverterConversionResult(false, 0d, errorMessage);
        }
    }
}
