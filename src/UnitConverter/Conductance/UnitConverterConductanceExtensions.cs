namespace UnitConverter.Conductance
{
    /// <summary>
    /// Extension-method API for Conductance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterConductanceExtensions
    {
        public static double Convert(this double value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return (float)UnitConverterConductance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return (decimal)UnitConverterConductance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterConductanceUnit from, UnitConverterConductanceUnit to)
        {
            return UnitConverterConductance.Convert(value, from, to);
        }
    }
}
