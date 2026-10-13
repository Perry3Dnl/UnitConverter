namespace UnitTools.MassConcentration.Imperial
{
    public static class UnitToolsImperialMassConcentration
    {
        public static double PoundPerCubicFootToKilogramPerCubicMeter(double value)
        {
            return value * 16.018463373960142d;
        }

        public static double KilogramPerCubicMeterToPoundPerCubicFoot(double baseValue)
        {
            return baseValue / 16.018463373960142d;
        }
    }
}
