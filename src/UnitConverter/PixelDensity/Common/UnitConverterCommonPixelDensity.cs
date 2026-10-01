namespace UnitConverter.PixelDensity.Common
{
    public static class UnitConverterCommonPixelDensity
    {
        public static double PixelPerMeterToPixelPerMeter(double value)
        {
            return value;
        }

        public static double PixelPerCentimeterToPixelPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double PixelPerMeterToPixelPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double PixelPerMillimeterToPixelPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double PixelPerMeterToPixelPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double PixelPerInchToPixelPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double PixelPerMeterToPixelPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double DotPerInchToPixelPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double PixelPerMeterToDotPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double PointPerInchToPixelPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double PixelPerMeterToPointPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double DotPerCentimeterToPixelPerMeter(double value)
        {
            return value * 100.0d;
        }

        public static double PixelPerMeterToDotPerCentimeter(double baseValue)
        {
            return baseValue / 100.0d;
        }

        public static double DotPerMillimeterToPixelPerMeter(double value)
        {
            return value * 1000.0d;
        }

        public static double PixelPerMeterToDotPerMillimeter(double baseValue)
        {
            return baseValue / 1000.0d;
        }

        public static double DotPerMeterToPixelPerMeter(double value)
        {
            return value * 1.0d;
        }

        public static double PixelPerMeterToDotPerMeter(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double PixelPerUnityUnitToPixelPerMeter(double value)
        {
            return value * 1.0d;
        }

        public static double PixelPerMeterToPixelPerUnityUnit(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
