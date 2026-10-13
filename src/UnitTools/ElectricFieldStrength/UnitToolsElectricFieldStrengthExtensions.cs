namespace UnitTools.ElectricFieldStrength
{
    /// <summary>
    /// Extension-method API for Electric Field Strength conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricFieldStrengthExtensions
    {
        public static double Convert(this double value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return (float)UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricFieldStrengthUnit from, UnitToolsElectricFieldStrengthUnit to)
        {
            return UnitToolsElectricFieldStrength.Convert(value, from, to);
        }
    }
}
