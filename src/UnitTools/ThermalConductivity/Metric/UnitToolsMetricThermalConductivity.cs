namespace UnitTools.ThermalConductivity.Metric
{
    public static class UnitToolsMetricThermalConductivity
    {
        public static double WattPerMeterKelvinToWattPerMeterKelvin(double value)
        {
            return value;
        }

        public static double MilliwattPerMeterKelvinToWattPerMeterKelvin(double value)
        {
            return value * 0.001d;
        }

        public static double WattPerMeterKelvinToMilliwattPerMeterKelvin(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilowattPerMeterKelvinToWattPerMeterKelvin(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerMeterKelvinToKilowattPerMeterKelvin(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CaloriePerSecondCentimeterCelsiusToWattPerMeterKelvin(double value)
        {
            return value * 418.39999999999998d;
        }

        public static double WattPerMeterKelvinToCaloriePerSecondCentimeterCelsius(double baseValue)
        {
            return baseValue / 418.39999999999998d;
        }

        public static double WattPerMillimeterKelvinToWattPerMeterKelvin(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerMeterKelvinToWattPerMillimeterKelvin(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CaloriePerSecondMeterCelsiusToWattPerMeterKelvin(double value)
        {
            return value * 4.1840000000000002d;
        }

        public static double WattPerMeterKelvinToCaloriePerSecondMeterCelsius(double baseValue)
        {
            return baseValue / 4.1840000000000002d;
        }

        public static double KilocaloriePerSecondMeterCelsiusToWattPerMeterKelvin(double value)
        {
            return value * 4184.0d;
        }

        public static double WattPerMeterKelvinToKilocaloriePerSecondMeterCelsius(double baseValue)
        {
            return baseValue / 4184.0d;
        }
    }
}
