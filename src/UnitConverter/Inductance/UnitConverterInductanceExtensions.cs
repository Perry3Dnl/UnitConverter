namespace UnitConverter.Inductance
{
    /// <summary>
    /// Extension-method API for Inductance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterInductanceExtensions
    {
        public static double Convert(this double value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return (float)UnitConverterInductance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterInductanceUnit from, UnitConverterInductanceUnit to)
        {
            return UnitConverterInductance.Convert(value, from, to);
        }
    }
}
