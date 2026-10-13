namespace UnitTools.ThermalExpansion.Imperial
{
    public static class UnitToolsImperialThermalExpansion
    {
        public static double PerFahrenheitToPerKelvin(double value)
        {
            return value * 1.8d;
        }

        public static double PerKelvinToPerFahrenheit(double baseValue)
        {
            return baseValue / 1.8d;
        }

        public static double PerRankineToPerKelvin(double value)
        {
            return value * 1.8d;
        }

        public static double PerKelvinToPerRankine(double baseValue)
        {
            return baseValue / 1.8d;
        }
    }
}
