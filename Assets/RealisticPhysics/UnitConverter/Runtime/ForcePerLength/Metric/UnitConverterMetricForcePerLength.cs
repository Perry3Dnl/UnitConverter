namespace RealisticPhysics.UnitConversion.ForcePerLength.Metric
{
    public static class UnitConverterMetricForcePerLength
    {
        public static double NewtonPerMeterToNewtonPerMeter(double value)
        {
            return value;
        }

        public static double KilonewtonPerMeterToNewtonPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerMeterToKilonewtonPerMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double NewtonPerMillimeterToNewtonPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerMeterToNewtonPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MillinewtonPerMeterToNewtonPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerMeterToMillinewtonPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double NewtonPerCentimeterToNewtonPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double NewtonPerMeterToNewtonPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double KilogramForcePerCentimeterToNewtonPerMeter(double value)
        {
            return value * 980.66499999999996d;
        }

        public static double NewtonPerMeterToKilogramForcePerCentimeter(double baseValue)
        {
            return baseValue / 980.66499999999996d;
        }
    }
}
