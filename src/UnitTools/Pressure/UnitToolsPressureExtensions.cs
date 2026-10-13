namespace UnitTools.Pressure
{
    /// <summary>
    /// Extension-method API for Pressure conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsPressureExtensions
    {
        public static double Convert(this double value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return (float)UnitToolsPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsPressureUnit from, UnitToolsPressureUnit to)
        {
            return UnitToolsPressure.Convert(value, from, to);
        }
    }
}
