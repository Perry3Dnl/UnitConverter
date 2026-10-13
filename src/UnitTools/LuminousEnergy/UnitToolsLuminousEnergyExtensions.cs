namespace UnitTools.LuminousEnergy
{
    /// <summary>
    /// Extension-method API for Luminous Energy conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsLuminousEnergyExtensions
    {
        public static double Convert(this double value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return (float)UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsLuminousEnergyUnit from, UnitToolsLuminousEnergyUnit to)
        {
            return UnitToolsLuminousEnergy.Convert(value, from, to);
        }
    }
}
