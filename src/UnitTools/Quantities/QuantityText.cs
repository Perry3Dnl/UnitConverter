#if NET8_0_OR_GREATER
using System;
using System.Globalization;
using System.Numerics;

namespace UnitTools.Quantities
{
    internal static class QuantityText
    {
        public static string Format<T>(
            T value,
            string unit,
            string format,
            IFormatProvider provider)
            where T : IFloatingPoint<T>
        {
            return value.ToString(format, provider) + " " + unit;
        }

        public static bool TryFormat<T>(
            T value,
            ReadOnlySpan<char> unit,
            Span<char> destination,
            out int charsWritten,
            ReadOnlySpan<char> format,
            IFormatProvider provider)
            where T : IFloatingPoint<T>
        {
            charsWritten = 0;
            if (!value.TryFormat(destination, out int valueWritten, format, provider))
                return false;

            int required = valueWritten + 1 + unit.Length;
            if (required > destination.Length)
                return false;

            destination[valueWritten] = ' ';
            unit.CopyTo(destination.Slice(valueWritten + 1));
            charsWritten = required;
            return true;
        }

        public static bool TryParseValueAndUnit<T>(
            ReadOnlySpan<char> input,
            IFormatProvider provider,
            out T value,
            out ReadOnlySpan<char> unit)
            where T : IFloatingPoint<T>
        {
            value = default;
            unit = default;
            input = input.Trim();

            if (input.IsEmpty)
                return false;

            // Preserve the existing fast path for the overwhelmingly common
            // "number unit" form.
            if (QuantityParser.TrySplit(
                    input,
                    out ReadOnlySpan<char> number,
                    out ReadOnlySpan<char> fastUnit) &&
                T.TryParse(
                    number,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    provider,
                    out value))
            {
                unit = fastUnit;
                return true;
            }

            // Fall back to the longest numeric prefix. This handles compact
            // forms such as "1.5km" and unit names containing whitespace.
            for (int splitIndex = input.Length - 1; splitIndex > 0; splitIndex--)
            {
                ReadOnlySpan<char> numberPart =
                    input.Slice(0, splitIndex).TrimEnd();
                ReadOnlySpan<char> unitPart =
                    input.Slice(splitIndex).Trim();

                if (numberPart.IsEmpty || unitPart.IsEmpty)
                    continue;

                if (T.TryParse(
                    numberPart,
                    NumberStyles.Float | NumberStyles.AllowThousands,
                    provider,
                    out value))
                {
                    unit = unitPart;
                    return true;
                }
            }

            value = default;
            unit = default;
            return false;
        }

        public static bool TryResolveLocalizedUnit<TUnit>(
            ReadOnlySpan<char> unitText,
            IFormatProvider provider,
            out TUnit unit)
            where TUnit : struct
        {
            if (unitText.IsEmpty)
            {
                unit = default;
                return false;
            }

            return global::UnitTools.UnitToolsLocalization.ResolveUnit(
                unitText.ToString(),
                provider,
                out unit) ==
                global::UnitTools.Catalog.UnitToolsUnitResolution.Resolved;
        }
    }
}
#endif
