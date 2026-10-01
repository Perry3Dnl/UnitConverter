namespace UnitConverter.Jerk.Scientific
{
    public static class UnitConverterScientificJerk
    {
        public static double GalPerSecondToMeterPerSecondCubed(double value)
        {
            return value * 0.01d;
        }

        public static double MeterPerSecondCubedToGalPerSecond(double baseValue)
        {
            return baseValue / 0.01d;
        }
    }
}
