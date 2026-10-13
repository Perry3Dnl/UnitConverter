namespace UnitTools.HydraulicPermeability
{
    /// <summary>
    /// Extension-method API for Hydraulic Permeability conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsHydraulicPermeabilityExtensions
    {
        public static double Convert(this double value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return (float)UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsHydraulicPermeabilityUnit from, UnitToolsHydraulicPermeabilityUnit to)
        {
            return UnitToolsHydraulicPermeability.Convert(value, from, to);
        }
    }
}
