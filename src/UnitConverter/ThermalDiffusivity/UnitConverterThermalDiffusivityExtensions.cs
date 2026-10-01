namespace UnitConverter.ThermalDiffusivity
{
    /// <summary>
    /// Extension-method API for Thermal Diffusivity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterThermalDiffusivityExtensions
    {
        public static double Convert(this double value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return (float)UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return (decimal)UnitConverterThermalDiffusivity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterThermalDiffusivityUnit from, UnitConverterThermalDiffusivityUnit to)
        {
            return UnitConverterThermalDiffusivity.Convert(value, from, to);
        }
    }
}
