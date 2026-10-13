namespace UnitTools.LuminousIntensity.Historical
{
    public static class UnitToolsHistoricalLuminousIntensity
    {
        public static double CandlepowerToCandela(double value)
        {
            return value * 1.0d;
        }

        public static double CandelaToCandlepower(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double HefnerkerzeToCandela(double value)
        {
            return value * 0.90300000000000002d;
        }

        public static double CandelaToHefnerkerze(double baseValue)
        {
            return baseValue / 0.90300000000000002d;
        }

        public static double SphericalCandlepowerToCandela(double value)
        {
            return value * 1.0d;
        }

        public static double CandelaToSphericalCandlepower(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double ViolleToCandela(double value)
        {
            return value * 20.170000000000002d;
        }

        public static double CandelaToViolle(double baseValue)
        {
            return baseValue / 20.170000000000002d;
        }
    }
}
