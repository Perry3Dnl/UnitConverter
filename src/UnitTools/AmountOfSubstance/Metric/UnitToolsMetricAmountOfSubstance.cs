namespace UnitTools.AmountOfSubstance.Metric
{
    public static class UnitToolsMetricAmountOfSubstance
    {
        public static double MoleToMole(double value)
        {
            return value;
        }

        public static double MillimoleToMole(double value)
        {
            return value * 0.001d;
        }

        public static double MoleToMillimole(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicromoleToMole(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double MoleToMicromole(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NanomoleToMole(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double MoleToNanomole(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double KilomoleToMole(double value)
        {
            return value * 1000.0d;
        }

        public static double MoleToKilomole(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CentimoleToMole(double value)
        {
            return value * 0.01d;
        }

        public static double MoleToCentimole(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double DecimoleToMole(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double MoleToDecimole(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }

        public static double PicomoleToMole(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double MoleToPicomole(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double FemtomoleToMole(double value)
        {
            return value * 1.0000000000000001e-15d;
        }

        public static double MoleToFemtomole(double baseValue)
        {
            return baseValue / 1.0000000000000001e-15d;
        }
    }
}
