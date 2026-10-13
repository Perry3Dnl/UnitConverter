namespace UnitTools.FuelEconomy
{
    /// <summary>
    /// Extension-method API for Fuel Economy conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsFuelEconomyExtensions
    {
        public static double Convert(this double value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return (float)UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            return UnitToolsFuelEconomy.Convert(value, from, to);
        }
    }
}
