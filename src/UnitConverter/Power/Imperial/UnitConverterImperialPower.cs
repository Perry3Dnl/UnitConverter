namespace UnitConverter.Power.Imperial
{
    public static class UnitConverterImperialPower
    {
        public static double HorsepowerMechanicalToWatt(double value)
        {
            return value * 745.69987158227025d;
        }

        public static double WattToHorsepowerMechanical(double baseValue)
        {
            return baseValue / 745.69987158227025d;
        }

        public static double BtuPerHourToWatt(double value)
        {
            return value * 0.29307107017222223d;
        }

        public static double WattToBtuPerHour(double baseValue)
        {
            return baseValue / 0.29307107017222223d;
        }

        public static double FootPoundPerSecondToWatt(double value)
        {
            return value * 1.3558179483314003d;
        }

        public static double WattToFootPoundPerSecond(double baseValue)
        {
            return baseValue / 1.3558179483314003d;
        }
    }
}
