namespace RealisticPhysics.UnitConversion.AngularAcceleration.Common
{
    public static class UnitConverterCommonAngularAcceleration
    {
        public static double DegreePerSecondSquaredToRadianPerSecondSquared(double value)
        {
            return value * 0.017453292519943295d;
        }

        public static double RadianPerSecondSquaredToDegreePerSecondSquared(double baseValue)
        {
            return baseValue / 0.017453292519943295d;
        }

        public static double RevolutionPerSecondSquaredToRadianPerSecondSquared(double value)
        {
            return value * 6.2831853071795862d;
        }

        public static double RadianPerSecondSquaredToRevolutionPerSecondSquared(double baseValue)
        {
            return baseValue / 6.2831853071795862d;
        }

        public static double RevolutionPerMinutePerSecondToRadianPerSecondSquared(double value)
        {
            return value * 0.10471975511965977d;
        }

        public static double RadianPerSecondSquaredToRevolutionPerMinutePerSecond(double baseValue)
        {
            return baseValue / 0.10471975511965977d;
        }

        public static double RevolutionPerMinuteSquaredToRadianPerSecondSquared(double value)
        {
            return value * 0.0017453292519943296d;
        }

        public static double RadianPerSecondSquaredToRevolutionPerMinuteSquared(double baseValue)
        {
            return baseValue / 0.0017453292519943296d;
        }

        public static double TurnPerSecondSquaredToRadianPerSecondSquared(double value)
        {
            return value * 6.2831853071795862d;
        }

        public static double RadianPerSecondSquaredToTurnPerSecondSquared(double baseValue)
        {
            return baseValue / 6.2831853071795862d;
        }

        public static double TurnPerMinuteSquaredToRadianPerSecondSquared(double value)
        {
            return value * 0.0017453292519943296d;
        }

        public static double RadianPerSecondSquaredToTurnPerMinuteSquared(double baseValue)
        {
            return baseValue / 0.0017453292519943296d;
        }
    }
}
