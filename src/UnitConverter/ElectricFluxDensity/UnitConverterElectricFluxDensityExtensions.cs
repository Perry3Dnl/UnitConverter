namespace UnitConverter.ElectricFluxDensity
{
    /// <summary>
    /// Extension-method API for Electric Flux Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricFluxDensityExtensions
    {
        public static double Convert(this double value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return (float)UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return (decimal)UnitConverterElectricFluxDensity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricFluxDensityUnit from, UnitConverterElectricFluxDensityUnit to)
        {
            return UnitConverterElectricFluxDensity.Convert(value, from, to);
        }
    }
}
