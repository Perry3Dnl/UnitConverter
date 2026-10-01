namespace UnitConverter.MassConcentration
{
    /// <summary>
    /// Extension-method API for Mass Concentration conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterMassConcentrationExtensions
    {
        public static double Convert(this double value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return (float)UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return (decimal)UnitConverterMassConcentration.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterMassConcentrationUnit from, UnitConverterMassConcentrationUnit to)
        {
            return UnitConverterMassConcentration.Convert(value, from, to);
        }
    }
}
