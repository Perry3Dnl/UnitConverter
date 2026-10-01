namespace RealisticPhysics.UnitConversion.LinearDensity.Metric
{
    public static class UnitConverterMetricLinearDensity
    {
        public static double KilogramPerMeterToKilogramPerMeter(double value)
        {
            return value;
        }

        public static double GramPerMeterToKilogramPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerMeterToGramPerMeter(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MilligramPerMeterToKilogramPerMeter(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double KilogramPerMeterToMilligramPerMeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double KilogramPerKilometerToKilogramPerMeter(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerMeterToKilogramPerKilometer(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double KilogramPerCentimeterToKilogramPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double KilogramPerMeterToKilogramPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double KilogramPerMillimeterToKilogramPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double KilogramPerMeterToKilogramPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double GramPerMillimeterToKilogramPerMeter(double value)
        {
            return value * 1.0d;
        }

        public static double KilogramPerMeterToGramPerMillimeter(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
