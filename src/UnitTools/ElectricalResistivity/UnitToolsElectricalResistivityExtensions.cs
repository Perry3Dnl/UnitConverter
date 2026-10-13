namespace UnitTools.ElectricalResistivity
{
    /// <summary>
    /// Extension-method API for Electrical Resistivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricalResistivityExtensions
    {
        public static double Convert(this double value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return (float)UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricalResistivityUnit from, UnitToolsElectricalResistivityUnit to)
        {
            return UnitToolsElectricalResistivity.Convert(value, from, to);
        }
    }
}
