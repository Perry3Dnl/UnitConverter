namespace UnitTools
{
    using System;
    using System.Globalization;
    using UnitTools.Catalog;

    /// <summary>
    /// Parses text values such as "1.8 km" into the existing UnitTools unit enums
    /// and routes parsed values through the existing family converters.
    /// </summary>
    public static class UnitToolsParser
    {
        private const int MaxInputLength = 4096;
        public static bool TryParse<TUnit>(string input, out double value, out TUnit unit)
            where TUnit : struct
        {
            return TryParse(input, CultureInfo.InvariantCulture, out value, out unit);
        }

        public static UnitToolsParseResult<TUnit> ParseDetailed<TUnit>(string input)
            where TUnit : struct
        {
            return ParseDetailed<TUnit>(input, CultureInfo.InvariantCulture);
        }

        public static UnitToolsParseResult<TUnit> ParseDetailed<TUnit>(
            string input,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            if (!typeof(TUnit).IsEnum)
            {
                return UnitToolsParseResult<TUnit>.Fail(
                    UnitToolsError.UnsupportedUnit,
                    typeof(TUnit).FullName + " is not a unit enum.");
            }

            double parsedValue;
            string unitText;
            UnitToolsError splitError;

            if (!TrySplitValueAndUnit(
                input,
                formatProvider ?? CultureInfo.InvariantCulture,
                out parsedValue,
                out unitText,
                out splitError))
            {
                return UnitToolsParseResult<TUnit>.Fail(
                    splitError,
                    splitError == UnitToolsError.MissingUnit
                        ? "The input does not contain a unit."
                        : "The numeric value could not be parsed.");
            }

            UnitToolsFamilyDescriptor<TUnit> descriptor;
            if (!UnitToolsCatalog.TryGetFamily(out descriptor))
            {
                return UnitToolsParseResult<TUnit>.Fail(
                    UnitToolsError.UnknownFamily,
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            TUnit unit;
            UnitToolsUnitResolution resolution = descriptor.ResolveUnit(unitText, out unit);

            if (resolution == UnitToolsUnitResolution.Unknown)
            {
                resolution = UnitToolsLocalization.ResolveUnit(
                    unitText,
                    formatProvider ?? CultureInfo.InvariantCulture,
                    out unit);
            }

            if (resolution == UnitToolsUnitResolution.Ambiguous)
            {
                return UnitToolsParseResult<TUnit>.Fail(
                    UnitToolsError.AmbiguousUnit,
                    "The unit '" + unitText + "' is ambiguous.");
            }

            if (resolution == UnitToolsUnitResolution.Unknown)
            {
                return UnitToolsParseResult<TUnit>.Fail(
                    UnitToolsError.UnknownUnit,
                    "The unit '" + unitText + "' is not recognized for " + descriptor.Name + ".");
            }

            return UnitToolsParseResult<TUnit>.Ok(parsedValue, unit);
        }

        public static bool TryParse<TUnit>(
            string input,
            IFormatProvider formatProvider,
            out double value,
            out TUnit unit)
            where TUnit : struct
        {
            UnitToolsParseResult<TUnit> result =
                ParseDetailed<TUnit>(input, formatProvider);

            value = result.Value;
            unit = result.Unit;
            return result.Success;
        }

        public static UnitToolsParsedValue<TUnit> Parse<TUnit>(string input)
            where TUnit : struct
        {
            return Parse<TUnit>(input, CultureInfo.InvariantCulture);
        }

        public static UnitToolsParsedValue<TUnit> Parse<TUnit>(
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

            return new UnitToolsParsedValue<TUnit>(value, unit);
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
            UnitToolsParsedValue<TUnit> parsed = Parse<TUnit>(input, formatProvider);

            UnitToolsFamilyDescriptor<TUnit> descriptor;
            if (!UnitToolsCatalog.TryGetFamily(out descriptor))
            {
                throw new NotSupportedException(
                    "No unit family descriptor is registered for " + typeof(TUnit).FullName + ".");
            }

            return descriptor.Convert(parsed.Value, parsed.Unit, to);
        }

        public static UnitToolsConversionResult TryConvert<TUnit>(string input, TUnit to)
            where TUnit : struct
        {
            return TryConvert(
                input,
                to,
                CultureInfo.InvariantCulture);
        }

        public static UnitToolsConversionResult TryConvert<TUnit>(
            string input,
            TUnit to,
            IFormatProvider formatProvider)
            where TUnit : struct
        {
            try
            {
                return UnitToolsConversionResult.Ok(
                    Convert(input, to, formatProvider));
            }
            catch (ArgumentException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (FormatException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (InvalidOperationException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (NotSupportedException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (OverflowException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
            catch (UnitToolsConversionException exception)
            {
                return UnitToolsConversionResult.Fail(exception.Message);
            }
        }

        internal static bool TrySplitValueAndUnit(
            string text,
            IFormatProvider formatProvider,
            out double value,
            out string unitText,
            out UnitToolsError error)
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
            error = UnitToolsError.InvalidNumber;

            if (string.IsNullOrWhiteSpace(text) || text.Length > MaxInputLength)
            {
                return false;
            }

            string trimmed = text.Trim();
            double numericOnly;

            if (double.TryParse(
                trimmed,
                NumberStyles.Float | NumberStyles.AllowThousands,
                formatProvider,
                out numericOnly))
            {
                error = UnitToolsError.MissingUnit;
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
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    formatProvider,
                    out candidateValue))
                {
                    value = candidateValue;
                    unitText = candidateUnit;
                    error = UnitToolsError.None;
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
            out UnitToolsError error)
        {
            value = 0d;
            unitText = null;
            error = UnitToolsError.InvalidNumber;

            if (string.IsNullOrWhiteSpace(text) || text.Length > MaxInputLength)
            {
                return false;
            }

            ReadOnlySpan<char> trimmed = text.AsSpan().Trim();
            double numericOnly;

            if (double.TryParse(
                trimmed,
                NumberStyles.Float | NumberStyles.AllowThousands,
                formatProvider,
                out numericOnly))
            {
                error = UnitToolsError.MissingUnit;
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
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    formatProvider,
                    out candidateValue))
                {
                    value = candidateValue;
                    unitText = candidateUnit.ToString();
                    error = UnitToolsError.None;
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
    public readonly struct UnitToolsParsedValue<TUnit> : IFormattable
        where TUnit : struct
    {
        public UnitToolsParsedValue(double value, TUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }

        public TUnit Unit { get; }

        public override string ToString()
        {
            return UnitToolsFormatter.Format(Value, Unit);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return UnitToolsFormatter.Format(
                Value,
                Unit,
                string.IsNullOrEmpty(format) ? "G" : format,
                formatProvider ?? CultureInfo.InvariantCulture,
                UnitToolsUnitFormat.Symbol);
        }
    }
}