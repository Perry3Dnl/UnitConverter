namespace UnitTools.DataRate
{
    /// <summary>
    /// Extension-method API for Data Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDataRateExtensions
    {
        public static double Convert(this double value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return (float)UnitToolsDataRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDataRateUnit from, UnitToolsDataRateUnit to)
        {
            return UnitToolsDataRate.Convert(value, from, to);
        }
    }
}
