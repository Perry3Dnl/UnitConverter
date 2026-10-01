namespace RealisticPhysics.UnitConversion.Yank.Imperial
{
    public static class UnitConverterImperialYank
    {
        public static double PoundForcePerSecondToNewtonPerSecond(double value)
        {
            return value * 4.4482216152604996d;
        }

        public static double NewtonPerSecondToPoundForcePerSecond(double baseValue)
        {
            return baseValue / 4.4482216152604996d;
        }

        public static double PoundForcePerMinuteToNewtonPerSecond(double value)
        {
            return value * 0.074137026921008334d;
        }

        public static double NewtonPerSecondToPoundForcePerMinute(double baseValue)
        {
            return baseValue / 0.074137026921008334d;
        }

        public static double OunceForcePerSecondToNewtonPerSecond(double value)
        {
            return value * 0.27801385095378123d;
        }

        public static double NewtonPerSecondToOunceForcePerSecond(double baseValue)
        {
            return baseValue / 0.27801385095378123d;
        }
    }
}
