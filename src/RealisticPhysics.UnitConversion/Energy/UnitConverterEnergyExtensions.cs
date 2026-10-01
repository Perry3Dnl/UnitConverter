namespace RealisticPhysics.UnitConversion.Energy
{
    /// <summary>
    /// Extension-method API for Energy conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterEnergyExtensions
    {
        public static double Convert(this double value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return (float)UnitConverterEnergy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return (decimal)UnitConverterEnergy.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            return UnitConverterEnergy.Convert(value, from, to);
        }
    }
}
