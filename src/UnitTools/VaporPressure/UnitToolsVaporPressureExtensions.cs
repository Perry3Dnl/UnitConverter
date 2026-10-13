namespace UnitTools.VaporPressure
{
    /// <summary>
    /// Extension-method API for Vapor Pressure conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsVaporPressureExtensions
    {
        public static double Convert(this double value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return (float)UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsVaporPressureUnit from, UnitToolsVaporPressureUnit to)
        {
            return UnitToolsVaporPressure.Convert(value, from, to);
        }
    }
}
