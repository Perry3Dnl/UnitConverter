namespace UnitTools.Time
{
    /// <summary>
    /// Extension-method API for Time conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsTimeExtensions
    {
        public static double Convert(this double value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return (float)UnitToolsTime.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsTimeUnit from, UnitToolsTimeUnit to)
        {
            return UnitToolsTime.Convert(value, from, to);
        }
    }
}
