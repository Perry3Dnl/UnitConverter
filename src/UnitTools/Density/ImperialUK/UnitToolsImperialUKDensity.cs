namespace UnitTools.Density.ImperialUK
{
    public static class UnitToolsImperialUKDensity
    {
        public static double PoundPerImperialGallonToKilogramPerCubicMeter(double value)
        {
            return value * 99.776372663101654d;
        }

        public static double KilogramPerCubicMeterToPoundPerImperialGallon(double baseValue)
        {
            return baseValue / 99.776372663101654d;
        }

        public static double TonUKPerCubicYardToKilogramPerCubicMeter(double value)
        {
            return value * 1329.337246216744d;
        }

        public static double KilogramPerCubicMeterToTonUKPerCubicYard(double baseValue)
        {
            return baseValue / 1329.337246216744d;
        }

        public static double LongTonPerCubicFootToKilogramPerCubicMeter(double value)
        {
            return value * 35881.357957670712d;
        }

        public static double KilogramPerCubicMeterToLongTonPerCubicFoot(double baseValue)
        {
            return baseValue / 35881.357957670712d;
        }
    }
}
