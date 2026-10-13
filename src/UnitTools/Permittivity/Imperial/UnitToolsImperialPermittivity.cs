namespace UnitTools.Permittivity.Imperial
{
    public static class UnitToolsImperialPermittivity
    {
        public static double FaradPerInchToFaradPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double FaradPerMeterToFaradPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }
    }
}
