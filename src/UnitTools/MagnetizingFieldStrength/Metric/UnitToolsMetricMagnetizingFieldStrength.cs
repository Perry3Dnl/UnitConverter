namespace UnitTools.MagnetizingFieldStrength.Metric
{
    public static class UnitToolsMetricMagnetizingFieldStrength
    {
        public static double AmperePerMeterToAmperePerMeter(double value)
        {
            return value;
        }

        public static double AmperePerCentimeterToAmperePerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double AmperePerMeterToAmperePerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double AmperePerMillimeterToAmperePerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double AmperePerMeterToAmperePerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double KiloamperePerMeterToAmperePerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double AmperePerMeterToKiloamperePerMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MilliamperePerMeterToAmperePerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double AmperePerMeterToMilliamperePerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
