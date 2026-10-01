namespace RealisticPhysics.UnitConversion.SpecificGravity
{
    /// <summary>
    /// Extension-method API for Specific Gravity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterSpecificGravityExtensions
    {
        public static double Convert(this double value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return (float)UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return (decimal)UnitConverterSpecificGravity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterSpecificGravityUnit from, UnitConverterSpecificGravityUnit to)
        {
            return UnitConverterSpecificGravity.Convert(value, from, to);
        }
    }
}
