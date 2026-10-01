namespace UnitConverter.ForcePerLength
{
    /// <summary>
    /// Extension-method API for Force Per Length conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterForcePerLengthExtensions
    {
        public static double Convert(this double value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return (float)UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return (decimal)UnitConverterForcePerLength.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterForcePerLengthUnit from, UnitConverterForcePerLengthUnit to)
        {
            return UnitConverterForcePerLength.Convert(value, from, to);
        }
    }
}
