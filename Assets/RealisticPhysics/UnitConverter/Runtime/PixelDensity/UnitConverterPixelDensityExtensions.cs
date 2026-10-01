namespace RealisticPhysics.UnitConversion.PixelDensity
{
    /// <summary>
    /// Extension-method API for Pixel Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPixelDensityExtensions
    {
        public static double Convert(this double value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return (float)UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return (decimal)UnitConverterPixelDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPixelDensityUnit from, UnitConverterPixelDensityUnit to)
        {
            return UnitConverterPixelDensity.Convert(value, from, to);
        }
    }
}
