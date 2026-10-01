namespace UnitConverter.Irradiance
{
    /// <summary>
    /// Extension-method API for Irradiance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterIrradianceExtensions
    {
        public static double Convert(this double value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return (float)UnitConverterIrradiance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return (decimal)UnitConverterIrradiance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterIrradianceUnit from, UnitConverterIrradianceUnit to)
        {
            return UnitConverterIrradiance.Convert(value, from, to);
        }
    }
}
