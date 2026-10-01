namespace RealisticPhysics.UnitConversion.PowerDensity.Metric
{
    public static class UnitConverterMetricPowerDensity
    {
        public static double WattPerCubicMeterToWattPerCubicMeter(double value)
        {
            return value;
        }

        public static double KilowattPerCubicMeterToWattPerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerCubicMeterToKilowattPerCubicMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegawattPerCubicMeterToWattPerCubicMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double WattPerCubicMeterToMegawattPerCubicMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double WattPerLiterToWattPerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double WattPerCubicMeterToWattPerLiter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MilliwattPerCubicMeterToWattPerCubicMeter(double value)
        {
            return value * 0.001d;
        }

        public static double WattPerCubicMeterToMilliwattPerCubicMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double WattPerCubicCentimeterToWattPerCubicMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double WattPerCubicMeterToWattPerCubicCentimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double WattPerCubicMillimeterToWattPerCubicMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double WattPerCubicMeterToWattPerCubicMillimeter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }
    }
}
