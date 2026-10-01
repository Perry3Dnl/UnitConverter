namespace RealisticPhysics.UnitConversion.Compressibility.Metric
{
    public static class UnitConverterMetricCompressibility
    {
        public static double PerPascalToPerPascal(double value)
        {
            return value;
        }

        public static double PerKilopascalToPerPascal(double value)
        {
            return value * 0.001d;
        }

        public static double PerPascalToPerKilopascal(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double PerMegapascalToPerPascal(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PerPascalToPerMegapascal(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double PerBarToPerPascal(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double PerPascalToPerBar(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }

        public static double PerAtmosphereToPerPascal(double value)
        {
            return value * 9.8692326671601285e-06d;
        }

        public static double PerPascalToPerAtmosphere(double baseValue)
        {
            return baseValue / 9.8692326671601285e-06d;
        }

        public static double PerMillibarToPerPascal(double value)
        {
            return value * 0.01d;
        }

        public static double PerPascalToPerMillibar(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double PerHectopascalToPerPascal(double value)
        {
            return value * 0.01d;
        }

        public static double PerPascalToPerHectopascal(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double PerGigapascalToPerPascal(double value)
        {
            return value * 1.0000000000000001e-09d;
        }

        public static double PerPascalToPerGigapascal(double baseValue)
        {
            return baseValue / 1.0000000000000001e-09d;
        }

        public static double PerTorrToPerPascal(double value)
        {
            return value * 0.0075006168270416972d;
        }

        public static double PerPascalToPerTorr(double baseValue)
        {
            return baseValue / 0.0075006168270416972d;
        }

        public static double PerMillimeterMercuryToPerPascal(double value)
        {
            return value * 0.0075006157584565627d;
        }

        public static double PerPascalToPerMillimeterMercury(double baseValue)
        {
            return baseValue / 0.0075006157584565627d;
        }
    }
}
