namespace RealisticPhysics.UnitConversion.MassFlux
{
    using RealisticPhysics.UnitConversion.MassFlux.Metric;
    using RealisticPhysics.UnitConversion.MassFlux.Imperial;

    public enum UnitConverterMassFluxUnit
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

    public static class UnitConverterMassFlux
    {
        public static double Convert(double value, UnitConverterMassFluxUnit from, UnitConverterMassFluxUnit to)
        {
            double baseValue = ToKilogramPerSquareMeterSecond(value, from);
            return FromKilogramPerSquareMeterSecond(baseValue, to);
        }

        public static double ToKilogramPerSquareMeterSecond(double value, UnitConverterMassFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.GramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterHourToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitConverterMetricMassFlux.GramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitConverterImperialMassFlux.PoundPerSquareFootSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.MilligramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.MicrogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareCentimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMillimeterSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitConverterImperialMassFlux.OuncePerSquareFootSecondToKilogramPerSquareMeterSecond(value);
                case UnitConverterMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitConverterImperialMassFlux.PoundPerSquareInchSecondToKilogramPerSquareMeterSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported mass flux unit.");
            }
        }

        public static double FromKilogramPerSquareMeterSecond(double baseValue, UnitConverterMassFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterSecond(baseValue);
                case UnitConverterMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToGramPerSquareMeterSecond(baseValue);
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMeterHour(baseValue);
                case UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToGramPerSquareCentimeterSecond(baseValue);
                case UnitConverterMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitConverterImperialMassFlux.KilogramPerSquareMeterSecondToPoundPerSquareFootSecond(baseValue);
                case UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToMilligramPerSquareMeterSecond(baseValue);
                case UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToMicrogramPerSquareMeterSecond(baseValue);
                case UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareCentimeterSecond(baseValue);
                case UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitConverterMetricMassFlux.KilogramPerSquareMeterSecondToKilogramPerSquareMillimeterSecond(baseValue);
                case UnitConverterMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitConverterImperialMassFlux.KilogramPerSquareMeterSecondToOuncePerSquareFootSecond(baseValue);
                case UnitConverterMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitConverterImperialMassFlux.KilogramPerSquareMeterSecondToPoundPerSquareInchSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported mass flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond:
                    return "kg/(m²·s)";
                case UnitConverterMassFluxUnit.GramPerSquareMeterSecond:
                    return "g/(m²·s)";
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterHour:
                    return "kg/(m²·h)";
                case UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond:
                    return "g/(cm²·s)";
                case UnitConverterMassFluxUnit.PoundPerSquareFootSecond:
                    return "lb/(ft²·s)";
                case UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond:
                    return "mg/(m²·s)";
                case UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return "µg/(m²·s)";
                case UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return "kg/(cm²·s)";
                case UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return "kg/(mm²·s)";
                case UnitConverterMassFluxUnit.OuncePerSquareFootSecond:
                    return "oz/(ft²·s)";
                case UnitConverterMassFluxUnit.PoundPerSquareInchSecond:
                    return "lb/(in²·s)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond:
                    return "Kilogram Per Square Meter Second";
                case UnitConverterMassFluxUnit.GramPerSquareMeterSecond:
                    return "Gram Per Square Meter Second";
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterHour:
                    return "Kilogram Per Square Meter Hour";
                case UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond:
                    return "Gram Per Square Centimeter Second";
                case UnitConverterMassFluxUnit.PoundPerSquareFootSecond:
                    return "Pound Per Square Foot Second";
                case UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond:
                    return "Milligram Per Square Meter Second";
                case UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return "Microgram Per Square Meter Second";
                case UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return "Kilogram Per Square Centimeter Second";
                case UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return "Kilogram Per Square Millimeter Second";
                case UnitConverterMassFluxUnit.OuncePerSquareFootSecond:
                    return "Ounce Per Square Foot Second";
                case UnitConverterMassFluxUnit.PoundPerSquareInchSecond:
                    return "Pound Per Square Inch Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterMassFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.GramPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.KilogramPerSquareMeterHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.PoundPerSquareFootSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterMassFluxUnit.OuncePerSquareFootSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterMassFluxUnit.PoundPerSquareInchSecond:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterMassFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond, UnitConverterMassFluxUnit.GramPerSquareMeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareMeterHour, UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond, UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond, UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterMassFluxUnit.PoundPerSquareFootSecond, UnitConverterMassFluxUnit.OuncePerSquareFootSecond, UnitConverterMassFluxUnit.PoundPerSquareInchSecond };
                default:
                    return new[] { UnitConverterMassFluxUnit.KilogramPerSquareMeterSecond, UnitConverterMassFluxUnit.GramPerSquareMeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareMeterHour, UnitConverterMassFluxUnit.GramPerSquareCentimeterSecond, UnitConverterMassFluxUnit.PoundPerSquareFootSecond, UnitConverterMassFluxUnit.MilligramPerSquareMeterSecond, UnitConverterMassFluxUnit.MicrogramPerSquareMeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareCentimeterSecond, UnitConverterMassFluxUnit.KilogramPerSquareMillimeterSecond, UnitConverterMassFluxUnit.OuncePerSquareFootSecond, UnitConverterMassFluxUnit.PoundPerSquareInchSecond };
            }
        }
    }
}
