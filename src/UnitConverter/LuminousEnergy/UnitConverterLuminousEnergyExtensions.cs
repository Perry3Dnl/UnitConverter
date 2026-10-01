namespace UnitConverter.LuminousEnergy
{
    /// <summary>
    /// Extension-method API for Luminous Energy conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterLuminousEnergyExtensions
    {
        public static double Convert(this double value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return (float)UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return (decimal)UnitConverterLuminousEnergy.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterLuminousEnergyUnit from, UnitConverterLuminousEnergyUnit to)
        {
            return UnitConverterLuminousEnergy.Convert(value, from, to);
        }
    }
}
