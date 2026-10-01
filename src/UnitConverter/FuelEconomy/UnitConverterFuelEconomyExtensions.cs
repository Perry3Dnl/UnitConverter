namespace UnitConverter.FuelEconomy
{
    /// <summary>
    /// Extension-method API for Fuel Economy conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterFuelEconomyExtensions
    {
        public static double Convert(this double value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return (float)UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return (decimal)UnitConverterFuelEconomy.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            return UnitConverterFuelEconomy.Convert(value, from, to);
        }
    }
}
