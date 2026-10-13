namespace UnitTools.ForcePerLength.Imperial
{
    public static class UnitToolsImperialForcePerLength
    {
        public static double PoundForcePerFootToNewtonPerMeter(double value)
        {
            return value * 14.593902937206362d;
        }

        public static double NewtonPerMeterToPoundForcePerFoot(double baseValue)
        {
            return baseValue / 14.593902937206362d;
        }

        public static double PoundForcePerInchToNewtonPerMeter(double value)
        {
            return value * 175.12683524647636d;
        }

        public static double NewtonPerMeterToPoundForcePerInch(double baseValue)
        {
            return baseValue / 175.12683524647636d;
        }

        public static double NewtonPerInchToNewtonPerMeter(double value)
        {
            return value * 39.370078740157481d;
        }

        public static double NewtonPerMeterToNewtonPerInch(double baseValue)
        {
            return baseValue / 39.370078740157481d;
        }

        public static double OunceForcePerInchToNewtonPerMeter(double value)
        {
            return value * 10.945427202904773d;
        }

        public static double NewtonPerMeterToOunceForcePerInch(double baseValue)
        {
            return baseValue / 10.945427202904773d;
        }
    }
}
