namespace UnitTools.ElectricFlux.Imperial
{
    public static class UnitToolsImperialElectricFlux
    {
        public static double VoltInchToVoltMeter(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double VoltMeterToVoltInch(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double VoltFootToVoltMeter(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double VoltMeterToVoltFoot(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }
    }
}
