namespace UnitTools.Yank
{
    using UnitTools.Yank.Metric;
    using UnitTools.Yank.Scientific;
    using UnitTools.Yank.Imperial;

    public enum UnitToolsYankUnit
    {
        NewtonPerSecond = 0,
        KilonewtonPerSecond = 1,
        DynePerSecond = 2,
        PoundForcePerSecond = 3,
        MillinewtonPerSecond = 4,
        MicronewtonPerSecond = 5,
        MeganewtonPerSecond = 6,
        NewtonPerMinute = 7,
        PoundForcePerMinute = 8,
        KilogramForcePerSecond = 9,
        OunceForcePerSecond = 10,
    }

    public static class UnitToolsYank
    {
        public static double Convert(double value, UnitToolsYankUnit from, UnitToolsYankUnit to)
        {
            double baseValue = ToNewtonPerSecond(value, from);
            return FromNewtonPerSecond(baseValue, to);
        }

        public static double ToNewtonPerSecond(double value, UnitToolsYankUnit from)
        {
            switch (from)
            {
                case UnitToolsYankUnit.NewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.KilonewtonPerSecond:
                    return UnitToolsMetricYank.KilonewtonPerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.DynePerSecond:
                    return UnitToolsScientificYank.DynePerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.PoundForcePerSecond:
                    return UnitToolsImperialYank.PoundForcePerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.MillinewtonPerSecond:
                    return UnitToolsMetricYank.MillinewtonPerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.MicronewtonPerSecond:
                    return UnitToolsMetricYank.MicronewtonPerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.MeganewtonPerSecond:
                    return UnitToolsMetricYank.MeganewtonPerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.NewtonPerMinute:
                    return UnitToolsMetricYank.NewtonPerMinuteToNewtonPerSecond(value);
                case UnitToolsYankUnit.PoundForcePerMinute:
                    return UnitToolsImperialYank.PoundForcePerMinuteToNewtonPerSecond(value);
                case UnitToolsYankUnit.KilogramForcePerSecond:
                    return UnitToolsMetricYank.KilogramForcePerSecondToNewtonPerSecond(value);
                case UnitToolsYankUnit.OunceForcePerSecond:
                    return UnitToolsImperialYank.OunceForcePerSecondToNewtonPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported yank unit.");
            }
        }

        public static double FromNewtonPerSecond(double baseValue, UnitToolsYankUnit to)
        {
            switch (to)
            {
                case UnitToolsYankUnit.NewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToNewtonPerSecond(baseValue);
                case UnitToolsYankUnit.KilonewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToKilonewtonPerSecond(baseValue);
                case UnitToolsYankUnit.DynePerSecond:
                    return UnitToolsScientificYank.NewtonPerSecondToDynePerSecond(baseValue);
                case UnitToolsYankUnit.PoundForcePerSecond:
                    return UnitToolsImperialYank.NewtonPerSecondToPoundForcePerSecond(baseValue);
                case UnitToolsYankUnit.MillinewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToMillinewtonPerSecond(baseValue);
                case UnitToolsYankUnit.MicronewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToMicronewtonPerSecond(baseValue);
                case UnitToolsYankUnit.MeganewtonPerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToMeganewtonPerSecond(baseValue);
                case UnitToolsYankUnit.NewtonPerMinute:
                    return UnitToolsMetricYank.NewtonPerSecondToNewtonPerMinute(baseValue);
                case UnitToolsYankUnit.PoundForcePerMinute:
                    return UnitToolsImperialYank.NewtonPerSecondToPoundForcePerMinute(baseValue);
                case UnitToolsYankUnit.KilogramForcePerSecond:
                    return UnitToolsMetricYank.NewtonPerSecondToKilogramForcePerSecond(baseValue);
                case UnitToolsYankUnit.OunceForcePerSecond:
                    return UnitToolsImperialYank.NewtonPerSecondToOunceForcePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported yank unit.");
            }
        }

        public static string GetSymbol(UnitToolsYankUnit unit)
        {
            switch (unit)
            {
                case UnitToolsYankUnit.NewtonPerSecond:
                    return "N/s";
                case UnitToolsYankUnit.KilonewtonPerSecond:
                    return "kN/s";
                case UnitToolsYankUnit.DynePerSecond:
                    return "dyn/s";
                case UnitToolsYankUnit.PoundForcePerSecond:
                    return "lbf/s";
                case UnitToolsYankUnit.MillinewtonPerSecond:
                    return "mN/s";
                case UnitToolsYankUnit.MicronewtonPerSecond:
                    return "µN/s";
                case UnitToolsYankUnit.MeganewtonPerSecond:
                    return "MN/s";
                case UnitToolsYankUnit.NewtonPerMinute:
                    return "N/min";
                case UnitToolsYankUnit.PoundForcePerMinute:
                    return "lbf/min";
                case UnitToolsYankUnit.KilogramForcePerSecond:
                    return "kgf/s";
                case UnitToolsYankUnit.OunceForcePerSecond:
                    return "ozf/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsYankUnit unit)
        {
            switch (unit)
            {
                case UnitToolsYankUnit.NewtonPerSecond:
                    return "Newton Per Second";
                case UnitToolsYankUnit.KilonewtonPerSecond:
                    return "Kilonewton Per Second";
                case UnitToolsYankUnit.DynePerSecond:
                    return "Dyne Per Second";
                case UnitToolsYankUnit.PoundForcePerSecond:
                    return "Pound Force Per Second";
                case UnitToolsYankUnit.MillinewtonPerSecond:
                    return "Millinewton Per Second";
                case UnitToolsYankUnit.MicronewtonPerSecond:
                    return "Micronewton Per Second";
                case UnitToolsYankUnit.MeganewtonPerSecond:
                    return "Meganewton Per Second";
                case UnitToolsYankUnit.NewtonPerMinute:
                    return "Newton Per Minute";
                case UnitToolsYankUnit.PoundForcePerMinute:
                    return "Pound Force Per Minute";
                case UnitToolsYankUnit.KilogramForcePerSecond:
                    return "Kilogram Force Per Second";
                case UnitToolsYankUnit.OunceForcePerSecond:
                    return "Ounce Force Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsYankUnit unit)
        {
            switch (unit)
            {
                case UnitToolsYankUnit.NewtonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.KilonewtonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.DynePerSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsYankUnit.PoundForcePerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsYankUnit.MillinewtonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.MicronewtonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.MeganewtonPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.NewtonPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.PoundForcePerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsYankUnit.KilogramForcePerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsYankUnit.OunceForcePerSecond:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsYankUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsYankUnit.NewtonPerSecond, UnitToolsYankUnit.KilonewtonPerSecond, UnitToolsYankUnit.MillinewtonPerSecond, UnitToolsYankUnit.MicronewtonPerSecond, UnitToolsYankUnit.MeganewtonPerSecond, UnitToolsYankUnit.NewtonPerMinute, UnitToolsYankUnit.KilogramForcePerSecond };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsYankUnit.DynePerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsYankUnit.PoundForcePerSecond, UnitToolsYankUnit.PoundForcePerMinute, UnitToolsYankUnit.OunceForcePerSecond };
                default:
                    return new[] { UnitToolsYankUnit.NewtonPerSecond, UnitToolsYankUnit.KilonewtonPerSecond, UnitToolsYankUnit.DynePerSecond, UnitToolsYankUnit.PoundForcePerSecond, UnitToolsYankUnit.MillinewtonPerSecond, UnitToolsYankUnit.MicronewtonPerSecond, UnitToolsYankUnit.MeganewtonPerSecond, UnitToolsYankUnit.NewtonPerMinute, UnitToolsYankUnit.PoundForcePerMinute, UnitToolsYankUnit.KilogramForcePerSecond, UnitToolsYankUnit.OunceForcePerSecond };
            }
        }
    }
}
