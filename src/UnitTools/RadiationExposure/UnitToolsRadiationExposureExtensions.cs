namespace UnitTools.RadiationExposure
{
    /// <summary>
    /// Extension-method API for Radiation Exposure conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsRadiationExposureExtensions
    {
        public static double Convert(this double value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return (float)UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsRadiationExposureUnit from, UnitToolsRadiationExposureUnit to)
        {
            return UnitToolsRadiationExposure.Convert(value, from, to);
        }
    }
}
