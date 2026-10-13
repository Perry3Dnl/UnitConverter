namespace UnitTools.Energy
{
    /// <summary>
    /// Extension-method API for Energy conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsEnergyExtensions
    {
        public static double Convert(this double value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return (float)UnitToolsEnergy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            return UnitToolsEnergy.Convert(value, from, to);
        }
    }
}
