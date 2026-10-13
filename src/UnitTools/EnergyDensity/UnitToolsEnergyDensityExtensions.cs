namespace UnitTools.EnergyDensity
{
    /// <summary>
    /// Extension-method API for Energy Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsEnergyDensityExtensions
    {
        public static double Convert(this double value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return (float)UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            return UnitToolsEnergyDensity.Convert(value, from, to);
        }
    }
}
