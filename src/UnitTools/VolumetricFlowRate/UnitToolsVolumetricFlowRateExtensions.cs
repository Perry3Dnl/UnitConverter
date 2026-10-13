namespace UnitTools.VolumetricFlowRate
{
    /// <summary>
    /// Extension-method API for Volumetric Flow Rate conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsVolumetricFlowRateExtensions
    {
        public static double Convert(this double value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return (float)UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            return UnitToolsVolumetricFlowRate.Convert(value, from, to);
        }
    }
}
