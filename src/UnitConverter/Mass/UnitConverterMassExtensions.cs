namespace UnitConverter.Mass
{
    /// <summary>
    /// Extension-method API for Mass conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMassExtensions
    {
        public static double Convert(this double value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return (float)UnitConverterMass.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return (decimal)UnitConverterMass.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMassUnit from, UnitConverterMassUnit to)
        {
            return UnitConverterMass.Convert(value, from, to);
        }
    }
}
