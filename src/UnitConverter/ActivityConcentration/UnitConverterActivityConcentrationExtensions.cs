namespace UnitConverter.ActivityConcentration
{
    /// <summary>
    /// Extension-method API for Activity Concentration conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterActivityConcentrationExtensions
    {
        public static double Convert(this double value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return (float)UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return (decimal)UnitConverterActivityConcentration.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterActivityConcentrationUnit from, UnitConverterActivityConcentrationUnit to)
        {
            return UnitConverterActivityConcentration.Convert(value, from, to);
        }
    }
}
