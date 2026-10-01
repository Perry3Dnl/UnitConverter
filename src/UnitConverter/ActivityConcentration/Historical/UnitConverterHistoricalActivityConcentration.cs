namespace UnitConverter.ActivityConcentration.Historical
{
    public static class UnitConverterHistoricalActivityConcentration
    {
        public static double CuriePerCubicMeterToBecquerelPerCubicMeter(double value)
        {
            return value * 37000000000.0d;
        }

        public static double BecquerelPerCubicMeterToCuriePerCubicMeter(double baseValue)
        {
            return baseValue / 37000000000.0d;
        }

        public static double MicrocuriePerLiterToBecquerelPerCubicMeter(double value)
        {
            return value * 37000000.0d;
        }

        public static double BecquerelPerCubicMeterToMicrocuriePerLiter(double baseValue)
        {
            return baseValue / 37000000.0d;
        }

        public static double PicocuriePerLiterToBecquerelPerCubicMeter(double value)
        {
            return value * 37.0d;
        }

        public static double BecquerelPerCubicMeterToPicocuriePerLiter(double baseValue)
        {
            return baseValue / 37.0d;
        }

        public static double NanocuriePerLiterToBecquerelPerCubicMeter(double value)
        {
            return value * 37000.0d;
        }

        public static double BecquerelPerCubicMeterToNanocuriePerLiter(double baseValue)
        {
            return baseValue / 37000.0d;
        }
    }
}
