namespace RealisticPhysics.UnitConversion.AngularMomentum
{
    using RealisticPhysics.UnitConversion.AngularMomentum.Metric;
    using RealisticPhysics.UnitConversion.AngularMomentum.Imperial;
    using RealisticPhysics.UnitConversion.AngularMomentum.Scientific;

    public enum UnitConverterAngularMomentumUnit
    {
        KilogramSquareMeterPerSecond = 0,
        NewtonMeterSecond = 1,
        JouleSecond = 2,
        GramSquareCentimeterPerSecond = 3,
        PoundSquareFootPerSecond = 4,
        SlugSquareFootPerSecond = 5,
        KilogramSquareMeterPerMinute = 6,
        GramSquareMeterPerSecond = 7,
        KilogramSquareCentimeterPerSecond = 8,
        PoundSquareInchPerSecond = 9,
        SlugSquareInchPerSecond = 10,
        PlanckConstant = 11,
        ReducedPlanckConstant = 12,
    }

    public static class UnitConverterAngularMomentum
    {
        public static double Convert(double value, UnitConverterAngularMomentumUnit from, UnitConverterAngularMomentumUnit to)
        {
            double baseValue = ToKilogramSquareMeterPerSecond(value, from);
            return FromKilogramSquareMeterPerSecond(baseValue, to);
        }

        public static double ToKilogramSquareMeterPerSecond(double value, UnitConverterAngularMomentumUnit from)
        {
            switch (from)
            {
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.NewtonMeterSecond:
                    return UnitConverterMetricAngularMomentum.NewtonMeterSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.JouleSecond:
                    return UnitConverterMetricAngularMomentum.JouleSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitConverterMetricAngularMomentum.GramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitConverterImperialAngularMomentum.PoundSquareFootPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitConverterImperialAngularMomentum.SlugSquareFootPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerMinuteToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitConverterMetricAngularMomentum.GramSquareMeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitConverterImperialAngularMomentum.PoundSquareInchPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitConverterImperialAngularMomentum.SlugSquareInchPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.PlanckConstant:
                    return UnitConverterScientificAngularMomentum.PlanckConstantToKilogramSquareMeterPerSecond(value);
                case UnitConverterAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitConverterScientificAngularMomentum.ReducedPlanckConstantToKilogramSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular momentum unit.");
            }
        }

        public static double FromKilogramSquareMeterPerSecond(double baseValue, UnitConverterAngularMomentumUnit to)
        {
            switch (to)
            {
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.NewtonMeterSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToNewtonMeterSecond(baseValue);
                case UnitConverterAngularMomentumUnit.JouleSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToJouleSecond(baseValue);
                case UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToGramSquareCentimeterPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitConverterImperialAngularMomentum.KilogramSquareMeterPerSecondToPoundSquareFootPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitConverterImperialAngularMomentum.KilogramSquareMeterPerSecondToSlugSquareFootPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerMinute(baseValue);
                case UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToGramSquareMeterPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitConverterMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareCentimeterPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitConverterImperialAngularMomentum.KilogramSquareMeterPerSecondToPoundSquareInchPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitConverterImperialAngularMomentum.KilogramSquareMeterPerSecondToSlugSquareInchPerSecond(baseValue);
                case UnitConverterAngularMomentumUnit.PlanckConstant:
                    return UnitConverterScientificAngularMomentum.KilogramSquareMeterPerSecondToPlanckConstant(baseValue);
                case UnitConverterAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitConverterScientificAngularMomentum.KilogramSquareMeterPerSecondToReducedPlanckConstant(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular momentum unit.");
            }
        }

        public static string GetSymbol(UnitConverterAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return "kg·m²/s";
                case UnitConverterAngularMomentumUnit.NewtonMeterSecond:
                    return "N·m·s";
                case UnitConverterAngularMomentumUnit.JouleSecond:
                    return "J·s";
                case UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return "g·cm²/s";
                case UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond:
                    return "lb·ft²/s";
                case UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond:
                    return "slug·ft²/s";
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return "kg·m²/min";
                case UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond:
                    return "g·m²/s";
                case UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return "kg·cm²/s";
                case UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond:
                    return "lb·in²/s";
                case UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond:
                    return "slug·in²/s";
                case UnitConverterAngularMomentumUnit.PlanckConstant:
                    return "h";
                case UnitConverterAngularMomentumUnit.ReducedPlanckConstant:
                    return "ħ";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return "Kilogram Square Meter Per Second";
                case UnitConverterAngularMomentumUnit.NewtonMeterSecond:
                    return "Newton Meter Second";
                case UnitConverterAngularMomentumUnit.JouleSecond:
                    return "Joule Second";
                case UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return "Gram Square Centimeter Per Second";
                case UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond:
                    return "Pound Square Foot Per Second";
                case UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond:
                    return "Slug Square Foot Per Second";
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return "Kilogram Square Meter Per Minute";
                case UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond:
                    return "Gram Square Meter Per Second";
                case UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return "Kilogram Square Centimeter Per Second";
                case UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond:
                    return "Pound Square Inch Per Second";
                case UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond:
                    return "Slug Square Inch Per Second";
                case UnitConverterAngularMomentumUnit.PlanckConstant:
                    return "Planck Constant";
                case UnitConverterAngularMomentumUnit.ReducedPlanckConstant:
                    return "Reduced Planck Constant";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.NewtonMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.JouleSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAngularMomentumUnit.PlanckConstant:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitConverterUnitSystem.Scientific;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAngularMomentumUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond, UnitConverterAngularMomentumUnit.NewtonMeterSecond, UnitConverterAngularMomentumUnit.JouleSecond, UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond, UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute, UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond, UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond, UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond, UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond, UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAngularMomentumUnit.PlanckConstant, UnitConverterAngularMomentumUnit.ReducedPlanckConstant };
                default:
                    return new[] { UnitConverterAngularMomentumUnit.KilogramSquareMeterPerSecond, UnitConverterAngularMomentumUnit.NewtonMeterSecond, UnitConverterAngularMomentumUnit.JouleSecond, UnitConverterAngularMomentumUnit.GramSquareCentimeterPerSecond, UnitConverterAngularMomentumUnit.PoundSquareFootPerSecond, UnitConverterAngularMomentumUnit.SlugSquareFootPerSecond, UnitConverterAngularMomentumUnit.KilogramSquareMeterPerMinute, UnitConverterAngularMomentumUnit.GramSquareMeterPerSecond, UnitConverterAngularMomentumUnit.KilogramSquareCentimeterPerSecond, UnitConverterAngularMomentumUnit.PoundSquareInchPerSecond, UnitConverterAngularMomentumUnit.SlugSquareInchPerSecond, UnitConverterAngularMomentumUnit.PlanckConstant, UnitConverterAngularMomentumUnit.ReducedPlanckConstant };
            }
        }
    }
}
