namespace UnitTools.LuminousEfficacy
{
    /// <summary>
    /// Extension-method API for Luminous Efficacy conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminousEfficacyExtensions
    {
        public static double Convert(this double value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return (float)UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminousEfficacyUnit from, UnitToolsLuminousEfficacyUnit to)
        {
            return UnitToolsLuminousEfficacy.Convert(value, from, to);
        }
    }
}
