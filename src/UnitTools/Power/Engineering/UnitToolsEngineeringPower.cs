namespace UnitTools.Power.Engineering
{
    public static class UnitToolsEngineeringPower
    {
        public static double HorsepowerElectricalToWatt(double value)
        {
            return value * 746.0d;
        }

        public static double WattToHorsepowerElectrical(double baseValue)
        {
            return baseValue / 746.0d;
        }

        public static double TonOfRefrigerationToWatt(double value)
        {
            return value * 3516.8528420666998d;
        }

        public static double WattToTonOfRefrigeration(double baseValue)
        {
            return baseValue / 3516.8528420666998d;
        }

        public static double VoltAmpereToWatt(double value)
        {
            return value * 1.0d;
        }

        public static double WattToVoltAmpere(double baseValue)
        {
            return baseValue / 1.0d;
        }

        public static double KilovoltAmpereToWatt(double value)
        {
            return value * 1000.0d;
        }

        public static double WattToKilovoltAmpere(double baseValue)
        {
            return baseValue / 1000.0d;
        }
    }
}
