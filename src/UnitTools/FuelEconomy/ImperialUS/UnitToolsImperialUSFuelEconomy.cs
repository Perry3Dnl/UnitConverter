namespace UnitTools.FuelEconomy.ImperialUS
{
    public static class UnitToolsImperialUSFuelEconomy
    {
        public static double USGallonPerMileToKilometerPerLiter(double value)
        {
            return 1.609344d / (value * 3.785411784d);
        }

        public static double KilometerPerLiterToUSGallonPerMile(double baseValue)
        {
            return 1.609344d / (baseValue * 3.785411784d);
        }

        public static double KilometerPerUSGallonToKilometerPerLiter(double value)
        {
            return value / 3.785411784d;
        }

        public static double KilometerPerLiterToKilometerPerUSGallon(double baseValue)
        {
            return baseValue * 3.785411784d;
        }

        public static double USGallonPer100MileToKilometerPerLiter(double value)
        {
            return 160.9344d / (value * 3.785411784d);
        }

        public static double KilometerPerLiterToUSGallonPer100Mile(double baseValue)
        {
            return 160.9344d / (baseValue * 3.785411784d);
        }

        public static double USGallonPer100KilometerToKilometerPerLiter(double value)
        {
            return 100d / (value * 3.785411784d);
        }

        public static double KilometerPerLiterToUSGallonPer100Kilometer(double baseValue)
        {
            return 100d / (baseValue * 3.785411784d);
        }
    }
}
