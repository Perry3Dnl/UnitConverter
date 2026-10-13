namespace UnitTools.SpecificGravity
{
    /// <summary>
    /// Extension-method API for Specific Gravity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsSpecificGravityExtensions
    {
        public static double Convert(this double value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return (float)UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsSpecificGravityUnit from, UnitToolsSpecificGravityUnit to)
        {
            return UnitToolsSpecificGravity.Convert(value, from, to);
        }
    }
}
