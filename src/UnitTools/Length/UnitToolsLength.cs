namespace UnitTools.Length
{
    using UnitTools.Length.Metric;
    using UnitTools.Length.Scientific;
    using UnitTools.Length.Imperial;
    using UnitTools.Length.ImperialUS;
    using UnitTools.Length.Survey;
    using UnitTools.Length.Nautical;
    using UnitTools.Length.Astronomical;
    using UnitTools.Length.Historical;
    using UnitTools.Length.Common;

    public enum UnitToolsLengthUnit
    {
        Femtometer = 0,
        Picometer = 1,
        Nanometer = 2,
        Micrometer = 3,
        Millimeter = 4,
        Centimeter = 5,
        Decimeter = 6,
        Meter = 7,
        Decameter = 8,
        Hectometer = 9,
        Kilometer = 10,
        Megameter = 11,
        Gigameter = 12,
        Angstrom = 13,
        Thou = 14,
        Inch = 15,
        Foot = 16,
        Yard = 17,
        Mile = 18,
        League = 19,
        Hand = 20,
        USSurveyInch = 21,
        USSurveyFoot = 22,
        USSurveyYard = 23,
        USSurveyMile = 24,
        Link = 25,
        Rod = 26,
        Chain = 27,
        Furlong = 28,
        Fathom = 29,
        Cable = 30,
        NauticalMile = 31,
        AstronomicalUnit = 32,
        LightYear = 33,
        Parsec = 34,
        Cubit = 35,
        Span = 36,
        Pace = 37,
        Ell = 38,
        Quectometer = 39,
        Rontometer = 40,
        Yoctometer = 41,
        Zeptometer = 42,
        Attometer = 43,
        Petameter = 44,
        Exameter = 45,
        Zettameter = 46,
        Yottameter = 47,
        Ronnameter = 48,
        Quettameter = 49,
        Fermi = 50,
        BohrRadius = 51,
        PlanckLength = 52,
        ClassicalElectronRadius = 53,
        EarthEquatorialRadius = 54,
        EarthMeanRadius = 55,
        SolarRadius = 56,
        LunarDistance = 57,
        PointPostScript = 58,
        PicaPostScript = 59,
        DidotPoint = 60,
        Cicero = 61,
        Barleycorn = 62,
        Nail = 63,
        Palm = 64,
        RomanFoot = 65,
        Arshin = 66,
        Vara = 67,
        Smoot = 68,
        NauticalLeague = 69,
        Twip = 70,
        PrinterPoint = 71,
        PrinterPica = 72,
        Ken = 73,
        Shaku = 74,
        Ri = 75,
        LiChinese = 76,
        ChiChinese = 77,
        Kiloparsec = 78,
        Megaparsec = 79,
        Gigaparsec = 80,
        LightSecond = 81,
        LightMinute = 82,
        LightHour = 83,
        LightDay = 84,
        LightWeek = 85,
        Microinch = 86,
        Nanoinch = 87,
        Caliber = 88,
        RackUnit = 89,
        Quarter = 90,
    }

    public static class UnitToolsLength
    {
        public static double Convert(double value, UnitToolsLengthUnit from, UnitToolsLengthUnit to)
        {
            double baseValue = ToMeter(value, from);
            return FromMeter(baseValue, to);
        }

        public static double ToMeter(double value, UnitToolsLengthUnit from)
        {
            switch (from)
            {
                case UnitToolsLengthUnit.Femtometer:
                    return UnitToolsMetricLength.FemtometerToMeter(value);
                case UnitToolsLengthUnit.Picometer:
                    return UnitToolsMetricLength.PicometerToMeter(value);
                case UnitToolsLengthUnit.Nanometer:
                    return UnitToolsMetricLength.NanometerToMeter(value);
                case UnitToolsLengthUnit.Micrometer:
                    return UnitToolsMetricLength.MicrometerToMeter(value);
                case UnitToolsLengthUnit.Millimeter:
                    return UnitToolsMetricLength.MillimeterToMeter(value);
                case UnitToolsLengthUnit.Centimeter:
                    return UnitToolsMetricLength.CentimeterToMeter(value);
                case UnitToolsLengthUnit.Decimeter:
                    return UnitToolsMetricLength.DecimeterToMeter(value);
                case UnitToolsLengthUnit.Meter:
                    return UnitToolsMetricLength.MeterToMeter(value);
                case UnitToolsLengthUnit.Decameter:
                    return UnitToolsMetricLength.DecameterToMeter(value);
                case UnitToolsLengthUnit.Hectometer:
                    return UnitToolsMetricLength.HectometerToMeter(value);
                case UnitToolsLengthUnit.Kilometer:
                    return UnitToolsMetricLength.KilometerToMeter(value);
                case UnitToolsLengthUnit.Megameter:
                    return UnitToolsMetricLength.MegameterToMeter(value);
                case UnitToolsLengthUnit.Gigameter:
                    return UnitToolsMetricLength.GigameterToMeter(value);
                case UnitToolsLengthUnit.Angstrom:
                    return UnitToolsScientificLength.AngstromToMeter(value);
                case UnitToolsLengthUnit.Thou:
                    return UnitToolsImperialLength.ThouToMeter(value);
                case UnitToolsLengthUnit.Inch:
                    return UnitToolsImperialLength.InchToMeter(value);
                case UnitToolsLengthUnit.Foot:
                    return UnitToolsImperialLength.FootToMeter(value);
                case UnitToolsLengthUnit.Yard:
                    return UnitToolsImperialLength.YardToMeter(value);
                case UnitToolsLengthUnit.Mile:
                    return UnitToolsImperialLength.MileToMeter(value);
                case UnitToolsLengthUnit.League:
                    return UnitToolsImperialLength.LeagueToMeter(value);
                case UnitToolsLengthUnit.Hand:
                    return UnitToolsImperialLength.HandToMeter(value);
                case UnitToolsLengthUnit.USSurveyInch:
                    return UnitToolsImperialUSLength.USSurveyInchToMeter(value);
                case UnitToolsLengthUnit.USSurveyFoot:
                    return UnitToolsImperialUSLength.USSurveyFootToMeter(value);
                case UnitToolsLengthUnit.USSurveyYard:
                    return UnitToolsImperialUSLength.USSurveyYardToMeter(value);
                case UnitToolsLengthUnit.USSurveyMile:
                    return UnitToolsImperialUSLength.USSurveyMileToMeter(value);
                case UnitToolsLengthUnit.Link:
                    return UnitToolsSurveyLength.LinkToMeter(value);
                case UnitToolsLengthUnit.Rod:
                    return UnitToolsSurveyLength.RodToMeter(value);
                case UnitToolsLengthUnit.Chain:
                    return UnitToolsSurveyLength.ChainToMeter(value);
                case UnitToolsLengthUnit.Furlong:
                    return UnitToolsSurveyLength.FurlongToMeter(value);
                case UnitToolsLengthUnit.Fathom:
                    return UnitToolsNauticalLength.FathomToMeter(value);
                case UnitToolsLengthUnit.Cable:
                    return UnitToolsNauticalLength.CableToMeter(value);
                case UnitToolsLengthUnit.NauticalMile:
                    return UnitToolsNauticalLength.NauticalMileToMeter(value);
                case UnitToolsLengthUnit.AstronomicalUnit:
                    return UnitToolsAstronomicalLength.AstronomicalUnitToMeter(value);
                case UnitToolsLengthUnit.LightYear:
                    return UnitToolsAstronomicalLength.LightYearToMeter(value);
                case UnitToolsLengthUnit.Parsec:
                    return UnitToolsAstronomicalLength.ParsecToMeter(value);
                case UnitToolsLengthUnit.Cubit:
                    return UnitToolsHistoricalLength.CubitToMeter(value);
                case UnitToolsLengthUnit.Span:
                    return UnitToolsHistoricalLength.SpanToMeter(value);
                case UnitToolsLengthUnit.Pace:
                    return UnitToolsHistoricalLength.PaceToMeter(value);
                case UnitToolsLengthUnit.Ell:
                    return UnitToolsHistoricalLength.EllToMeter(value);
                case UnitToolsLengthUnit.Quectometer:
                    return UnitToolsMetricLength.QuectometerToMeter(value);
                case UnitToolsLengthUnit.Rontometer:
                    return UnitToolsMetricLength.RontometerToMeter(value);
                case UnitToolsLengthUnit.Yoctometer:
                    return UnitToolsMetricLength.YoctometerToMeter(value);
                case UnitToolsLengthUnit.Zeptometer:
                    return UnitToolsMetricLength.ZeptometerToMeter(value);
                case UnitToolsLengthUnit.Attometer:
                    return UnitToolsMetricLength.AttometerToMeter(value);
                case UnitToolsLengthUnit.Petameter:
                    return UnitToolsMetricLength.PetameterToMeter(value);
                case UnitToolsLengthUnit.Exameter:
                    return UnitToolsMetricLength.ExameterToMeter(value);
                case UnitToolsLengthUnit.Zettameter:
                    return UnitToolsMetricLength.ZettameterToMeter(value);
                case UnitToolsLengthUnit.Yottameter:
                    return UnitToolsMetricLength.YottameterToMeter(value);
                case UnitToolsLengthUnit.Ronnameter:
                    return UnitToolsMetricLength.RonnameterToMeter(value);
                case UnitToolsLengthUnit.Quettameter:
                    return UnitToolsMetricLength.QuettameterToMeter(value);
                case UnitToolsLengthUnit.Fermi:
                    return UnitToolsScientificLength.FermiToMeter(value);
                case UnitToolsLengthUnit.BohrRadius:
                    return UnitToolsScientificLength.BohrRadiusToMeter(value);
                case UnitToolsLengthUnit.PlanckLength:
                    return UnitToolsScientificLength.PlanckLengthToMeter(value);
                case UnitToolsLengthUnit.ClassicalElectronRadius:
                    return UnitToolsScientificLength.ClassicalElectronRadiusToMeter(value);
                case UnitToolsLengthUnit.EarthEquatorialRadius:
                    return UnitToolsAstronomicalLength.EarthEquatorialRadiusToMeter(value);
                case UnitToolsLengthUnit.EarthMeanRadius:
                    return UnitToolsAstronomicalLength.EarthMeanRadiusToMeter(value);
                case UnitToolsLengthUnit.SolarRadius:
                    return UnitToolsAstronomicalLength.SolarRadiusToMeter(value);
                case UnitToolsLengthUnit.LunarDistance:
                    return UnitToolsAstronomicalLength.LunarDistanceToMeter(value);
                case UnitToolsLengthUnit.PointPostScript:
                    return UnitToolsCommonLength.PointPostScriptToMeter(value);
                case UnitToolsLengthUnit.PicaPostScript:
                    return UnitToolsCommonLength.PicaPostScriptToMeter(value);
                case UnitToolsLengthUnit.DidotPoint:
                    return UnitToolsHistoricalLength.DidotPointToMeter(value);
                case UnitToolsLengthUnit.Cicero:
                    return UnitToolsHistoricalLength.CiceroToMeter(value);
                case UnitToolsLengthUnit.Barleycorn:
                    return UnitToolsHistoricalLength.BarleycornToMeter(value);
                case UnitToolsLengthUnit.Nail:
                    return UnitToolsHistoricalLength.NailToMeter(value);
                case UnitToolsLengthUnit.Palm:
                    return UnitToolsHistoricalLength.PalmToMeter(value);
                case UnitToolsLengthUnit.RomanFoot:
                    return UnitToolsHistoricalLength.RomanFootToMeter(value);
                case UnitToolsLengthUnit.Arshin:
                    return UnitToolsHistoricalLength.ArshinToMeter(value);
                case UnitToolsLengthUnit.Vara:
                    return UnitToolsHistoricalLength.VaraToMeter(value);
                case UnitToolsLengthUnit.Smoot:
                    return UnitToolsHistoricalLength.SmootToMeter(value);
                case UnitToolsLengthUnit.NauticalLeague:
                    return UnitToolsNauticalLength.NauticalLeagueToMeter(value);
                case UnitToolsLengthUnit.Twip:
                    return UnitToolsCommonLength.TwipToMeter(value);
                case UnitToolsLengthUnit.PrinterPoint:
                    return UnitToolsCommonLength.PrinterPointToMeter(value);
                case UnitToolsLengthUnit.PrinterPica:
                    return UnitToolsCommonLength.PrinterPicaToMeter(value);
                case UnitToolsLengthUnit.Ken:
                    return UnitToolsHistoricalLength.KenToMeter(value);
                case UnitToolsLengthUnit.Shaku:
                    return UnitToolsHistoricalLength.ShakuToMeter(value);
                case UnitToolsLengthUnit.Ri:
                    return UnitToolsHistoricalLength.RiToMeter(value);
                case UnitToolsLengthUnit.LiChinese:
                    return UnitToolsHistoricalLength.LiChineseToMeter(value);
                case UnitToolsLengthUnit.ChiChinese:
                    return UnitToolsHistoricalLength.ChiChineseToMeter(value);
                case UnitToolsLengthUnit.Kiloparsec:
                    return UnitToolsAstronomicalLength.KiloparsecToMeter(value);
                case UnitToolsLengthUnit.Megaparsec:
                    return UnitToolsAstronomicalLength.MegaparsecToMeter(value);
                case UnitToolsLengthUnit.Gigaparsec:
                    return UnitToolsAstronomicalLength.GigaparsecToMeter(value);
                case UnitToolsLengthUnit.LightSecond:
                    return UnitToolsAstronomicalLength.LightSecondToMeter(value);
                case UnitToolsLengthUnit.LightMinute:
                    return UnitToolsAstronomicalLength.LightMinuteToMeter(value);
                case UnitToolsLengthUnit.LightHour:
                    return UnitToolsAstronomicalLength.LightHourToMeter(value);
                case UnitToolsLengthUnit.LightDay:
                    return UnitToolsAstronomicalLength.LightDayToMeter(value);
                case UnitToolsLengthUnit.LightWeek:
                    return UnitToolsAstronomicalLength.LightWeekToMeter(value);
                case UnitToolsLengthUnit.Microinch:
                    return UnitToolsImperialLength.MicroinchToMeter(value);
                case UnitToolsLengthUnit.Nanoinch:
                    return UnitToolsImperialLength.NanoinchToMeter(value);
                case UnitToolsLengthUnit.Caliber:
                    return UnitToolsImperialLength.CaliberToMeter(value);
                case UnitToolsLengthUnit.RackUnit:
                    return UnitToolsCommonLength.RackUnitToMeter(value);
                case UnitToolsLengthUnit.Quarter:
                    return UnitToolsHistoricalLength.QuarterToMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported length unit.");
            }
        }

        public static double FromMeter(double baseValue, UnitToolsLengthUnit to)
        {
            switch (to)
            {
                case UnitToolsLengthUnit.Femtometer:
                    return UnitToolsMetricLength.MeterToFemtometer(baseValue);
                case UnitToolsLengthUnit.Picometer:
                    return UnitToolsMetricLength.MeterToPicometer(baseValue);
                case UnitToolsLengthUnit.Nanometer:
                    return UnitToolsMetricLength.MeterToNanometer(baseValue);
                case UnitToolsLengthUnit.Micrometer:
                    return UnitToolsMetricLength.MeterToMicrometer(baseValue);
                case UnitToolsLengthUnit.Millimeter:
                    return UnitToolsMetricLength.MeterToMillimeter(baseValue);
                case UnitToolsLengthUnit.Centimeter:
                    return UnitToolsMetricLength.MeterToCentimeter(baseValue);
                case UnitToolsLengthUnit.Decimeter:
                    return UnitToolsMetricLength.MeterToDecimeter(baseValue);
                case UnitToolsLengthUnit.Meter:
                    return UnitToolsMetricLength.MeterToMeter(baseValue);
                case UnitToolsLengthUnit.Decameter:
                    return UnitToolsMetricLength.MeterToDecameter(baseValue);
                case UnitToolsLengthUnit.Hectometer:
                    return UnitToolsMetricLength.MeterToHectometer(baseValue);
                case UnitToolsLengthUnit.Kilometer:
                    return UnitToolsMetricLength.MeterToKilometer(baseValue);
                case UnitToolsLengthUnit.Megameter:
                    return UnitToolsMetricLength.MeterToMegameter(baseValue);
                case UnitToolsLengthUnit.Gigameter:
                    return UnitToolsMetricLength.MeterToGigameter(baseValue);
                case UnitToolsLengthUnit.Angstrom:
                    return UnitToolsScientificLength.MeterToAngstrom(baseValue);
                case UnitToolsLengthUnit.Thou:
                    return UnitToolsImperialLength.MeterToThou(baseValue);
                case UnitToolsLengthUnit.Inch:
                    return UnitToolsImperialLength.MeterToInch(baseValue);
                case UnitToolsLengthUnit.Foot:
                    return UnitToolsImperialLength.MeterToFoot(baseValue);
                case UnitToolsLengthUnit.Yard:
                    return UnitToolsImperialLength.MeterToYard(baseValue);
                case UnitToolsLengthUnit.Mile:
                    return UnitToolsImperialLength.MeterToMile(baseValue);
                case UnitToolsLengthUnit.League:
                    return UnitToolsImperialLength.MeterToLeague(baseValue);
                case UnitToolsLengthUnit.Hand:
                    return UnitToolsImperialLength.MeterToHand(baseValue);
                case UnitToolsLengthUnit.USSurveyInch:
                    return UnitToolsImperialUSLength.MeterToUSSurveyInch(baseValue);
                case UnitToolsLengthUnit.USSurveyFoot:
                    return UnitToolsImperialUSLength.MeterToUSSurveyFoot(baseValue);
                case UnitToolsLengthUnit.USSurveyYard:
                    return UnitToolsImperialUSLength.MeterToUSSurveyYard(baseValue);
                case UnitToolsLengthUnit.USSurveyMile:
                    return UnitToolsImperialUSLength.MeterToUSSurveyMile(baseValue);
                case UnitToolsLengthUnit.Link:
                    return UnitToolsSurveyLength.MeterToLink(baseValue);
                case UnitToolsLengthUnit.Rod:
                    return UnitToolsSurveyLength.MeterToRod(baseValue);
                case UnitToolsLengthUnit.Chain:
                    return UnitToolsSurveyLength.MeterToChain(baseValue);
                case UnitToolsLengthUnit.Furlong:
                    return UnitToolsSurveyLength.MeterToFurlong(baseValue);
                case UnitToolsLengthUnit.Fathom:
                    return UnitToolsNauticalLength.MeterToFathom(baseValue);
                case UnitToolsLengthUnit.Cable:
                    return UnitToolsNauticalLength.MeterToCable(baseValue);
                case UnitToolsLengthUnit.NauticalMile:
                    return UnitToolsNauticalLength.MeterToNauticalMile(baseValue);
                case UnitToolsLengthUnit.AstronomicalUnit:
                    return UnitToolsAstronomicalLength.MeterToAstronomicalUnit(baseValue);
                case UnitToolsLengthUnit.LightYear:
                    return UnitToolsAstronomicalLength.MeterToLightYear(baseValue);
                case UnitToolsLengthUnit.Parsec:
                    return UnitToolsAstronomicalLength.MeterToParsec(baseValue);
                case UnitToolsLengthUnit.Cubit:
                    return UnitToolsHistoricalLength.MeterToCubit(baseValue);
                case UnitToolsLengthUnit.Span:
                    return UnitToolsHistoricalLength.MeterToSpan(baseValue);
                case UnitToolsLengthUnit.Pace:
                    return UnitToolsHistoricalLength.MeterToPace(baseValue);
                case UnitToolsLengthUnit.Ell:
                    return UnitToolsHistoricalLength.MeterToEll(baseValue);
                case UnitToolsLengthUnit.Quectometer:
                    return UnitToolsMetricLength.MeterToQuectometer(baseValue);
                case UnitToolsLengthUnit.Rontometer:
                    return UnitToolsMetricLength.MeterToRontometer(baseValue);
                case UnitToolsLengthUnit.Yoctometer:
                    return UnitToolsMetricLength.MeterToYoctometer(baseValue);
                case UnitToolsLengthUnit.Zeptometer:
                    return UnitToolsMetricLength.MeterToZeptometer(baseValue);
                case UnitToolsLengthUnit.Attometer:
                    return UnitToolsMetricLength.MeterToAttometer(baseValue);
                case UnitToolsLengthUnit.Petameter:
                    return UnitToolsMetricLength.MeterToPetameter(baseValue);
                case UnitToolsLengthUnit.Exameter:
                    return UnitToolsMetricLength.MeterToExameter(baseValue);
                case UnitToolsLengthUnit.Zettameter:
                    return UnitToolsMetricLength.MeterToZettameter(baseValue);
                case UnitToolsLengthUnit.Yottameter:
                    return UnitToolsMetricLength.MeterToYottameter(baseValue);
                case UnitToolsLengthUnit.Ronnameter:
                    return UnitToolsMetricLength.MeterToRonnameter(baseValue);
                case UnitToolsLengthUnit.Quettameter:
                    return UnitToolsMetricLength.MeterToQuettameter(baseValue);
                case UnitToolsLengthUnit.Fermi:
                    return UnitToolsScientificLength.MeterToFermi(baseValue);
                case UnitToolsLengthUnit.BohrRadius:
                    return UnitToolsScientificLength.MeterToBohrRadius(baseValue);
                case UnitToolsLengthUnit.PlanckLength:
                    return UnitToolsScientificLength.MeterToPlanckLength(baseValue);
                case UnitToolsLengthUnit.ClassicalElectronRadius:
                    return UnitToolsScientificLength.MeterToClassicalElectronRadius(baseValue);
                case UnitToolsLengthUnit.EarthEquatorialRadius:
                    return UnitToolsAstronomicalLength.MeterToEarthEquatorialRadius(baseValue);
                case UnitToolsLengthUnit.EarthMeanRadius:
                    return UnitToolsAstronomicalLength.MeterToEarthMeanRadius(baseValue);
                case UnitToolsLengthUnit.SolarRadius:
                    return UnitToolsAstronomicalLength.MeterToSolarRadius(baseValue);
                case UnitToolsLengthUnit.LunarDistance:
                    return UnitToolsAstronomicalLength.MeterToLunarDistance(baseValue);
                case UnitToolsLengthUnit.PointPostScript:
                    return UnitToolsCommonLength.MeterToPointPostScript(baseValue);
                case UnitToolsLengthUnit.PicaPostScript:
                    return UnitToolsCommonLength.MeterToPicaPostScript(baseValue);
                case UnitToolsLengthUnit.DidotPoint:
                    return UnitToolsHistoricalLength.MeterToDidotPoint(baseValue);
                case UnitToolsLengthUnit.Cicero:
                    return UnitToolsHistoricalLength.MeterToCicero(baseValue);
                case UnitToolsLengthUnit.Barleycorn:
                    return UnitToolsHistoricalLength.MeterToBarleycorn(baseValue);
                case UnitToolsLengthUnit.Nail:
                    return UnitToolsHistoricalLength.MeterToNail(baseValue);
                case UnitToolsLengthUnit.Palm:
                    return UnitToolsHistoricalLength.MeterToPalm(baseValue);
                case UnitToolsLengthUnit.RomanFoot:
                    return UnitToolsHistoricalLength.MeterToRomanFoot(baseValue);
                case UnitToolsLengthUnit.Arshin:
                    return UnitToolsHistoricalLength.MeterToArshin(baseValue);
                case UnitToolsLengthUnit.Vara:
                    return UnitToolsHistoricalLength.MeterToVara(baseValue);
                case UnitToolsLengthUnit.Smoot:
                    return UnitToolsHistoricalLength.MeterToSmoot(baseValue);
                case UnitToolsLengthUnit.NauticalLeague:
                    return UnitToolsNauticalLength.MeterToNauticalLeague(baseValue);
                case UnitToolsLengthUnit.Twip:
                    return UnitToolsCommonLength.MeterToTwip(baseValue);
                case UnitToolsLengthUnit.PrinterPoint:
                    return UnitToolsCommonLength.MeterToPrinterPoint(baseValue);
                case UnitToolsLengthUnit.PrinterPica:
                    return UnitToolsCommonLength.MeterToPrinterPica(baseValue);
                case UnitToolsLengthUnit.Ken:
                    return UnitToolsHistoricalLength.MeterToKen(baseValue);
                case UnitToolsLengthUnit.Shaku:
                    return UnitToolsHistoricalLength.MeterToShaku(baseValue);
                case UnitToolsLengthUnit.Ri:
                    return UnitToolsHistoricalLength.MeterToRi(baseValue);
                case UnitToolsLengthUnit.LiChinese:
                    return UnitToolsHistoricalLength.MeterToLiChinese(baseValue);
                case UnitToolsLengthUnit.ChiChinese:
                    return UnitToolsHistoricalLength.MeterToChiChinese(baseValue);
                case UnitToolsLengthUnit.Kiloparsec:
                    return UnitToolsAstronomicalLength.MeterToKiloparsec(baseValue);
                case UnitToolsLengthUnit.Megaparsec:
                    return UnitToolsAstronomicalLength.MeterToMegaparsec(baseValue);
                case UnitToolsLengthUnit.Gigaparsec:
                    return UnitToolsAstronomicalLength.MeterToGigaparsec(baseValue);
                case UnitToolsLengthUnit.LightSecond:
                    return UnitToolsAstronomicalLength.MeterToLightSecond(baseValue);
                case UnitToolsLengthUnit.LightMinute:
                    return UnitToolsAstronomicalLength.MeterToLightMinute(baseValue);
                case UnitToolsLengthUnit.LightHour:
                    return UnitToolsAstronomicalLength.MeterToLightHour(baseValue);
                case UnitToolsLengthUnit.LightDay:
                    return UnitToolsAstronomicalLength.MeterToLightDay(baseValue);
                case UnitToolsLengthUnit.LightWeek:
                    return UnitToolsAstronomicalLength.MeterToLightWeek(baseValue);
                case UnitToolsLengthUnit.Microinch:
                    return UnitToolsImperialLength.MeterToMicroinch(baseValue);
                case UnitToolsLengthUnit.Nanoinch:
                    return UnitToolsImperialLength.MeterToNanoinch(baseValue);
                case UnitToolsLengthUnit.Caliber:
                    return UnitToolsImperialLength.MeterToCaliber(baseValue);
                case UnitToolsLengthUnit.RackUnit:
                    return UnitToolsCommonLength.MeterToRackUnit(baseValue);
                case UnitToolsLengthUnit.Quarter:
                    return UnitToolsHistoricalLength.MeterToQuarter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported length unit.");
            }
        }

        public static string GetSymbol(UnitToolsLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLengthUnit.Femtometer:
                    return "fm";
                case UnitToolsLengthUnit.Picometer:
                    return "pm";
                case UnitToolsLengthUnit.Nanometer:
                    return "nm";
                case UnitToolsLengthUnit.Micrometer:
                    return "µm";
                case UnitToolsLengthUnit.Millimeter:
                    return "mm";
                case UnitToolsLengthUnit.Centimeter:
                    return "cm";
                case UnitToolsLengthUnit.Decimeter:
                    return "dm";
                case UnitToolsLengthUnit.Meter:
                    return "m";
                case UnitToolsLengthUnit.Decameter:
                    return "dam";
                case UnitToolsLengthUnit.Hectometer:
                    return "hm";
                case UnitToolsLengthUnit.Kilometer:
                    return "km";
                case UnitToolsLengthUnit.Megameter:
                    return "Mm";
                case UnitToolsLengthUnit.Gigameter:
                    return "Gm";
                case UnitToolsLengthUnit.Angstrom:
                    return "Å";
                case UnitToolsLengthUnit.Thou:
                    return "thou";
                case UnitToolsLengthUnit.Inch:
                    return "in";
                case UnitToolsLengthUnit.Foot:
                    return "ft";
                case UnitToolsLengthUnit.Yard:
                    return "yd";
                case UnitToolsLengthUnit.Mile:
                    return "mi";
                case UnitToolsLengthUnit.League:
                    return "lea";
                case UnitToolsLengthUnit.Hand:
                    return "hh";
                case UnitToolsLengthUnit.USSurveyInch:
                    return "in (survey)";
                case UnitToolsLengthUnit.USSurveyFoot:
                    return "ft (survey)";
                case UnitToolsLengthUnit.USSurveyYard:
                    return "yd (survey)";
                case UnitToolsLengthUnit.USSurveyMile:
                    return "mi (survey)";
                case UnitToolsLengthUnit.Link:
                    return "li";
                case UnitToolsLengthUnit.Rod:
                    return "rd";
                case UnitToolsLengthUnit.Chain:
                    return "ch";
                case UnitToolsLengthUnit.Furlong:
                    return "fur";
                case UnitToolsLengthUnit.Fathom:
                    return "ftm";
                case UnitToolsLengthUnit.Cable:
                    return "cable";
                case UnitToolsLengthUnit.NauticalMile:
                    return "nmi";
                case UnitToolsLengthUnit.AstronomicalUnit:
                    return "au";
                case UnitToolsLengthUnit.LightYear:
                    return "ly";
                case UnitToolsLengthUnit.Parsec:
                    return "pc";
                case UnitToolsLengthUnit.Cubit:
                    return "cubit";
                case UnitToolsLengthUnit.Span:
                    return "span";
                case UnitToolsLengthUnit.Pace:
                    return "pace";
                case UnitToolsLengthUnit.Ell:
                    return "ell";
                case UnitToolsLengthUnit.Quectometer:
                    return "qm";
                case UnitToolsLengthUnit.Rontometer:
                    return "rm";
                case UnitToolsLengthUnit.Yoctometer:
                    return "ym";
                case UnitToolsLengthUnit.Zeptometer:
                    return "zm";
                case UnitToolsLengthUnit.Attometer:
                    return "am";
                case UnitToolsLengthUnit.Petameter:
                    return "Pm";
                case UnitToolsLengthUnit.Exameter:
                    return "Em";
                case UnitToolsLengthUnit.Zettameter:
                    return "Zm";
                case UnitToolsLengthUnit.Yottameter:
                    return "Ym";
                case UnitToolsLengthUnit.Ronnameter:
                    return "Rm";
                case UnitToolsLengthUnit.Quettameter:
                    return "Qm";
                case UnitToolsLengthUnit.Fermi:
                    return "fermi";
                case UnitToolsLengthUnit.BohrRadius:
                    return "a₀";
                case UnitToolsLengthUnit.PlanckLength:
                    return "ℓP";
                case UnitToolsLengthUnit.ClassicalElectronRadius:
                    return "re";
                case UnitToolsLengthUnit.EarthEquatorialRadius:
                    return "Rₑ";
                case UnitToolsLengthUnit.EarthMeanRadius:
                    return "Rₘ";
                case UnitToolsLengthUnit.SolarRadius:
                    return "R☉";
                case UnitToolsLengthUnit.LunarDistance:
                    return "LD";
                case UnitToolsLengthUnit.PointPostScript:
                    return "pt";
                case UnitToolsLengthUnit.PicaPostScript:
                    return "pc";
                case UnitToolsLengthUnit.DidotPoint:
                    return "dd";
                case UnitToolsLengthUnit.Cicero:
                    return "cicero";
                case UnitToolsLengthUnit.Barleycorn:
                    return "barleycorn";
                case UnitToolsLengthUnit.Nail:
                    return "nail";
                case UnitToolsLengthUnit.Palm:
                    return "palm";
                case UnitToolsLengthUnit.RomanFoot:
                    return "pes";
                case UnitToolsLengthUnit.Arshin:
                    return "arshin";
                case UnitToolsLengthUnit.Vara:
                    return "vara";
                case UnitToolsLengthUnit.Smoot:
                    return "smoot";
                case UnitToolsLengthUnit.NauticalLeague:
                    return "nlea";
                case UnitToolsLengthUnit.Twip:
                    return "twip";
                case UnitToolsLengthUnit.PrinterPoint:
                    return "pt printer";
                case UnitToolsLengthUnit.PrinterPica:
                    return "pc printer";
                case UnitToolsLengthUnit.Ken:
                    return "ken";
                case UnitToolsLengthUnit.Shaku:
                    return "shaku";
                case UnitToolsLengthUnit.Ri:
                    return "ri";
                case UnitToolsLengthUnit.LiChinese:
                    return "li";
                case UnitToolsLengthUnit.ChiChinese:
                    return "chi";
                case UnitToolsLengthUnit.Kiloparsec:
                    return "kpc";
                case UnitToolsLengthUnit.Megaparsec:
                    return "Mpc";
                case UnitToolsLengthUnit.Gigaparsec:
                    return "Gpc";
                case UnitToolsLengthUnit.LightSecond:
                    return "light-second";
                case UnitToolsLengthUnit.LightMinute:
                    return "light-minute";
                case UnitToolsLengthUnit.LightHour:
                    return "light-hour";
                case UnitToolsLengthUnit.LightDay:
                    return "light-day";
                case UnitToolsLengthUnit.LightWeek:
                    return "light-week";
                case UnitToolsLengthUnit.Microinch:
                    return "µin";
                case UnitToolsLengthUnit.Nanoinch:
                    return "nin";
                case UnitToolsLengthUnit.Caliber:
                    return "cal";
                case UnitToolsLengthUnit.RackUnit:
                    return "U";
                case UnitToolsLengthUnit.Quarter:
                    return "qr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLengthUnit.Femtometer:
                    return "femtometer";
                case UnitToolsLengthUnit.Picometer:
                    return "picometer";
                case UnitToolsLengthUnit.Nanometer:
                    return "nanometer";
                case UnitToolsLengthUnit.Micrometer:
                    return "micrometer";
                case UnitToolsLengthUnit.Millimeter:
                    return "millimeter";
                case UnitToolsLengthUnit.Centimeter:
                    return "centimeter";
                case UnitToolsLengthUnit.Decimeter:
                    return "decimeter";
                case UnitToolsLengthUnit.Meter:
                    return "meter";
                case UnitToolsLengthUnit.Decameter:
                    return "decameter";
                case UnitToolsLengthUnit.Hectometer:
                    return "hectometer";
                case UnitToolsLengthUnit.Kilometer:
                    return "kilometer";
                case UnitToolsLengthUnit.Megameter:
                    return "megameter";
                case UnitToolsLengthUnit.Gigameter:
                    return "gigameter";
                case UnitToolsLengthUnit.Angstrom:
                    return "ångström";
                case UnitToolsLengthUnit.Thou:
                    return "thou";
                case UnitToolsLengthUnit.Inch:
                    return "inch";
                case UnitToolsLengthUnit.Foot:
                    return "foot";
                case UnitToolsLengthUnit.Yard:
                    return "yard";
                case UnitToolsLengthUnit.Mile:
                    return "mile";
                case UnitToolsLengthUnit.League:
                    return "league";
                case UnitToolsLengthUnit.Hand:
                    return "hand";
                case UnitToolsLengthUnit.USSurveyInch:
                    return "US survey inch";
                case UnitToolsLengthUnit.USSurveyFoot:
                    return "US survey foot";
                case UnitToolsLengthUnit.USSurveyYard:
                    return "US survey yard";
                case UnitToolsLengthUnit.USSurveyMile:
                    return "US survey mile";
                case UnitToolsLengthUnit.Link:
                    return "link";
                case UnitToolsLengthUnit.Rod:
                    return "rod";
                case UnitToolsLengthUnit.Chain:
                    return "chain";
                case UnitToolsLengthUnit.Furlong:
                    return "furlong";
                case UnitToolsLengthUnit.Fathom:
                    return "fathom";
                case UnitToolsLengthUnit.Cable:
                    return "cable";
                case UnitToolsLengthUnit.NauticalMile:
                    return "nautical mile";
                case UnitToolsLengthUnit.AstronomicalUnit:
                    return "astronomical unit";
                case UnitToolsLengthUnit.LightYear:
                    return "light-year";
                case UnitToolsLengthUnit.Parsec:
                    return "parsec";
                case UnitToolsLengthUnit.Cubit:
                    return "cubit";
                case UnitToolsLengthUnit.Span:
                    return "span";
                case UnitToolsLengthUnit.Pace:
                    return "pace";
                case UnitToolsLengthUnit.Ell:
                    return "ell";
                case UnitToolsLengthUnit.Quectometer:
                    return "Quectometer";
                case UnitToolsLengthUnit.Rontometer:
                    return "Rontometer";
                case UnitToolsLengthUnit.Yoctometer:
                    return "Yoctometer";
                case UnitToolsLengthUnit.Zeptometer:
                    return "Zeptometer";
                case UnitToolsLengthUnit.Attometer:
                    return "Attometer";
                case UnitToolsLengthUnit.Petameter:
                    return "Petameter";
                case UnitToolsLengthUnit.Exameter:
                    return "Exameter";
                case UnitToolsLengthUnit.Zettameter:
                    return "Zettameter";
                case UnitToolsLengthUnit.Yottameter:
                    return "Yottameter";
                case UnitToolsLengthUnit.Ronnameter:
                    return "Ronnameter";
                case UnitToolsLengthUnit.Quettameter:
                    return "Quettameter";
                case UnitToolsLengthUnit.Fermi:
                    return "Fermi";
                case UnitToolsLengthUnit.BohrRadius:
                    return "Bohr Radius";
                case UnitToolsLengthUnit.PlanckLength:
                    return "Planck Length";
                case UnitToolsLengthUnit.ClassicalElectronRadius:
                    return "Classical Electron Radius";
                case UnitToolsLengthUnit.EarthEquatorialRadius:
                    return "Earth Equatorial Radius";
                case UnitToolsLengthUnit.EarthMeanRadius:
                    return "Earth Mean Radius";
                case UnitToolsLengthUnit.SolarRadius:
                    return "Solar Radius";
                case UnitToolsLengthUnit.LunarDistance:
                    return "Lunar Distance";
                case UnitToolsLengthUnit.PointPostScript:
                    return "Point (PostScript)";
                case UnitToolsLengthUnit.PicaPostScript:
                    return "Pica (PostScript)";
                case UnitToolsLengthUnit.DidotPoint:
                    return "Didot Point";
                case UnitToolsLengthUnit.Cicero:
                    return "Cicero";
                case UnitToolsLengthUnit.Barleycorn:
                    return "Barleycorn";
                case UnitToolsLengthUnit.Nail:
                    return "Nail";
                case UnitToolsLengthUnit.Palm:
                    return "Palm";
                case UnitToolsLengthUnit.RomanFoot:
                    return "Roman Foot";
                case UnitToolsLengthUnit.Arshin:
                    return "Arshin";
                case UnitToolsLengthUnit.Vara:
                    return "Vara";
                case UnitToolsLengthUnit.Smoot:
                    return "Smoot";
                case UnitToolsLengthUnit.NauticalLeague:
                    return "Nautical League";
                case UnitToolsLengthUnit.Twip:
                    return "Twip";
                case UnitToolsLengthUnit.PrinterPoint:
                    return "Printer Point";
                case UnitToolsLengthUnit.PrinterPica:
                    return "Printer Pica";
                case UnitToolsLengthUnit.Ken:
                    return "Ken";
                case UnitToolsLengthUnit.Shaku:
                    return "Shaku";
                case UnitToolsLengthUnit.Ri:
                    return "Ri";
                case UnitToolsLengthUnit.LiChinese:
                    return "Li Chinese";
                case UnitToolsLengthUnit.ChiChinese:
                    return "Chi Chinese";
                case UnitToolsLengthUnit.Kiloparsec:
                    return "Kiloparsec";
                case UnitToolsLengthUnit.Megaparsec:
                    return "Megaparsec";
                case UnitToolsLengthUnit.Gigaparsec:
                    return "Gigaparsec";
                case UnitToolsLengthUnit.LightSecond:
                    return "Light Second";
                case UnitToolsLengthUnit.LightMinute:
                    return "Light Minute";
                case UnitToolsLengthUnit.LightHour:
                    return "Light Hour";
                case UnitToolsLengthUnit.LightDay:
                    return "Light Day";
                case UnitToolsLengthUnit.LightWeek:
                    return "Light Week";
                case UnitToolsLengthUnit.Microinch:
                    return "Microinch";
                case UnitToolsLengthUnit.Nanoinch:
                    return "Nanoinch";
                case UnitToolsLengthUnit.Caliber:
                    return "Caliber";
                case UnitToolsLengthUnit.RackUnit:
                    return "Rack Unit";
                case UnitToolsLengthUnit.Quarter:
                    return "Quarter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsLengthUnit unit)
        {
            switch (unit)
            {
                case UnitToolsLengthUnit.Femtometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Picometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Nanometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Micrometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Millimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Centimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Decimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Meter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Decameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Hectometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Kilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Megameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Gigameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Angstrom:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLengthUnit.Thou:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Inch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Foot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Yard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Mile:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.League:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Hand:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.USSurveyInch:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsLengthUnit.USSurveyFoot:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsLengthUnit.USSurveyYard:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsLengthUnit.USSurveyMile:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsLengthUnit.Link:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsLengthUnit.Rod:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsLengthUnit.Chain:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsLengthUnit.Furlong:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsLengthUnit.Fathom:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsLengthUnit.Cable:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsLengthUnit.NauticalMile:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsLengthUnit.AstronomicalUnit:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightYear:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.Parsec:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.Cubit:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Span:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Pace:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Ell:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Quectometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Rontometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Yoctometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Zeptometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Attometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Petameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Exameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Zettameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Yottameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Ronnameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Quettameter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsLengthUnit.Fermi:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLengthUnit.BohrRadius:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLengthUnit.PlanckLength:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLengthUnit.ClassicalElectronRadius:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsLengthUnit.EarthEquatorialRadius:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.EarthMeanRadius:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.SolarRadius:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LunarDistance:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.PointPostScript:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.PicaPostScript:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.DidotPoint:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Cicero:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Barleycorn:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Nail:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Palm:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.RomanFoot:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Arshin:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Vara:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Smoot:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.NauticalLeague:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsLengthUnit.Twip:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.PrinterPoint:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.PrinterPica:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.Ken:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Shaku:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Ri:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.LiChinese:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.ChiChinese:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsLengthUnit.Kiloparsec:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.Megaparsec:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.Gigaparsec:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightSecond:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightMinute:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightHour:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightDay:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.LightWeek:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsLengthUnit.Microinch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Nanoinch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.Caliber:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsLengthUnit.RackUnit:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsLengthUnit.Quarter:
                    return UnitToolsUnitSystem.Historical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsLengthUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsLengthUnit.Femtometer, UnitToolsLengthUnit.Picometer, UnitToolsLengthUnit.Nanometer, UnitToolsLengthUnit.Micrometer, UnitToolsLengthUnit.Millimeter, UnitToolsLengthUnit.Centimeter, UnitToolsLengthUnit.Decimeter, UnitToolsLengthUnit.Meter, UnitToolsLengthUnit.Decameter, UnitToolsLengthUnit.Hectometer, UnitToolsLengthUnit.Kilometer, UnitToolsLengthUnit.Megameter, UnitToolsLengthUnit.Gigameter, UnitToolsLengthUnit.Quectometer, UnitToolsLengthUnit.Rontometer, UnitToolsLengthUnit.Yoctometer, UnitToolsLengthUnit.Zeptometer, UnitToolsLengthUnit.Attometer, UnitToolsLengthUnit.Petameter, UnitToolsLengthUnit.Exameter, UnitToolsLengthUnit.Zettameter, UnitToolsLengthUnit.Yottameter, UnitToolsLengthUnit.Ronnameter, UnitToolsLengthUnit.Quettameter };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsLengthUnit.Angstrom, UnitToolsLengthUnit.Fermi, UnitToolsLengthUnit.BohrRadius, UnitToolsLengthUnit.PlanckLength, UnitToolsLengthUnit.ClassicalElectronRadius };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsLengthUnit.Thou, UnitToolsLengthUnit.Inch, UnitToolsLengthUnit.Foot, UnitToolsLengthUnit.Yard, UnitToolsLengthUnit.Mile, UnitToolsLengthUnit.League, UnitToolsLengthUnit.Hand, UnitToolsLengthUnit.Microinch, UnitToolsLengthUnit.Nanoinch, UnitToolsLengthUnit.Caliber };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsLengthUnit.USSurveyInch, UnitToolsLengthUnit.USSurveyFoot, UnitToolsLengthUnit.USSurveyYard, UnitToolsLengthUnit.USSurveyMile };
                case UnitToolsUnitSystem.Survey:
                    return new[] { UnitToolsLengthUnit.Link, UnitToolsLengthUnit.Rod, UnitToolsLengthUnit.Chain, UnitToolsLengthUnit.Furlong };
                case UnitToolsUnitSystem.Nautical:
                    return new[] { UnitToolsLengthUnit.Fathom, UnitToolsLengthUnit.Cable, UnitToolsLengthUnit.NauticalMile, UnitToolsLengthUnit.NauticalLeague };
                case UnitToolsUnitSystem.Astronomical:
                    return new[] { UnitToolsLengthUnit.AstronomicalUnit, UnitToolsLengthUnit.LightYear, UnitToolsLengthUnit.Parsec, UnitToolsLengthUnit.EarthEquatorialRadius, UnitToolsLengthUnit.EarthMeanRadius, UnitToolsLengthUnit.SolarRadius, UnitToolsLengthUnit.LunarDistance, UnitToolsLengthUnit.Kiloparsec, UnitToolsLengthUnit.Megaparsec, UnitToolsLengthUnit.Gigaparsec, UnitToolsLengthUnit.LightSecond, UnitToolsLengthUnit.LightMinute, UnitToolsLengthUnit.LightHour, UnitToolsLengthUnit.LightDay, UnitToolsLengthUnit.LightWeek };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsLengthUnit.Cubit, UnitToolsLengthUnit.Span, UnitToolsLengthUnit.Pace, UnitToolsLengthUnit.Ell, UnitToolsLengthUnit.DidotPoint, UnitToolsLengthUnit.Cicero, UnitToolsLengthUnit.Barleycorn, UnitToolsLengthUnit.Nail, UnitToolsLengthUnit.Palm, UnitToolsLengthUnit.RomanFoot, UnitToolsLengthUnit.Arshin, UnitToolsLengthUnit.Vara, UnitToolsLengthUnit.Smoot, UnitToolsLengthUnit.Ken, UnitToolsLengthUnit.Shaku, UnitToolsLengthUnit.Ri, UnitToolsLengthUnit.LiChinese, UnitToolsLengthUnit.ChiChinese, UnitToolsLengthUnit.Quarter };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsLengthUnit.PointPostScript, UnitToolsLengthUnit.PicaPostScript, UnitToolsLengthUnit.Twip, UnitToolsLengthUnit.PrinterPoint, UnitToolsLengthUnit.PrinterPica, UnitToolsLengthUnit.RackUnit };
                default:
                    return new[] { UnitToolsLengthUnit.Femtometer, UnitToolsLengthUnit.Picometer, UnitToolsLengthUnit.Nanometer, UnitToolsLengthUnit.Micrometer, UnitToolsLengthUnit.Millimeter, UnitToolsLengthUnit.Centimeter, UnitToolsLengthUnit.Decimeter, UnitToolsLengthUnit.Meter, UnitToolsLengthUnit.Decameter, UnitToolsLengthUnit.Hectometer, UnitToolsLengthUnit.Kilometer, UnitToolsLengthUnit.Megameter, UnitToolsLengthUnit.Gigameter, UnitToolsLengthUnit.Angstrom, UnitToolsLengthUnit.Thou, UnitToolsLengthUnit.Inch, UnitToolsLengthUnit.Foot, UnitToolsLengthUnit.Yard, UnitToolsLengthUnit.Mile, UnitToolsLengthUnit.League, UnitToolsLengthUnit.Hand, UnitToolsLengthUnit.USSurveyInch, UnitToolsLengthUnit.USSurveyFoot, UnitToolsLengthUnit.USSurveyYard, UnitToolsLengthUnit.USSurveyMile, UnitToolsLengthUnit.Link, UnitToolsLengthUnit.Rod, UnitToolsLengthUnit.Chain, UnitToolsLengthUnit.Furlong, UnitToolsLengthUnit.Fathom, UnitToolsLengthUnit.Cable, UnitToolsLengthUnit.NauticalMile, UnitToolsLengthUnit.AstronomicalUnit, UnitToolsLengthUnit.LightYear, UnitToolsLengthUnit.Parsec, UnitToolsLengthUnit.Cubit, UnitToolsLengthUnit.Span, UnitToolsLengthUnit.Pace, UnitToolsLengthUnit.Ell, UnitToolsLengthUnit.Quectometer, UnitToolsLengthUnit.Rontometer, UnitToolsLengthUnit.Yoctometer, UnitToolsLengthUnit.Zeptometer, UnitToolsLengthUnit.Attometer, UnitToolsLengthUnit.Petameter, UnitToolsLengthUnit.Exameter, UnitToolsLengthUnit.Zettameter, UnitToolsLengthUnit.Yottameter, UnitToolsLengthUnit.Ronnameter, UnitToolsLengthUnit.Quettameter, UnitToolsLengthUnit.Fermi, UnitToolsLengthUnit.BohrRadius, UnitToolsLengthUnit.PlanckLength, UnitToolsLengthUnit.ClassicalElectronRadius, UnitToolsLengthUnit.EarthEquatorialRadius, UnitToolsLengthUnit.EarthMeanRadius, UnitToolsLengthUnit.SolarRadius, UnitToolsLengthUnit.LunarDistance, UnitToolsLengthUnit.PointPostScript, UnitToolsLengthUnit.PicaPostScript, UnitToolsLengthUnit.DidotPoint, UnitToolsLengthUnit.Cicero, UnitToolsLengthUnit.Barleycorn, UnitToolsLengthUnit.Nail, UnitToolsLengthUnit.Palm, UnitToolsLengthUnit.RomanFoot, UnitToolsLengthUnit.Arshin, UnitToolsLengthUnit.Vara, UnitToolsLengthUnit.Smoot, UnitToolsLengthUnit.NauticalLeague, UnitToolsLengthUnit.Twip, UnitToolsLengthUnit.PrinterPoint, UnitToolsLengthUnit.PrinterPica, UnitToolsLengthUnit.Ken, UnitToolsLengthUnit.Shaku, UnitToolsLengthUnit.Ri, UnitToolsLengthUnit.LiChinese, UnitToolsLengthUnit.ChiChinese, UnitToolsLengthUnit.Kiloparsec, UnitToolsLengthUnit.Megaparsec, UnitToolsLengthUnit.Gigaparsec, UnitToolsLengthUnit.LightSecond, UnitToolsLengthUnit.LightMinute, UnitToolsLengthUnit.LightHour, UnitToolsLengthUnit.LightDay, UnitToolsLengthUnit.LightWeek, UnitToolsLengthUnit.Microinch, UnitToolsLengthUnit.Nanoinch, UnitToolsLengthUnit.Caliber, UnitToolsLengthUnit.RackUnit, UnitToolsLengthUnit.Quarter };
            }
        }
    }
}
