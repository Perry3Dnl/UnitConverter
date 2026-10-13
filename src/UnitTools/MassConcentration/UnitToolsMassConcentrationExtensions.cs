namespace UnitTools.MassConcentration
{
    /// <summary>
    /// Extension-method API for Mass Concentration conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMassConcentrationExtensions
    {
        public static double Convert(this double value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return (float)UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMassConcentrationUnit from, UnitToolsMassConcentrationUnit to)
        {
            return UnitToolsMassConcentration.Convert(value, from, to);
        }
    }
}
