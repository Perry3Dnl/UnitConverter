namespace RealisticPhysics.UnitConversion.Mass.Troy
{
    public static class UnitConverterTroyMass
    {
        public static double GrainToKilogram(double value)
        {
            return value * 6.4798909999999995e-05d;
        }

        public static double KilogramToGrain(double baseValue)
        {
            return baseValue / 6.4798909999999995e-05d;
        }

        public static double PennyweightToKilogram(double value)
        {
            return value * 0.0015551738400000001d;
        }

        public static double KilogramToPennyweight(double baseValue)
        {
            return baseValue / 0.0015551738400000001d;
        }

        public static double TroyOunceToKilogram(double value)
        {
            return value * 0.031103476800000002d;
        }

        public static double KilogramToTroyOunce(double baseValue)
        {
            return baseValue / 0.031103476800000002d;
        }

        public static double TroyPoundToKilogram(double value)
        {
            return value * 0.37324172160000002d;
        }

        public static double KilogramToTroyPound(double baseValue)
        {
            return baseValue / 0.37324172160000002d;
        }
    }
}
