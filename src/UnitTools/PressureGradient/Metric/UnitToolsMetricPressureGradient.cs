namespace UnitTools.PressureGradient.Metric
{
    public static class UnitToolsMetricPressureGradient
    {
        public static double PascalPerMeterToPascalPerMeter(double value)
        {
            return value;
        }

        public static double KilopascalPerMeterToPascalPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double PascalPerMeterToKilopascalPerMeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double PascalPerCentimeterToPascalPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double PascalPerMeterToPascalPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double BarPerMeterToPascalPerMeter(double value)
        {
            return value * 100000.0d;
        }

        public static double PascalPerMeterToBarPerMeter(double baseValue)
        {
            return baseValue / 100000.0d;
        }

        public static double MillimeterMercuryPerMeterToPascalPerMeter(double value)
        {
            return value * 133.32238741500001d;
        }

        public static double PascalPerMeterToMillimeterMercuryPerMeter(double baseValue)
        {
            return baseValue / 133.32238741500001d;
        }

        public static double PascalPerMillimeterToPascalPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double PascalPerMeterToPascalPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double MegapascalPerMeterToPascalPerMeter(double value)
        {
            return value * 1000000.0d;
        }

        public static double PascalPerMeterToMegapascalPerMeter(double baseValue)
        {
            return baseValue / 1000000.0d;
        }

        public static double KilopascalPerCentimeterToPascalPerMeter(double value)
        {
            return value * 100000.0d;
        }

        public static double PascalPerMeterToKilopascalPerCentimeter(double baseValue)
        {
            return baseValue / 100000.0d;
        }

        public static double BarPerCentimeterToPascalPerMeter(double value)
        {
            return value * 10000000.0d;
        }

        public static double PascalPerMeterToBarPerCentimeter(double baseValue)
        {
            return baseValue / 10000000.0d;
        }

        public static double AtmospherePerMeterToPascalPerMeter(double value)
        {
            return value * 101325.0d;
        }

        public static double PascalPerMeterToAtmospherePerMeter(double baseValue)
        {
            return baseValue / 101325.0d;
        }
    }
}
