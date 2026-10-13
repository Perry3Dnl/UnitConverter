namespace UnitTools.Length.Survey
{
    public static class UnitToolsSurveyLength
    {
        public static double LinkToMeter(double value)
        {
            return value * 0.20116800000000001d;
        }

        public static double MeterToLink(double baseValue)
        {
            return baseValue / 0.20116800000000001d;
        }

        public static double RodToMeter(double value)
        {
            return value * 5.0292000000000003d;
        }

        public static double MeterToRod(double baseValue)
        {
            return baseValue / 5.0292000000000003d;
        }

        public static double ChainToMeter(double value)
        {
            return value * 20.116800000000001d;
        }

        public static double MeterToChain(double baseValue)
        {
            return baseValue / 20.116800000000001d;
        }

        public static double FurlongToMeter(double value)
        {
            return value * 201.16800000000001d;
        }

        public static double MeterToFurlong(double baseValue)
        {
            return baseValue / 201.16800000000001d;
        }
    }
}
