namespace UnitTools.Density
{
    /// <summary>
    /// Extension-method API for Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDensityExtensions
    {
        public static double Convert(this double value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return (float)UnitToolsDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDensityUnit from, UnitToolsDensityUnit to)
        {
            return UnitToolsDensity.Convert(value, from, to);
        }
    }
}
