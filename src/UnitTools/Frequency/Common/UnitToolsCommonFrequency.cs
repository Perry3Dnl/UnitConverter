namespace UnitTools.Frequency.Common
{
    public static class UnitToolsCommonFrequency
    {
        public static double BeatsPerMinuteToHertz(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double HertzToBeatsPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }

        public static double FramesPerSecondToHertz(double value)
        {
            return value * 1.0d;
        }

        public static double HertzToFramesPerSecond(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double CyclesPerMinuteToHertz(double value)
        {
            return value * 0.016666666666666666d;
        }

        public static double HertzToCyclesPerMinute(double baseValue)
        {
            return baseValue / 0.016666666666666666d;
        }
    }
}
