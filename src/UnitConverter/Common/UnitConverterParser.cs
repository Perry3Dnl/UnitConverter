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

        public static bool TryParse<TUnit>(
            string input,
            IFormatProvider formatProvider,
            out double value,
            out TUnit unit)
            where TUnit : struct
        {
            value = 0d;
            unit = default(TUnit);

            if (!typeof(TUnit).IsEnum || string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            double parsedValue;
            string unitText;

            if (!TrySplitValueAndUnit(
                input.Trim(),
                formatProvider ?? CultureInfo.InvariantCulture,
                out parsedValue,
                out unitText))
            {
                return false;
            }

            UnitConverterFamilyDescriptor<TUnit> descriptor;
            if (!UnitConverterCatalog.TryGetFamily(out descriptor) ||
                !descriptor.TryResolveUnit(unitText, out unit))
            {
                return false;
            }

            value = parsedValue;
            return true;
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

        private static bool TrySplitValueAndUnit(
            string text,
            IFormatProvider formatProvider,
            out double value,
            out string unitText)
        {
            value = 0d;
            unitText = null;

            for (int splitIndex = text.Length - 1; splitIndex > 0; splitIndex--)
            {
                string numberPart = text.Substring(0, splitIndex).TrimEnd();
                string candidateUnit = text.Substring(splitIndex).Trim();

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
                    return true;
                }
            }

            return false;
        }
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
