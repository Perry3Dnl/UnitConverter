namespace UnitTools.ForcePerLength
{
    /// <summary>
    /// Extension-method API for Force Per Length conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsForcePerLengthExtensions
    {
        public static double Convert(this double value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return (float)UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsForcePerLengthUnit from, UnitToolsForcePerLengthUnit to)
        {
            return UnitToolsForcePerLength.Convert(value, from, to);
        }
    }
}
