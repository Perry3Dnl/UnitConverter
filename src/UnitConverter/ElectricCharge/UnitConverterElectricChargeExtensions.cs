namespace UnitConverter.ElectricCharge
{
    /// <summary>
    /// Extension-method API for Electric Charge conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricChargeExtensions
    {
        public static double Convert(this double value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return (float)UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricChargeUnit from, UnitConverterElectricChargeUnit to)
        {
            return UnitConverterElectricCharge.Convert(value, from, to);
        }
    }
}
