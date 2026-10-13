namespace UnitTools.Snap.Metric
{
    public static class UnitToolsMetricSnap
    {
        public static double MeterPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value;
        }

        public static double CentimeterPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondFourthToCentimeterPerSecondFourth(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MillimeterPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.001d;
        }

        public static double MeterPerSecondFourthToMillimeterPerSecondFourth(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilometerPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 1000.0d;
        }

        public static double MeterPerSecondFourthToKilometerPerSecondFourth(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double DecimeterPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double MeterPerSecondFourthToDecimeterPerSecondFourth(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }

        public static double MicrometerPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double MeterPerSecondFourthToMicrometerPerSecondFourth(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }
    }
}
