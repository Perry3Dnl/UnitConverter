namespace UnitTools.KinematicViscosity
{
    /// <summary>
    /// Extension-method API for Kinematic Viscosity conversions.
    /// These methods route through the matching static UnitTools class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitToolsKinematicViscosityExtensions
    {
        public static double Convert(this double value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return (float)UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return global::UnitTools.UnitToolsExact.Convert(value, from, to);
        }

        public static double Convert(this byte value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitToolsKinematicViscosityUnit from, UnitToolsKinematicViscosityUnit to)
        {
            return UnitToolsKinematicViscosity.Convert(value, from, to);
        }
    }
}
