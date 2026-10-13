namespace UnitTools.Force.Imperial
{
    public static class UnitToolsImperialForce
    {
        public static double PoundForceToNewton(double value)
        {
            return value * 4.4482216152604996d;
        }

        public static double NewtonToPoundForce(double baseValue)
        {
            return baseValue / 4.4482216152604996d;
        }

        public static double OunceForceToNewton(double value)
        {
            return value * 0.27801385095378123d;
        }

        public static double NewtonToOunceForce(double baseValue)
        {
            return baseValue / 0.27801385095378123d;
        }

        public static double PoundalToNewton(double value)
        {
            return value * 0.13825495437599999d;
        }

        public static double NewtonToPoundal(double baseValue)
        {
            return baseValue / 0.13825495437599999d;
        }
    }
}
