namespace UnitConverter.Mass.ImperialUS
{
    public static class UnitConverterImperialUSMass
    {
        public static double HundredweightUSToKilogram(double value)
        {
            return value * 45.359237d;
        }

        public static double KilogramToHundredweightUS(double baseValue)
        {
            return baseValue / 45.359237d;
        }

        public static double ShortTonToKilogram(double value)
        {
            return value * 907.18474000000003d;
        }

        public static double KilogramToShortTon(double baseValue)
        {
            return baseValue / 907.18474000000003d;
        }
    }
}
