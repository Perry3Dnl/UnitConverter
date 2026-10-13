namespace UnitTools.SpecificVolume.Imperial
{
    public static class UnitToolsImperialSpecificVolume
    {
        public static double CubicFootPerPoundToCubicMeterPerKilogram(double value)
        {
            return value * 0.062427960576144609d;
        }

        public static double CubicMeterPerKilogramToCubicFootPerPound(double baseValue)
        {
            return baseValue / 0.062427960576144609d;
        }

        public static double CubicInchPerPoundToCubicMeterPerKilogram(double value)
        {
            return value * 3.6127292000083687e-05d;
        }

        public static double CubicMeterPerKilogramToCubicInchPerPound(double baseValue)
        {
            return baseValue / 3.6127292000083687e-05d;
        }

        public static double CubicYardPerPoundToCubicMeterPerKilogram(double value)
        {
            return value * 1.6855549355559045d;
        }

        public static double CubicMeterPerKilogramToCubicYardPerPound(double baseValue)
        {
            return baseValue / 1.6855549355559045d;
        }

        public static double CubicFootPerSlugToCubicMeterPerKilogram(double value)
        {
            return value * 0.0019403203316082902d;
        }

        public static double CubicMeterPerKilogramToCubicFootPerSlug(double baseValue)
        {
            return baseValue / 0.0019403203316082902d;
        }
    }
}
