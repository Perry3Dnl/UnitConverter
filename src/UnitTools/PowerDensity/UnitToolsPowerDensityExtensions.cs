namespace UnitTools.PowerDensity
{
    /// <summary>
    /// Extension-method API for Power Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPowerDensityExtensions
    {
        public static double Convert(this double value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return (float)UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            return UnitToolsPowerDensity.Convert(value, from, to);
        }
    }
}
