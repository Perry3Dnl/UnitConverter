namespace UnitTools.FuelEconomy.Nautical
{
    public static class UnitToolsNauticalFuelEconomy
    {
        public static double NauticalMilePerUSGallonToKilometerPerLiter(double value)
        {
            return value * 1.852d / 3.785411784d;
        }

        public static double KilometerPerLiterToNauticalMilePerUSGallon(double baseValue)
        {
            return baseValue * 3.785411784d / 1.852d;
        }

        public static double NauticalMilePerImperialGallonToKilometerPerLiter(double value)
        {
            return value * 1.852d / 4.54609d;
        }

        public static double KilometerPerLiterToNauticalMilePerImperialGallon(double baseValue)
        {
            return baseValue * 4.54609d / 1.852d;
        }
    }
}
