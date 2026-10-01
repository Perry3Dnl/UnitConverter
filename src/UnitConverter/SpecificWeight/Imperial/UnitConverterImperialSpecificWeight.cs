namespace UnitConverter.SpecificWeight.Imperial
{
    public static class UnitConverterImperialSpecificWeight
    {
        public static double PoundForcePerCubicFootToNewtonPerCubicMeter(double value)
        {
            return value * 157.08746384624618d;
        }

        public static double NewtonPerCubicMeterToPoundForcePerCubicFoot(double baseValue)
        {
            return baseValue / 157.08746384624618d;
        }

        public static double OunceForcePerCubicFootToNewtonPerCubicMeter(double value)
        {
            return value * 9.8179664903903863d;
        }

        public static double NewtonPerCubicMeterToOunceForcePerCubicFoot(double baseValue)
        {
            return baseValue / 9.8179664903903863d;
        }
    }
}
