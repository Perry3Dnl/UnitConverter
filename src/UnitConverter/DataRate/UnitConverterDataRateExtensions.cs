namespace UnitConverter.DataRate
{
    /// <summary>
    /// Extension-method API for Data Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDataRateExtensions
    {
        public static double Convert(this double value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return (float)UnitConverterDataRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDataRateUnit from, UnitConverterDataRateUnit to)
        {
            return UnitConverterDataRate.Convert(value, from, to);
        }
    }
}
