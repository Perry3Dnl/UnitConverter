namespace UnitTools.LuminousIntensity
{
    /// <summary>
    /// Extension-method API for Luminous Intensity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminousIntensityExtensions
    {
        public static double Convert(this double value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return (float)UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminousIntensityUnit from, UnitToolsLuminousIntensityUnit to)
        {
            return UnitToolsLuminousIntensity.Convert(value, from, to);
        }
    }
}
