namespace UnitConverter.VaporPressure
{
    /// <summary>
    /// Extension-method API for Vapor Pressure conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterVaporPressureExtensions
    {
        public static double Convert(this double value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return (float)UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterVaporPressureUnit from, UnitConverterVaporPressureUnit to)
        {
            return UnitConverterVaporPressure.Convert(value, from, to);
        }
    }
}
