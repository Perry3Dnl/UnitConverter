namespace UnitConverter.EnergyDensity.Metric
{
    public static class UnitConverterMetricEnergyDensity
    {
        public static double JoulePerCubicMeterToJoulePerCubicMeter(double value)
        {
            return value;
        }

        public static double KilojoulePerCubicMeterToJoulePerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double JoulePerCubicMeterToKilojoulePerCubicMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegajoulePerCubicMeterToJoulePerCubicMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double JoulePerCubicMeterToMegajoulePerCubicMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double JoulePerLiterToJoulePerCubicMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double JoulePerCubicMeterToJoulePerLiter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double WattHourPerLiterToJoulePerCubicMeter(double value)
        {
            return value * 3600000.0d;
        }

        public static double JoulePerCubicMeterToWattHourPerLiter(double baseValue)
        {
            return baseValue / 3600000.0d;
        }

        public static double MegajoulePerLiterToJoulePerCubicMeter(double value)
        {
            return value * 1000000000.0d;
        }

        public static double JoulePerCubicMeterToMegajoulePerLiter(double baseValue)
        {
            return baseValue / 1000000000.0d;
        }

        public static double KilowattHourPerLiterToJoulePerCubicMeter(double value)
        {
            return value * 3600000000.0d;
        }

        public static double JoulePerCubicMeterToKilowattHourPerLiter(double baseValue)
        {
            return baseValue / 3600000000.0d;
        }

        public static double CaloriePerLiterToJoulePerCubicMeter(double value)
        {
            return value * 4184.0d;
        }

        public static double JoulePerCubicMeterToCaloriePerLiter(double baseValue)
        {
            return baseValue / 4184.0d;
        }

        public static double KilocaloriePerLiterToJoulePerCubicMeter(double value)
        {
            return value * 4184000.0d;
        }

        public static double JoulePerCubicMeterToKilocaloriePerLiter(double baseValue)
        {
            return baseValue / 4184000.0d;
        }
    }
}
