namespace UnitConverter.AreaDensity
{
    /// <summary>
    /// Extension-method API for Area Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAreaDensityExtensions
    {
        public static double Convert(this double value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return (float)UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAreaDensityUnit from, UnitConverterAreaDensityUnit to)
        {
            return UnitConverterAreaDensity.Convert(value, from, to);
        }
    }
}
