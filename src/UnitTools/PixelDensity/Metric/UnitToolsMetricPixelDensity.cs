namespace UnitTools.PixelDensity.Metric
{
    public static class UnitToolsMetricPixelDensity
    {
        public static double PixelPerKilometerToPixelPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double PixelPerMeterToPixelPerKilometer(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
