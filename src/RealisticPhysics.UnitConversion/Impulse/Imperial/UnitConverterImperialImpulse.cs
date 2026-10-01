namespace RealisticPhysics.UnitConversion.Impulse.Imperial
{
    public static class UnitConverterImperialImpulse
    {
        public static double PoundForceSecondToNewtonSecond(double value)
        {
            return value * 4.4482216152604996d;
        }

        public static double NewtonSecondToPoundForceSecond(double baseValue)
        {
            return baseValue / 4.4482216152604996d;
        }

        public static double OunceForceSecondToNewtonSecond(double value)
        {
            return value * 0.27801385095378123d;
        }

        public static double NewtonSecondToOunceForceSecond(double baseValue)
        {
            return baseValue / 0.27801385095378123d;
        }

        public static double PoundForceMinuteToNewtonSecond(double value)
        {
            return value * 266.89329691563d;
        }

        public static double NewtonSecondToPoundForceMinute(double baseValue)
        {
            return baseValue / 266.89329691563d;
        }
    }
}
