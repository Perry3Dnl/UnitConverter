namespace RealisticPhysics.UnitConversion.MagneticPermeability.Scientific
{
    public static class UnitConverterScientificMagneticPermeability
    {
        public static double VacuumPermeabilityToHenryPerMeter(double value)
        {
            return value * 1.2566370621199999e-06d;
        }

        public static double HenryPerMeterToVacuumPermeability(double baseValue)
        {
            return baseValue / 1.2566370621199999e-06d;
        }

        public static double RelativePermeabilityToHenryPerMeter(double value)
        {
            return value * 1.2566370621199999e-06d;
        }

        public static double HenryPerMeterToRelativePermeability(double baseValue)
        {
            return baseValue / 1.2566370621199999e-06d;
        }

        public static double GaussPerOerstedToHenryPerMeter(double value)
        {
            return value * 1.2566370621199999e-06d;
        }

        public static double HenryPerMeterToGaussPerOersted(double baseValue)
        {
            return baseValue / 1.2566370621199999e-06d;
        }
    }
}
