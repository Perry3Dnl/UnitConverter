namespace UnitTools.DynamicPressure
{
    /// <summary>
    /// Extension-method API for Dynamic Pressure conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDynamicPressureExtensions
    {
        public static double Convert(this double value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return (float)UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDynamicPressureUnit from, UnitToolsDynamicPressureUnit to)
        {
            return UnitToolsDynamicPressure.Convert(value, from, to);
        }
    }
}
