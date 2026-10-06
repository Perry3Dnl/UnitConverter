#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitConverter.Quantities
{
    internal static class QuantityText
    {
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

            if (!QuantityParser.TrySplit(input, out ReadOnlySpan<char> number, out unit))
                return false;

            return T.TryParse(number, provider, out value);
        }
    }
}
#endif
