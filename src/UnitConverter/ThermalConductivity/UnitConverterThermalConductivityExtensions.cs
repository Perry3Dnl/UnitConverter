namespace UnitConverter.ThermalConductivity
{
    /// <summary>
    /// Extension-method API for Thermal Conductivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterThermalConductivityExtensions
    {
        public static double Convert(this double value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return (float)UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterThermalConductivityUnit from, UnitConverterThermalConductivityUnit to)
        {
            return UnitConverterThermalConductivity.Convert(value, from, to);
        }
    }
}
