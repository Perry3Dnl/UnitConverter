namespace UnitTools.DiffusionCoefficient
{
    /// <summary>
    /// Extension-method API for Diffusion Coefficient conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsDiffusionCoefficientExtensions
    {
        public static double Convert(this double value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return (float)UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsDiffusionCoefficientUnit from, UnitToolsDiffusionCoefficientUnit to)
        {
            return UnitToolsDiffusionCoefficient.Convert(value, from, to);
        }
    }
}
