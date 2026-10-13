namespace UnitTools.ThermalExpansion.Engineering
{
    public static class UnitToolsEngineeringThermalExpansion
    {
        public static double MicrostrainPerKelvinToPerKelvin(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PerKelvinToMicrostrainPerKelvin(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double PpmPerKelvinToPerKelvin(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PerKelvinToPpmPerKelvin(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MicrostrainPerCelsiusToPerKelvin(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PerKelvinToMicrostrainPerCelsius(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double MicrostrainPerFahrenheitToPerKelvin(double value)
        {
            return value * 1.7999999999999999e-06d;
        }

        public static double PerKelvinToMicrostrainPerFahrenheit(double baseValue)
        {
            return baseValue / 1.7999999999999999e-06d;
        }

        public static double PpmPerCelsiusToPerKelvin(double value)
        {
            return value * 9.9999999999999995e-07d;
        }

        public static double PerKelvinToPpmPerCelsius(double baseValue)
        {
            return baseValue / 9.9999999999999995e-07d;
        }

        public static double PpmPerFahrenheitToPerKelvin(double value)
        {
            return value * 1.7999999999999999e-06d;
        }

        public static double PerKelvinToPpmPerFahrenheit(double baseValue)
        {
            return baseValue / 1.7999999999999999e-06d;
        }
    }
}
