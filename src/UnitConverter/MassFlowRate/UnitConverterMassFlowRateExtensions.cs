namespace UnitConverter.MassFlowRate
{
    /// <summary>
    /// Extension-method API for Mass Flow Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMassFlowRateExtensions
    {
        public static double Convert(this double value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return (float)UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMassFlowRateUnit from, UnitConverterMassFlowRateUnit to)
        {
            return UnitConverterMassFlowRate.Convert(value, from, to);
        }
    }
}
