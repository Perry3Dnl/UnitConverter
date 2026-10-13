namespace UnitTools.RadiationDose
{
    /// <summary>
    /// Extension-method API for Radiation Dose conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsRadiationDoseExtensions
    {
        public static double Convert(this double value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return (float)UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsRadiationDoseUnit from, UnitToolsRadiationDoseUnit to)
        {
            return UnitToolsRadiationDose.Convert(value, from, to);
        }
    }
}
