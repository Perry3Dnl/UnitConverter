namespace UnitConverter
{
    /// <summary>
    /// Represents the non-throwing result of a text-to-unit conversion.
    /// </summary>
    public readonly struct UnitConverterConversionResult
    {
        /// <summary>Gets whether the conversion succeeded.</summary>
        public readonly bool Success;

        /// <summary>Gets the converted value when <see cref="Success"/> is true.</summary>
        public readonly double Value;

        /// <summary>Gets the failure message when <see cref="Success"/> is false.</summary>
        public readonly string ErrorMessage;

        private UnitConverterConversionResult(bool success, double value, string errorMessage)
        {
            Success = success;
            Value = value;
            ErrorMessage = errorMessage;
        }

        internal static UnitConverterConversionResult Ok(double value)
        {
            return new UnitConverterConversionResult(true, value, null);
        }

        internal static UnitConverterConversionResult Fail(string errorMessage)
        {
            return new UnitConverterConversionResult(false, 0d, errorMessage);
        }
    }
}
