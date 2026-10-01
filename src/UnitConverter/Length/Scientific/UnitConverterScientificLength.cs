namespace UnitConverter.Length.Scientific
{
    public static class UnitConverterScientificLength
    {
        public static double AngstromToMeter(double value)
        {
            return value * 1e-10d;
        }

        public static double MeterToAngstrom(double baseValue)
        {
            return baseValue / 1e-10d;
        }

        public static double FermiToMeter(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double MeterToFermi(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }

        public static double BohrRadiusToMeter(double value)
        {
            return value * 5.2917721090299998e-11d;
        }

        public static double MeterToBohrRadius(double baseValue)
        {
            return baseValue / 5.2917721090299998e-11d;
        }

        public static double PlanckLengthToMeter(double value)
        {
            return value * 1.6162550000000001e-35d;
        }

        public static double MeterToPlanckLength(double baseValue)
        {
            return baseValue / 1.6162550000000001e-35d;
        }

        public static double ClassicalElectronRadiusToMeter(double value)
        {
            return value * 2.8179403262e-15d;
        }

        public static double MeterToClassicalElectronRadius(double baseValue)
        {
            return baseValue / 2.8179403262e-15d;
        }
    }
}
