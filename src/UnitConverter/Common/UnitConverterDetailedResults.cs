namespace UnitConverter
{
    using UnitConverter.Catalog;

    public enum UnitConverterError
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
    }

    public readonly struct UnitConverterParseResult<TUnit>
        where TUnit : struct
    {
        private UnitConverterParseResult(
            bool success,
            double value,
            TUnit unit,
            UnitConverterError error,
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
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        public static UnitConverterParseResult<TUnit> Ok(double value, TUnit unit)
        {
            return new UnitConverterParseResult<TUnit>(
                true,
                value,
                unit,
                UnitConverterError.None,
                null);
        }

        public static UnitConverterParseResult<TUnit> Fail(
            UnitConverterError error,
            string errorMessage)
        {
            return new UnitConverterParseResult<TUnit>(
                false,
                0d,
                default(TUnit),
                error,
                errorMessage);
        }
    }

    public readonly struct UnitConverterDynamicResult
    {
        private UnitConverterDynamicResult(
            bool success,
            double value,
            UnitConverterFamily family,
            UnitConverterUnitDescriptor fromUnit,
            UnitConverterUnitDescriptor toUnit,
            UnitConverterError error,
            string errorMessage)
        {
            Success = success;
            Value = value;
            Family = family;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            Error = error;
            ErrorMessage = errorMessage;
        }

        public bool Success { get; }
        public double Value { get; }
        public UnitConverterFamily Family { get; }
        public UnitConverterUnitDescriptor FromUnit { get; }
        public UnitConverterUnitDescriptor ToUnit { get; }
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        public static UnitConverterDynamicResult Ok(
            double value,
            UnitConverterFamily family,
            UnitConverterUnitDescriptor fromUnit,
            UnitConverterUnitDescriptor toUnit)
        {
            return new UnitConverterDynamicResult(
                true,
                value,
                family,
                fromUnit,
                toUnit,
                UnitConverterError.None,
                null);
        }

        public static UnitConverterDynamicResult Fail(
            UnitConverterFamily family,
            UnitConverterError error,
            string errorMessage)
        {
            return new UnitConverterDynamicResult(
                false,
                0d,
                family,
                null,
                null,
                error,
                errorMessage);
        }
    }
}
