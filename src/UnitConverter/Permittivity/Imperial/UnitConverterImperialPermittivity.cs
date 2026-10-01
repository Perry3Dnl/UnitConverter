namespace UnitConverter.Permittivity.Imperial
{
    public static class UnitConverterImperialPermittivity
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
