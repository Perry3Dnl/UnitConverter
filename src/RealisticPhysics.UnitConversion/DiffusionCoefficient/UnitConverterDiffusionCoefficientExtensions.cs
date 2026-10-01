namespace RealisticPhysics.UnitConversion.DiffusionCoefficient
{
    /// <summary>
    /// Extension-method API for Diffusion Coefficient conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterDiffusionCoefficientExtensions
    {
        public static double Convert(this double value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return (float)UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return (decimal)UnitConverterDiffusionCoefficient.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterDiffusionCoefficientUnit from, UnitConverterDiffusionCoefficientUnit to)
        {
            return UnitConverterDiffusionCoefficient.Convert(value, from, to);
        }
    }
}
