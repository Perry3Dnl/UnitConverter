namespace UnitTools.Mass.Astronomical
{
    public static class UnitToolsAstronomicalMass
    {
        public static double EarthMassToKilogram(double value)
        {
            return value * 5.9722000000000002e+24d;
        }

        public static double KilogramToEarthMass(double baseValue)
        {
            return baseValue / 5.9722000000000002e+24d;
        }

        public static double JupiterMassToKilogram(double value)
        {
            return value * 1.89813e+27d;
        }

        public static double KilogramToJupiterMass(double baseValue)
        {
            return baseValue / 1.89813e+27d;
        }

        public static double SolarMassToKilogram(double value)
        {
            return value * 1.98847e+30d;
        }

        public static double KilogramToSolarMass(double baseValue)
        {
            return baseValue / 1.98847e+30d;
        }
    }
}
