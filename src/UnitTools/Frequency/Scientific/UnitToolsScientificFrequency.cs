namespace UnitTools.Frequency.Scientific
{
    public static class UnitToolsScientificFrequency
    {
        public static double RadianPerSecondAsFrequencyToHertz(double value)
        {
            return value * 0.15915494309189535d;
        }

        public static double HertzToRadianPerSecondAsFrequency(double baseValue)
        {
            return baseValue / 0.15915494309189535d;
        }
    }
}
