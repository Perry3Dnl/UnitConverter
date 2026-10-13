namespace UnitTools.HeatTransferCoefficient
{
    /// <summary>
    /// Extension-method API for Heat Transfer Coefficient conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsHeatTransferCoefficientExtensions
    {
        public static double Convert(this double value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return (float)UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsHeatTransferCoefficientUnit from, UnitToolsHeatTransferCoefficientUnit to)
        {
            return UnitToolsHeatTransferCoefficient.Convert(value, from, to);
        }
    }
}
