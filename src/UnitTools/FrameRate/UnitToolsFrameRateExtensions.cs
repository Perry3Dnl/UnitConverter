namespace UnitTools.FrameRate
{
    /// <summary>
    /// Extension-method API for Frame Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsFrameRateExtensions
    {
        public static double Convert(this double value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return (float)UnitToolsFrameRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsFrameRateUnit from, UnitToolsFrameRateUnit to)
        {
            return UnitToolsFrameRate.Convert(value, from, to);
        }
    }
}
