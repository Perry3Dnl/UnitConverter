namespace UnitTools.Speed.Imperial
{
    public static class UnitToolsImperialSpeed
    {
        public static double FootPerSecondToMeterPerSecond(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double MeterPerSecondToFootPerSecond(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double MilePerHourToMeterPerSecond(double value)
        {
            return value * 0.44703999999999999d;
        }

        public static double MeterPerSecondToMilePerHour(double baseValue)
        {
            return baseValue / 0.44703999999999999d;
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

        public static double FootPerMinuteToMeterPerSecond(double value)
        {
            return value * 0.0050800000000000003d;
        }

        public static double MeterPerSecondToFootPerMinute(double baseValue)
        {
            return baseValue / 0.0050800000000000003d;
        }

        public static double YardPerSecondToMeterPerSecond(double value)
        {
            return value * 0.91439999999999999d;
        }

        public static double MeterPerSecondToYardPerSecond(double baseValue)
        {
            return baseValue / 0.91439999999999999d;
        }

        public static double MilePerSecondToMeterPerSecond(double value)
        {
            return value * 1609.3440000000001d;
        }

        public static double MeterPerSecondToMilePerSecond(double baseValue)
        {
            return baseValue / 1609.3440000000001d;
        }
    }
}
