namespace RealisticPhysics.UnitConversion.Torque.Scientific
{
    public static class UnitConverterScientificTorque
    {
        public static double DyneCentimeterToNewtonMeter(double value)
        {
            return value * 9.9999999999999995e-08d;
        }

        public static double NewtonMeterToDyneCentimeter(double baseValue)
        {
            return baseValue / 9.9999999999999995e-08d;
        }

        public static double DyneMeterToNewtonMeter(double value)
        {
            return value * 1.0000000000000001e-05d;
        }

        public static double NewtonMeterToDyneMeter(double baseValue)
        {
            return baseValue / 1.0000000000000001e-05d;
        }
    }
}
