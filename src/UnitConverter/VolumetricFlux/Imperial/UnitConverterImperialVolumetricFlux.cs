namespace UnitConverter.VolumetricFlux.Imperial
{
    public static class UnitConverterImperialVolumetricFlux
    {
        public static double FootPerSecondToMeterPerSecond(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double MeterPerSecondToFootPerSecond(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double FootPerMinuteToMeterPerSecond(double value)
        {
            return value * 0.0050800000000000003d;
        }

        public static double MeterPerSecondToFootPerMinute(double baseValue)
        {
            return baseValue / 0.0050800000000000003d;
        }

        public static double InchPerSecondToMeterPerSecond(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double MeterPerSecondToInchPerSecond(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double InchPerMinuteToMeterPerSecond(double value)
        {
            return value * 0.00042333333333333334d;
        }

        public static double MeterPerSecondToInchPerMinute(double baseValue)
        {
            return baseValue / 0.00042333333333333334d;
        }

        public static double InchPerHourToMeterPerSecond(double value)
        {
            return value * 7.055555555555555e-06d;
        }

        public static double MeterPerSecondToInchPerHour(double baseValue)
        {
            return baseValue / 7.055555555555555e-06d;
        }
    }
}
