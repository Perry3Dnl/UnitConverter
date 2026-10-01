namespace RealisticPhysics.UnitConversion.HeatTransferCoefficient.Metric
{
    public static class UnitConverterMetricHeatTransferCoefficient
    {
        public static double WattPerSquareMeterKelvinToWattPerSquareMeterKelvin(double value)
        {
            return value;
        }

        public static double KilowattPerSquareMeterKelvinToWattPerSquareMeterKelvin(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerSquareMeterKelvinToKilowattPerSquareMeterKelvin(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CaloriePerSecondSquareCentimeterCelsiusToWattPerSquareMeterKelvin(double value)
        {
            return value * 41868.0d;
        }

        public static double WattPerSquareMeterKelvinToCaloriePerSecondSquareCentimeterCelsius(double baseValue)
        {
            return baseValue / 41868.0d;
        }

        public static double KilocaloriePerHourSquareMeterCelsiusToWattPerSquareMeterKelvin(double value)
        {
            return value * 1.163d;
        }

        public static double WattPerSquareMeterKelvinToKilocaloriePerHourSquareMeterCelsius(double baseValue)
        {
            return baseValue / 1.163d;
        }

        public static double WattPerSquareMillimeterKelvinToWattPerSquareMeterKelvin(double value)
        {
            return value * 1000000.0d;
        }

        public static double WattPerSquareMeterKelvinToWattPerSquareMillimeterKelvin(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double MilliwattPerSquareMeterKelvinToWattPerSquareMeterKelvin(double value)
        {
            return value * 0.001d;
        }

        public static double WattPerSquareMeterKelvinToMilliwattPerSquareMeterKelvin(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double CaloriePerSecondSquareMeterCelsiusToWattPerSquareMeterKelvin(double value)
        {
            return value * 4.1840000000000002d;
        }

        public static double WattPerSquareMeterKelvinToCaloriePerSecondSquareMeterCelsius(double baseValue)
        {
            return baseValue / 4.1840000000000002d;
        }
    }
}
