namespace UnitConverter.SpecificGravity.Engineering
{
    public static class UnitConverterEngineeringSpecificGravity
    {
        public static double APIGravityToRatio(double value)
        {
            return 141.5d / (value + 131.5d);
        }

        public static double RatioToAPIGravity(double baseValue)
        {
            return 141.5d / baseValue - 131.5d;
        }

        public static double BaumeLightToRatio(double value)
        {
            return 140d / (130d + value);
        }

        public static double RatioToBaumeLight(double baseValue)
        {
            return 140d / baseValue - 130d;
        }

        public static double BaumeHeavyToRatio(double value)
        {
            return 145d / (145d - value);
        }

        public static double RatioToBaumeHeavy(double baseValue)
        {
            return 145d - 145d / baseValue;
        }

        public static double TwaddellToRatio(double value)
        {
            return 1d + value / 200d;
        }

        public static double RatioToTwaddell(double baseValue)
        {
            return (baseValue - 1d) * 200d;
        }
    }
}
