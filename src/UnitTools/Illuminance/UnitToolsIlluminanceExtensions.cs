namespace UnitTools.Illuminance
{
    /// <summary>
    /// Extension-method API for Illuminance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsIlluminanceExtensions
    {
        public static double Convert(this double value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return (float)UnitToolsIlluminance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsIlluminanceUnit from, UnitToolsIlluminanceUnit to)
        {
            return UnitToolsIlluminance.Convert(value, from, to);
        }
    }
}
