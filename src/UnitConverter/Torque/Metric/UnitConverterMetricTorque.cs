namespace UnitConverter.Torque.Metric
{
    public static class UnitConverterMetricTorque
    {
        public static double NewtonMeterToNewtonMeter(double value)
        {
            return value;
        }

        public static double KilonewtonMeterToNewtonMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double NewtonMeterToKilonewtonMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MillinewtonMeterToNewtonMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonMeterToMillinewtonMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MicronewtonMeterToNewtonMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double NewtonMeterToMicronewtonMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MeganewtonMeterToNewtonMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double NewtonMeterToMeganewtonMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double NewtonCentimeterToNewtonMeter(double value)
        {
            return value * 0.01d;
        }

        public static double NewtonMeterToNewtonCentimeter(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double NewtonMillimeterToNewtonMeter(double value)
        {
            return value * 0.001d;
        }

        public static double NewtonMeterToNewtonMillimeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramForceMeterToNewtonMeter(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double NewtonMeterToKilogramForceMeter(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double KilogramForceCentimeterToNewtonMeter(double value)
        {
            return value * 0.098066500000000001d;
        }

        public static double NewtonMeterToKilogramForceCentimeter(double baseValue)
        {
            return baseValue / 0.098066500000000001d;
        }

        public static double GramForceCentimeterToNewtonMeter(double value)
        {
            return value * 9.80665e-05d;
        }

        public static double NewtonMeterToGramForceCentimeter(double baseValue)
        {
            return baseValue / 9.80665e-05d;
        }
    }
}
