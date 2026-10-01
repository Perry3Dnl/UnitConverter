namespace RealisticPhysics.UnitConversion.Energy.Imperial
{
    public static class UnitConverterImperialEnergy
    {
        public static double BtuInternationalToJoule(double value)
        {
            return value * 1055.05585262d;
        }

        public static double JouleToBtuInternational(double baseValue)
        {
            return baseValue / 1055.05585262d;
        }

        public static double FootPoundToJoule(double value)
        {
            return value * 1.3558179483314003d;
        }

        public static double JouleToFootPound(double baseValue)
        {
            return baseValue / 1.3558179483314003d;
        }

        public static double HorsepowerHourToJoule(double value)
        {
            return value * 2684519.5376961725d;
        }

        public static double JouleToHorsepowerHour(double baseValue)
        {
            return baseValue / 2684519.5376961725d;
        }

        public static double ThermECToJoule(double value)
        {
            return value * 105506000.0d;
        }

        public static double JouleToThermEC(double baseValue)
        {
            return baseValue / 105506000.0d;
        }
    }
}
