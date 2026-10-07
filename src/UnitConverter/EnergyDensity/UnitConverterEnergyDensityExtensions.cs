namespace UnitConverter.EnergyDensity
{
    /// <summary>
    /// Extension-method API for Energy Density conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterEnergyDensityExtensions
    {
        public static double Convert(this double value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return (float)UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            return UnitConverterEnergyDensity.Convert(value, from, to);
        }
    }
}
