namespace UnitTools.Permittivity.Scientific
{
    public static class UnitToolsScientificPermittivity
    {
        public static double VacuumPermittivityToFaradPerMeter(double value)
        {
            return value * 8.8541878128000006e-12d;
        }

        public static double FaradPerMeterToVacuumPermittivity(double baseValue)
        {
            return baseValue / 8.8541878128000006e-12d;
        }

        public static double RelativePermittivityToFaradPerMeter(double value)
        {
            return value * 8.8541878128000006e-12d;
        }

        public static double FaradPerMeterToRelativePermittivity(double baseValue)
        {
            return baseValue / 8.8541878128000006e-12d;
        }
    }
}
