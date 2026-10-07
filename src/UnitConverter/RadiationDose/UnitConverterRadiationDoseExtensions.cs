namespace UnitConverter.RadiationDose
{
    /// <summary>
    /// Extension-method API for Radiation Dose conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterRadiationDoseExtensions
    {
        public static double Convert(this double value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return (float)UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterRadiationDoseUnit from, UnitConverterRadiationDoseUnit to)
        {
            return UnitConverterRadiationDose.Convert(value, from, to);
        }
    }
}
