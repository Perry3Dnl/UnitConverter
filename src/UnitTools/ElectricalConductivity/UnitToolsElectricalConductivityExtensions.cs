namespace UnitTools.ElectricalConductivity
{
    /// <summary>
    /// Extension-method API for Electrical Conductivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsElectricalConductivityExtensions
    {
        public static double Convert(this double value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return (float)UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsElectricalConductivityUnit from, UnitToolsElectricalConductivityUnit to)
        {
            return UnitToolsElectricalConductivity.Convert(value, from, to);
        }
    }
}
