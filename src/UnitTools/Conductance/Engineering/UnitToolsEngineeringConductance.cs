namespace UnitTools.Conductance.Engineering
{
    public static class UnitToolsEngineeringConductance
    {
        public static double MhoToSiemens(double value)
        {
            return value * 1.0d;
        }

        public static double SiemensToMho(double baseValue)
        {
            return baseValue / 1.0d;
        }
    }
}
