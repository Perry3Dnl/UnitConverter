namespace RealisticPhysics.UnitConversion.Jerk
{
    /// <summary>
    /// Extension-method API for Jerk conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterJerkExtensions
    {
        public static double Convert(this double value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return (float)UnitConverterJerk.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return (decimal)UnitConverterJerk.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterJerkUnit from, UnitConverterJerkUnit to)
        {
            return UnitConverterJerk.Convert(value, from, to);
        }
    }
}
