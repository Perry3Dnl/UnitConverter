namespace UnitTools.Snap.Imperial
{
    public static class UnitToolsImperialSnap
    {
        public static double FootPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double MeterPerSecondFourthToFootPerSecondFourth(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double InchPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double MeterPerSecondFourthToInchPerSecondFourth(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double YardPerSecondFourthToMeterPerSecondFourth(double value)
        {
            return value * 0.91439999999999999d;
        }

        public static double MeterPerSecondFourthToYardPerSecondFourth(double baseValue)
        {
            return baseValue / 0.91439999999999999d;
        }
    }
}
