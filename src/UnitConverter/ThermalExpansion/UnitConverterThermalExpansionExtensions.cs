namespace UnitConverter.ThermalExpansion
{
    /// <summary>
    /// Extension-method API for Thermal Expansion conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterThermalExpansionExtensions
    {
        public static double Convert(this double value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return (float)UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterThermalExpansionUnit from, UnitConverterThermalExpansionUnit to)
        {
            return UnitConverterThermalExpansion.Convert(value, from, to);
        }
    }
}
