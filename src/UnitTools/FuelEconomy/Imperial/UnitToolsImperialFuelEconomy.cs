namespace UnitTools.FuelEconomy.Imperial
{
    public static class UnitToolsImperialFuelEconomy
    {
        public static double LiterPerMileToKilometerPerLiter(double value)
        {
            return 1.609344d / value;
        }

        public static double KilometerPerLiterToLiterPerMile(double baseValue)
        {
            return 1.609344d / baseValue;
        }

        public static double MilePerLiterToKilometerPerLiter(double value)
        {
            return value * 1.609344d;
        }

        public static double KilometerPerLiterToMilePerLiter(double baseValue)
        {
            return baseValue / 1.609344d;
        }

        public static double LiterPer100MileToKilometerPerLiter(double value)
        {
            return 160.9344d / value;
        }

        public static double KilometerPerLiterToLiterPer100Mile(double baseValue)
        {
            return 160.9344d / baseValue;
        }
    }
}
