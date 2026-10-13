namespace UnitTools.AngularVelocity.Common
{
    public static class UnitToolsCommonAngularVelocity
    {
        public static double DegreePerSecondToRadianPerSecond(double value)
        {
            return value * 0.017453292519943295d;
        }

        public static double RadianPerSecondToDegreePerSecond(double baseValue)
        {
            return baseValue / 0.017453292519943295d;
        }

        public static double DegreePerMinuteToRadianPerSecond(double value)
        {
            return value * 0.00029088820866572158d;
        }

        public static double RadianPerSecondToDegreePerMinute(double baseValue)
        {
            return baseValue / 0.00029088820866572158d;
        }

        public static double RevolutionPerSecondToRadianPerSecond(double value)
        {
            return value * 6.2831853071795862d;
        }

        public static double RadianPerSecondToRevolutionPerSecond(double baseValue)
        {
            return baseValue / 6.2831853071795862d;
        }

        public static double RevolutionPerMinuteToRadianPerSecond(double value)
        {
            return value * 0.10471975511965977d;
        }

        public static double RadianPerSecondToRevolutionPerMinute(double baseValue)
        {
            return baseValue / 0.10471975511965977d;
        }

        public static double RevolutionPerHourToRadianPerSecond(double value)
        {
            return value * 0.0017453292519943296d;
        }

        public static double RadianPerSecondToRevolutionPerHour(double baseValue)
        {
            return baseValue / 0.0017453292519943296d;
        }

        public static double RevolutionPerDayToRadianPerSecond(double value)
        {
            return value * 7.2722052166430395e-05d;
        }

        public static double RadianPerSecondToRevolutionPerDay(double baseValue)
        {
            return baseValue / 7.2722052166430395e-05d;
        }

        public static double TurnPerSecondToRadianPerSecond(double value)
        {
            return value * 6.2831853071795862d;
        }

        public static double RadianPerSecondToTurnPerSecond(double baseValue)
        {
            return baseValue / 6.2831853071795862d;
        }

        public static double TurnPerMinuteToRadianPerSecond(double value)
        {
            return value * 0.10471975511965977d;
        }

        public static double RadianPerSecondToTurnPerMinute(double baseValue)
        {
            return baseValue / 0.10471975511965977d;
        }

        public static double CyclePerSecondToRadianPerSecond(double value)
        {
            return value * 6.2831853071795862d;
        }

        public static double RadianPerSecondToCyclePerSecond(double baseValue)
        {
            return baseValue / 6.2831853071795862d;
        }
    }
}
