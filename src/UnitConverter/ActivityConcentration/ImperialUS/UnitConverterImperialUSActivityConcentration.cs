namespace UnitConverter.ActivityConcentration.ImperialUS
{
    public static class UnitConverterImperialUSActivityConcentration
    {
        public static double BecquerelPerUSGallonToBecquerelPerCubicMeter(double value)
        {
            return value * 264.17205235814839d;
        }

        public static double BecquerelPerCubicMeterToBecquerelPerUSGallon(double baseValue)
        {
            return baseValue / 264.17205235814839d;
        }
    }
}
