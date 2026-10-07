namespace UnitConverter.Force
{
    /// <summary>
    /// Extension-method API for Force conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterForceExtensions
    {
        public static double Convert(this double value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return (float)UnitConverterForce.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterForceUnit from, UnitConverterForceUnit to)
        {
            return UnitConverterForce.Convert(value, from, to);
        }
    }
}
