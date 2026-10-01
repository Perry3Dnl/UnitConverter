namespace RealisticPhysics.UnitConversion.DiffusionCoefficient.Imperial
{
    public static class UnitConverterImperialDiffusionCoefficient
    {
        public static double SquareFootPerSecondToSquareMeterPerSecond(double value)
        {
            return value * 0.092903040000000006d;
        }

        public static double SquareMeterPerSecondToSquareFootPerSecond(double baseValue)
        {
            return baseValue / 0.092903040000000006d;
        }

        public static double SquareInchPerSecondToSquareMeterPerSecond(double value)
        {
            return value * 0.00064515999999999998d;
        }

        public static double SquareMeterPerSecondToSquareInchPerSecond(double baseValue)
        {
            return baseValue / 0.00064515999999999998d;
        }

        public static double SquareFootPerMinuteToSquareMeterPerSecond(double value)
        {
            return value * 0.0015483840000000001d;
        }

        public static double SquareMeterPerSecondToSquareFootPerMinute(double baseValue)
        {
            return baseValue / 0.0015483840000000001d;
        }

        public static double SquareInchPerMinuteToSquareMeterPerSecond(double value)
        {
            return value * 1.0752666666666666e-05d;
        }

        public static double SquareMeterPerSecondToSquareInchPerMinute(double baseValue)
        {
            return baseValue / 1.0752666666666666e-05d;
        }
    }
}
