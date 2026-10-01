namespace RealisticPhysics.UnitConversion.SurfaceTension.Metric
{
    public static class UnitConverterMetricSurfaceTension
    {
        public static double NewtonPerMeterToNewtonPerMeter(double value)
        {
            return value;
        }

        public static double MillinewtonPerMeterToNewtonPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerMeterToMillinewtonPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicronewtonPerMeterToNewtonPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double NewtonPerMeterToMicronewtonPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double GramForcePerCentimeterToNewtonPerMeter(double value)
        {
            return value * 0.98066500000000001d;
        }

        public static double NewtonPerMeterToGramForcePerCentimeter(double baseValue)
        {
            return baseValue / 0.98066500000000001d;
        }

        public static double JoulePerSquareMeterToNewtonPerMeter(double value)
        {
            return value * 1.0d;
        }

        public static double NewtonPerMeterToJoulePerSquareMeter(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double MillijoulePerSquareMeterToNewtonPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonPerMeterToMillijoulePerSquareMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicrojoulePerSquareMeterToNewtonPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double NewtonPerMeterToMicrojoulePerSquareMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NewtonPerCentimeterToNewtonPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double NewtonPerMeterToNewtonPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double NewtonPerMillimeterToNewtonPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonPerMeterToNewtonPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
