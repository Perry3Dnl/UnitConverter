namespace UnitTools.SpecificWeight
{
    /// <summary>
    /// Extension-method API for Specific Weight conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSpecificWeightExtensions
    {
        public static double Convert(this double value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return (float)UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSpecificWeightUnit from, UnitToolsSpecificWeightUnit to)
        {
            return UnitToolsSpecificWeight.Convert(value, from, to);
        }
    }
}
