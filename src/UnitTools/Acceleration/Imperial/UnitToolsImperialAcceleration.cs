namespace UnitTools.Acceleration.Imperial
{
    public static class UnitToolsImperialAcceleration
    {
        public static double FootPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double MeterPerSecondSquaredToFootPerSecondSquared(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double MilePerHourPerSecondToMeterPerSecondSquared(double value)
        {
            return value * 0.44703999999999999d;
        }

        public static double MeterPerSecondSquaredToMilePerHourPerSecond(double baseValue)
        {
            return baseValue / 0.44703999999999999d;
        }

        public static double InchPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double MeterPerSecondSquaredToInchPerSecondSquared(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double YardPerSecondSquaredToMeterPerSecondSquared(double value)
        {
            return value * 0.91439999999999999d;
        }

        public static double MeterPerSecondSquaredToYardPerSecondSquared(double baseValue)
        {
            return baseValue / 0.91439999999999999d;
        }

        public static double FootPerMinuteSquaredToMeterPerSecondSquared(double value)
        {
            return value * 8.4666666666666674e-05d;
        }

        public static double MeterPerSecondSquaredToFootPerMinuteSquared(double baseValue)
        {
            return baseValue / 8.4666666666666674e-05d;
        }
    }
}
