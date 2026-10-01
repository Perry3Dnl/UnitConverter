namespace RealisticPhysics.UnitConversion.MomentOfInertia.Imperial
{
    public static class UnitConverterImperialMomentOfInertia
    {
        public static double PoundSquareFootToKilogramSquareMeter(double value)
        {
            return value * 0.042140110093804806d;
        }

        public static double KilogramSquareMeterToPoundSquareFoot(double baseValue)
        {
            return baseValue / 0.042140110093804806d;
        }

        public static double SlugSquareFootToKilogramSquareMeter(double value)
        {
            return value * 1.3558179485909376d;
        }

        public static double KilogramSquareMeterToSlugSquareFoot(double baseValue)
        {
            return baseValue / 1.3558179485909376d;
        }

        public static double PoundSquareInchToKilogramSquareMeter(double value)
        {
            return value * 0.00029263965342919999d;
        }

        public static double KilogramSquareMeterToPoundSquareInch(double baseValue)
        {
            return baseValue / 0.00029263965342919999d;
        }

        public static double SlugSquareInchToKilogramSquareMeter(double value)
        {
            return value * 0.0094154024207703992d;
        }

        public static double KilogramSquareMeterToSlugSquareInch(double baseValue)
        {
            return baseValue / 0.0094154024207703992d;
        }
    }
}
