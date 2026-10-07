namespace UnitConverter.Time
{
    /// <summary>
    /// Extension-method API for Time conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterTimeExtensions
    {
        public static double Convert(this double value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return (float)UnitConverterTime.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterTimeUnit from, UnitConverterTimeUnit to)
        {
            return UnitConverterTime.Convert(value, from, to);
        }
    }
}
