namespace UnitTools.LinearDensity
{
    /// <summary>
    /// Extension-method API for Linear Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLinearDensityExtensions
    {
        public static double Convert(this double value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return (float)UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLinearDensityUnit from, UnitToolsLinearDensityUnit to)
        {
            return UnitToolsLinearDensity.Convert(value, from, to);
        }
    }
}
