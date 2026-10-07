namespace UnitConverter.LuminousExposure
{
    /// <summary>
    /// Extension-method API for Luminous Exposure conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminousExposureExtensions
    {
        public static double Convert(this double value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return (float)UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminousExposureUnit from, UnitConverterLuminousExposureUnit to)
        {
            return UnitConverterLuminousExposure.Convert(value, from, to);
        }
    }
}
