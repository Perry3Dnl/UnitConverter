#if NET8_0_OR_GREATER
using System;
using System.Numerics;

namespace UnitConverter.Quantities
{
    public static class QuantityFormattingExtensions
    {
        public static bool TryFormatWithUnit<T>(this Mass<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("kg".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilograms, "kg".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("g".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Grams, "g".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("mg".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Milligrams, "mg".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Area<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("m2".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("m²".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.SquareMetres, "m²".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("km2".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("km²".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.SquareKilometres, "km²".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("ha".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Hectares, "ha".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Volume<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("m3".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("m³".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.CubicMetres, "m³".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("l".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Litres, "L".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("ml".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Millilitres, "mL".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Acceleration<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("m/s2".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("m/s²".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.MetresPerSecondSquared, "m/s²".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Force<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("N".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Newtons, "N".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kN".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilonewtons, "kN".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Energy<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("J".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Joules, "J".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kJ".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilojoules, "kJ".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Power<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("W".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Watts, "W".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kW".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilowatts, "kW".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Pressure<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("Pa".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Pascals, "Pa".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kPa".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilopascals, "kPa".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("MPa".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Megapascals, "MPa".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("bar".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Bars, "bar".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Density<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("kg/m3".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("kg/m³".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.KilogramsPerCubicMetre, "kg/m³".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("g/cm3".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("g/cm³".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.GramsPerCubicCentimetre, "g/cm³".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Frequency<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("Hz".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Hertz, "Hz".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kHz".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kilohertz, "kHz".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("MHz".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Megahertz, "MHz".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this ElectricCurrent<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("A".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Amperes, "A".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("mA".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Milliamperes, "mA".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this ElectricCharge<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("C".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Coulombs, "C".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Voltage<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("V".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Volts, "V".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("mV".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Millivolts, "mV".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }

        public static bool TryFormatWithUnit<T>(this Resistance<T> quantity, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, ReadOnlySpan<char> unit) where T : IFloatingPoint<T>
        {
            if (unit.Equals("ohm".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("Ω".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Ohms, "Ω".AsSpan(), destination, out charsWritten, format, provider);
            if (unit.Equals("kohm".AsSpan(), StringComparison.OrdinalIgnoreCase) || unit.Equals("kΩ".AsSpan(), StringComparison.OrdinalIgnoreCase)) return QuantityText.TryFormat(quantity.Kiloohms, "kΩ".AsSpan(), destination, out charsWritten, format, provider);
            charsWritten = 0; return false;
        }
    }
}
#endif
