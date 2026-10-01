namespace RealisticPhysics.UnitConversion.ExposureRate
{
    /// <summary>
    /// Extension-method API for Exposure Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterExposureRateExtensions
    {
        public static double Convert(this double value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return (float)UnitConverterExposureRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return (decimal)UnitConverterExposureRate.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterExposureRateUnit from, UnitConverterExposureRateUnit to)
        {
            return UnitConverterExposureRate.Convert(value, from, to);
        }
    }
}
