namespace UnitConverter.MolarMass
{
    /// <summary>
    /// Extension-method API for Molar Mass conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMolarMassExtensions
    {
        public static double Convert(this double value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return (float)UnitConverterMolarMass.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMolarMassUnit from, UnitConverterMolarMassUnit to)
        {
            return UnitConverterMolarMass.Convert(value, from, to);
        }
    }
}
