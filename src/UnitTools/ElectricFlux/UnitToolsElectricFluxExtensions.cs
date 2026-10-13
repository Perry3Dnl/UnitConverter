namespace UnitTools.ElectricFlux
{
    /// <summary>
    /// Extension-method API for Electric Flux conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricFluxExtensions
    {
        public static double Convert(this double value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return (float)UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricFluxUnit from, UnitToolsElectricFluxUnit to)
        {
            return UnitToolsElectricFlux.Convert(value, from, to);
        }
    }
}
