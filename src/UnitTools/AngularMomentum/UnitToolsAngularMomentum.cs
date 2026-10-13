namespace UnitTools.AngularMomentum
{
    using UnitTools.AngularMomentum.Metric;
    using UnitTools.AngularMomentum.Imperial;
    using UnitTools.AngularMomentum.Scientific;

    public enum UnitToolsAngularMomentumUnit
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

    public static class UnitToolsAngularMomentum
    {
        public static double Convert(double value, UnitToolsAngularMomentumUnit from, UnitToolsAngularMomentumUnit to)
        {
            double baseValue = ToKilogramSquareMeterPerSecond(value, from);
            return FromKilogramSquareMeterPerSecond(baseValue, to);
        }

        public static double ToKilogramSquareMeterPerSecond(double value, UnitToolsAngularMomentumUnit from)
        {
            switch (from)
            {
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.NewtonMeterSecond:
                    return UnitToolsMetricAngularMomentum.NewtonMeterSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.JouleSecond:
                    return UnitToolsMetricAngularMomentum.JouleSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitToolsMetricAngularMomentum.GramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitToolsImperialAngularMomentum.PoundSquareFootPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitToolsImperialAngularMomentum.SlugSquareFootPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerMinuteToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitToolsMetricAngularMomentum.GramSquareMeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareCentimeterPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitToolsImperialAngularMomentum.PoundSquareInchPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitToolsImperialAngularMomentum.SlugSquareInchPerSecondToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.PlanckConstant:
                    return UnitToolsScientificAngularMomentum.PlanckConstantToKilogramSquareMeterPerSecond(value);
                case UnitToolsAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitToolsScientificAngularMomentum.ReducedPlanckConstantToKilogramSquareMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angular momentum unit.");
            }
        }

        public static double FromKilogramSquareMeterPerSecond(double baseValue, UnitToolsAngularMomentumUnit to)
        {
            switch (to)
            {
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.NewtonMeterSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToNewtonMeterSecond(baseValue);
                case UnitToolsAngularMomentumUnit.JouleSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToJouleSecond(baseValue);
                case UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToGramSquareCentimeterPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitToolsImperialAngularMomentum.KilogramSquareMeterPerSecondToPoundSquareFootPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitToolsImperialAngularMomentum.KilogramSquareMeterPerSecondToSlugSquareFootPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareMeterPerMinute(baseValue);
                case UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToGramSquareMeterPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitToolsMetricAngularMomentum.KilogramSquareMeterPerSecondToKilogramSquareCentimeterPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitToolsImperialAngularMomentum.KilogramSquareMeterPerSecondToPoundSquareInchPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitToolsImperialAngularMomentum.KilogramSquareMeterPerSecondToSlugSquareInchPerSecond(baseValue);
                case UnitToolsAngularMomentumUnit.PlanckConstant:
                    return UnitToolsScientificAngularMomentum.KilogramSquareMeterPerSecondToPlanckConstant(baseValue);
                case UnitToolsAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitToolsScientificAngularMomentum.KilogramSquareMeterPerSecondToReducedPlanckConstant(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angular momentum unit.");
            }
        }

        public static string GetSymbol(UnitToolsAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return "kg·m²/s";
                case UnitToolsAngularMomentumUnit.NewtonMeterSecond:
                    return "N·m·s";
                case UnitToolsAngularMomentumUnit.JouleSecond:
                    return "J·s";
                case UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return "g·cm²/s";
                case UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond:
                    return "lb·ft²/s";
                case UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond:
                    return "slug·ft²/s";
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return "kg·m²/min";
                case UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond:
                    return "g·m²/s";
                case UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return "kg·cm²/s";
                case UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond:
                    return "lb·in²/s";
                case UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond:
                    return "slug·in²/s";
                case UnitToolsAngularMomentumUnit.PlanckConstant:
                    return "h";
                case UnitToolsAngularMomentumUnit.ReducedPlanckConstant:
                    return "ħ";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return "Kilogram Square Meter Per Second";
                case UnitToolsAngularMomentumUnit.NewtonMeterSecond:
                    return "Newton Meter Second";
                case UnitToolsAngularMomentumUnit.JouleSecond:
                    return "Joule Second";
                case UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return "Gram Square Centimeter Per Second";
                case UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond:
                    return "Pound Square Foot Per Second";
                case UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond:
                    return "Slug Square Foot Per Second";
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return "Kilogram Square Meter Per Minute";
                case UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond:
                    return "Gram Square Meter Per Second";
                case UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return "Kilogram Square Centimeter Per Second";
                case UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond:
                    return "Pound Square Inch Per Second";
                case UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond:
                    return "Slug Square Inch Per Second";
                case UnitToolsAngularMomentumUnit.PlanckConstant:
                    return "Planck Constant";
                case UnitToolsAngularMomentumUnit.ReducedPlanckConstant:
                    return "Reduced Planck Constant";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAngularMomentumUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.NewtonMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.JouleSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAngularMomentumUnit.PlanckConstant:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngularMomentumUnit.ReducedPlanckConstant:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAngularMomentumUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond, UnitToolsAngularMomentumUnit.NewtonMeterSecond, UnitToolsAngularMomentumUnit.JouleSecond, UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond, UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute, UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond, UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond, UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond, UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond, UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAngularMomentumUnit.PlanckConstant, UnitToolsAngularMomentumUnit.ReducedPlanckConstant };
                default:
                    return new[] { UnitToolsAngularMomentumUnit.KilogramSquareMeterPerSecond, UnitToolsAngularMomentumUnit.NewtonMeterSecond, UnitToolsAngularMomentumUnit.JouleSecond, UnitToolsAngularMomentumUnit.GramSquareCentimeterPerSecond, UnitToolsAngularMomentumUnit.PoundSquareFootPerSecond, UnitToolsAngularMomentumUnit.SlugSquareFootPerSecond, UnitToolsAngularMomentumUnit.KilogramSquareMeterPerMinute, UnitToolsAngularMomentumUnit.GramSquareMeterPerSecond, UnitToolsAngularMomentumUnit.KilogramSquareCentimeterPerSecond, UnitToolsAngularMomentumUnit.PoundSquareInchPerSecond, UnitToolsAngularMomentumUnit.SlugSquareInchPerSecond, UnitToolsAngularMomentumUnit.PlanckConstant, UnitToolsAngularMomentumUnit.ReducedPlanckConstant };
            }
        }
    }
}
