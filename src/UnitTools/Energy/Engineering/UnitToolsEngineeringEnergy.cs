namespace UnitTools.Energy.Engineering
{
    public static class UnitToolsEngineeringEnergy
    {
        public static double KilogramForceMeterToJoule(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double JouleToKilogramForceMeter(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }
    }
}
