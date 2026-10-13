namespace UnitTools.PixelDensity
{
    /// <summary>
    /// Extension-method API for Pixel Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPixelDensityExtensions
    {
        public static double Convert(this double value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return (float)UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPixelDensityUnit from, UnitToolsPixelDensityUnit to)
        {
            return UnitToolsPixelDensity.Convert(value, from, to);
        }
    }
}
