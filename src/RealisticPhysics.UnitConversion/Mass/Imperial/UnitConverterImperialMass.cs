namespace RealisticPhysics.UnitConversion.Mass.Imperial
{
    public static class UnitConverterImperialMass
    {
        public static double OunceToKilogram(double value)
        {
            return value * 0.028349523125000001d;
        }

        public static double KilogramToOunce(double baseValue)
        {
            return baseValue / 0.028349523125000001d;
        }

        public static double PoundToKilogram(double value)
        {
            return value * 0.45359237000000002d;
        }

        public static double KilogramToPound(double baseValue)
        {
            return baseValue / 0.45359237000000002d;
        }

        public static double DramToKilogram(double value)
        {
            return value * 0.0017718451953125001d;
        }

        public static double KilogramToDram(double baseValue)
        {
            return baseValue / 0.0017718451953125001d;
        }
    }
}
