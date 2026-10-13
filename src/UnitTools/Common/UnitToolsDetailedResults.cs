namespace UnitTools
{
    using UnitTools.Catalog;

    /// <summary>
    /// Identifies a structured parsing, resolution, or conversion failure.
    /// </summary>
    public enum UnitToolsError
    {
        None = 0,
        InvalidNumber = 1,
        MissingUnit = 2,
        UnknownUnit = 3,
        AmbiguousUnit = 4,
        UnknownFamily = 5,
        WrongUnitFamily = 6,
        UnsupportedUnit = 7,
        ConversionFailed = 8,
        InvalidExpression = 9,
        IncompatibleDimensions = 10,
    }

    /// <summary>
    /// Represents the result of parsing a numeric value and unit without throwing for expected input errors.
    /// </summary>
    /// <typeparam name="TUnit">The catalog unit enum type.</typeparam>
    public readonly struct UnitToolsParseResult<TUnit>
        where TUnit : struct
    {
        private UnitToolsParseResult(
            bool success,
            double value,
            TUnit unit,
            UnitToolsError error,
            string errorMessage)
        {
            Success = success;
            Value = value;
            Unit = unit;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public double Value { get; }
        public TUnit Unit { get; }
        public UnitToolsError Error { get; }
        public string ErrorMessage { get; }

        internal static UnitToolsParseResult<TUnit> Ok(double value, TUnit unit)
        {
            return new UnitToolsParseResult<TUnit>(
                true,
                value,
                unit,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsParseResult<TUnit> Fail(
            UnitToolsError error,
            string errorMessage)
        {
            return new UnitToolsParseResult<TUnit>(
                false,
                0d,
                default(TUnit),
                error,
                errorMessage);
        }
    }

    /// <summary>
    /// Represents a dynamic conversion result, including resolved built-in/custom unit metadata and structured failure information.
    /// </summary>
    public readonly struct UnitToolsDynamicResult
    {
        private UnitToolsDynamicResult(
            bool success,
            double value,
            UnitToolsFamily family,
            UnitToolsUnitDescriptor fromUnit,
            UnitToolsUnitDescriptor toUnit,
            UnitToolsCustomUnit customFromUnit,
            UnitToolsCustomUnit customToUnit,
            UnitToolsError error,
            string errorMessage)
        {
            Success = success;
            Value = value;
            Family = family;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            CustomFromUnit = customFromUnit;
            CustomToUnit = customToUnit;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public double Value { get; }
        public UnitToolsFamily Family { get; }
        public UnitToolsUnitDescriptor FromUnit { get; }
        public UnitToolsUnitDescriptor ToUnit { get; }
        public UnitToolsCustomUnit CustomFromUnit { get; }
        public UnitToolsCustomUnit CustomToUnit { get; }
        public UnitToolsError Error { get; }
        public string ErrorMessage { get; }

        internal static UnitToolsDynamicResult Ok(
            double value,
            UnitToolsFamily family,
            UnitToolsUnitDescriptor fromUnit,
            UnitToolsUnitDescriptor toUnit)
        {
            return new UnitToolsDynamicResult(
                true,
                value,
                family,
                fromUnit,
                toUnit,
                null,
                null,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsDynamicResult Ok(
            double value,
            UnitToolsFamily family,
            UnitToolsUnitDescriptor fromUnit,
            UnitToolsUnitDescriptor toUnit,
            UnitToolsCustomUnit customFromUnit,
            UnitToolsCustomUnit customToUnit)
        {
            return new UnitToolsDynamicResult(
                true,
                value,
                family,
                fromUnit,
                toUnit,
                customFromUnit,
                customToUnit,
                UnitToolsError.None,
                null);
        }

        internal static UnitToolsDynamicResult Fail(
            UnitToolsFamily family,
            UnitToolsError error,
            string errorMessage)
        {
            return new UnitToolsDynamicResult(
                false,
                0d,
                family,
                null,
                null,
                null,
                null,
                error,
                errorMessage);
        }
    }
}
