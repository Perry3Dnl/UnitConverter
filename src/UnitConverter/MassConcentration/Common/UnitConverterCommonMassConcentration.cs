namespace UnitConverter.MassConcentration.Common
{
    public static class UnitConverterCommonMassConcentration
    {
        public static double PartPerMillionWaterToKilogramPerCubicMeter(double value)
        {
            return value * 0.001d;
        }

        public static double KilogramPerCubicMeterToPartPerMillionWater(double baseValue)
        {
            return baseValue / 0.001d;
        }
    }
}
