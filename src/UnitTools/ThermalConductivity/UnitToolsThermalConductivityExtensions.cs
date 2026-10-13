namespace UnitTools.ThermalConductivity
{
    /// <summary>
    /// Extension-method API for Thermal Conductivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsThermalConductivityExtensions
    {
        public static double Convert(this double value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return (float)UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsThermalConductivityUnit from, UnitToolsThermalConductivityUnit to)
        {
            return UnitToolsThermalConductivity.Convert(value, from, to);
        }
    }
}
