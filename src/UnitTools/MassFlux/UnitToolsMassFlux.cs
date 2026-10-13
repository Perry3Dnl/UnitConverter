namespace UnitTools.MassFlux
{
    using UnitTools.MassFlux.Metric;
    using UnitTools.MassFlux.Imperial;

    public enum UnitToolsMassFluxUnit
    {
        KilogramPerSquareMeterSecond = 0,
        GramPerSquareMeterSecond = 1,
        KilogramPerSquareMeterHour = 2,
        GramPerSquareCentimeterSecond = 3,
        PoundPerSquareFootSecond = 4,
        MilligramPerSquareMeterSecond = 5,
        MicrogramPerSquareMeterSecond = 6,
        KilogramPerSquareCentimeterSecond = 7,
        KilogramPerSquareMillimeterSecond = 8,
        OuncePerSquareFootSecond = 9,
        PoundPerSquareInchSecond = 10,
    }

    public static class UnitToolsMassFlux
    {
        public static double Convert(double value, UnitToolsMassFluxUnit from, UnitToolsMassFluxUnit to)
        {
            double baseValue = ToKilogramPerSquareMeterSecond(value, from);
            return FromKilogramPerSquareMeterSecond(baseValue, to);
        }

        public static double ToKilogramPerSquareMeterSecond(double value, UnitToolsMassFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.GramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterHourToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitToolsMetricMassFlux.GramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitToolsImperialMassFlux.PoundPerSquareFootSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.MilligramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.MicrogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMillimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitToolsImperialMassFlux.OuncePerSquareFootSecondToKilogramPerSquareMeterSecond(value);
                case UnitToolsMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitToolsImperialMassFlux.PoundPerSquareInchSecondToKilogramPerSquareMeterSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass flux unit.");
            }
        }

        public static double FromKilogramPerSquareMeterSecond(double baseValue, UnitToolsMassFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(baseValue);
                case UnitToolsMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToGramPerSquareMeterSecond(baseValue);
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterHour(baseValue);
                case UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToGramPerSquareCentimeterSecond(baseValue);
                case UnitToolsMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitToolsImperialMassFlux.KilogramPerSquareMeterSecondToPoundPerSquareFootSecond(baseValue);
                case UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToMilligramPerSquareMeterSecond(baseValue);
                case UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToMicrogramPerSquareMeterSecond(baseValue);
                case UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareCentimeterSecond(baseValue);
                case UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitToolsMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMillimeterSecond(baseValue);
                case UnitToolsMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitToolsImperialMassFlux.KilogramPerSquareMeterSecondToOuncePerSquareFootSecond(baseValue);
                case UnitToolsMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitToolsImperialMassFlux.KilogramPerSquareMeterSecondToPoundPerSquareInchSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond:
                    return "kg/(m²·s)";
                case UnitToolsMassFluxUnit.GramPerSquareMeterSecond:
                    return "g/(m²·s)";
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterHour:
                    return "kg/(m²·h)";
                case UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond:
                    return "g/(cm²·s)";
                case UnitToolsMassFluxUnit.PoundPerSquareFootSecond:
                    return "lb/(ft²·s)";
                case UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond:
                    return "mg/(m²·s)";
                case UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return "µg/(m²·s)";
                case UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return "kg/(cm²·s)";
                case UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return "kg/(mm²·s)";
                case UnitToolsMassFluxUnit.OuncePerSquareFootSecond:
                    return "oz/(ft²·s)";
                case UnitToolsMassFluxUnit.PoundPerSquareInchSecond:
                    return "lb/(in²·s)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond:
                    return "Kilogram Per Square Meter Second";
                case UnitToolsMassFluxUnit.GramPerSquareMeterSecond:
                    return "Gram Per Square Meter Second";
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterHour:
                    return "Kilogram Per Square Meter Hour";
                case UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond:
                    return "Gram Per Square Centimeter Second";
                case UnitToolsMassFluxUnit.PoundPerSquareFootSecond:
                    return "Pound Per Square Foot Second";
                case UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond:
                    return "Milligram Per Square Meter Second";
                case UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return "Microgram Per Square Meter Second";
                case UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return "Kilogram Per Square Centimeter Second";
                case UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return "Kilogram Per Square Millimeter Second";
                case UnitToolsMassFluxUnit.OuncePerSquareFootSecond:
                    return "Ounce Per Square Foot Second";
                case UnitToolsMassFluxUnit.PoundPerSquareInchSecond:
                    return "Pound Per Square Inch Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsMassFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond, UnitToolsMassFluxUnit.GramPerSquareMeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareMeterHour, UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond, UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond, UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsMassFluxUnit.PoundPerSquareFootSecond, UnitToolsMassFluxUnit.OuncePerSquareFootSecond, UnitToolsMassFluxUnit.PoundPerSquareInchSecond };
                default:
                    return new[] { UnitToolsMassFluxUnit.KilogramPerSquareMeterSecond, UnitToolsMassFluxUnit.GramPerSquareMeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareMeterHour, UnitToolsMassFluxUnit.GramPerSquareCentimeterSecond, UnitToolsMassFluxUnit.PoundPerSquareFootSecond, UnitToolsMassFluxUnit.MilligramPerSquareMeterSecond, UnitToolsMassFluxUnit.MicrogramPerSquareMeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareCentimeterSecond, UnitToolsMassFluxUnit.KilogramPerSquareMillimeterSecond, UnitToolsMassFluxUnit.OuncePerSquareFootSecond, UnitToolsMassFluxUnit.PoundPerSquareInchSecond };
            }
        }
    }
}
