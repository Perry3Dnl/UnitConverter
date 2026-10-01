namespace RealisticPhysics.UnitConversion.AmountOfSubstance
{
    /// <summary>
    /// Extension-method API for Amount Of Substance conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterAmountOfSubstanceExtensions
    {
        public static double Convert(this double value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return (float)UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return (decimal)UnitConverterAmountOfSubstance.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterAmountOfSubstanceUnit from, UnitConverterAmountOfSubstanceUnit to)
        {
            return UnitConverterAmountOfSubstance.Convert(value, from, to);
        }
    }
}
