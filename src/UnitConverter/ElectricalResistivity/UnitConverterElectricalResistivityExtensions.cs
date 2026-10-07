namespace UnitConverter.ElectricalResistivity
{
    /// <summary>
    /// Extension-method API for Electrical Resistivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricalResistivityExtensions
    {
        public static double Convert(this double value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return (float)UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricalResistivityUnit from, UnitConverterElectricalResistivityUnit to)
        {
            return UnitConverterElectricalResistivity.Convert(value, from, to);
        }
    }
}
