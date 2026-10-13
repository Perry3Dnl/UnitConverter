namespace UnitTools.CurrentDensity
{
    /// <summary>
    /// Extension-method API for Current Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsCurrentDensityExtensions
    {
        public static double Convert(this double value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return (float)UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsCurrentDensityUnit from, UnitToolsCurrentDensityUnit to)
        {
            return UnitToolsCurrentDensity.Convert(value, from, to);
        }
    }
}
