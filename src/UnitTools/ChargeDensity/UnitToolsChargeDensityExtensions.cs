namespace UnitTools.ChargeDensity
{
    /// <summary>
    /// Extension-method API for Charge Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsChargeDensityExtensions
    {
        public static double Convert(this double value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return (float)UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsChargeDensityUnit from, UnitToolsChargeDensityUnit to)
        {
            return UnitToolsChargeDensity.Convert(value, from, to);
        }
    }
}
