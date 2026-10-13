namespace UnitTools.AmountOfSubstance
{
    /// <summary>
    /// Extension-method API for Amount Of Substance conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsAmountOfSubstanceExtensions
    {
        public static double Convert(this double value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return (float)UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsAmountOfSubstanceUnit from, UnitToolsAmountOfSubstanceUnit to)
        {
            return UnitToolsAmountOfSubstance.Convert(value, from, to);
        }
    }
}
