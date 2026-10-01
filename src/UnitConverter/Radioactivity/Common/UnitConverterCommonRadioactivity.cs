namespace UnitConverter.Radioactivity.Common
{
    public static class UnitConverterCommonRadioactivity
    {
        public static double CurieToBecquerel(double value)
        {
            return value * 37000000000.0d;
        }

        public static double BecquerelToCurie(double baseValue)
        {
            return baseValue / 37000000000.0d;
        }

        public static double MillicurieToBecquerel(double value)
        {
            return value * 37000000.0d;
        }

        public static double BecquerelToMillicurie(double baseValue)
        {
            return baseValue / 37000000.0d;
        }

        public static double MicrocurieToBecquerel(double value)
        {
            return value * 37000.0d;
        }

        public static double BecquerelToMicrocurie(double baseValue)
        {
            return baseValue / 37000.0d;
        }

        public static double DisintegrationsPerSecondToBecquerel(double value)
        {
            return value * 1.0d;
        }

        public static double BecquerelToDisintegrationsPerSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double DisintegrationsPerMinuteToBecquerel(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double BecquerelToDisintegrationsPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double DisintegrationsPerHourToBecquerel(double value)
        {
            return value * 0.00027777777777777778d;
        }

        public static double BecquerelToDisintegrationsPerHour(double baseValue)
        {
            return baseValue / 0.00027777777777777778d;
        }
    }
}
