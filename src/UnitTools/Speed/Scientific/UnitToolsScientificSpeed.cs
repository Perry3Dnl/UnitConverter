namespace UnitTools.Speed.Scientific
{
    public static class UnitToolsScientificSpeed
    {
        public static double MachAtSeaLevelToMeterPerSecond(double value)
        {
            return value * 340.29000000000002d;
        }

        public static double MeterPerSecondToMachAtSeaLevel(double baseValue)
        {
            return baseValue / 340.29000000000002d;
        }

        public static double SpeedOfLightToMeterPerSecond(double value)
        {
            return value * 299792458.0d;
        }

        public static double MeterPerSecondToSpeedOfLight(double baseValue)
        {
            return baseValue / 299792458.0d;
        }

        public static double SpeedOfSoundAirApproxToMeterPerSecond(double value)
        {
            return value * 343.0d;
        }

        public static double MeterPerSecondToSpeedOfSoundAirApprox(double baseValue)
        {
            return baseValue / 343.0d;
        }
    }
}
