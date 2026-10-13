namespace UnitTools.ExposureRate
{
    /// <summary>
    /// Extension-method API for Exposure Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsExposureRateExtensions
    {
        public static double Convert(this double value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return (float)UnitToolsExposureRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsExposureRateUnit from, UnitToolsExposureRateUnit to)
        {
            return UnitToolsExposureRate.Convert(value, from, to);
        }
    }
}
