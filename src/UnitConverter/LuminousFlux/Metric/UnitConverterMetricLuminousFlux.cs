namespace UnitConverter.LuminousFlux.Metric
{
    public static class UnitConverterMetricLuminousFlux
    {
        public static double LumenToLumen(double value)
        {
            return value;
        }

        public static double MillilumenToLumen(double value)
        {
            return value * 0.001d;
        }

        public static double LumenToMillilumen(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilolumenToLumen(double value)
        {
            return value * 1000.0d;
        }

        public static double LumenToKilolumen(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegalumenToLumen(double value)
        {
            return value * 1000000.0d;
        }

        public static double LumenToMegalumen(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double CandelaSteradianToLumen(double value)
        {
            return value * 1.0d;
        }

        public static double LumenToCandelaSteradian(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double MicrolumenToLumen(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double LumenToMicrolumen(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double NanolumenToLumen(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double LumenToNanolumen(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double GigalumenToLumen(double value)
        {
            return value * 1000000000.0d;
        }

        public static double LumenToGigalumen(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }
    }
}
