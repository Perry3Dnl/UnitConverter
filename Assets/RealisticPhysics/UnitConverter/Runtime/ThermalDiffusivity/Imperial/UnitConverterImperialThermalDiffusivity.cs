namespace RealisticPhysics.UnitConversion.ThermalDiffusivity.Imperial
{
    public static class UnitConverterImperialThermalDiffusivity
    {
        public static double SquareFootPerSecondToSquareMeterPerSecond(double value)
        {
            return value * 0.092903040000000006d;
        }

        public static double SquareMeterPerSecondToSquareFootPerSecond(double baseValue)
        {
            return baseValue / 0.092903040000000006d;
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
