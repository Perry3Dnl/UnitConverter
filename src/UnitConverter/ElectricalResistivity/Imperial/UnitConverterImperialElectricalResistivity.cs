namespace UnitConverter.ElectricalResistivity.Imperial
{
    public static class UnitConverterImperialElectricalResistivity
    {
        public static double OhmInchToOhmMeter(double value)
        {
            return value * 0.025399999999999999d;
        }

        public static double OhmMeterToOhmInch(double baseValue)
        {
            return baseValue / 0.025399999999999999d;
        }

        public static double CircularMilOhmPerFootToOhmMeter(double value)
        {
            return value * 1.662426e-09d;
        }

        public static double OhmMeterToCircularMilOhmPerFoot(double baseValue)
        {
            return baseValue / 1.662426e-09d;
        }

        public static double OhmFootToOhmMeter(double value)
        {
            return value * 0.30480000000000002d;
        }

        public static double OhmMeterToOhmFoot(double baseValue)
        {
            return baseValue / 0.30480000000000002d;
        }

        public static double MicroohmInchToOhmMeter(double value)
        {
            return value * 2.5399999999999999e-08d;
        }

        public static double OhmMeterToMicroohmInch(double baseValue)
        {
            return baseValue / 2.5399999999999999e-08d;
        }
    }
}
