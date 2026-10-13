namespace UnitTools.Luminance
{
    /// <summary>
    /// Extension-method API for Luminance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminanceExtensions
    {
        public static double Convert(this double value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return (float)UnitToolsLuminance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminanceUnit from, UnitToolsLuminanceUnit to)
        {
            return UnitToolsLuminance.Convert(value, from, to);
        }
    }
}
