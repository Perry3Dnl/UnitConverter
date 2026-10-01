namespace RealisticPhysics.UnitConversion.EnergyDensity.Scientific
{
    public static class UnitConverterScientificEnergyDensity
    {
        public static double ElectronVoltPerCubicNanometerToJoulePerCubicMeter(double value)
        {
            return value * 160217663.40000001d;
        }

        public static double JoulePerCubicMeterToElectronVoltPerCubicNanometer(double baseValue)
        {
            return baseValue / 160217663.40000001d;
        }
    }
}
