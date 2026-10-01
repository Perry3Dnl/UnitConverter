namespace RealisticPhysics.UnitConversion.Density
{
    /// <summary>
    /// Extension-method API for Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDensityExtensions
    {
        public static double Convert(this double value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return (float)UnitConverterDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return (decimal)UnitConverterDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDensityUnit from, UnitConverterDensityUnit to)
        {
            return UnitConverterDensity.Convert(value, from, to);
        }
    }
}
