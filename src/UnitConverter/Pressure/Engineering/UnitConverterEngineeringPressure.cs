namespace UnitConverter.Pressure.Engineering
{
    public static class UnitConverterEngineeringPressure
    {
        public static double TechnicalAtmosphereToPascal(double value)
        {
            return value * 98066.5d;
        }

        public static double PascalToTechnicalAtmosphere(double baseValue)
        {
            return baseValue / 98066.5d;
        }

        public static double KilogramForcePerSquareCentimeterToPascal(double value)
        {
            return value * 98066.5d;
        }

        public static double PascalToKilogramForcePerSquareCentimeter(double baseValue)
        {
            return baseValue / 98066.5d;
        }

        public static double MillimeterWaterToPascal(double value)
        {
            return value * 9.8066499999999994d;
        }

        public static double PascalToMillimeterWater(double baseValue)
        {
            return baseValue / 9.8066499999999994d;
        }

        public static double CentimeterWaterToPascal(double value)
        {
            return value * 98.066500000000005d;
        }

        public static double PascalToCentimeterWater(double baseValue)
        {
            return baseValue / 98.066500000000005d;
        }

        public static double MeterWaterToPascal(double value)
        {
            return value * 9806.6499999999996d;
        }

        public static double PascalToMeterWater(double baseValue)
        {
            return baseValue / 9806.6499999999996d;
        }
    }
}
