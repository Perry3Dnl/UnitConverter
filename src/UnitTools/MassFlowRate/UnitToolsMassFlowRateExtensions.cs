namespace UnitTools.MassFlowRate
{
    /// <summary>
    /// Extension-method API for Mass Flow Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMassFlowRateExtensions
    {
        public static double Convert(this double value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return (float)UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMassFlowRateUnit from, UnitToolsMassFlowRateUnit to)
        {
            return UnitToolsMassFlowRate.Convert(value, from, to);
        }
    }
}
