namespace UnitConverter.HeatTransferCoefficient
{
    /// <summary>
    /// Extension-method API for Heat Transfer Coefficient conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterHeatTransferCoefficientExtensions
    {
        public static double Convert(this double value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return (float)UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterHeatTransferCoefficientUnit from, UnitConverterHeatTransferCoefficientUnit to)
        {
            return UnitConverterHeatTransferCoefficient.Convert(value, from, to);
        }
    }
}
