namespace UnitConverter.SpecificHeatCapacity
{
    /// <summary>
    /// Extension-method API for Specific Heat Capacity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSpecificHeatCapacityExtensions
    {
        public static double Convert(this double value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return (float)UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSpecificHeatCapacityUnit from, UnitConverterSpecificHeatCapacityUnit to)
        {
            return UnitConverterSpecificHeatCapacity.Convert(value, from, to);
        }
    }
}
