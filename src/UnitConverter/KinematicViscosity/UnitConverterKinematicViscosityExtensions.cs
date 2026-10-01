namespace UnitConverter.KinematicViscosity
{
    /// <summary>
    /// Extension-method API for Kinematic Viscosity conversions.
    /// These methods route through the matching static UnitConverter class.
    /// Integral overloads return double to avoid losing fractional conversion results.
    /// </summary>
    public static class UnitConverterKinematicViscosityExtensions
    {
        public static double Convert(this double value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static float Convert(this float value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return (float)UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static decimal Convert(this decimal value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return (decimal)UnitConverterKinematicViscosity.Convert((double)value, from, to);
        }

        public static double Convert(this byte value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this sbyte value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this short value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ushort value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this int value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this uint value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this long value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }

        public static double Convert(this ulong value, UnitConverterKinematicViscosityUnit from, UnitConverterKinematicViscosityUnit to)
        {
            return UnitConverterKinematicViscosity.Convert(value, from, to);
        }
    }
}
