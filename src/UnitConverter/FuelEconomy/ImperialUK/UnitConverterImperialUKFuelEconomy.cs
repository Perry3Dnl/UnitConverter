namespace UnitConverter.FuelEconomy.ImperialUK
{
    public static class UnitConverterImperialUKFuelEconomy
    {
        public static double ImperialGallonPerMileToKilometerPerLiter(double value)
        {
            return 1.609344d / (value * 4.54609d);
        }

        public static double KilometerPerLiterToImperialGallonPerMile(double baseValue)
        {
            return 1.609344d / (baseValue * 4.54609d);
        }

        public static double KilometerPerImperialGallonToKilometerPerLiter(double value)
        {
            return value / 4.54609d;
        }

        public static double KilometerPerLiterToKilometerPerImperialGallon(double baseValue)
        {
            return baseValue * 4.54609d;
        }

        public static double ImperialGallonPer100MileToKilometerPerLiter(double value)
        {
            return 160.9344d / (value * 4.54609d);
        }

        public static double KilometerPerLiterToImperialGallonPer100Mile(double baseValue)
        {
            return 160.9344d / (baseValue * 4.54609d);
        }

        public static double ImperialGallonPer100KilometerToKilometerPerLiter(double value)
        {
            return 100d / (value * 4.54609d);
        }

        public static double KilometerPerLiterToImperialGallonPer100Kilometer(double baseValue)
        {
            return 100d / (baseValue * 4.54609d);
        }
    }
}
