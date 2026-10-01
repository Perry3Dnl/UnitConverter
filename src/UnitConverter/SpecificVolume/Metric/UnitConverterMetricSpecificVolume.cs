namespace UnitConverter.SpecificVolume.Metric
{
    public static class UnitConverterMetricSpecificVolume
    {
        public static double CubicMeterPerKilogramToCubicMeterPerKilogram(double value)
        {
            return value;
        }

        public static double LiterPerKilogramToCubicMeterPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CubicMeterPerKilogramToLiterPerKilogram(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double MilliliterPerGramToCubicMeterPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CubicMeterPerKilogramToMilliliterPerGram(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double CubicCentimeterPerGramToCubicMeterPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CubicMeterPerKilogramToCubicCentimeterPerGram(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double CubicMeterPerGramToCubicMeterPerKilogram(double value)
        {
            return value * 1000.0d;
        }

        public static double CubicMeterPerKilogramToCubicMeterPerGram(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double CubicMeterPerTonneToCubicMeterPerKilogram(double value)
        {
            return value * 0.001d;
        }

        public static double CubicMeterPerKilogramToCubicMeterPerTonne(double baseValue)
        {
            return baseValue / 0.001d;
        }

        public static double LiterPerGramToCubicMeterPerKilogram(double value)
        {
            return value * 1.0d;
        }

        public static double CubicMeterPerKilogramToLiterPerGram(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
