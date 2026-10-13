namespace UnitTools.ThermalExpansion.Metric
{
    public static class UnitToolsMetricThermalExpansion
    {
        public static double PerKelvinToPerKelvin(double value)
        {
            return value;
        }

        public static double PerCelsiusToPerKelvin(double value)
        {
            return value * 1.0d;
        }

        public static double PerKelvinToPerCelsius(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
