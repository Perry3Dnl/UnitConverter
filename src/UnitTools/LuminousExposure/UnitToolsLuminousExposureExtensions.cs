namespace UnitTools.LuminousExposure
{
    /// <summary>
    /// Extension-method API for Luminous Exposure conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminousExposureExtensions
    {
        public static double Convert(this double value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return (float)UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminousExposureUnit from, UnitToolsLuminousExposureUnit to)
        {
            return UnitToolsLuminousExposure.Convert(value, from, to);
        }
    }
}
