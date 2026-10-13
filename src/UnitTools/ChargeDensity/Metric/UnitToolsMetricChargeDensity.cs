namespace UnitTools.ChargeDensity.Metric
{
    public static class UnitToolsMetricChargeDensity
    {
        public static double CoulombPerCubicMeterToCoulombPerCubicMeter(double value)
        {
            return value;
        }

        public static double MillicoulombPerCubicMeterToCoulombPerCubicMeter(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerCubicMeterToMillicoulombPerCubicMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrocoulombPerCubicMeterToCoulombPerCubicMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombPerCubicMeterToMicrocoulombPerCubicMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double CoulombPerLiterToCoulombPerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double CoulombPerCubicMeterToCoulombPerLiter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CoulombPerCubicCentimeterToCoulombPerCubicMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double CoulombPerCubicMeterToCoulombPerCubicCentimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double NanocoulombPerCubicMeterToCoulombPerCubicMeter(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double CoulombPerCubicMeterToNanocoulombPerCubicMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double CoulombPerCubicMillimeterToCoulombPerCubicMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double CoulombPerCubicMeterToCoulombPerCubicMillimeter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double MicrocoulombPerLiterToCoulombPerCubicMeter(double value)
        {
            return value * 0.001d;
        }

        public static double CoulombPerCubicMeterToMicrocoulombPerLiter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double NanocoulombPerLiterToCoulombPerCubicMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double CoulombPerCubicMeterToNanocoulombPerLiter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }
    }
}
