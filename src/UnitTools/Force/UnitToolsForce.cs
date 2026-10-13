namespace UnitTools.Force
{
    using UnitTools.Force.Metric;
    using UnitTools.Force.Scientific;
    using UnitTools.Force.Imperial;
    using UnitTools.Force.ImperialUS;
    using UnitTools.Force.ImperialUK;
    using UnitTools.Force.Historical;
    using UnitTools.Force.Engineering;

    public enum UnitToolsForceUnit
    {
        Micronewton = 0,
        Millinewton = 1,
        Newton = 2,
        Kilonewton = 3,
        Meganewton = 4,
        Dyne = 5,
        PoundForce = 6,
        OunceForce = 7,
        Kip = 8,
        Poundal = 9,
        KilogramForce = 10,
        TonForceUS = 11,
        TonForceUK = 12,
        Piconewton = 13,
        Nanonewton = 14,
        GramForce = 15,
        MilligramForce = 16,
        Pond = 17,
        Sthene = 18,
        JoulePerMeter = 19,
        PlanckForce = 20,
    }

    public static class UnitToolsForce
    {
        public static double Convert(double value, UnitToolsForceUnit from, UnitToolsForceUnit to)
        {
            double baseValue = ToNewton(value, from);
            return FromNewton(baseValue, to);
        }

        public static double ToNewton(double value, UnitToolsForceUnit from)
        {
            switch (from)
            {
                case UnitToolsForceUnit.Micronewton:
                    return UnitToolsMetricForce.MicronewtonToNewton(value);
                case UnitToolsForceUnit.Millinewton:
                    return UnitToolsMetricForce.MillinewtonToNewton(value);
                case UnitToolsForceUnit.Newton:
                    return UnitToolsMetricForce.NewtonToNewton(value);
                case UnitToolsForceUnit.Kilonewton:
                    return UnitToolsMetricForce.KilonewtonToNewton(value);
                case UnitToolsForceUnit.Meganewton:
                    return UnitToolsMetricForce.MeganewtonToNewton(value);
                case UnitToolsForceUnit.Dyne:
                    return UnitToolsScientificForce.DyneToNewton(value);
                case UnitToolsForceUnit.PoundForce:
                    return UnitToolsImperialForce.PoundForceToNewton(value);
                case UnitToolsForceUnit.OunceForce:
                    return UnitToolsImperialForce.OunceForceToNewton(value);
                case UnitToolsForceUnit.Kip:
                    return UnitToolsImperialUSForce.KipToNewton(value);
                case UnitToolsForceUnit.Poundal:
                    return UnitToolsImperialForce.PoundalToNewton(value);
                case UnitToolsForceUnit.KilogramForce:
                    return UnitToolsMetricForce.KilogramForceToNewton(value);
                case UnitToolsForceUnit.TonForceUS:
                    return UnitToolsImperialUSForce.TonForceUSToNewton(value);
                case UnitToolsForceUnit.TonForceUK:
                    return UnitToolsImperialUKForce.TonForceUKToNewton(value);
                case UnitToolsForceUnit.Piconewton:
                    return UnitToolsMetricForce.PiconewtonToNewton(value);
                case UnitToolsForceUnit.Nanonewton:
                    return UnitToolsMetricForce.NanonewtonToNewton(value);
                case UnitToolsForceUnit.GramForce:
                    return UnitToolsMetricForce.GramForceToNewton(value);
                case UnitToolsForceUnit.MilligramForce:
                    return UnitToolsMetricForce.MilligramForceToNewton(value);
                case UnitToolsForceUnit.Pond:
                    return UnitToolsHistoricalForce.PondToNewton(value);
                case UnitToolsForceUnit.Sthene:
                    return UnitToolsHistoricalForce.StheneToNewton(value);
                case UnitToolsForceUnit.JoulePerMeter:
                    return UnitToolsEngineeringForce.JoulePerMeterToNewton(value);
                case UnitToolsForceUnit.PlanckForce:
                    return UnitToolsScientificForce.PlanckForceToNewton(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported force unit.");
            }
        }

        public static double FromNewton(double baseValue, UnitToolsForceUnit to)
        {
            switch (to)
            {
                case UnitToolsForceUnit.Micronewton:
                    return UnitToolsMetricForce.NewtonToMicronewton(baseValue);
                case UnitToolsForceUnit.Millinewton:
                    return UnitToolsMetricForce.NewtonToMillinewton(baseValue);
                case UnitToolsForceUnit.Newton:
                    return UnitToolsMetricForce.NewtonToNewton(baseValue);
                case UnitToolsForceUnit.Kilonewton:
                    return UnitToolsMetricForce.NewtonToKilonewton(baseValue);
                case UnitToolsForceUnit.Meganewton:
                    return UnitToolsMetricForce.NewtonToMeganewton(baseValue);
                case UnitToolsForceUnit.Dyne:
                    return UnitToolsScientificForce.NewtonToDyne(baseValue);
                case UnitToolsForceUnit.PoundForce:
                    return UnitToolsImperialForce.NewtonToPoundForce(baseValue);
                case UnitToolsForceUnit.OunceForce:
                    return UnitToolsImperialForce.NewtonToOunceForce(baseValue);
                case UnitToolsForceUnit.Kip:
                    return UnitToolsImperialUSForce.NewtonToKip(baseValue);
                case UnitToolsForceUnit.Poundal:
                    return UnitToolsImperialForce.NewtonToPoundal(baseValue);
                case UnitToolsForceUnit.KilogramForce:
                    return UnitToolsMetricForce.NewtonToKilogramForce(baseValue);
                case UnitToolsForceUnit.TonForceUS:
                    return UnitToolsImperialUSForce.NewtonToTonForceUS(baseValue);
                case UnitToolsForceUnit.TonForceUK:
                    return UnitToolsImperialUKForce.NewtonToTonForceUK(baseValue);
                case UnitToolsForceUnit.Piconewton:
                    return UnitToolsMetricForce.NewtonToPiconewton(baseValue);
                case UnitToolsForceUnit.Nanonewton:
                    return UnitToolsMetricForce.NewtonToNanonewton(baseValue);
                case UnitToolsForceUnit.GramForce:
                    return UnitToolsMetricForce.NewtonToGramForce(baseValue);
                case UnitToolsForceUnit.MilligramForce:
                    return UnitToolsMetricForce.NewtonToMilligramForce(baseValue);
                case UnitToolsForceUnit.Pond:
                    return UnitToolsHistoricalForce.NewtonToPond(baseValue);
                case UnitToolsForceUnit.Sthene:
                    return UnitToolsHistoricalForce.NewtonToSthene(baseValue);
                case UnitToolsForceUnit.JoulePerMeter:
                    return UnitToolsEngineeringForce.NewtonToJoulePerMeter(baseValue);
                case UnitToolsForceUnit.PlanckForce:
                    return UnitToolsScientificForce.NewtonToPlanckForce(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported force unit.");
            }
        }

        public static string GetSymbol(UnitToolsForceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForceUnit.Micronewton:
                    return "µN";
                case UnitToolsForceUnit.Millinewton:
                    return "mN";
                case UnitToolsForceUnit.Newton:
                    return "N";
                case UnitToolsForceUnit.Kilonewton:
                    return "kN";
                case UnitToolsForceUnit.Meganewton:
                    return "MN";
                case UnitToolsForceUnit.Dyne:
                    return "dyn";
                case UnitToolsForceUnit.PoundForce:
                    return "lbf";
                case UnitToolsForceUnit.OunceForce:
                    return "ozf";
                case UnitToolsForceUnit.Kip:
                    return "kip";
                case UnitToolsForceUnit.Poundal:
                    return "pdl";
                case UnitToolsForceUnit.KilogramForce:
                    return "kgf";
                case UnitToolsForceUnit.TonForceUS:
                    return "tonf US";
                case UnitToolsForceUnit.TonForceUK:
                    return "tonf UK";
                case UnitToolsForceUnit.Piconewton:
                    return "pN";
                case UnitToolsForceUnit.Nanonewton:
                    return "nN";
                case UnitToolsForceUnit.GramForce:
                    return "gf";
                case UnitToolsForceUnit.MilligramForce:
                    return "mgf";
                case UnitToolsForceUnit.Pond:
                    return "p";
                case UnitToolsForceUnit.Sthene:
                    return "sn";
                case UnitToolsForceUnit.JoulePerMeter:
                    return "J/m";
                case UnitToolsForceUnit.PlanckForce:
                    return "FP";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsForceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForceUnit.Micronewton:
                    return "micronewton";
                case UnitToolsForceUnit.Millinewton:
                    return "millinewton";
                case UnitToolsForceUnit.Newton:
                    return "newton";
                case UnitToolsForceUnit.Kilonewton:
                    return "kilonewton";
                case UnitToolsForceUnit.Meganewton:
                    return "meganewton";
                case UnitToolsForceUnit.Dyne:
                    return "dyne";
                case UnitToolsForceUnit.PoundForce:
                    return "pound-force";
                case UnitToolsForceUnit.OunceForce:
                    return "ounce-force";
                case UnitToolsForceUnit.Kip:
                    return "kip";
                case UnitToolsForceUnit.Poundal:
                    return "poundal";
                case UnitToolsForceUnit.KilogramForce:
                    return "kilogram-force";
                case UnitToolsForceUnit.TonForceUS:
                    return "US ton-force";
                case UnitToolsForceUnit.TonForceUK:
                    return "UK ton-force";
                case UnitToolsForceUnit.Piconewton:
                    return "Piconewton";
                case UnitToolsForceUnit.Nanonewton:
                    return "Nanonewton";
                case UnitToolsForceUnit.GramForce:
                    return "Gram Force";
                case UnitToolsForceUnit.MilligramForce:
                    return "Milligram Force";
                case UnitToolsForceUnit.Pond:
                    return "Pond";
                case UnitToolsForceUnit.Sthene:
                    return "Sthene";
                case UnitToolsForceUnit.JoulePerMeter:
                    return "Joule Per Meter";
                case UnitToolsForceUnit.PlanckForce:
                    return "Planck Force";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsForceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsForceUnit.Micronewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Millinewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Newton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Kilonewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Meganewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Dyne:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsForceUnit.PoundForce:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForceUnit.OunceForce:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForceUnit.Kip:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsForceUnit.Poundal:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsForceUnit.KilogramForce:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.TonForceUS:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsForceUnit.TonForceUK:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsForceUnit.Piconewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Nanonewton:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.GramForce:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.MilligramForce:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsForceUnit.Pond:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsForceUnit.Sthene:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsForceUnit.JoulePerMeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsForceUnit.PlanckForce:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsForceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsForceUnit.Micronewton, UnitToolsForceUnit.Millinewton, UnitToolsForceUnit.Newton, UnitToolsForceUnit.Kilonewton, UnitToolsForceUnit.Meganewton, UnitToolsForceUnit.KilogramForce, UnitToolsForceUnit.Piconewton, UnitToolsForceUnit.Nanonewton, UnitToolsForceUnit.GramForce, UnitToolsForceUnit.MilligramForce };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsForceUnit.Dyne, UnitToolsForceUnit.PlanckForce };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsForceUnit.PoundForce, UnitToolsForceUnit.OunceForce, UnitToolsForceUnit.Poundal };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsForceUnit.Kip, UnitToolsForceUnit.TonForceUS };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsForceUnit.TonForceUK };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsForceUnit.Pond, UnitToolsForceUnit.Sthene };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsForceUnit.JoulePerMeter };
                default:
                    return new[] { UnitToolsForceUnit.Micronewton, UnitToolsForceUnit.Millinewton, UnitToolsForceUnit.Newton, UnitToolsForceUnit.Kilonewton, UnitToolsForceUnit.Meganewton, UnitToolsForceUnit.Dyne, UnitToolsForceUnit.PoundForce, UnitToolsForceUnit.OunceForce, UnitToolsForceUnit.Kip, UnitToolsForceUnit.Poundal, UnitToolsForceUnit.KilogramForce, UnitToolsForceUnit.TonForceUS, UnitToolsForceUnit.TonForceUK, UnitToolsForceUnit.Piconewton, UnitToolsForceUnit.Nanonewton, UnitToolsForceUnit.GramForce, UnitToolsForceUnit.MilligramForce, UnitToolsForceUnit.Pond, UnitToolsForceUnit.Sthene, UnitToolsForceUnit.JoulePerMeter, UnitToolsForceUnit.PlanckForce };
            }
        }
    }
}
