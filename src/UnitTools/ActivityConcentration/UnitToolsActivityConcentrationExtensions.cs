namespace UnitTools.ActivityConcentration
{
    /// <summary>
    /// Extension-method API for Activity Concentration conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsActivityConcentrationExtensions
    {
        public static double Convert(this double value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return (float)UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsActivityConcentrationUnit from, UnitToolsActivityConcentrationUnit to)
        {
            return UnitToolsActivityConcentration.Convert(value, from, to);
        }
    }
}
