namespace UnitTools.Volume.Imperial
{
    public static class UnitToolsImperialVolume
    {
        public static double CubicInchToLiter(double value)
        {
            return value * 0.016387064d;
        }

        public static double LiterToCubicInch(double baseValue)
        {
            return baseValue / 0.016387064d;
        }

        public static double CubicFootToLiter(double value)
        {
            return value * 28.316846592000001d;
        }

        public static double LiterToCubicFoot(double baseValue)
        {
            return baseValue / 28.316846592000001d;
        }

        public static double CubicYardToLiter(double value)
        {
            return value * 764.55485798400002d;
        }

        public static double LiterToCubicYard(double baseValue)
        {
            return baseValue / 764.55485798400002d;
        }

        public static double BoardFootToLiter(double value)
        {
            return value * 2.3597372160000001d;
        }

        public static double LiterToBoardFoot(double baseValue)
        {
            return baseValue / 2.3597372160000001d;
        }

        public static double CordToLiter(double value)
        {
            return value * 3624.5563637760001d;
        }

        public static double LiterToCord(double baseValue)
        {
            return baseValue / 3624.5563637760001d;
        }
    }
}
