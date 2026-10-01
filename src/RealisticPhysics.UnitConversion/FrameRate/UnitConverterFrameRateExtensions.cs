namespace RealisticPhysics.UnitConversion.FrameRate
{
    /// <summary>
    /// Extension-method API for Frame Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterFrameRateExtensions
    {
        public static double Convert(this double value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return (float)UnitConverterFrameRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return (decimal)UnitConverterFrameRate.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterFrameRateUnit from, UnitConverterFrameRateUnit to)
        {
            return UnitConverterFrameRate.Convert(value, from, to);
        }
    }
}
