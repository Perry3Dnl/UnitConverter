namespace UnitTools.PowerDensity.Imperial
{
    public static class UnitToolsImperialPowerDensity
    {
        public static double HorsepowerPerCubicFootToWattPerCubicMeter(double value)
        {
            return value * 26334.1424539367d;
        }

        public static double WattPerCubicMeterToHorsepowerPerCubicFoot(double baseValue)
        {
            return baseValue / 26334.1424539367d;
        }

        public static double BtuPerHourCubicFootToWattPerCubicMeter(double value)
        {
            return value * 10.349707168842023d;
        }

        public static double WattPerCubicMeterToBtuPerHourCubicFoot(double baseValue)
        {
            return baseValue / 10.349707168842023d;
        }

        public static double KilowattPerCubicFootToWattPerCubicMeter(double value)
        {
            return value * 35314.666721488589d;
        }

        public static double WattPerCubicMeterToKilowattPerCubicFoot(double baseValue)
        {
            return baseValue / 35314.666721488589d;
        }

        public static double BtuPerSecondCubicFootToWattPerCubicMeter(double value)
        {
            return value * 37258.945807831282d;
        }

        public static double WattPerCubicMeterToBtuPerSecondCubicFoot(double baseValue)
        {
            return baseValue / 37258.945807831282d;
        }
    }
}
