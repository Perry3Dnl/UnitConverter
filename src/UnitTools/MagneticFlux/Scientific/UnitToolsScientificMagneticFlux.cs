namespace UnitTools.MagneticFlux.Scientific
{
    public static class UnitToolsScientificMagneticFlux
    {
        public static double UnitPoleToWeber(double value)
        {
            return value * 1.2566370614359172e-07d;
        }

        public static double WeberToUnitPole(double baseValue)
        {
            return baseValue / 1.2566370614359172e-07d;
        }

        public static double KilomaxwellToWeber(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double WeberToKilomaxwell(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }

        public static double MegamaxwellToWeber(double value)
        {
            return value * 0.01d;
        }

        public static double WeberToMegamaxwell(double baseValue)
        {
            return baseValue / 0.01d;
        }

        public static double LineToWeber(double value)
        {
            return value * 1e-08d;
        }

        public static double WeberToLine(double baseValue)
        {
            return baseValue / 1e-08d;
        }
    }
}
