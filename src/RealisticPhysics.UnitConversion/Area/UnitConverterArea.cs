namespace RealisticPhysics.UnitConversion.Area
{
    using RealisticPhysics.UnitConversion.Area.Metric;
    using RealisticPhysics.UnitConversion.Area.Imperial;
    using RealisticPhysics.UnitConversion.Area.ImperialUK;
    using RealisticPhysics.UnitConversion.Area.ImperialUS;
    using RealisticPhysics.UnitConversion.Area.Scientific;
    using RealisticPhysics.UnitConversion.Area.Survey;
    using RealisticPhysics.UnitConversion.Area.Historical;

    public enum UnitConverterAreaUnit
    {
        SquareMillimeter = 0,
        SquareCentimeter = 1,
        SquareMeter = 2,
        Are = 3,
        Hectare = 4,
        SquareKilometer = 5,
        SquareInch = 6,
        SquareFoot = 7,
        SquareYard = 8,
        Acre = 9,
        SquareMile = 10,
        Rood = 11,
        Township = 12,
        Barn = 13,
        SquareNanometer = 14,
        SquareMicrometer = 15,
        SquareDecimeter = 16,
        SquareDecameter = 17,
        SquareHectometer = 18,
        SquareMegameter = 19,
        SquareThou = 20,
        CircularMil = 21,
        SquareRod = 22,
        SquarePole = 23,
        SquarePerch = 24,
        SquareChain = 25,
        SquareFurlong = 26,
        Section = 27,
        Homestead = 28,
        SquareLeague = 29,
        Dunam = 30,
        Tatami = 31,
    }

    public static class UnitConverterArea
    {
        public static double Convert(double value, UnitConverterAreaUnit from, UnitConverterAreaUnit to)
        {
            double baseValue = ToSquareMeter(value, from);
            return FromSquareMeter(baseValue, to);
        }

        public static double ToSquareMeter(double value, UnitConverterAreaUnit from)
        {
            switch (from)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return UnitConverterMetricArea.SquareMillimeterToSquareMeter(value);
                case UnitConverterAreaUnit.SquareCentimeter:
                    return UnitConverterMetricArea.SquareCentimeterToSquareMeter(value);
                case UnitConverterAreaUnit.SquareMeter:
                    return UnitConverterMetricArea.SquareMeterToSquareMeter(value);
                case UnitConverterAreaUnit.Are:
                    return UnitConverterMetricArea.AreToSquareMeter(value);
                case UnitConverterAreaUnit.Hectare:
                    return UnitConverterMetricArea.HectareToSquareMeter(value);
                case UnitConverterAreaUnit.SquareKilometer:
                    return UnitConverterMetricArea.SquareKilometerToSquareMeter(value);
                case UnitConverterAreaUnit.SquareInch:
                    return UnitConverterImperialArea.SquareInchToSquareMeter(value);
                case UnitConverterAreaUnit.SquareFoot:
                    return UnitConverterImperialArea.SquareFootToSquareMeter(value);
                case UnitConverterAreaUnit.SquareYard:
                    return UnitConverterImperialArea.SquareYardToSquareMeter(value);
                case UnitConverterAreaUnit.Acre:
                    return UnitConverterImperialArea.AcreToSquareMeter(value);
                case UnitConverterAreaUnit.SquareMile:
                    return UnitConverterImperialArea.SquareMileToSquareMeter(value);
                case UnitConverterAreaUnit.Rood:
                    return UnitConverterImperialUKArea.RoodToSquareMeter(value);
                case UnitConverterAreaUnit.Township:
                    return UnitConverterImperialUSArea.TownshipToSquareMeter(value);
                case UnitConverterAreaUnit.Barn:
                    return UnitConverterScientificArea.BarnToSquareMeter(value);
                case UnitConverterAreaUnit.SquareNanometer:
                    return UnitConverterMetricArea.SquareNanometerToSquareMeter(value);
                case UnitConverterAreaUnit.SquareMicrometer:
                    return UnitConverterMetricArea.SquareMicrometerToSquareMeter(value);
                case UnitConverterAreaUnit.SquareDecimeter:
                    return UnitConverterMetricArea.SquareDecimeterToSquareMeter(value);
                case UnitConverterAreaUnit.SquareDecameter:
                    return UnitConverterMetricArea.SquareDecameterToSquareMeter(value);
                case UnitConverterAreaUnit.SquareHectometer:
                    return UnitConverterMetricArea.SquareHectometerToSquareMeter(value);
                case UnitConverterAreaUnit.SquareMegameter:
                    return UnitConverterMetricArea.SquareMegameterToSquareMeter(value);
                case UnitConverterAreaUnit.SquareThou:
                    return UnitConverterImperialArea.SquareThouToSquareMeter(value);
                case UnitConverterAreaUnit.CircularMil:
                    return UnitConverterImperialArea.CircularMilToSquareMeter(value);
                case UnitConverterAreaUnit.SquareRod:
                    return UnitConverterSurveyArea.SquareRodToSquareMeter(value);
                case UnitConverterAreaUnit.SquarePole:
                    return UnitConverterSurveyArea.SquarePoleToSquareMeter(value);
                case UnitConverterAreaUnit.SquarePerch:
                    return UnitConverterSurveyArea.SquarePerchToSquareMeter(value);
                case UnitConverterAreaUnit.SquareChain:
                    return UnitConverterSurveyArea.SquareChainToSquareMeter(value);
                case UnitConverterAreaUnit.SquareFurlong:
                    return UnitConverterSurveyArea.SquareFurlongToSquareMeter(value);
                case UnitConverterAreaUnit.Section:
                    return UnitConverterSurveyArea.SectionToSquareMeter(value);
                case UnitConverterAreaUnit.Homestead:
                    return UnitConverterSurveyArea.HomesteadToSquareMeter(value);
                case UnitConverterAreaUnit.SquareLeague:
                    return UnitConverterHistoricalArea.SquareLeagueToSquareMeter(value);
                case UnitConverterAreaUnit.Dunam:
                    return UnitConverterHistoricalArea.DunamToSquareMeter(value);
                case UnitConverterAreaUnit.Tatami:
                    return UnitConverterHistoricalArea.TatamiToSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported area unit.");
            }
        }

        public static double FromSquareMeter(double baseValue, UnitConverterAreaUnit to)
        {
            switch (to)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return UnitConverterMetricArea.SquareMeterToSquareMillimeter(baseValue);
                case UnitConverterAreaUnit.SquareCentimeter:
                    return UnitConverterMetricArea.SquareMeterToSquareCentimeter(baseValue);
                case UnitConverterAreaUnit.SquareMeter:
                    return UnitConverterMetricArea.SquareMeterToSquareMeter(baseValue);
                case UnitConverterAreaUnit.Are:
                    return UnitConverterMetricArea.SquareMeterToAre(baseValue);
                case UnitConverterAreaUnit.Hectare:
                    return UnitConverterMetricArea.SquareMeterToHectare(baseValue);
                case UnitConverterAreaUnit.SquareKilometer:
                    return UnitConverterMetricArea.SquareMeterToSquareKilometer(baseValue);
                case UnitConverterAreaUnit.SquareInch:
                    return UnitConverterImperialArea.SquareMeterToSquareInch(baseValue);
                case UnitConverterAreaUnit.SquareFoot:
                    return UnitConverterImperialArea.SquareMeterToSquareFoot(baseValue);
                case UnitConverterAreaUnit.SquareYard:
                    return UnitConverterImperialArea.SquareMeterToSquareYard(baseValue);
                case UnitConverterAreaUnit.Acre:
                    return UnitConverterImperialArea.SquareMeterToAcre(baseValue);
                case UnitConverterAreaUnit.SquareMile:
                    return UnitConverterImperialArea.SquareMeterToSquareMile(baseValue);
                case UnitConverterAreaUnit.Rood:
                    return UnitConverterImperialUKArea.SquareMeterToRood(baseValue);
                case UnitConverterAreaUnit.Township:
                    return UnitConverterImperialUSArea.SquareMeterToTownship(baseValue);
                case UnitConverterAreaUnit.Barn:
                    return UnitConverterScientificArea.SquareMeterToBarn(baseValue);
                case UnitConverterAreaUnit.SquareNanometer:
                    return UnitConverterMetricArea.SquareMeterToSquareNanometer(baseValue);
                case UnitConverterAreaUnit.SquareMicrometer:
                    return UnitConverterMetricArea.SquareMeterToSquareMicrometer(baseValue);
                case UnitConverterAreaUnit.SquareDecimeter:
                    return UnitConverterMetricArea.SquareMeterToSquareDecimeter(baseValue);
                case UnitConverterAreaUnit.SquareDecameter:
                    return UnitConverterMetricArea.SquareMeterToSquareDecameter(baseValue);
                case UnitConverterAreaUnit.SquareHectometer:
                    return UnitConverterMetricArea.SquareMeterToSquareHectometer(baseValue);
                case UnitConverterAreaUnit.SquareMegameter:
                    return UnitConverterMetricArea.SquareMeterToSquareMegameter(baseValue);
                case UnitConverterAreaUnit.SquareThou:
                    return UnitConverterImperialArea.SquareMeterToSquareThou(baseValue);
                case UnitConverterAreaUnit.CircularMil:
                    return UnitConverterImperialArea.SquareMeterToCircularMil(baseValue);
                case UnitConverterAreaUnit.SquareRod:
                    return UnitConverterSurveyArea.SquareMeterToSquareRod(baseValue);
                case UnitConverterAreaUnit.SquarePole:
                    return UnitConverterSurveyArea.SquareMeterToSquarePole(baseValue);
                case UnitConverterAreaUnit.SquarePerch:
                    return UnitConverterSurveyArea.SquareMeterToSquarePerch(baseValue);
                case UnitConverterAreaUnit.SquareChain:
                    return UnitConverterSurveyArea.SquareMeterToSquareChain(baseValue);
                case UnitConverterAreaUnit.SquareFurlong:
                    return UnitConverterSurveyArea.SquareMeterToSquareFurlong(baseValue);
                case UnitConverterAreaUnit.Section:
                    return UnitConverterSurveyArea.SquareMeterToSection(baseValue);
                case UnitConverterAreaUnit.Homestead:
                    return UnitConverterSurveyArea.SquareMeterToHomestead(baseValue);
                case UnitConverterAreaUnit.SquareLeague:
                    return UnitConverterHistoricalArea.SquareMeterToSquareLeague(baseValue);
                case UnitConverterAreaUnit.Dunam:
                    return UnitConverterHistoricalArea.SquareMeterToDunam(baseValue);
                case UnitConverterAreaUnit.Tatami:
                    return UnitConverterHistoricalArea.SquareMeterToTatami(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported area unit.");
            }
        }

        public static string GetSymbol(UnitConverterAreaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return "mm²";
                case UnitConverterAreaUnit.SquareCentimeter:
                    return "cm²";
                case UnitConverterAreaUnit.SquareMeter:
                    return "m²";
                case UnitConverterAreaUnit.Are:
                    return "a";
                case UnitConverterAreaUnit.Hectare:
                    return "ha";
                case UnitConverterAreaUnit.SquareKilometer:
                    return "km²";
                case UnitConverterAreaUnit.SquareInch:
                    return "in²";
                case UnitConverterAreaUnit.SquareFoot:
                    return "ft²";
                case UnitConverterAreaUnit.SquareYard:
                    return "yd²";
                case UnitConverterAreaUnit.Acre:
                    return "ac";
                case UnitConverterAreaUnit.SquareMile:
                    return "mi²";
                case UnitConverterAreaUnit.Rood:
                    return "rood";
                case UnitConverterAreaUnit.Township:
                    return "twp";
                case UnitConverterAreaUnit.Barn:
                    return "b";
                case UnitConverterAreaUnit.SquareNanometer:
                    return "nm²";
                case UnitConverterAreaUnit.SquareMicrometer:
                    return "µm²";
                case UnitConverterAreaUnit.SquareDecimeter:
                    return "dm²";
                case UnitConverterAreaUnit.SquareDecameter:
                    return "dam²";
                case UnitConverterAreaUnit.SquareHectometer:
                    return "hm²";
                case UnitConverterAreaUnit.SquareMegameter:
                    return "Mm²";
                case UnitConverterAreaUnit.SquareThou:
                    return "thou²";
                case UnitConverterAreaUnit.CircularMil:
                    return "cmil";
                case UnitConverterAreaUnit.SquareRod:
                    return "rod²";
                case UnitConverterAreaUnit.SquarePole:
                    return "pole²";
                case UnitConverterAreaUnit.SquarePerch:
                    return "perch²";
                case UnitConverterAreaUnit.SquareChain:
                    return "chain²";
                case UnitConverterAreaUnit.SquareFurlong:
                    return "fur²";
                case UnitConverterAreaUnit.Section:
                    return "section";
                case UnitConverterAreaUnit.Homestead:
                    return "homestead";
                case UnitConverterAreaUnit.SquareLeague:
                    return "lea²";
                case UnitConverterAreaUnit.Dunam:
                    return "dunam";
                case UnitConverterAreaUnit.Tatami:
                    return "tatami";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterAreaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return "square millimeter";
                case UnitConverterAreaUnit.SquareCentimeter:
                    return "square centimeter";
                case UnitConverterAreaUnit.SquareMeter:
                    return "square meter";
                case UnitConverterAreaUnit.Are:
                    return "are";
                case UnitConverterAreaUnit.Hectare:
                    return "hectare";
                case UnitConverterAreaUnit.SquareKilometer:
                    return "square kilometer";
                case UnitConverterAreaUnit.SquareInch:
                    return "square inch";
                case UnitConverterAreaUnit.SquareFoot:
                    return "square foot";
                case UnitConverterAreaUnit.SquareYard:
                    return "square yard";
                case UnitConverterAreaUnit.Acre:
                    return "acre";
                case UnitConverterAreaUnit.SquareMile:
                    return "square mile";
                case UnitConverterAreaUnit.Rood:
                    return "rood";
                case UnitConverterAreaUnit.Township:
                    return "township";
                case UnitConverterAreaUnit.Barn:
                    return "barn";
                case UnitConverterAreaUnit.SquareNanometer:
                    return "Square Nanometer";
                case UnitConverterAreaUnit.SquareMicrometer:
                    return "Square Micrometer";
                case UnitConverterAreaUnit.SquareDecimeter:
                    return "Square Decimeter";
                case UnitConverterAreaUnit.SquareDecameter:
                    return "Square Decameter";
                case UnitConverterAreaUnit.SquareHectometer:
                    return "Square Hectometer";
                case UnitConverterAreaUnit.SquareMegameter:
                    return "Square Megameter";
                case UnitConverterAreaUnit.SquareThou:
                    return "Square Thou";
                case UnitConverterAreaUnit.CircularMil:
                    return "Circular Mil";
                case UnitConverterAreaUnit.SquareRod:
                    return "Square Rod";
                case UnitConverterAreaUnit.SquarePole:
                    return "Square Pole";
                case UnitConverterAreaUnit.SquarePerch:
                    return "Square Perch";
                case UnitConverterAreaUnit.SquareChain:
                    return "Square Chain";
                case UnitConverterAreaUnit.SquareFurlong:
                    return "Square Furlong";
                case UnitConverterAreaUnit.Section:
                    return "Section";
                case UnitConverterAreaUnit.Homestead:
                    return "Homestead";
                case UnitConverterAreaUnit.SquareLeague:
                    return "Square League";
                case UnitConverterAreaUnit.Dunam:
                    return "Dunam";
                case UnitConverterAreaUnit.Tatami:
                    return "Tatami";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterAreaUnit unit)
        {
            switch (unit)
            {
                case UnitConverterAreaUnit.SquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.Are:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.Hectare:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.SquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.SquareYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.Acre:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.SquareMile:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.Rood:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterAreaUnit.Township:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterAreaUnit.Barn:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterAreaUnit.SquareNanometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareMicrometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareDecimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareDecameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareHectometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareMegameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterAreaUnit.SquareThou:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.CircularMil:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterAreaUnit.SquareRod:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.SquarePole:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.SquarePerch:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.SquareChain:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.SquareFurlong:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.Section:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.Homestead:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterAreaUnit.SquareLeague:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterAreaUnit.Dunam:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterAreaUnit.Tatami:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterAreaUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterAreaUnit.SquareMillimeter, UnitConverterAreaUnit.SquareCentimeter, UnitConverterAreaUnit.SquareMeter, UnitConverterAreaUnit.Are, UnitConverterAreaUnit.Hectare, UnitConverterAreaUnit.SquareKilometer, UnitConverterAreaUnit.SquareNanometer, UnitConverterAreaUnit.SquareMicrometer, UnitConverterAreaUnit.SquareDecimeter, UnitConverterAreaUnit.SquareDecameter, UnitConverterAreaUnit.SquareHectometer, UnitConverterAreaUnit.SquareMegameter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterAreaUnit.SquareInch, UnitConverterAreaUnit.SquareFoot, UnitConverterAreaUnit.SquareYard, UnitConverterAreaUnit.Acre, UnitConverterAreaUnit.SquareMile, UnitConverterAreaUnit.SquareThou, UnitConverterAreaUnit.CircularMil };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterAreaUnit.Rood };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterAreaUnit.Township };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterAreaUnit.Barn };
                case UnitConverterUnitSystem.Survey:
                    return new[] { UnitConverterAreaUnit.SquareRod, UnitConverterAreaUnit.SquarePole, UnitConverterAreaUnit.SquarePerch, UnitConverterAreaUnit.SquareChain, UnitConverterAreaUnit.SquareFurlong, UnitConverterAreaUnit.Section, UnitConverterAreaUnit.Homestead };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterAreaUnit.SquareLeague, UnitConverterAreaUnit.Dunam, UnitConverterAreaUnit.Tatami };
                default:
                    return new[] { UnitConverterAreaUnit.SquareMillimeter, UnitConverterAreaUnit.SquareCentimeter, UnitConverterAreaUnit.SquareMeter, UnitConverterAreaUnit.Are, UnitConverterAreaUnit.Hectare, UnitConverterAreaUnit.SquareKilometer, UnitConverterAreaUnit.SquareInch, UnitConverterAreaUnit.SquareFoot, UnitConverterAreaUnit.SquareYard, UnitConverterAreaUnit.Acre, UnitConverterAreaUnit.SquareMile, UnitConverterAreaUnit.Rood, UnitConverterAreaUnit.Township, UnitConverterAreaUnit.Barn, UnitConverterAreaUnit.SquareNanometer, UnitConverterAreaUnit.SquareMicrometer, UnitConverterAreaUnit.SquareDecimeter, UnitConverterAreaUnit.SquareDecameter, UnitConverterAreaUnit.SquareHectometer, UnitConverterAreaUnit.SquareMegameter, UnitConverterAreaUnit.SquareThou, UnitConverterAreaUnit.CircularMil, UnitConverterAreaUnit.SquareRod, UnitConverterAreaUnit.SquarePole, UnitConverterAreaUnit.SquarePerch, UnitConverterAreaUnit.SquareChain, UnitConverterAreaUnit.SquareFurlong, UnitConverterAreaUnit.Section, UnitConverterAreaUnit.Homestead, UnitConverterAreaUnit.SquareLeague, UnitConverterAreaUnit.Dunam, UnitConverterAreaUnit.Tatami };
            }
        }
    }
}
