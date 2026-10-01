namespace RealisticPhysics.UnitConversion.FuelEconomy.Metric
{
    public static class UnitConverterMetricFuelEconomy
    {
        public static double LiterPerKilometerToKilometerPerLiter(double value)
        {
            return 1d / value;
        }

        public static double KilometerPerLiterToLiterPerKilometer(double baseValue)
        {
            return 1d / baseValue;
        }

        public static double MeterPerLiterToKilometerPerLiter(double value)
        {
            return value / 1000d;
        }

        public static double KilometerPerLiterToMeterPerLiter(double baseValue)
        {
            return baseValue * 1000d;
        }

        public static double MilliliterPerKilometerToKilometerPerLiter(double value)
        {
            return 1000d / value;
        }

        public static double KilometerPerLiterToMilliliterPerKilometer(double baseValue)
        {
            return 1000d / baseValue;
        }

        public static double LiterPer10KilometerToKilometerPerLiter(double value)
        {
            return 10d / value;
        }

        public static double KilometerPerLiterToLiterPer10Kilometer(double baseValue)
        {
            return 10d / baseValue;
        }

        public static double KilometerPerMilliliterToKilometerPerLiter(double value)
        {
            return value * 1000d;
        }

        public static double KilometerPerLiterToKilometerPerMilliliter(double baseValue)
        {
            return baseValue / 1000d;
        }

        public static double MeterPerMilliliterToKilometerPerLiter(double value)
        {
            return value;
        }

        public static double KilometerPerLiterToMeterPerMilliliter(double baseValue)
        {
            return baseValue;
        }
    }
}
