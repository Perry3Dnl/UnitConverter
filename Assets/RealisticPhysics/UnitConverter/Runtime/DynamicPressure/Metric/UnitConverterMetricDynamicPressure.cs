namespace RealisticPhysics.UnitConversion.DynamicPressure.Metric
{
    public static class UnitConverterMetricDynamicPressure
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

        public static double AtmosphereToPascal(double value)
        {
            return value * 101325.0d;
        }

        public static double PascalToAtmosphere(double baseValue)
        {
            return baseValue / 101325.0d;
        }

        public static double HectopascalToPascal(double value)
        {
            return value * 100.0d;
        }

        public static double PascalToHectopascal(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double MillibarToPascal(double value)
        {
            return value * 100.0d;
        }

        public static double PascalToMillibar(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double TorrToPascal(double value)
        {
            return value * 133.32236842105263d;
        }

        public static double PascalToTorr(double baseValue)
        {
            return baseValue / 133.32236842105263d;
        }

        public static double MillimeterMercuryToPascal(double value)
        {
            return value * 133.32238741500001d;
        }

        public static double PascalToMillimeterMercury(double baseValue)
        {
            return baseValue / 133.32238741500001d;
        }
    }
}
