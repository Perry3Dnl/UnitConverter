namespace UnitConverter.LuminousIntensity
{
    /// <summary>
    /// Extension-method API for Luminous Intensity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminousIntensityExtensions
    {
        public static double Convert(this double value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return (float)UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminousIntensityUnit from, UnitConverterLuminousIntensityUnit to)
        {
            return UnitConverterLuminousIntensity.Convert(value, from, to);
        }
    }
}
