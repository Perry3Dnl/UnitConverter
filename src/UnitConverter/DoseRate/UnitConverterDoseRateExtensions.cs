namespace UnitConverter.DoseRate
{
    /// <summary>
    /// Extension-method API for Dose Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDoseRateExtensions
    {
        public static double Convert(this double value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return (float)UnitConverterDoseRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDoseRateUnit from, UnitConverterDoseRateUnit to)
        {
            return UnitConverterDoseRate.Convert(value, from, to);
        }
    }
}
