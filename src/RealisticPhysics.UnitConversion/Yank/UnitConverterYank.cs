namespace RealisticPhysics.UnitConversion.Yank
{
    using RealisticPhysics.UnitConversion.Yank.Metric;
    using RealisticPhysics.UnitConversion.Yank.Scientific;
    using RealisticPhysics.UnitConversion.Yank.Imperial;

    public enum UnitConverterYankUnit
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

    public static class UnitConverterYank
    {
        public static double Convert(double value, UnitConverterYankUnit from, UnitConverterYankUnit to)
        {
            double baseValue = ToNewtonPerSecond(value, from);
            return FromNewtonPerSecond(baseValue, to);
        }

        public static double ToNewtonPerSecond(double value, UnitConverterYankUnit from)
        {
            switch (from)
            {
                case UnitConverterYankUnit.NewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.KilonewtonPerSecond:
                    return UnitConverterMetricYank.KilonewtonPerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.DynePerSecond:
                    return UnitConverterScientificYank.DynePerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.PoundForcePerSecond:
                    return UnitConverterImperialYank.PoundForcePerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.MillinewtonPerSecond:
                    return UnitConverterMetricYank.MillinewtonPerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.MicronewtonPerSecond:
                    return UnitConverterMetricYank.MicronewtonPerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.MeganewtonPerSecond:
                    return UnitConverterMetricYank.MeganewtonPerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.NewtonPerMinute:
                    return UnitConverterMetricYank.NewtonPerMinuteToNewtonPerSecond(value);
                case UnitConverterYankUnit.PoundForcePerMinute:
                    return UnitConverterImperialYank.PoundForcePerMinuteToNewtonPerSecond(value);
                case UnitConverterYankUnit.KilogramForcePerSecond:
                    return UnitConverterMetricYank.KilogramForcePerSecondToNewtonPerSecond(value);
                case UnitConverterYankUnit.OunceForcePerSecond:
                    return UnitConverterImperialYank.OunceForcePerSecondToNewtonPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported yank unit.");
            }
        }

        public static double FromNewtonPerSecond(double baseValue, UnitConverterYankUnit to)
        {
            switch (to)
            {
                case UnitConverterYankUnit.NewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToNewtonPerSecond(baseValue);
                case UnitConverterYankUnit.KilonewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToKilonewtonPerSecond(baseValue);
                case UnitConverterYankUnit.DynePerSecond:
                    return UnitConverterScientificYank.NewtonPerSecondToDynePerSecond(baseValue);
                case UnitConverterYankUnit.PoundForcePerSecond:
                    return UnitConverterImperialYank.NewtonPerSecondToPoundForcePerSecond(baseValue);
                case UnitConverterYankUnit.MillinewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToMillinewtonPerSecond(baseValue);
                case UnitConverterYankUnit.MicronewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToMicronewtonPerSecond(baseValue);
                case UnitConverterYankUnit.MeganewtonPerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToMeganewtonPerSecond(baseValue);
                case UnitConverterYankUnit.NewtonPerMinute:
                    return UnitConverterMetricYank.NewtonPerSecondToNewtonPerMinute(baseValue);
                case UnitConverterYankUnit.PoundForcePerMinute:
                    return UnitConverterImperialYank.NewtonPerSecondToPoundForcePerMinute(baseValue);
                case UnitConverterYankUnit.KilogramForcePerSecond:
                    return UnitConverterMetricYank.NewtonPerSecondToKilogramForcePerSecond(baseValue);
                case UnitConverterYankUnit.OunceForcePerSecond:
                    return UnitConverterImperialYank.NewtonPerSecondToOunceForcePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported yank unit.");
            }
        }

        public static string GetSymbol(UnitConverterYankUnit unit)
        {
            switch (unit)
            {
                case UnitConverterYankUnit.NewtonPerSecond:
                    return "N/s";
                case UnitConverterYankUnit.KilonewtonPerSecond:
                    return "kN/s";
                case UnitConverterYankUnit.DynePerSecond:
                    return "dyn/s";
                case UnitConverterYankUnit.PoundForcePerSecond:
                    return "lbf/s";
                case UnitConverterYankUnit.MillinewtonPerSecond:
                    return "mN/s";
                case UnitConverterYankUnit.MicronewtonPerSecond:
                    return "µN/s";
                case UnitConverterYankUnit.MeganewtonPerSecond:
                    return "MN/s";
                case UnitConverterYankUnit.NewtonPerMinute:
                    return "N/min";
                case UnitConverterYankUnit.PoundForcePerMinute:
                    return "lbf/min";
                case UnitConverterYankUnit.KilogramForcePerSecond:
                    return "kgf/s";
                case UnitConverterYankUnit.OunceForcePerSecond:
                    return "ozf/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterYankUnit unit)
        {
            switch (unit)
            {
                case UnitConverterYankUnit.NewtonPerSecond:
                    return "Newton Per Second";
                case UnitConverterYankUnit.KilonewtonPerSecond:
                    return "Kilonewton Per Second";
                case UnitConverterYankUnit.DynePerSecond:
                    return "Dyne Per Second";
                case UnitConverterYankUnit.PoundForcePerSecond:
                    return "Pound Force Per Second";
                case UnitConverterYankUnit.MillinewtonPerSecond:
                    return "Millinewton Per Second";
                case UnitConverterYankUnit.MicronewtonPerSecond:
                    return "Micronewton Per Second";
                case UnitConverterYankUnit.MeganewtonPerSecond:
                    return "Meganewton Per Second";
                case UnitConverterYankUnit.NewtonPerMinute:
                    return "Newton Per Minute";
                case UnitConverterYankUnit.PoundForcePerMinute:
                    return "Pound Force Per Minute";
                case UnitConverterYankUnit.KilogramForcePerSecond:
                    return "Kilogram Force Per Second";
                case UnitConverterYankUnit.OunceForcePerSecond:
                    return "Ounce Force Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterYankUnit unit)
        {
            switch (unit)
            {
                case UnitConverterYankUnit.NewtonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.KilonewtonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.DynePerSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterYankUnit.PoundForcePerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterYankUnit.MillinewtonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.MicronewtonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.MeganewtonPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.NewtonPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.PoundForcePerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterYankUnit.KilogramForcePerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterYankUnit.OunceForcePerSecond:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterYankUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterYankUnit.NewtonPerSecond, UnitConverterYankUnit.KilonewtonPerSecond, UnitConverterYankUnit.MillinewtonPerSecond, UnitConverterYankUnit.MicronewtonPerSecond, UnitConverterYankUnit.MeganewtonPerSecond, UnitConverterYankUnit.NewtonPerMinute, UnitConverterYankUnit.KilogramForcePerSecond };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterYankUnit.DynePerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterYankUnit.PoundForcePerSecond, UnitConverterYankUnit.PoundForcePerMinute, UnitConverterYankUnit.OunceForcePerSecond };
                default:
                    return new[] { UnitConverterYankUnit.NewtonPerSecond, UnitConverterYankUnit.KilonewtonPerSecond, UnitConverterYankUnit.DynePerSecond, UnitConverterYankUnit.PoundForcePerSecond, UnitConverterYankUnit.MillinewtonPerSecond, UnitConverterYankUnit.MicronewtonPerSecond, UnitConverterYankUnit.MeganewtonPerSecond, UnitConverterYankUnit.NewtonPerMinute, UnitConverterYankUnit.PoundForcePerMinute, UnitConverterYankUnit.KilogramForcePerSecond, UnitConverterYankUnit.OunceForcePerSecond };
            }
        }
    }
}
