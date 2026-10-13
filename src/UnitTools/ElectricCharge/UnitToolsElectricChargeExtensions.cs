namespace UnitTools.ElectricCharge
{
    /// <summary>
    /// Extension-method API for Electric Charge conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricChargeExtensions
    {
        public static double Convert(this double value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return (float)UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricChargeUnit from, UnitToolsElectricChargeUnit to)
        {
            return UnitToolsElectricCharge.Convert(value, from, to);
        }
    }
}
