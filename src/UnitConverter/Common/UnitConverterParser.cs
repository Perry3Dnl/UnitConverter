namespace UnitConverter
{
    using System;
    using System.Globalization;
    using UnitConverter.Catalog;

    /// <summary>
    /// Parses text values such as "1.8 km" into the existing UnitConverter unit enums
    /// and routes parsed values through the existing family converters.
    /// </summary>
    public static class UnitConverterParser
    {
        public static bool TryParse<TUnit>(string input, out double value, out TUnit unit)
            where TUnit : struct
        {
            return TryParse(input, CultureInfo.InvariantCulture, out value, out unit);
        }

        public static UnitConverterParseResult<TUnit> ParseDetailed<TUnit>(string input)
            where TUnit : struct
        {
            return ParseDetailed<TUnit>(input, CultureInfo.InvariantCulture);
        }

        public static UnitConverterParseResult<TUnit> ParseDetailed<TUnit>(
            string input,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            if (!typeof(TUnit).IsEnum)
            {
                return UnitConverterParseResult<TUnit>.Fail(
                    UnitConverterError.UnsupportedUnit,
                    typeof(TUnit).FullName + " is not a unit enum.");
            }

            double parsedValue;
            string unitText;
            UnitConverterError splitError;

            if (!TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out parsedValue,
                out unitText,
                out splitError))
            {
                return UnitConverterParseResult<TUnit>.Fail(
                    splitError,
                    splitError == UnitConverterError.MissingUnit
                        ? "The input does not contain a unit."
                        : "The numeric value could not be parsed.");
            }

            UnitConverterFamilyDescriptor<TUnit> descriptor;
            if (!UnitConverterCatalog.TryGetFamily(out descriptor))
            {
                return UnitConverterParseResult<TUnit>.Fail(
                    UnitConverterError.UnknownFamily,
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            TUnit unit;
            UnitConverterUnitResolution resolution = descriptor.ResolveUnit(unitText, out unit);

            if (resolution == UnitConverterUnitResolution.Unknown)
            {
                resolution = UnitConverterLocalization.ResolveUnit(
                    unitText,
                    formatProvider ?? CultureInfo.InvariantCulture,
                    out unit);
            }

            if (resolution == UnitConverterUnitResolution.Ambiguous)
            {
                return UnitConverterParseResult<TUnit>.Fail(
                    UnitConverterError.AmbiguousUnit,
                    "The unit '" + unitText + "' is ambiguous.");
            }

            if (resolution == UnitConverterUnitResolution.Unknown)
            {
                return UnitConverterParseResult<TUnit>.Fail(
                    UnitConverterError.UnknownUnit,
                    "The unit '" + unitText + "' is not recognized for " + descriptor.Name + ".");
            }

            return UnitConverterParseResult<TUnit>.Ok(parsedValue, unit);
        }

        public static bool TryParse<TUnit>(
            string input,
            IFormatProvider formatProvider,
            out double value,
            out TUnit unit)
            where TUnit : struct
        {
            UnitConverterParseResult<TUnit> result =
                ParseDetailed<TUnit>(input, formatProvider);

            value = result.Value;
            unit = result.Unit;
            return result.Success;
        }

        public static UnitConverterParsedValue<TUnit> Parse<TUnit>(string input)
            where TUnit : struct
        {
            return Parse<TUnit>(input, CultureInfo.InvariantCulture);
        }

        public static UnitConverterParsedValue<TUnit> Parse<TUnit>(
            string input,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            double value;
            TUnit unit;

            if (!TryParse(input, formatProvider, out value, out unit))
            {
                throw new FormatException(
                    "The value could not be parsed as " + typeof(TUnit).Name + ".");
            }

            return new UnitConverterParsedValue<TUnit>(value, unit);
        }

        public static double Convert<TUnit>(string input, TUnit to)
            where TUnit : struct
        {
            return Convert(input, to, CultureInfo.InvariantCulture);
        }

        public static double Convert<TUnit>(
            string input,
            TUnit to,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            UnitConverterParsedValue<TUnit> parsed = Parse<TUnit>(input, formatProvider);

            UnitConverterFamilyDescriptor<TUnit> descriptor;
            if (!UnitConverterCatalog.TryGetFamily(out descriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            return descriptor.Convert(parsed.Value, parsed.Unit, to);
        }

        public static UnitConverterConversionResult TryConvert<TUnit>(string input, TUnit to)
            where TUnit : struct
        {
            try
            {
                return UnitConverterConversionResult.Ok(Convert(input, to));
            }
            catch (Exception exception)
            {
                return UnitConverterConversionResult.Fail(exception.Message);
            }
        }

        internal static bool TrySplitValueAndUnit(
            string text,
            IFormatProvider formatProvider,
            out double value,
            out string unitText,
            out UnitConverterError error)
        {
#if NET8_0_OR_GREATER
            return TrySplitValueAndUnitSpan(
                text,
                formatProvider,
                out value,
                out unitText,
                out error);
#else
            value = 0d;
            unitText = null;
            error = UnitConverterError.InvalidNumber;

            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string trimmed = text.Trim();
            double numericOnly;

            if (double.TryParse(
                trimmed,
                NumberStyles.Float,
                formatProvider,
                out numericOnly))
            {
                error = UnitConverterError.MissingUnit;
                return false;
            }

            for (int splitIndex = trimmed.Length - 1; splitIndex > 0; splitIndex--)
            {
                string numberPart = trimmed.Substring(0, splitIndex).TrimEnd();
                string candidateUnit = trimmed.Substring(splitIndex).Trim();

                if (candidateUnit.Length == 0)
                {
                    continue;
                }

                double candidateValue;
                if (double.TryParse(
                    numberPart,
                    NumberStyles.Float,
                    formatProvider,
                    out candidateValue))
                {
                    value = candidateValue;
                    unitText = candidateUnit;
                    error = UnitConverterError.None;
                    return true;
                }
            }

            return false;
#endif
        }

#if NET8_0_OR_GREATER
        private static bool TrySplitValueAndUnitSpan(
            string text,
            IFormatProvider formatProvider,
            out double value,
            out string unitText,
            out UnitConverterError error)
        {
            value = 0d;
            unitText = null;
            error = UnitConverterError.InvalidNumber;

            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            ReadOnlySpan<char> trimmed = text.AsSpan().Trim();
            double numericOnly;

            if (double.TryParse(
                trimmed,
                NumberStyles.Float,
                formatProvider,
                out numericOnly))
            {
                error = UnitConverterError.MissingUnit;
                return false;
            }

            for (int splitIndex = trimmed.Length - 1; splitIndex > 0; splitIndex--)
            {
                ReadOnlySpan<char> numberPart =
                    trimmed.Slice(0, splitIndex).TrimEnd();
                ReadOnlySpan<char> candidateUnit =
                    trimmed.Slice(splitIndex).Trim();

                if (candidateUnit.IsEmpty)
                {
                    continue;
                }

                double candidateValue;
                if (double.TryParse(
                    numberPart,
                    NumberStyles.Float,
                    formatProvider,
                    out candidateValue))
                {
                    value = candidateValue;
                    unitText = candidateUnit.ToString();
                    error = UnitConverterError.None;
                    return true;
                }
            }

            return false;
        }
#endif
    }

    /// <summary>
    /// A parsed numeric value together with the unit that was present in the source text.
    /// </summary>
    public readonly struct UnitConverterParsedValue<TUnit>
        where TUnit : struct
    {
        public UnitConverterParsedValue(double value, TUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }

        public TUnit Unit { get; }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture) + " " + Unit;
        }
    }
}