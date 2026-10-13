namespace UnitTools.Power.Metric
{
    public static class UnitToolsMetricPower
    {
        public static double MicrowattToWatt(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double WattToMicrowatt(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MilliwattToWatt(double value)
        {
            return value * 0.001d;
        }

        public static double WattToMilliwatt(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double WattToWatt(double value)
        {
            return value;
        }

        public static double KilowattToWatt(double value)
        {
            return value * 1000.0d;
        }

        public static double WattToKilowatt(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegawattToWatt(double value)
        {
            return value * 1000000.0d;
        }

        public static double WattToMegawatt(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double GigawattToWatt(double value)
        {
            return value * 1000000000.0d;
        }

        public static double WattToGigawatt(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double HorsepowerMetricToWatt(double value)
        {
            return value * 735.49874999999997d;
        }

        public static double WattToHorsepowerMetric(double baseValue)
        {
            return baseValue / 735.49874999999997d;
        }

        public static double PicowattToWatt(double value)
        {
            return value * 9.9999999999999998e-13d;
        }

        public static double WattToPicowatt(double baseValue)
        {
            return baseValue / 9.9999999999999998e-13d;
        }

        public static double NanowattToWatt(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double WattToNanowatt(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double TerawattToWatt(double value)
        {
            return value * 1000000000000.0d;
        }

        public static double WattToTerawatt(double baseValue)
        {
            return baseValue / 1000000000000.0d;
        }

        public static double PetawattToWatt(double value)
        {
            return value * 1000000000000000.0d;
        }

        public static double WattToPetawatt(double baseValue)
        {
            return baseValue / 1000000000000000.0d;
        }

        public static double CaloriePerSecondToWatt(double value)
        {
            return value * 4.1840000000000002d;
        }

        public static double WattToCaloriePerSecond(double baseValue)
        {
            return baseValue / 4.1840000000000002d;
        }

        public static double KilocaloriePerHourToWatt(double value)
        {
            return value * 1.1622222222222223d;
        }

        public static double WattToKilocaloriePerHour(double baseValue)
        {
            return baseValue / 1.1622222222222223d;
        }
    }
}
