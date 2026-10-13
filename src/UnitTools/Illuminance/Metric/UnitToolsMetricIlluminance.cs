namespace UnitTools.Illuminance.Metric
{
    public static class UnitToolsMetricIlluminance
    {
        public static double NoxToLux(double value)
        {
            return value * 0.001d;
        }

        public static double LuxToNox(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double LuxToLux(double value)
        {
            return value;
        }

        public static double KiloluxToLux(double value)
        {
            return value * 1000.0d;
        }

        public static double LuxToKilolux(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double PhotToLux(double value)
        {
            return value * 10000.0d;
        }

        public static double LuxToPhot(double baseValue)
        {
            return baseValue / 10000.0d;
        }

        public static double MicroluxToLux(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double LuxToMicrolux(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliluxToLux(double value)
        {
            return value * 0.001d;
        }

        public static double LuxToMillilux(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MegaluxToLux(double value)
        {
            return value * 1000000.0d;
        }

        public static double LuxToMegalux(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double LumenPerSquareMeterToLux(double value)
        {
            return value * 1.0d;
        }

        public static double LuxToLumenPerSquareMeter(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
