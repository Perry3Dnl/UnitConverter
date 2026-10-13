namespace UnitTools.SpecificWeight.Metric
{
    public static class UnitToolsMetricSpecificWeight
    {
        public static double NewtonPerCubicMeterToNewtonPerCubicMeter(double value)
        {
            return value;
        }

        public static double KilonewtonPerCubicMeterToNewtonPerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerCubicMeterToKilonewtonPerCubicMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double NewtonPerLiterToNewtonPerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerCubicMeterToNewtonPerLiter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double KilogramForcePerCubicMeterToNewtonPerCubicMeter(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonPerCubicMeterToKilogramForcePerCubicMeter(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double MillinewtonPerCubicMeterToNewtonPerCubicMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerCubicMeterToMillinewtonPerCubicMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double NewtonPerCubicCentimeterToNewtonPerCubicMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double NewtonPerCubicMeterToNewtonPerCubicCentimeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double NewtonPerCubicMillimeterToNewtonPerCubicMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double NewtonPerCubicMeterToNewtonPerCubicMillimeter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }
    }
}
