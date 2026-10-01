namespace RealisticPhysics.UnitConversion.RadiationExposure
{
    /// <summary>
    /// Extension-method API for Radiation Exposure conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterRadiationExposureExtensions
    {
        public static double Convert(this double value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return (float)UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return (decimal)UnitConverterRadiationExposure.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterRadiationExposureUnit from, UnitConverterRadiationExposureUnit to)
        {
            return UnitConverterRadiationExposure.Convert(value, from, to);
        }
    }
}
