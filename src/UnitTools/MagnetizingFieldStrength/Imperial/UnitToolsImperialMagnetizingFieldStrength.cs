namespace UnitTools.MagnetizingFieldStrength.Imperial
{
    public static class UnitToolsImperialMagnetizingFieldStrength
    {
        public static double AmperePerInchToAmperePerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double AmperePerMeterToAmperePerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double AmpereTurnPerInchToAmperePerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double AmperePerMeterToAmpereTurnPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }
    }
}
