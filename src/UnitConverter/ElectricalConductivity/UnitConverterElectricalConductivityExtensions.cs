namespace UnitConverter.ElectricalConductivity
{
    /// <summary>
    /// Extension-method API for Electrical Conductivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterElectricalConductivityExtensions
    {
        public static double Convert(this double value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return (float)UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterElectricalConductivityUnit from, UnitConverterElectricalConductivityUnit to)
        {
            return UnitConverterElectricalConductivity.Convert(value, from, to);
        }
    }
}
