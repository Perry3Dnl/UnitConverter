namespace UnitConverter.Pressure
{
    /// <summary>
    /// Extension-method API for Pressure conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterPressureExtensions
    {
        public static double Convert(this double value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return (float)UnitConverterPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterPressureUnit from, UnitConverterPressureUnit to)
        {
            return UnitConverterPressure.Convert(value, from, to);
        }
    }
}
