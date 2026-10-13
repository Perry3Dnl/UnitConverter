namespace UnitTools.ElectricFieldStrength.Imperial
{
    public static class UnitToolsImperialElectricFieldStrength
    {
        public static double VoltPerInchToVoltPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double VoltPerMeterToVoltPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double VoltPerFootToVoltPerMeter(double value)
        {
            return value * 3.280839895013123d;
        }

        public static double VoltPerMeterToVoltPerFoot(double baseValue)
        {
            return baseValue / 3.280839895013123d;
        }
    }
}
