namespace UnitConverter.Illuminance
{
    /// <summary>
    /// Extension-method API for Illuminance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterIlluminanceExtensions
    {
        public static double Convert(this double value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return (float)UnitConverterIlluminance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return (decimal)UnitConverterIlluminance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterIlluminanceUnit from, UnitConverterIlluminanceUnit to)
        {
            return UnitConverterIlluminance.Convert(value, from, to);
        }
    }
}
