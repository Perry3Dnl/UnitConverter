namespace RealisticPhysics.UnitConversion.FrameRate.Metric
{
    public static class UnitConverterMetricFrameRate
    {
        public static double HertzToFramePerSecond(double value)
        {
            return value * 1.0d;
        }

        public static double FramePerSecondToHertz(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double KilohertzToFramePerSecond(double value)
        {
            return value * 1000.0d;
        }

        public static double FramePerSecondToKilohertz(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegahertzToFramePerSecond(double value)
        {
            return value * 1000000.0d;
        }

        public static double FramePerSecondToMegahertz(double baseValue)
        {
            return baseValue / 1000000.0d;
        }
    }
}
