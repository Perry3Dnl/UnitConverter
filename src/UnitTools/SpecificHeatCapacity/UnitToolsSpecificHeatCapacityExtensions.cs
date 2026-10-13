namespace UnitTools.SpecificHeatCapacity
{
    /// <summary>
    /// Extension-method API for Specific Heat Capacity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSpecificHeatCapacityExtensions
    {
        public static double Convert(this double value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return (float)UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSpecificHeatCapacityUnit from, UnitToolsSpecificHeatCapacityUnit to)
        {
            return UnitToolsSpecificHeatCapacity.Convert(value, from, to);
        }
    }
}
