namespace UnitTools.AreaDensity
{
    /// <summary>
    /// Extension-method API for Area Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAreaDensityExtensions
    {
        public static double Convert(this double value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return (float)UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAreaDensityUnit from, UnitToolsAreaDensityUnit to)
        {
            return UnitToolsAreaDensity.Convert(value, from, to);
        }
    }
}
