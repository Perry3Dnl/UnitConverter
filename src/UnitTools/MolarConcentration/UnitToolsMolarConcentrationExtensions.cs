namespace UnitTools.MolarConcentration
{
    /// <summary>
    /// Extension-method API for Molar Concentration conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMolarConcentrationExtensions
    {
        public static double Convert(this double value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return (float)UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMolarConcentrationUnit from, UnitToolsMolarConcentrationUnit to)
        {
            return UnitToolsMolarConcentration.Convert(value, from, to);
        }
    }
}
