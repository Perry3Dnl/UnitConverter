namespace UnitConverter.VolumetricFlowRate
{
    /// <summary>
    /// Extension-method API for Volumetric Flow Rate conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterVolumetricFlowRateExtensions
    {
        public static double Convert(this double value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return (float)UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return global::UnitConverter.UnitConverterExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            return UnitConverterVolumetricFlowRate.Convert(value, from, to);
        }
    }
}
