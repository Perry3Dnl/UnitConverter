namespace UnitTools.ThermalExpansion
{
    /// <summary>
    /// Extension-method API for Thermal Expansion conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsThermalExpansionExtensions
    {
        public static double Convert(this double value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return (float)UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsThermalExpansionUnit from, UnitToolsThermalExpansionUnit to)
        {
            return UnitToolsThermalExpansion.Convert(value, from, to);
        }
    }
}
