namespace UnitConverter.LuminousEfficacy.Metric
{
    public static class UnitConverterMetricLuminousEfficacy
    {
        public static double LumenPerWattToLumenPerWatt(double value)
        {
            return value;
        }

        public static double LumenPerKilowattToLumenPerWatt(double value)
        {
            return value * 0.001d;
        }

        public static double LumenPerWattToLumenPerKilowatt(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilolumenPerWattToLumenPerWatt(double value)
        {
            return value * 1000.0d;
        }

        public static double LumenPerWattToKilolumenPerWatt(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CandelaSteradianPerWattToLumenPerWatt(double value)
        {
            return value * 1.0d;
        }

        public static double LumenPerWattToCandelaSteradianPerWatt(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double LumenPerMilliwattToLumenPerWatt(double value)
        {
            return value * 1000.0d;
        }

        public static double LumenPerWattToLumenPerMilliwatt(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double LumenPerMegawattToLumenPerWatt(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double LumenPerWattToLumenPerMegawatt(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double KilolumenPerKilowattToLumenPerWatt(double value)
        {
            return value * 1.0d;
        }

        public static double LumenPerWattToKilolumenPerKilowatt(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double CandelaSteradianPerKilowattToLumenPerWatt(double value)
        {
            return value * 0.001d;
        }

        public static double LumenPerWattToCandelaSteradianPerKilowatt(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double LumenPerMicrowattToLumenPerWatt(double value)
        {
            return value * 1000000.0d;
        }

        public static double LumenPerWattToLumenPerMicrowatt(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double LumenPerNanowattToLumenPerWatt(double value)
        {
            return value * 1000000000.0d;
        }

        public static double LumenPerWattToLumenPerNanowatt(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double MegalumenPerWattToLumenPerWatt(double value)
        {
            return value * 1000000.0d;
        }

        public static double LumenPerWattToMegalumenPerWatt(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
