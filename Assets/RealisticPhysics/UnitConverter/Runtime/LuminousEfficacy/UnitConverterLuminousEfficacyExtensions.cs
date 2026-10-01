namespace RealisticPhysics.UnitConversion.LuminousEfficacy
{
    /// <summary>
    /// Extension-method API for Luminous Efficacy conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminousEfficacyExtensions
    {
        public static double Convert(this double value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return (float)UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return (decimal)UnitConverterLuminousEfficacy.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminousEfficacyUnit from, UnitConverterLuminousEfficacyUnit to)
        {
            return UnitConverterLuminousEfficacy.Convert(value, from, to);
        }
    }
}
