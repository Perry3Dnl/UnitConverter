namespace UnitTools.Area
{
    using UnitTools.Area.Metric;
    using UnitTools.Area.Imperial;
    using UnitTools.Area.ImperialUK;
    using UnitTools.Area.ImperialUS;
    using UnitTools.Area.Scientific;
    using UnitTools.Area.Survey;
    using UnitTools.Area.Historical;

    public enum UnitToolsAreaUnit
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

    public static class UnitToolsArea
    {
        public static double Convert(double value, UnitToolsAreaUnit from, UnitToolsAreaUnit to)
        {
            double baseValue = ToSquareMeter(value, from);
            return FromSquareMeter(baseValue, to);
        }

        public static double ToSquareMeter(double value, UnitToolsAreaUnit from)
        {
            switch (from)
            {
                case UnitToolsAreaUnit.SquareMillimeter:
                    return UnitToolsMetricArea.SquareMillimeterToSquareMeter(value);
                case UnitToolsAreaUnit.SquareCentimeter:
                    return UnitToolsMetricArea.SquareCentimeterToSquareMeter(value);
                case UnitToolsAreaUnit.SquareMeter:
                    return UnitToolsMetricArea.SquareMeterToSquareMeter(value);
                case UnitToolsAreaUnit.Are:
                    return UnitToolsMetricArea.AreToSquareMeter(value);
                case UnitToolsAreaUnit.Hectare:
                    return UnitToolsMetricArea.HectareToSquareMeter(value);
                case UnitToolsAreaUnit.SquareKilometer:
                    return UnitToolsMetricArea.SquareKilometerToSquareMeter(value);
                case UnitToolsAreaUnit.SquareInch:
                    return UnitToolsImperialArea.SquareInchToSquareMeter(value);
                case UnitToolsAreaUnit.SquareFoot:
                    return UnitToolsImperialArea.SquareFootToSquareMeter(value);
                case UnitToolsAreaUnit.SquareYard:
                    return UnitToolsImperialArea.SquareYardToSquareMeter(value);
                case UnitToolsAreaUnit.Acre:
                    return UnitToolsImperialArea.AcreToSquareMeter(value);
                case UnitToolsAreaUnit.SquareMile:
                    return UnitToolsImperialArea.SquareMileToSquareMeter(value);
                case UnitToolsAreaUnit.Rood:
                    return UnitToolsImperialUKArea.RoodToSquareMeter(value);
                case UnitToolsAreaUnit.Township:
                    return UnitToolsImperialUSArea.TownshipToSquareMeter(value);
                case UnitToolsAreaUnit.Barn:
                    return UnitToolsScientificArea.BarnToSquareMeter(value);
                case UnitToolsAreaUnit.SquareNanometer:
                    return UnitToolsMetricArea.SquareNanometerToSquareMeter(value);
                case UnitToolsAreaUnit.SquareMicrometer:
                    return UnitToolsMetricArea.SquareMicrometerToSquareMeter(value);
                case UnitToolsAreaUnit.SquareDecimeter:
                    return UnitToolsMetricArea.SquareDecimeterToSquareMeter(value);
                case UnitToolsAreaUnit.SquareDecameter:
                    return UnitToolsMetricArea.SquareDecameterToSquareMeter(value);
                case UnitToolsAreaUnit.SquareHectometer:
                    return UnitToolsMetricArea.SquareHectometerToSquareMeter(value);
                case UnitToolsAreaUnit.SquareMegameter:
                    return UnitToolsMetricArea.SquareMegameterToSquareMeter(value);
                case UnitToolsAreaUnit.SquareThou:
                    return UnitToolsImperialArea.SquareThouToSquareMeter(value);
                case UnitToolsAreaUnit.CircularMil:
                    return UnitToolsImperialArea.CircularMilToSquareMeter(value);
                case UnitToolsAreaUnit.SquareRod:
                    return UnitToolsSurveyArea.SquareRodToSquareMeter(value);
                case UnitToolsAreaUnit.SquarePole:
                    return UnitToolsSurveyArea.SquarePoleToSquareMeter(value);
                case UnitToolsAreaUnit.SquarePerch:
                    return UnitToolsSurveyArea.SquarePerchToSquareMeter(value);
                case UnitToolsAreaUnit.SquareChain:
                    return UnitToolsSurveyArea.SquareChainToSquareMeter(value);
                case UnitToolsAreaUnit.SquareFurlong:
                    return UnitToolsSurveyArea.SquareFurlongToSquareMeter(value);
                case UnitToolsAreaUnit.Section:
                    return UnitToolsSurveyArea.SectionToSquareMeter(value);
                case UnitToolsAreaUnit.Homestead:
                    return UnitToolsSurveyArea.HomesteadToSquareMeter(value);
                case UnitToolsAreaUnit.SquareLeague:
                    return UnitToolsHistoricalArea.SquareLeagueToSquareMeter(value);
                case UnitToolsAreaUnit.Dunam:
                    return UnitToolsHistoricalArea.DunamToSquareMeter(value);
                case UnitToolsAreaUnit.Tatami:
                    return UnitToolsHistoricalArea.TatamiToSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported area unit.");
            }
        }

        public static double FromSquareMeter(double baseValue, UnitToolsAreaUnit to)
        {
            switch (to)
            {
                case UnitToolsAreaUnit.SquareMillimeter:
                    return UnitToolsMetricArea.SquareMeterToSquareMillimeter(baseValue);
                case UnitToolsAreaUnit.SquareCentimeter:
                    return UnitToolsMetricArea.SquareMeterToSquareCentimeter(baseValue);
                case UnitToolsAreaUnit.SquareMeter:
                    return UnitToolsMetricArea.SquareMeterToSquareMeter(baseValue);
                case UnitToolsAreaUnit.Are:
                    return UnitToolsMetricArea.SquareMeterToAre(baseValue);
                case UnitToolsAreaUnit.Hectare:
                    return UnitToolsMetricArea.SquareMeterToHectare(baseValue);
                case UnitToolsAreaUnit.SquareKilometer:
                    return UnitToolsMetricArea.SquareMeterToSquareKilometer(baseValue);
                case UnitToolsAreaUnit.SquareInch:
                    return UnitToolsImperialArea.SquareMeterToSquareInch(baseValue);
                case UnitToolsAreaUnit.SquareFoot:
                    return UnitToolsImperialArea.SquareMeterToSquareFoot(baseValue);
                case UnitToolsAreaUnit.SquareYard:
                    return UnitToolsImperialArea.SquareMeterToSquareYard(baseValue);
                case UnitToolsAreaUnit.Acre:
                    return UnitToolsImperialArea.SquareMeterToAcre(baseValue);
                case UnitToolsAreaUnit.SquareMile:
                    return UnitToolsImperialArea.SquareMeterToSquareMile(baseValue);
                case UnitToolsAreaUnit.Rood:
                    return UnitToolsImperialUKArea.SquareMeterToRood(baseValue);
                case UnitToolsAreaUnit.Township:
                    return UnitToolsImperialUSArea.SquareMeterToTownship(baseValue);
                case UnitToolsAreaUnit.Barn:
                    return UnitToolsScientificArea.SquareMeterToBarn(baseValue);
                case UnitToolsAreaUnit.SquareNanometer:
                    return UnitToolsMetricArea.SquareMeterToSquareNanometer(baseValue);
                case UnitToolsAreaUnit.SquareMicrometer:
                    return UnitToolsMetricArea.SquareMeterToSquareMicrometer(baseValue);
                case UnitToolsAreaUnit.SquareDecimeter:
                    return UnitToolsMetricArea.SquareMeterToSquareDecimeter(baseValue);
                case UnitToolsAreaUnit.SquareDecameter:
                    return UnitToolsMetricArea.SquareMeterToSquareDecameter(baseValue);
                case UnitToolsAreaUnit.SquareHectometer:
                    return UnitToolsMetricArea.SquareMeterToSquareHectometer(baseValue);
                case UnitToolsAreaUnit.SquareMegameter:
                    return UnitToolsMetricArea.SquareMeterToSquareMegameter(baseValue);
                case UnitToolsAreaUnit.SquareThou:
                    return UnitToolsImperialArea.SquareMeterToSquareThou(baseValue);
                case UnitToolsAreaUnit.CircularMil:
                    return UnitToolsImperialArea.SquareMeterToCircularMil(baseValue);
                case UnitToolsAreaUnit.SquareRod:
                    return UnitToolsSurveyArea.SquareMeterToSquareRod(baseValue);
                case UnitToolsAreaUnit.SquarePole:
                    return UnitToolsSurveyArea.SquareMeterToSquarePole(baseValue);
                case UnitToolsAreaUnit.SquarePerch:
                    return UnitToolsSurveyArea.SquareMeterToSquarePerch(baseValue);
                case UnitToolsAreaUnit.SquareChain:
                    return UnitToolsSurveyArea.SquareMeterToSquareChain(baseValue);
                case UnitToolsAreaUnit.SquareFurlong:
                    return UnitToolsSurveyArea.SquareMeterToSquareFurlong(baseValue);
                case UnitToolsAreaUnit.Section:
                    return UnitToolsSurveyArea.SquareMeterToSection(baseValue);
                case UnitToolsAreaUnit.Homestead:
                    return UnitToolsSurveyArea.SquareMeterToHomestead(baseValue);
                case UnitToolsAreaUnit.SquareLeague:
                    return UnitToolsHistoricalArea.SquareMeterToSquareLeague(baseValue);
                case UnitToolsAreaUnit.Dunam:
                    return UnitToolsHistoricalArea.SquareMeterToDunam(baseValue);
                case UnitToolsAreaUnit.Tatami:
                    return UnitToolsHistoricalArea.SquareMeterToTatami(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported area unit.");
            }
        }

        public static string GetSymbol(UnitToolsAreaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaUnit.SquareMillimeter:
                    return "mm²";
                case UnitToolsAreaUnit.SquareCentimeter:
                    return "cm²";
                case UnitToolsAreaUnit.SquareMeter:
                    return "m²";
                case UnitToolsAreaUnit.Are:
                    return "a";
                case UnitToolsAreaUnit.Hectare:
                    return "ha";
                case UnitToolsAreaUnit.SquareKilometer:
                    return "km²";
                case UnitToolsAreaUnit.SquareInch:
                    return "in²";
                case UnitToolsAreaUnit.SquareFoot:
                    return "ft²";
                case UnitToolsAreaUnit.SquareYard:
                    return "yd²";
                case UnitToolsAreaUnit.Acre:
                    return "ac";
                case UnitToolsAreaUnit.SquareMile:
                    return "mi²";
                case UnitToolsAreaUnit.Rood:
                    return "rood";
                case UnitToolsAreaUnit.Township:
                    return "twp";
                case UnitToolsAreaUnit.Barn:
                    return "b";
                case UnitToolsAreaUnit.SquareNanometer:
                    return "nm²";
                case UnitToolsAreaUnit.SquareMicrometer:
                    return "µm²";
                case UnitToolsAreaUnit.SquareDecimeter:
                    return "dm²";
                case UnitToolsAreaUnit.SquareDecameter:
                    return "dam²";
                case UnitToolsAreaUnit.SquareHectometer:
                    return "hm²";
                case UnitToolsAreaUnit.SquareMegameter:
                    return "Mm²";
                case UnitToolsAreaUnit.SquareThou:
                    return "thou²";
                case UnitToolsAreaUnit.CircularMil:
                    return "cmil";
                case UnitToolsAreaUnit.SquareRod:
                    return "rod²";
                case UnitToolsAreaUnit.SquarePole:
                    return "pole²";
                case UnitToolsAreaUnit.SquarePerch:
                    return "perch²";
                case UnitToolsAreaUnit.SquareChain:
                    return "chain²";
                case UnitToolsAreaUnit.SquareFurlong:
                    return "fur²";
                case UnitToolsAreaUnit.Section:
                    return "section";
                case UnitToolsAreaUnit.Homestead:
                    return "homestead";
                case UnitToolsAreaUnit.SquareLeague:
                    return "lea²";
                case UnitToolsAreaUnit.Dunam:
                    return "dunam";
                case UnitToolsAreaUnit.Tatami:
                    return "tatami";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAreaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaUnit.SquareMillimeter:
                    return "square millimeter";
                case UnitToolsAreaUnit.SquareCentimeter:
                    return "square centimeter";
                case UnitToolsAreaUnit.SquareMeter:
                    return "square meter";
                case UnitToolsAreaUnit.Are:
                    return "are";
                case UnitToolsAreaUnit.Hectare:
                    return "hectare";
                case UnitToolsAreaUnit.SquareKilometer:
                    return "square kilometer";
                case UnitToolsAreaUnit.SquareInch:
                    return "square inch";
                case UnitToolsAreaUnit.SquareFoot:
                    return "square foot";
                case UnitToolsAreaUnit.SquareYard:
                    return "square yard";
                case UnitToolsAreaUnit.Acre:
                    return "acre";
                case UnitToolsAreaUnit.SquareMile:
                    return "square mile";
                case UnitToolsAreaUnit.Rood:
                    return "rood";
                case UnitToolsAreaUnit.Township:
                    return "township";
                case UnitToolsAreaUnit.Barn:
                    return "barn";
                case UnitToolsAreaUnit.SquareNanometer:
                    return "Square Nanometer";
                case UnitToolsAreaUnit.SquareMicrometer:
                    return "Square Micrometer";
                case UnitToolsAreaUnit.SquareDecimeter:
                    return "Square Decimeter";
                case UnitToolsAreaUnit.SquareDecameter:
                    return "Square Decameter";
                case UnitToolsAreaUnit.SquareHectometer:
                    return "Square Hectometer";
                case UnitToolsAreaUnit.SquareMegameter:
                    return "Square Megameter";
                case UnitToolsAreaUnit.SquareThou:
                    return "Square Thou";
                case UnitToolsAreaUnit.CircularMil:
                    return "Circular Mil";
                case UnitToolsAreaUnit.SquareRod:
                    return "Square Rod";
                case UnitToolsAreaUnit.SquarePole:
                    return "Square Pole";
                case UnitToolsAreaUnit.SquarePerch:
                    return "Square Perch";
                case UnitToolsAreaUnit.SquareChain:
                    return "Square Chain";
                case UnitToolsAreaUnit.SquareFurlong:
                    return "Square Furlong";
                case UnitToolsAreaUnit.Section:
                    return "Section";
                case UnitToolsAreaUnit.Homestead:
                    return "Homestead";
                case UnitToolsAreaUnit.SquareLeague:
                    return "Square League";
                case UnitToolsAreaUnit.Dunam:
                    return "Dunam";
                case UnitToolsAreaUnit.Tatami:
                    return "Tatami";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAreaUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAreaUnit.SquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.Are:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.Hectare:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.SquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.SquareYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.Acre:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.SquareMile:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.Rood:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsAreaUnit.Township:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsAreaUnit.Barn:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAreaUnit.SquareNanometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareMicrometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareDecimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareDecameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareHectometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareMegameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAreaUnit.SquareThou:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.CircularMil:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsAreaUnit.SquareRod:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.SquarePole:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.SquarePerch:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.SquareChain:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.SquareFurlong:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.Section:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.Homestead:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsAreaUnit.SquareLeague:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsAreaUnit.Dunam:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsAreaUnit.Tatami:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAreaUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAreaUnit.SquareMillimeter, UnitToolsAreaUnit.SquareCentimeter, UnitToolsAreaUnit.SquareMeter, UnitToolsAreaUnit.Are, UnitToolsAreaUnit.Hectare, UnitToolsAreaUnit.SquareKilometer, UnitToolsAreaUnit.SquareNanometer, UnitToolsAreaUnit.SquareMicrometer, UnitToolsAreaUnit.SquareDecimeter, UnitToolsAreaUnit.SquareDecameter, UnitToolsAreaUnit.SquareHectometer, UnitToolsAreaUnit.SquareMegameter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsAreaUnit.SquareInch, UnitToolsAreaUnit.SquareFoot, UnitToolsAreaUnit.SquareYard, UnitToolsAreaUnit.Acre, UnitToolsAreaUnit.SquareMile, UnitToolsAreaUnit.SquareThou, UnitToolsAreaUnit.CircularMil };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsAreaUnit.Rood };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsAreaUnit.Township };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAreaUnit.Barn };
                case UnitToolsUnitSystem.Survey:
                    return new[] { UnitToolsAreaUnit.SquareRod, UnitToolsAreaUnit.SquarePole, UnitToolsAreaUnit.SquarePerch, UnitToolsAreaUnit.SquareChain, UnitToolsAreaUnit.SquareFurlong, UnitToolsAreaUnit.Section, UnitToolsAreaUnit.Homestead };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsAreaUnit.SquareLeague, UnitToolsAreaUnit.Dunam, UnitToolsAreaUnit.Tatami };
                default:
                    return new[] { UnitToolsAreaUnit.SquareMillimeter, UnitToolsAreaUnit.SquareCentimeter, UnitToolsAreaUnit.SquareMeter, UnitToolsAreaUnit.Are, UnitToolsAreaUnit.Hectare, UnitToolsAreaUnit.SquareKilometer, UnitToolsAreaUnit.SquareInch, UnitToolsAreaUnit.SquareFoot, UnitToolsAreaUnit.SquareYard, UnitToolsAreaUnit.Acre, UnitToolsAreaUnit.SquareMile, UnitToolsAreaUnit.Rood, UnitToolsAreaUnit.Township, UnitToolsAreaUnit.Barn, UnitToolsAreaUnit.SquareNanometer, UnitToolsAreaUnit.SquareMicrometer, UnitToolsAreaUnit.SquareDecimeter, UnitToolsAreaUnit.SquareDecameter, UnitToolsAreaUnit.SquareHectometer, UnitToolsAreaUnit.SquareMegameter, UnitToolsAreaUnit.SquareThou, UnitToolsAreaUnit.CircularMil, UnitToolsAreaUnit.SquareRod, UnitToolsAreaUnit.SquarePole, UnitToolsAreaUnit.SquarePerch, UnitToolsAreaUnit.SquareChain, UnitToolsAreaUnit.SquareFurlong, UnitToolsAreaUnit.Section, UnitToolsAreaUnit.Homestead, UnitToolsAreaUnit.SquareLeague, UnitToolsAreaUnit.Dunam, UnitToolsAreaUnit.Tatami };
            }
        }
    }
}
