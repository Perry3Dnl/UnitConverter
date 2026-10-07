namespace UnitConverter.SpecificWeight
{
    /// <summary>
    /// Extension-method API for Specific Weight conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSpecificWeightExtensions
    {
        public static double Convert(this double value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return (float)UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSpecificWeightUnit from, UnitConverterSpecificWeightUnit to)
        {
            return UnitConverterSpecificWeight.Convert(value, from, to);
        }
    }
}
