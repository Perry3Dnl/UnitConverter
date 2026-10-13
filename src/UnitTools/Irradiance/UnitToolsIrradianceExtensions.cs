namespace UnitTools.Irradiance
{
    /// <summary>
    /// Extension-method API for Irradiance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsIrradianceExtensions
    {
        public static double Convert(this double value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return (float)UnitToolsIrradiance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            return UnitToolsIrradiance.Convert(value, from, to);
        }
    }
}
