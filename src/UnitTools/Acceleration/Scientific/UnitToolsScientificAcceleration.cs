namespace UnitTools.Acceleration.Scientific
{
    public static class UnitToolsScientificAcceleration
    {
        public static double GalileoToMeterPerSecondSquared(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondSquaredToGalileo(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double StandardGravityToMeterPerSecondSquared(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double MeterPerSecondSquaredToStandardGravity(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double GalToMeterPerSecondSquared(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondSquaredToGal(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double MilligalToMeterPerSecondSquared(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double MeterPerSecondSquaredToMilligal(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }

        public static double MicrogalToMeterPerSecondSquared(double value)
        {
            return value * 1e-08d;
        }

        public static double MeterPerSecondSquaredToMicrogal(double baseValue)
        {
            return baseValue / 1e-08d;
        }
    }
}
