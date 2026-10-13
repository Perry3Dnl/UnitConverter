namespace UnitTools.ThermalDiffusivity
{
    /// <summary>
    /// Extension-method API for Thermal Diffusivity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsThermalDiffusivityExtensions
    {
        public static double Convert(this double value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return (float)UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsThermalDiffusivityUnit from, UnitToolsThermalDiffusivityUnit to)
        {
            return UnitToolsThermalDiffusivity.Convert(value, from, to);
        }
    }
}
