namespace RealisticPhysics.UnitConversion.Luminance
{
    /// <summary>
    /// Extension-method API for Luminance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminanceExtensions
    {
        public static double Convert(this double value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return (float)UnitConverterLuminance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return (decimal)UnitConverterLuminance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminanceUnit from, UnitConverterLuminanceUnit to)
        {
            return UnitConverterLuminance.Convert(value, from, to);
        }
    }
}
