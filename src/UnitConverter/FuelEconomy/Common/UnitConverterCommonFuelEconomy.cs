namespace UnitConverter.FuelEconomy.Common
{
    public static class UnitConverterCommonFuelEconomy
    {
        public static double KilometerPerLiterToKilometerPerLiter(double value)
        {
            return value;
        }

        public static double LiterPer100KilometerToKilometerPerLiter(double value)
        {
            return 100d / value;
        }

        public static double KilometerPerLiterToLiterPer100Kilometer(double baseValue)
        {
            return 100d / baseValue;
        }

        public static double MilePerUSGallonToKilometerPerLiter(double value)
        {
            return value * 1.609344d / 3.785411784d;
        }

        public static double KilometerPerLiterToMilePerUSGallon(double baseValue)
        {
            return baseValue * 3.785411784d / 1.609344d;
        }

        public static double MilePerImperialGallonToKilometerPerLiter(double value)
        {
            return value * 1.609344d / 4.54609d;
        }

        public static double KilometerPerLiterToMilePerImperialGallon(double baseValue)
        {
            return baseValue * 4.54609d / 1.609344d;
        }
    }
}
