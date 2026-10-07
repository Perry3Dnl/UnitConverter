namespace UnitConverter.MolarConcentration
{
    /// <summary>
    /// Extension-method API for Molar Concentration conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMolarConcentrationExtensions
    {
        public static double Convert(this double value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return (float)UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMolarConcentrationUnit from, UnitConverterMolarConcentrationUnit to)
        {
            return UnitConverterMolarConcentration.Convert(value, from, to);
        }
    }
}
