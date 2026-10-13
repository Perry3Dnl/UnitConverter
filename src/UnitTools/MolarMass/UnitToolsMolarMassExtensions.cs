namespace UnitTools.MolarMass
{
    /// <summary>
    /// Extension-method API for Molar Mass conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsMolarMassExtensions
    {
        public static double Convert(this double value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return (float)UnitToolsMolarMass.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsMolarMassUnit from, UnitToolsMolarMassUnit to)
        {
            return UnitToolsMolarMass.Convert(value, from, to);
        }
    }
}
