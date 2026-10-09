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
        InvalidExpression = 9,
        IncompatibleDimensions = 10,
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

        internal static UnitConverterParseResult<TUnit> Ok(double value, TUnit unit)
        {
            return new UnitConverterParseResult<TUnit>(
                true,
                value,
                unit,
                UnitConverterError.None,
                null);
        }

        internal static UnitConverterParseResult<TUnit> Fail(
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
            UnitConverterCustomUnit customFromUnit,
            UnitConverterCustomUnit customToUnit,
            UnitConverterError error,
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
        public UnitConverterFamily Family { get; }
        public UnitConverterUnitDescriptor FromUnit { get; }
        public UnitConverterUnitDescriptor ToUnit { get; }
        public UnitConverterCustomUnit CustomFromUnit { get; }
        public UnitConverterCustomUnit CustomToUnit { get; }
        public UnitConverterError Error { get; }
        public string ErrorMessage { get; }

        internal static UnitConverterDynamicResult Ok(
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
                null,
                null,
                UnitConverterError.None,
                null);
        }

        internal static UnitConverterDynamicResult Ok(
            double value,
            UnitConverterFamily family,
            UnitConverterUnitDescriptor fromUnit,
            UnitConverterUnitDescriptor toUnit,
            UnitConverterCustomUnit customFromUnit,
            UnitConverterCustomUnit customToUnit)
        {
            return new UnitConverterDynamicResult(
                true,
                value,
                family,
                fromUnit,
                toUnit,
                customFromUnit,
                customToUnit,
                UnitConverterError.None,
                null);
        }

        internal static UnitConverterDynamicResult Fail(
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
                null,
                null,
                error,
                errorMessage);
        }
    }
}
