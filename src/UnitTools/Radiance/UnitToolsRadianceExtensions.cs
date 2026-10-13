namespace UnitTools.Radiance
{
    /// <summary>
    /// Extension-method API for Radiance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsRadianceExtensions
    {
        public static double Convert(this double value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return (float)UnitToolsRadiance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            return UnitToolsRadiance.Convert(value, from, to);
        }
    }
}
