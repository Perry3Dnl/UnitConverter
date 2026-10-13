namespace UnitTools.Pressure.Scientific
{
    public static class UnitToolsScientificPressure
    {
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

        public static double MillimeterMercuryToPascal(double value)
        {
            return value * 133.32238741500001d;
        }

        public static double PascalToMillimeterMercury(double baseValue)
        {
            return baseValue / 133.32238741500001d;
        }

        public static double BaryeToPascal(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double PascalToBarye(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }

        public static double DynePerSquareCentimeterToPascal(double value)
        {
            return value * 0.10000000000000001d;
        }

        public static double PascalToDynePerSquareCentimeter(double baseValue)
        {
            return baseValue / 0.10000000000000001d;
        }
    }
}
