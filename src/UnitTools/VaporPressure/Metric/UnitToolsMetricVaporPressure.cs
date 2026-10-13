namespace UnitTools.VaporPressure.Metric
{
    public static class UnitToolsMetricVaporPressure
    {
        public static double PascalToPascal(double value)
        {
            return value;
        }

        public static double KilopascalToPascal(double value)
        {
            return value * 1000.0d;
        }

        public static double PascalToKilopascal(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegapascalToPascal(double value)
        {
            return value * 1000000.0d;
        }

        public static double PascalToMegapascal(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double BarToPascal(double value)
        {
            return value * 100000.0d;
        }

        public static double PascalToBar(double baseValue)
        {
            return baseValue / 100000.0d;
        }

        public static double MillibarToPascal(double value)
        {
            return value * 100.0d;
        }

        public static double PascalToMillibar(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double AtmosphereToPascal(double value)
        {
            return value * 101325.0d;
        }

        public static double PascalToAtmosphere(double baseValue)
        {
            return baseValue / 101325.0d;
        }

        public static double TorrToPascal(double value)
        {
            return value * 133.32236842105263d;
        }

        public static double PascalToTorr(double baseValue)
        {
            return baseValue / 133.32236842105263d;
        }

        public static double HectopascalToPascal(double value)
        {
            return value * 100.0d;
        }

        public static double PascalToHectopascal(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double MicropascalToPascal(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PascalToMicropascal(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MillipascalToPascal(double value)
        {
            return value * 0.001d;
        }

        public static double PascalToMillipascal(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
