namespace RealisticPhysics.UnitConversion.Radiance
{
    /// <summary>
    /// Extension-method API for Radiance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterRadianceExtensions
    {
        public static double Convert(this double value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return (float)UnitConverterRadiance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return (decimal)UnitConverterRadiance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            return UnitConverterRadiance.Convert(value, from, to);
        }
    }
}
