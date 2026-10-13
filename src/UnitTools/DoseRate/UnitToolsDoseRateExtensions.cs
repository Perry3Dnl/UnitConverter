namespace UnitTools.DoseRate
{
    /// <summary>
    /// Extension-method API for Dose Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDoseRateExtensions
    {
        public static double Convert(this double value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return (float)UnitToolsDoseRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDoseRateUnit from, UnitToolsDoseRateUnit to)
        {
            return UnitToolsDoseRate.Convert(value, from, to);
        }
    }
}
