namespace UnitTools.PixelDensity.Imperial
{
    public static class UnitToolsImperialPixelDensity
    {
        public static double PixelPerFootToPixelPerMeter(double value)
        {
            return value * 3.280839895013123d;
        }

        public static double PixelPerMeterToPixelPerFoot(double baseValue)
        {
            return baseValue / 3.280839895013123d;
        }

        public static double PixelPerYardToPixelPerMeter(double value)
        {
            return value * 1.0936132983377078d;
        }

        public static double PixelPerMeterToPixelPerYard(double baseValue)
        {
            return baseValue / 1.0936132983377078d;
        }

        public static double PixelPerMileToPixelPerMeter(double value)
        {
            return value * 0.00062137119223733392d;
        }

        public static double PixelPerMeterToPixelPerMile(double baseValue)
        {
            return baseValue / 0.00062137119223733392d;
        }
    }
}
