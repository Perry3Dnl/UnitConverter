namespace UnitConverter.Frequency.Scientific
{
    public static class UnitConverterScientificFrequency
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
