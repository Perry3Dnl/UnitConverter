namespace UnitConverter.HeatTransferCoefficient.Imperial
{
    public static class UnitConverterImperialHeatTransferCoefficient
    {
        public static double BtuPerHourSquareFootFahrenheitToWattPerSquareMeterKelvin(double value)
        {
            return value * 5.6782633369999997d;
        }

        public static double WattPerSquareMeterKelvinToBtuPerHourSquareFootFahrenheit(double baseValue)
        {
            return baseValue / 5.6782633369999997d;
        }

        public static double BtuPerSecondSquareFootFahrenheitToWattPerSquareMeterKelvin(double value)
        {
            return value * 20441.748028008555d;
        }

        public static double WattPerSquareMeterKelvinToBtuPerSecondSquareFootFahrenheit(double baseValue)
        {
            return baseValue / 20441.748028008555d;
        }

        public static double BtuPerMinuteSquareFootFahrenheitToWattPerSquareMeterKelvin(double value)
        {
            return value * 340.6958004668092d;
        }

        public static double WattPerSquareMeterKelvinToBtuPerMinuteSquareFootFahrenheit(double baseValue)
        {
            return baseValue / 340.6958004668092d;
        }
    }
}
