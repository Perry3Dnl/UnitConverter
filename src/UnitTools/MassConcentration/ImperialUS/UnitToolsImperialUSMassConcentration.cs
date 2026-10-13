namespace UnitTools.MassConcentration.ImperialUS
{
    public static class UnitToolsImperialUSMassConcentration
    {
        public static double PoundPerUSGallonToKilogramPerCubicMeter(double value)
        {
            return value * 119.82642731689663d;
        }

        public static double KilogramPerCubicMeterToPoundPerUSGallon(double baseValue)
        {
            return baseValue / 119.82642731689663d;
        }
    }
}
