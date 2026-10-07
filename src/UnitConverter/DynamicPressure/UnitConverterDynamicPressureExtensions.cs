namespace UnitConverter.DynamicPressure
{
    /// <summary>
    /// Extension-method API for Dynamic Pressure conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDynamicPressureExtensions
    {
        public static double Convert(this double value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return (float)UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDynamicPressureUnit from, UnitConverterDynamicPressureUnit to)
        {
            return UnitConverterDynamicPressure.Convert(value, from, to);
        }
    }
}
