namespace UnitConverter.Capacitance
{
    /// <summary>
    /// Extension-method API for Capacitance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterCapacitanceExtensions
    {
        public static double Convert(this double value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return (float)UnitConverterCapacitance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterCapacitanceUnit from, UnitConverterCapacitanceUnit to)
        {
            return UnitConverterCapacitance.Convert(value, from, to);
        }
    }
}
