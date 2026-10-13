namespace UnitTools.ThermalConductivity.Imperial
{
    public static class UnitToolsImperialThermalConductivity
    {
        public static double BtuPerHourFootFahrenheitToWattPerMeterKelvin(double value)
        {
            return value * 1.7307349999999999d;
        }

        public static double WattPerMeterKelvinToBtuPerHourFootFahrenheit(double baseValue)
        {
            return baseValue / 1.7307349999999999d;
        }

        public static double BtuInchPerHourSquareFootFahrenheitToWattPerMeterKelvin(double value)
        {
            return value * 0.14422789999999999d;
        }

        public static double WattPerMeterKelvinToBtuInchPerHourSquareFootFahrenheit(double baseValue)
        {
            return baseValue / 0.14422789999999999d;
        }

        public static double WattPerInchFahrenheitToWattPerMeterKelvin(double value)
        {
            return value * 70.866141732283467d;
        }

        public static double WattPerMeterKelvinToWattPerInchFahrenheit(double baseValue)
        {
            return baseValue / 70.866141732283467d;
        }

        public static double BtuFootPerHourSquareFootFahrenheitToWattPerMeterKelvin(double value)
        {
            return value * 1.7307349999999999d;
        }

        public static double WattPerMeterKelvinToBtuFootPerHourSquareFootFahrenheit(double baseValue)
        {
            return baseValue / 1.7307349999999999d;
        }
    }
}
