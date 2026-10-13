namespace UnitTools.ElectricFluxDensity
{
    /// <summary>
    /// Extension-method API for Electric Flux Density conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricFluxDensityExtensions
    {
        public static double Convert(this double value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return (float)UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricFluxDensityUnit from, UnitToolsElectricFluxDensityUnit to)
        {
            return UnitToolsElectricFluxDensity.Convert(value, from, to);
        }
    }
}
