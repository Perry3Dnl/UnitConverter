namespace UnitTools.Jerk
{
    /// <summary>
    /// Extension-method API for Jerk conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsJerkExtensions
    {
        public static double Convert(this double value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return (float)UnitToolsJerk.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsJerkUnit from, UnitToolsJerkUnit to)
        {
            return UnitToolsJerk.Convert(value, from, to);
        }
    }
}
