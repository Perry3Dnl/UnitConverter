namespace RealisticPhysics.UnitConversion.Length
{
    using RealisticPhysics.UnitConversion.Length.Metric;
    using RealisticPhysics.UnitConversion.Length.Scientific;
    using RealisticPhysics.UnitConversion.Length.Imperial;
    using RealisticPhysics.UnitConversion.Length.ImperialUS;
    using RealisticPhysics.UnitConversion.Length.Survey;
    using RealisticPhysics.UnitConversion.Length.Nautical;
    using RealisticPhysics.UnitConversion.Length.Astronomical;
    using RealisticPhysics.UnitConversion.Length.Historical;
    using RealisticPhysics.UnitConversion.Length.Common;

    public enum UnitConverterLengthUnit
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

    public static class UnitConverterLength
    {
        public static double Convert(double value, UnitConverterLengthUnit from, UnitConverterLengthUnit to)
        {
            double baseValue = ToMeter(value, from);
            return FromMeter(baseValue, to);
        }

        public static double ToMeter(double value, UnitConverterLengthUnit from)
        {
            switch (from)
            {
                case UnitConverterLengthUnit.Femtometer:
                    return UnitConverterMetricLength.FemtometerToMeter(value);
                case UnitConverterLengthUnit.Picometer:
                    return UnitConverterMetricLength.PicometerToMeter(value);
                case UnitConverterLengthUnit.Nanometer:
                    return UnitConverterMetricLength.NanometerToMeter(value);
                case UnitConverterLengthUnit.Micrometer:
                    return UnitConverterMetricLength.MicrometerToMeter(value);
                case UnitConverterLengthUnit.Millimeter:
                    return UnitConverterMetricLength.MillimeterToMeter(value);
                case UnitConverterLengthUnit.Centimeter:
                    return UnitConverterMetricLength.CentimeterToMeter(value);
                case UnitConverterLengthUnit.Decimeter:
                    return UnitConverterMetricLength.DecimeterToMeter(value);
                case UnitConverterLengthUnit.Meter:
                    return UnitConverterMetricLength.MeterToMeter(value);
                case UnitConverterLengthUnit.Decameter:
                    return UnitConverterMetricLength.DecameterToMeter(value);
                case UnitConverterLengthUnit.Hectometer:
                    return UnitConverterMetricLength.HectometerToMeter(value);
                case UnitConverterLengthUnit.Kilometer:
                    return UnitConverterMetricLength.KilometerToMeter(value);
                case UnitConverterLengthUnit.Megameter:
                    return UnitConverterMetricLength.MegameterToMeter(value);
                case UnitConverterLengthUnit.Gigameter:
                    return UnitConverterMetricLength.GigameterToMeter(value);
                case UnitConverterLengthUnit.Angstrom:
                    return UnitConverterScientificLength.AngstromToMeter(value);
                case UnitConverterLengthUnit.Thou:
                    return UnitConverterImperialLength.ThouToMeter(value);
                case UnitConverterLengthUnit.Inch:
                    return UnitConverterImperialLength.InchToMeter(value);
                case UnitConverterLengthUnit.Foot:
                    return UnitConverterImperialLength.FootToMeter(value);
                case UnitConverterLengthUnit.Yard:
                    return UnitConverterImperialLength.YardToMeter(value);
                case UnitConverterLengthUnit.Mile:
                    return UnitConverterImperialLength.MileToMeter(value);
                case UnitConverterLengthUnit.League:
                    return UnitConverterImperialLength.LeagueToMeter(value);
                case UnitConverterLengthUnit.Hand:
                    return UnitConverterImperialLength.HandToMeter(value);
                case UnitConverterLengthUnit.USSurveyInch:
                    return UnitConverterImperialUSLength.USSurveyInchToMeter(value);
                case UnitConverterLengthUnit.USSurveyFoot:
                    return UnitConverterImperialUSLength.USSurveyFootToMeter(value);
                case UnitConverterLengthUnit.USSurveyYard:
                    return UnitConverterImperialUSLength.USSurveyYardToMeter(value);
                case UnitConverterLengthUnit.USSurveyMile:
                    return UnitConverterImperialUSLength.USSurveyMileToMeter(value);
                case UnitConverterLengthUnit.Link:
                    return UnitConverterSurveyLength.LinkToMeter(value);
                case UnitConverterLengthUnit.Rod:
                    return UnitConverterSurveyLength.RodToMeter(value);
                case UnitConverterLengthUnit.Chain:
                    return UnitConverterSurveyLength.ChainToMeter(value);
                case UnitConverterLengthUnit.Furlong:
                    return UnitConverterSurveyLength.FurlongToMeter(value);
                case UnitConverterLengthUnit.Fathom:
                    return UnitConverterNauticalLength.FathomToMeter(value);
                case UnitConverterLengthUnit.Cable:
                    return UnitConverterNauticalLength.CableToMeter(value);
                case UnitConverterLengthUnit.NauticalMile:
                    return UnitConverterNauticalLength.NauticalMileToMeter(value);
                case UnitConverterLengthUnit.AstronomicalUnit:
                    return UnitConverterAstronomicalLength.AstronomicalUnitToMeter(value);
                case UnitConverterLengthUnit.LightYear:
                    return UnitConverterAstronomicalLength.LightYearToMeter(value);
                case UnitConverterLengthUnit.Parsec:
                    return UnitConverterAstronomicalLength.ParsecToMeter(value);
                case UnitConverterLengthUnit.Cubit:
                    return UnitConverterHistoricalLength.CubitToMeter(value);
                case UnitConverterLengthUnit.Span:
                    return UnitConverterHistoricalLength.SpanToMeter(value);
                case UnitConverterLengthUnit.Pace:
                    return UnitConverterHistoricalLength.PaceToMeter(value);
                case UnitConverterLengthUnit.Ell:
                    return UnitConverterHistoricalLength.EllToMeter(value);
                case UnitConverterLengthUnit.Quectometer:
                    return UnitConverterMetricLength.QuectometerToMeter(value);
                case UnitConverterLengthUnit.Rontometer:
                    return UnitConverterMetricLength.RontometerToMeter(value);
                case UnitConverterLengthUnit.Yoctometer:
                    return UnitConverterMetricLength.YoctometerToMeter(value);
                case UnitConverterLengthUnit.Zeptometer:
                    return UnitConverterMetricLength.ZeptometerToMeter(value);
                case UnitConverterLengthUnit.Attometer:
                    return UnitConverterMetricLength.AttometerToMeter(value);
                case UnitConverterLengthUnit.Petameter:
                    return UnitConverterMetricLength.PetameterToMeter(value);
                case UnitConverterLengthUnit.Exameter:
                    return UnitConverterMetricLength.ExameterToMeter(value);
                case UnitConverterLengthUnit.Zettameter:
                    return UnitConverterMetricLength.ZettameterToMeter(value);
                case UnitConverterLengthUnit.Yottameter:
                    return UnitConverterMetricLength.YottameterToMeter(value);
                case UnitConverterLengthUnit.Ronnameter:
                    return UnitConverterMetricLength.RonnameterToMeter(value);
                case UnitConverterLengthUnit.Quettameter:
                    return UnitConverterMetricLength.QuettameterToMeter(value);
                case UnitConverterLengthUnit.Fermi:
                    return UnitConverterScientificLength.FermiToMeter(value);
                case UnitConverterLengthUnit.BohrRadius:
                    return UnitConverterScientificLength.BohrRadiusToMeter(value);
                case UnitConverterLengthUnit.PlanckLength:
                    return UnitConverterScientificLength.PlanckLengthToMeter(value);
                case UnitConverterLengthUnit.ClassicalElectronRadius:
                    return UnitConverterScientificLength.ClassicalElectronRadiusToMeter(value);
                case UnitConverterLengthUnit.EarthEquatorialRadius:
                    return UnitConverterAstronomicalLength.EarthEquatorialRadiusToMeter(value);
                case UnitConverterLengthUnit.EarthMeanRadius:
                    return UnitConverterAstronomicalLength.EarthMeanRadiusToMeter(value);
                case UnitConverterLengthUnit.SolarRadius:
                    return UnitConverterAstronomicalLength.SolarRadiusToMeter(value);
                case UnitConverterLengthUnit.LunarDistance:
                    return UnitConverterAstronomicalLength.LunarDistanceToMeter(value);
                case UnitConverterLengthUnit.PointPostScript:
                    return UnitConverterCommonLength.PointPostScriptToMeter(value);
                case UnitConverterLengthUnit.PicaPostScript:
                    return UnitConverterCommonLength.PicaPostScriptToMeter(value);
                case UnitConverterLengthUnit.DidotPoint:
                    return UnitConverterHistoricalLength.DidotPointToMeter(value);
                case UnitConverterLengthUnit.Cicero:
                    return UnitConverterHistoricalLength.CiceroToMeter(value);
                case UnitConverterLengthUnit.Barleycorn:
                    return UnitConverterHistoricalLength.BarleycornToMeter(value);
                case UnitConverterLengthUnit.Nail:
                    return UnitConverterHistoricalLength.NailToMeter(value);
                case UnitConverterLengthUnit.Palm:
                    return UnitConverterHistoricalLength.PalmToMeter(value);
                case UnitConverterLengthUnit.RomanFoot:
                    return UnitConverterHistoricalLength.RomanFootToMeter(value);
                case UnitConverterLengthUnit.Arshin:
                    return UnitConverterHistoricalLength.ArshinToMeter(value);
                case UnitConverterLengthUnit.Vara:
                    return UnitConverterHistoricalLength.VaraToMeter(value);
                case UnitConverterLengthUnit.Smoot:
                    return UnitConverterHistoricalLength.SmootToMeter(value);
                case UnitConverterLengthUnit.NauticalLeague:
                    return UnitConverterNauticalLength.NauticalLeagueToMeter(value);
                case UnitConverterLengthUnit.Twip:
                    return UnitConverterCommonLength.TwipToMeter(value);
                case UnitConverterLengthUnit.PrinterPoint:
                    return UnitConverterCommonLength.PrinterPointToMeter(value);
                case UnitConverterLengthUnit.PrinterPica:
                    return UnitConverterCommonLength.PrinterPicaToMeter(value);
                case UnitConverterLengthUnit.Ken:
                    return UnitConverterHistoricalLength.KenToMeter(value);
                case UnitConverterLengthUnit.Shaku:
                    return UnitConverterHistoricalLength.ShakuToMeter(value);
                case UnitConverterLengthUnit.Ri:
                    return UnitConverterHistoricalLength.RiToMeter(value);
                case UnitConverterLengthUnit.LiChinese:
                    return UnitConverterHistoricalLength.LiChineseToMeter(value);
                case UnitConverterLengthUnit.ChiChinese:
                    return UnitConverterHistoricalLength.ChiChineseToMeter(value);
                case UnitConverterLengthUnit.Kiloparsec:
                    return UnitConverterAstronomicalLength.KiloparsecToMeter(value);
                case UnitConverterLengthUnit.Megaparsec:
                    return UnitConverterAstronomicalLength.MegaparsecToMeter(value);
                case UnitConverterLengthUnit.Gigaparsec:
                    return UnitConverterAstronomicalLength.GigaparsecToMeter(value);
                case UnitConverterLengthUnit.LightSecond:
                    return UnitConverterAstronomicalLength.LightSecondToMeter(value);
                case UnitConverterLengthUnit.LightMinute:
                    return UnitConverterAstronomicalLength.LightMinuteToMeter(value);
                case UnitConverterLengthUnit.LightHour:
                    return UnitConverterAstronomicalLength.LightHourToMeter(value);
                case UnitConverterLengthUnit.LightDay:
                    return UnitConverterAstronomicalLength.LightDayToMeter(value);
                case UnitConverterLengthUnit.LightWeek:
                    return UnitConverterAstronomicalLength.LightWeekToMeter(value);
                case UnitConverterLengthUnit.Microinch:
                    return UnitConverterImperialLength.MicroinchToMeter(value);
                case UnitConverterLengthUnit.Nanoinch:
                    return UnitConverterImperialLength.NanoinchToMeter(value);
                case UnitConverterLengthUnit.Caliber:
                    return UnitConverterImperialLength.CaliberToMeter(value);
                case UnitConverterLengthUnit.RackUnit:
                    return UnitConverterCommonLength.RackUnitToMeter(value);
                case UnitConverterLengthUnit.Quarter:
                    return UnitConverterHistoricalLength.QuarterToMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported length unit.");
            }
        }

        public static double FromMeter(double baseValue, UnitConverterLengthUnit to)
        {
            switch (to)
            {
                case UnitConverterLengthUnit.Femtometer:
                    return UnitConverterMetricLength.MeterToFemtometer(baseValue);
                case UnitConverterLengthUnit.Picometer:
                    return UnitConverterMetricLength.MeterToPicometer(baseValue);
                case UnitConverterLengthUnit.Nanometer:
                    return UnitConverterMetricLength.MeterToNanometer(baseValue);
                case UnitConverterLengthUnit.Micrometer:
                    return UnitConverterMetricLength.MeterToMicrometer(baseValue);
                case UnitConverterLengthUnit.Millimeter:
                    return UnitConverterMetricLength.MeterToMillimeter(baseValue);
                case UnitConverterLengthUnit.Centimeter:
                    return UnitConverterMetricLength.MeterToCentimeter(baseValue);
                case UnitConverterLengthUnit.Decimeter:
                    return UnitConverterMetricLength.MeterToDecimeter(baseValue);
                case UnitConverterLengthUnit.Meter:
                    return UnitConverterMetricLength.MeterToMeter(baseValue);
                case UnitConverterLengthUnit.Decameter:
                    return UnitConverterMetricLength.MeterToDecameter(baseValue);
                case UnitConverterLengthUnit.Hectometer:
                    return UnitConverterMetricLength.MeterToHectometer(baseValue);
                case UnitConverterLengthUnit.Kilometer:
                    return UnitConverterMetricLength.MeterToKilometer(baseValue);
                case UnitConverterLengthUnit.Megameter:
                    return UnitConverterMetricLength.MeterToMegameter(baseValue);
                case UnitConverterLengthUnit.Gigameter:
                    return UnitConverterMetricLength.MeterToGigameter(baseValue);
                case UnitConverterLengthUnit.Angstrom:
                    return UnitConverterScientificLength.MeterToAngstrom(baseValue);
                case UnitConverterLengthUnit.Thou:
                    return UnitConverterImperialLength.MeterToThou(baseValue);
                case UnitConverterLengthUnit.Inch:
                    return UnitConverterImperialLength.MeterToInch(baseValue);
                case UnitConverterLengthUnit.Foot:
                    return UnitConverterImperialLength.MeterToFoot(baseValue);
                case UnitConverterLengthUnit.Yard:
                    return UnitConverterImperialLength.MeterToYard(baseValue);
                case UnitConverterLengthUnit.Mile:
                    return UnitConverterImperialLength.MeterToMile(baseValue);
                case UnitConverterLengthUnit.League:
                    return UnitConverterImperialLength.MeterToLeague(baseValue);
                case UnitConverterLengthUnit.Hand:
                    return UnitConverterImperialLength.MeterToHand(baseValue);
                case UnitConverterLengthUnit.USSurveyInch:
                    return UnitConverterImperialUSLength.MeterToUSSurveyInch(baseValue);
                case UnitConverterLengthUnit.USSurveyFoot:
                    return UnitConverterImperialUSLength.MeterToUSSurveyFoot(baseValue);
                case UnitConverterLengthUnit.USSurveyYard:
                    return UnitConverterImperialUSLength.MeterToUSSurveyYard(baseValue);
                case UnitConverterLengthUnit.USSurveyMile:
                    return UnitConverterImperialUSLength.MeterToUSSurveyMile(baseValue);
                case UnitConverterLengthUnit.Link:
                    return UnitConverterSurveyLength.MeterToLink(baseValue);
                case UnitConverterLengthUnit.Rod:
                    return UnitConverterSurveyLength.MeterToRod(baseValue);
                case UnitConverterLengthUnit.Chain:
                    return UnitConverterSurveyLength.MeterToChain(baseValue);
                case UnitConverterLengthUnit.Furlong:
                    return UnitConverterSurveyLength.MeterToFurlong(baseValue);
                case UnitConverterLengthUnit.Fathom:
                    return UnitConverterNauticalLength.MeterToFathom(baseValue);
                case UnitConverterLengthUnit.Cable:
                    return UnitConverterNauticalLength.MeterToCable(baseValue);
                case UnitConverterLengthUnit.NauticalMile:
                    return UnitConverterNauticalLength.MeterToNauticalMile(baseValue);
                case UnitConverterLengthUnit.AstronomicalUnit:
                    return UnitConverterAstronomicalLength.MeterToAstronomicalUnit(baseValue);
                case UnitConverterLengthUnit.LightYear:
                    return UnitConverterAstronomicalLength.MeterToLightYear(baseValue);
                case UnitConverterLengthUnit.Parsec:
                    return UnitConverterAstronomicalLength.MeterToParsec(baseValue);
                case UnitConverterLengthUnit.Cubit:
                    return UnitConverterHistoricalLength.MeterToCubit(baseValue);
                case UnitConverterLengthUnit.Span:
                    return UnitConverterHistoricalLength.MeterToSpan(baseValue);
                case UnitConverterLengthUnit.Pace:
                    return UnitConverterHistoricalLength.MeterToPace(baseValue);
                case UnitConverterLengthUnit.Ell:
                    return UnitConverterHistoricalLength.MeterToEll(baseValue);
                case UnitConverterLengthUnit.Quectometer:
                    return UnitConverterMetricLength.MeterToQuectometer(baseValue);
                case UnitConverterLengthUnit.Rontometer:
                    return UnitConverterMetricLength.MeterToRontometer(baseValue);
                case UnitConverterLengthUnit.Yoctometer:
                    return UnitConverterMetricLength.MeterToYoctometer(baseValue);
                case UnitConverterLengthUnit.Zeptometer:
                    return UnitConverterMetricLength.MeterToZeptometer(baseValue);
                case UnitConverterLengthUnit.Attometer:
                    return UnitConverterMetricLength.MeterToAttometer(baseValue);
                case UnitConverterLengthUnit.Petameter:
                    return UnitConverterMetricLength.MeterToPetameter(baseValue);
                case UnitConverterLengthUnit.Exameter:
                    return UnitConverterMetricLength.MeterToExameter(baseValue);
                case UnitConverterLengthUnit.Zettameter:
                    return UnitConverterMetricLength.MeterToZettameter(baseValue);
                case UnitConverterLengthUnit.Yottameter:
                    return UnitConverterMetricLength.MeterToYottameter(baseValue);
                case UnitConverterLengthUnit.Ronnameter:
                    return UnitConverterMetricLength.MeterToRonnameter(baseValue);
                case UnitConverterLengthUnit.Quettameter:
                    return UnitConverterMetricLength.MeterToQuettameter(baseValue);
                case UnitConverterLengthUnit.Fermi:
                    return UnitConverterScientificLength.MeterToFermi(baseValue);
                case UnitConverterLengthUnit.BohrRadius:
                    return UnitConverterScientificLength.MeterToBohrRadius(baseValue);
                case UnitConverterLengthUnit.PlanckLength:
                    return UnitConverterScientificLength.MeterToPlanckLength(baseValue);
                case UnitConverterLengthUnit.ClassicalElectronRadius:
                    return UnitConverterScientificLength.MeterToClassicalElectronRadius(baseValue);
                case UnitConverterLengthUnit.EarthEquatorialRadius:
                    return UnitConverterAstronomicalLength.MeterToEarthEquatorialRadius(baseValue);
                case UnitConverterLengthUnit.EarthMeanRadius:
                    return UnitConverterAstronomicalLength.MeterToEarthMeanRadius(baseValue);
                case UnitConverterLengthUnit.SolarRadius:
                    return UnitConverterAstronomicalLength.MeterToSolarRadius(baseValue);
                case UnitConverterLengthUnit.LunarDistance:
                    return UnitConverterAstronomicalLength.MeterToLunarDistance(baseValue);
                case UnitConverterLengthUnit.PointPostScript:
                    return UnitConverterCommonLength.MeterToPointPostScript(baseValue);
                case UnitConverterLengthUnit.PicaPostScript:
                    return UnitConverterCommonLength.MeterToPicaPostScript(baseValue);
                case UnitConverterLengthUnit.DidotPoint:
                    return UnitConverterHistoricalLength.MeterToDidotPoint(baseValue);
                case UnitConverterLengthUnit.Cicero:
                    return UnitConverterHistoricalLength.MeterToCicero(baseValue);
                case UnitConverterLengthUnit.Barleycorn:
                    return UnitConverterHistoricalLength.MeterToBarleycorn(baseValue);
                case UnitConverterLengthUnit.Nail:
                    return UnitConverterHistoricalLength.MeterToNail(baseValue);
                case UnitConverterLengthUnit.Palm:
                    return UnitConverterHistoricalLength.MeterToPalm(baseValue);
                case UnitConverterLengthUnit.RomanFoot:
                    return UnitConverterHistoricalLength.MeterToRomanFoot(baseValue);
                case UnitConverterLengthUnit.Arshin:
                    return UnitConverterHistoricalLength.MeterToArshin(baseValue);
                case UnitConverterLengthUnit.Vara:
                    return UnitConverterHistoricalLength.MeterToVara(baseValue);
                case UnitConverterLengthUnit.Smoot:
                    return UnitConverterHistoricalLength.MeterToSmoot(baseValue);
                case UnitConverterLengthUnit.NauticalLeague:
                    return UnitConverterNauticalLength.MeterToNauticalLeague(baseValue);
                case UnitConverterLengthUnit.Twip:
                    return UnitConverterCommonLength.MeterToTwip(baseValue);
                case UnitConverterLengthUnit.PrinterPoint:
                    return UnitConverterCommonLength.MeterToPrinterPoint(baseValue);
                case UnitConverterLengthUnit.PrinterPica:
                    return UnitConverterCommonLength.MeterToPrinterPica(baseValue);
                case UnitConverterLengthUnit.Ken:
                    return UnitConverterHistoricalLength.MeterToKen(baseValue);
                case UnitConverterLengthUnit.Shaku:
                    return UnitConverterHistoricalLength.MeterToShaku(baseValue);
                case UnitConverterLengthUnit.Ri:
                    return UnitConverterHistoricalLength.MeterToRi(baseValue);
                case UnitConverterLengthUnit.LiChinese:
                    return UnitConverterHistoricalLength.MeterToLiChinese(baseValue);
                case UnitConverterLengthUnit.ChiChinese:
                    return UnitConverterHistoricalLength.MeterToChiChinese(baseValue);
                case UnitConverterLengthUnit.Kiloparsec:
                    return UnitConverterAstronomicalLength.MeterToKiloparsec(baseValue);
                case UnitConverterLengthUnit.Megaparsec:
                    return UnitConverterAstronomicalLength.MeterToMegaparsec(baseValue);
                case UnitConverterLengthUnit.Gigaparsec:
                    return UnitConverterAstronomicalLength.MeterToGigaparsec(baseValue);
                case UnitConverterLengthUnit.LightSecond:
                    return UnitConverterAstronomicalLength.MeterToLightSecond(baseValue);
                case UnitConverterLengthUnit.LightMinute:
                    return UnitConverterAstronomicalLength.MeterToLightMinute(baseValue);
                case UnitConverterLengthUnit.LightHour:
                    return UnitConverterAstronomicalLength.MeterToLightHour(baseValue);
                case UnitConverterLengthUnit.LightDay:
                    return UnitConverterAstronomicalLength.MeterToLightDay(baseValue);
                case UnitConverterLengthUnit.LightWeek:
                    return UnitConverterAstronomicalLength.MeterToLightWeek(baseValue);
                case UnitConverterLengthUnit.Microinch:
                    return UnitConverterImperialLength.MeterToMicroinch(baseValue);
                case UnitConverterLengthUnit.Nanoinch:
                    return UnitConverterImperialLength.MeterToNanoinch(baseValue);
                case UnitConverterLengthUnit.Caliber:
                    return UnitConverterImperialLength.MeterToCaliber(baseValue);
                case UnitConverterLengthUnit.RackUnit:
                    return UnitConverterCommonLength.MeterToRackUnit(baseValue);
                case UnitConverterLengthUnit.Quarter:
                    return UnitConverterHistoricalLength.MeterToQuarter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported length unit.");
            }
        }

        public static string GetSymbol(UnitConverterLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLengthUnit.Femtometer:
                    return "fm";
                case UnitConverterLengthUnit.Picometer:
                    return "pm";
                case UnitConverterLengthUnit.Nanometer:
                    return "nm";
                case UnitConverterLengthUnit.Micrometer:
                    return "µm";
                case UnitConverterLengthUnit.Millimeter:
                    return "mm";
                case UnitConverterLengthUnit.Centimeter:
                    return "cm";
                case UnitConverterLengthUnit.Decimeter:
                    return "dm";
                case UnitConverterLengthUnit.Meter:
                    return "m";
                case UnitConverterLengthUnit.Decameter:
                    return "dam";
                case UnitConverterLengthUnit.Hectometer:
                    return "hm";
                case UnitConverterLengthUnit.Kilometer:
                    return "km";
                case UnitConverterLengthUnit.Megameter:
                    return "Mm";
                case UnitConverterLengthUnit.Gigameter:
                    return "Gm";
                case UnitConverterLengthUnit.Angstrom:
                    return "Å";
                case UnitConverterLengthUnit.Thou:
                    return "thou";
                case UnitConverterLengthUnit.Inch:
                    return "in";
                case UnitConverterLengthUnit.Foot:
                    return "ft";
                case UnitConverterLengthUnit.Yard:
                    return "yd";
                case UnitConverterLengthUnit.Mile:
                    return "mi";
                case UnitConverterLengthUnit.League:
                    return "lea";
                case UnitConverterLengthUnit.Hand:
                    return "hh";
                case UnitConverterLengthUnit.USSurveyInch:
                    return "in (survey)";
                case UnitConverterLengthUnit.USSurveyFoot:
                    return "ft (survey)";
                case UnitConverterLengthUnit.USSurveyYard:
                    return "yd (survey)";
                case UnitConverterLengthUnit.USSurveyMile:
                    return "mi (survey)";
                case UnitConverterLengthUnit.Link:
                    return "li";
                case UnitConverterLengthUnit.Rod:
                    return "rd";
                case UnitConverterLengthUnit.Chain:
                    return "ch";
                case UnitConverterLengthUnit.Furlong:
                    return "fur";
                case UnitConverterLengthUnit.Fathom:
                    return "ftm";
                case UnitConverterLengthUnit.Cable:
                    return "cable";
                case UnitConverterLengthUnit.NauticalMile:
                    return "nmi";
                case UnitConverterLengthUnit.AstronomicalUnit:
                    return "au";
                case UnitConverterLengthUnit.LightYear:
                    return "ly";
                case UnitConverterLengthUnit.Parsec:
                    return "pc";
                case UnitConverterLengthUnit.Cubit:
                    return "cubit";
                case UnitConverterLengthUnit.Span:
                    return "span";
                case UnitConverterLengthUnit.Pace:
                    return "pace";
                case UnitConverterLengthUnit.Ell:
                    return "ell";
                case UnitConverterLengthUnit.Quectometer:
                    return "qm";
                case UnitConverterLengthUnit.Rontometer:
                    return "rm";
                case UnitConverterLengthUnit.Yoctometer:
                    return "ym";
                case UnitConverterLengthUnit.Zeptometer:
                    return "zm";
                case UnitConverterLengthUnit.Attometer:
                    return "am";
                case UnitConverterLengthUnit.Petameter:
                    return "Pm";
                case UnitConverterLengthUnit.Exameter:
                    return "Em";
                case UnitConverterLengthUnit.Zettameter:
                    return "Zm";
                case UnitConverterLengthUnit.Yottameter:
                    return "Ym";
                case UnitConverterLengthUnit.Ronnameter:
                    return "Rm";
                case UnitConverterLengthUnit.Quettameter:
                    return "Qm";
                case UnitConverterLengthUnit.Fermi:
                    return "fermi";
                case UnitConverterLengthUnit.BohrRadius:
                    return "a₀";
                case UnitConverterLengthUnit.PlanckLength:
                    return "ℓP";
                case UnitConverterLengthUnit.ClassicalElectronRadius:
                    return "re";
                case UnitConverterLengthUnit.EarthEquatorialRadius:
                    return "Rₑ";
                case UnitConverterLengthUnit.EarthMeanRadius:
                    return "Rₘ";
                case UnitConverterLengthUnit.SolarRadius:
                    return "R☉";
                case UnitConverterLengthUnit.LunarDistance:
                    return "LD";
                case UnitConverterLengthUnit.PointPostScript:
                    return "pt";
                case UnitConverterLengthUnit.PicaPostScript:
                    return "pc";
                case UnitConverterLengthUnit.DidotPoint:
                    return "dd";
                case UnitConverterLengthUnit.Cicero:
                    return "cicero";
                case UnitConverterLengthUnit.Barleycorn:
                    return "barleycorn";
                case UnitConverterLengthUnit.Nail:
                    return "nail";
                case UnitConverterLengthUnit.Palm:
                    return "palm";
                case UnitConverterLengthUnit.RomanFoot:
                    return "pes";
                case UnitConverterLengthUnit.Arshin:
                    return "arshin";
                case UnitConverterLengthUnit.Vara:
                    return "vara";
                case UnitConverterLengthUnit.Smoot:
                    return "smoot";
                case UnitConverterLengthUnit.NauticalLeague:
                    return "nlea";
                case UnitConverterLengthUnit.Twip:
                    return "twip";
                case UnitConverterLengthUnit.PrinterPoint:
                    return "pt printer";
                case UnitConverterLengthUnit.PrinterPica:
                    return "pc printer";
                case UnitConverterLengthUnit.Ken:
                    return "ken";
                case UnitConverterLengthUnit.Shaku:
                    return "shaku";
                case UnitConverterLengthUnit.Ri:
                    return "ri";
                case UnitConverterLengthUnit.LiChinese:
                    return "li";
                case UnitConverterLengthUnit.ChiChinese:
                    return "chi";
                case UnitConverterLengthUnit.Kiloparsec:
                    return "kpc";
                case UnitConverterLengthUnit.Megaparsec:
                    return "Mpc";
                case UnitConverterLengthUnit.Gigaparsec:
                    return "Gpc";
                case UnitConverterLengthUnit.LightSecond:
                    return "light-second";
                case UnitConverterLengthUnit.LightMinute:
                    return "light-minute";
                case UnitConverterLengthUnit.LightHour:
                    return "light-hour";
                case UnitConverterLengthUnit.LightDay:
                    return "light-day";
                case UnitConverterLengthUnit.LightWeek:
                    return "light-week";
                case UnitConverterLengthUnit.Microinch:
                    return "µin";
                case UnitConverterLengthUnit.Nanoinch:
                    return "nin";
                case UnitConverterLengthUnit.Caliber:
                    return "cal";
                case UnitConverterLengthUnit.RackUnit:
                    return "U";
                case UnitConverterLengthUnit.Quarter:
                    return "qr";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLengthUnit.Femtometer:
                    return "femtometer";
                case UnitConverterLengthUnit.Picometer:
                    return "picometer";
                case UnitConverterLengthUnit.Nanometer:
                    return "nanometer";
                case UnitConverterLengthUnit.Micrometer:
                    return "micrometer";
                case UnitConverterLengthUnit.Millimeter:
                    return "millimeter";
                case UnitConverterLengthUnit.Centimeter:
                    return "centimeter";
                case UnitConverterLengthUnit.Decimeter:
                    return "decimeter";
                case UnitConverterLengthUnit.Meter:
                    return "meter";
                case UnitConverterLengthUnit.Decameter:
                    return "decameter";
                case UnitConverterLengthUnit.Hectometer:
                    return "hectometer";
                case UnitConverterLengthUnit.Kilometer:
                    return "kilometer";
                case UnitConverterLengthUnit.Megameter:
                    return "megameter";
                case UnitConverterLengthUnit.Gigameter:
                    return "gigameter";
                case UnitConverterLengthUnit.Angstrom:
                    return "ångström";
                case UnitConverterLengthUnit.Thou:
                    return "thou";
                case UnitConverterLengthUnit.Inch:
                    return "inch";
                case UnitConverterLengthUnit.Foot:
                    return "foot";
                case UnitConverterLengthUnit.Yard:
                    return "yard";
                case UnitConverterLengthUnit.Mile:
                    return "mile";
                case UnitConverterLengthUnit.League:
                    return "league";
                case UnitConverterLengthUnit.Hand:
                    return "hand";
                case UnitConverterLengthUnit.USSurveyInch:
                    return "US survey inch";
                case UnitConverterLengthUnit.USSurveyFoot:
                    return "US survey foot";
                case UnitConverterLengthUnit.USSurveyYard:
                    return "US survey yard";
                case UnitConverterLengthUnit.USSurveyMile:
                    return "US survey mile";
                case UnitConverterLengthUnit.Link:
                    return "link";
                case UnitConverterLengthUnit.Rod:
                    return "rod";
                case UnitConverterLengthUnit.Chain:
                    return "chain";
                case UnitConverterLengthUnit.Furlong:
                    return "furlong";
                case UnitConverterLengthUnit.Fathom:
                    return "fathom";
                case UnitConverterLengthUnit.Cable:
                    return "cable";
                case UnitConverterLengthUnit.NauticalMile:
                    return "nautical mile";
                case UnitConverterLengthUnit.AstronomicalUnit:
                    return "astronomical unit";
                case UnitConverterLengthUnit.LightYear:
                    return "light-year";
                case UnitConverterLengthUnit.Parsec:
                    return "parsec";
                case UnitConverterLengthUnit.Cubit:
                    return "cubit";
                case UnitConverterLengthUnit.Span:
                    return "span";
                case UnitConverterLengthUnit.Pace:
                    return "pace";
                case UnitConverterLengthUnit.Ell:
                    return "ell";
                case UnitConverterLengthUnit.Quectometer:
                    return "Quectometer";
                case UnitConverterLengthUnit.Rontometer:
                    return "Rontometer";
                case UnitConverterLengthUnit.Yoctometer:
                    return "Yoctometer";
                case UnitConverterLengthUnit.Zeptometer:
                    return "Zeptometer";
                case UnitConverterLengthUnit.Attometer:
                    return "Attometer";
                case UnitConverterLengthUnit.Petameter:
                    return "Petameter";
                case UnitConverterLengthUnit.Exameter:
                    return "Exameter";
                case UnitConverterLengthUnit.Zettameter:
                    return "Zettameter";
                case UnitConverterLengthUnit.Yottameter:
                    return "Yottameter";
                case UnitConverterLengthUnit.Ronnameter:
                    return "Ronnameter";
                case UnitConverterLengthUnit.Quettameter:
                    return "Quettameter";
                case UnitConverterLengthUnit.Fermi:
                    return "Fermi";
                case UnitConverterLengthUnit.BohrRadius:
                    return "Bohr Radius";
                case UnitConverterLengthUnit.PlanckLength:
                    return "Planck Length";
                case UnitConverterLengthUnit.ClassicalElectronRadius:
                    return "Classical Electron Radius";
                case UnitConverterLengthUnit.EarthEquatorialRadius:
                    return "Earth Equatorial Radius";
                case UnitConverterLengthUnit.EarthMeanRadius:
                    return "Earth Mean Radius";
                case UnitConverterLengthUnit.SolarRadius:
                    return "Solar Radius";
                case UnitConverterLengthUnit.LunarDistance:
                    return "Lunar Distance";
                case UnitConverterLengthUnit.PointPostScript:
                    return "Point (PostScript)";
                case UnitConverterLengthUnit.PicaPostScript:
                    return "Pica (PostScript)";
                case UnitConverterLengthUnit.DidotPoint:
                    return "Didot Point";
                case UnitConverterLengthUnit.Cicero:
                    return "Cicero";
                case UnitConverterLengthUnit.Barleycorn:
                    return "Barleycorn";
                case UnitConverterLengthUnit.Nail:
                    return "Nail";
                case UnitConverterLengthUnit.Palm:
                    return "Palm";
                case UnitConverterLengthUnit.RomanFoot:
                    return "Roman Foot";
                case UnitConverterLengthUnit.Arshin:
                    return "Arshin";
                case UnitConverterLengthUnit.Vara:
                    return "Vara";
                case UnitConverterLengthUnit.Smoot:
                    return "Smoot";
                case UnitConverterLengthUnit.NauticalLeague:
                    return "Nautical League";
                case UnitConverterLengthUnit.Twip:
                    return "Twip";
                case UnitConverterLengthUnit.PrinterPoint:
                    return "Printer Point";
                case UnitConverterLengthUnit.PrinterPica:
                    return "Printer Pica";
                case UnitConverterLengthUnit.Ken:
                    return "Ken";
                case UnitConverterLengthUnit.Shaku:
                    return "Shaku";
                case UnitConverterLengthUnit.Ri:
                    return "Ri";
                case UnitConverterLengthUnit.LiChinese:
                    return "Li Chinese";
                case UnitConverterLengthUnit.ChiChinese:
                    return "Chi Chinese";
                case UnitConverterLengthUnit.Kiloparsec:
                    return "Kiloparsec";
                case UnitConverterLengthUnit.Megaparsec:
                    return "Megaparsec";
                case UnitConverterLengthUnit.Gigaparsec:
                    return "Gigaparsec";
                case UnitConverterLengthUnit.LightSecond:
                    return "Light Second";
                case UnitConverterLengthUnit.LightMinute:
                    return "Light Minute";
                case UnitConverterLengthUnit.LightHour:
                    return "Light Hour";
                case UnitConverterLengthUnit.LightDay:
                    return "Light Day";
                case UnitConverterLengthUnit.LightWeek:
                    return "Light Week";
                case UnitConverterLengthUnit.Microinch:
                    return "Microinch";
                case UnitConverterLengthUnit.Nanoinch:
                    return "Nanoinch";
                case UnitConverterLengthUnit.Caliber:
                    return "Caliber";
                case UnitConverterLengthUnit.RackUnit:
                    return "Rack Unit";
                case UnitConverterLengthUnit.Quarter:
                    return "Quarter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterLengthUnit unit)
        {
            switch (unit)
            {
                case UnitConverterLengthUnit.Femtometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Picometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Nanometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Micrometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Millimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Centimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Decimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Meter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Decameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Hectometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Kilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Megameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Gigameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Angstrom:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLengthUnit.Thou:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Inch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Foot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Yard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Mile:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.League:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Hand:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.USSurveyInch:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterLengthUnit.USSurveyFoot:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterLengthUnit.USSurveyYard:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterLengthUnit.USSurveyMile:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterLengthUnit.Link:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterLengthUnit.Rod:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterLengthUnit.Chain:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterLengthUnit.Furlong:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterLengthUnit.Fathom:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterLengthUnit.Cable:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterLengthUnit.NauticalMile:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterLengthUnit.AstronomicalUnit:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightYear:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.Parsec:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.Cubit:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Span:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Pace:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Ell:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Quectometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Rontometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Yoctometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Zeptometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Attometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Petameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Exameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Zettameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Yottameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Ronnameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Quettameter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterLengthUnit.Fermi:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLengthUnit.BohrRadius:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLengthUnit.PlanckLength:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLengthUnit.ClassicalElectronRadius:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterLengthUnit.EarthEquatorialRadius:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.EarthMeanRadius:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.SolarRadius:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LunarDistance:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.PointPostScript:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.PicaPostScript:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.DidotPoint:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Cicero:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Barleycorn:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Nail:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Palm:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.RomanFoot:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Arshin:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Vara:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Smoot:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.NauticalLeague:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterLengthUnit.Twip:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.PrinterPoint:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.PrinterPica:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.Ken:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Shaku:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Ri:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.LiChinese:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.ChiChinese:
                    return UnitConverterUnitSystem.Historical;
                case UnitConverterLengthUnit.Kiloparsec:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.Megaparsec:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.Gigaparsec:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightSecond:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightMinute:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightHour:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightDay:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.LightWeek:
                    return UnitConverterUnitSystem.Astronomical;
                case UnitConverterLengthUnit.Microinch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Nanoinch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.Caliber:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterLengthUnit.RackUnit:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterLengthUnit.Quarter:
                    return UnitConverterUnitSystem.Historical;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterLengthUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterLengthUnit.Femtometer, UnitConverterLengthUnit.Picometer, UnitConverterLengthUnit.Nanometer, UnitConverterLengthUnit.Micrometer, UnitConverterLengthUnit.Millimeter, UnitConverterLengthUnit.Centimeter, UnitConverterLengthUnit.Decimeter, UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Decameter, UnitConverterLengthUnit.Hectometer, UnitConverterLengthUnit.Kilometer, UnitConverterLengthUnit.Megameter, UnitConverterLengthUnit.Gigameter, UnitConverterLengthUnit.Quectometer, UnitConverterLengthUnit.Rontometer, UnitConverterLengthUnit.Yoctometer, UnitConverterLengthUnit.Zeptometer, UnitConverterLengthUnit.Attometer, UnitConverterLengthUnit.Petameter, UnitConverterLengthUnit.Exameter, UnitConverterLengthUnit.Zettameter, UnitConverterLengthUnit.Yottameter, UnitConverterLengthUnit.Ronnameter, UnitConverterLengthUnit.Quettameter };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterLengthUnit.Angstrom, UnitConverterLengthUnit.Fermi, UnitConverterLengthUnit.BohrRadius, UnitConverterLengthUnit.PlanckLength, UnitConverterLengthUnit.ClassicalElectronRadius };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterLengthUnit.Thou, UnitConverterLengthUnit.Inch, UnitConverterLengthUnit.Foot, UnitConverterLengthUnit.Yard, UnitConverterLengthUnit.Mile, UnitConverterLengthUnit.League, UnitConverterLengthUnit.Hand, UnitConverterLengthUnit.Microinch, UnitConverterLengthUnit.Nanoinch, UnitConverterLengthUnit.Caliber };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterLengthUnit.USSurveyInch, UnitConverterLengthUnit.USSurveyFoot, UnitConverterLengthUnit.USSurveyYard, UnitConverterLengthUnit.USSurveyMile };
                case UnitConverterUnitSystem.Survey:
                    return new[] { UnitConverterLengthUnit.Link, UnitConverterLengthUnit.Rod, UnitConverterLengthUnit.Chain, UnitConverterLengthUnit.Furlong };
                case UnitConverterUnitSystem.Nautical:
                    return new[] { UnitConverterLengthUnit.Fathom, UnitConverterLengthUnit.Cable, UnitConverterLengthUnit.NauticalMile, UnitConverterLengthUnit.NauticalLeague };
                case UnitConverterUnitSystem.Astronomical:
                    return new[] { UnitConverterLengthUnit.AstronomicalUnit, UnitConverterLengthUnit.LightYear, UnitConverterLengthUnit.Parsec, UnitConverterLengthUnit.EarthEquatorialRadius, UnitConverterLengthUnit.EarthMeanRadius, UnitConverterLengthUnit.SolarRadius, UnitConverterLengthUnit.LunarDistance, UnitConverterLengthUnit.Kiloparsec, UnitConverterLengthUnit.Megaparsec, UnitConverterLengthUnit.Gigaparsec, UnitConverterLengthUnit.LightSecond, UnitConverterLengthUnit.LightMinute, UnitConverterLengthUnit.LightHour, UnitConverterLengthUnit.LightDay, UnitConverterLengthUnit.LightWeek };
                case UnitConverterUnitSystem.Historical:
                    return new[] { UnitConverterLengthUnit.Cubit, UnitConverterLengthUnit.Span, UnitConverterLengthUnit.Pace, UnitConverterLengthUnit.Ell, UnitConverterLengthUnit.DidotPoint, UnitConverterLengthUnit.Cicero, UnitConverterLengthUnit.Barleycorn, UnitConverterLengthUnit.Nail, UnitConverterLengthUnit.Palm, UnitConverterLengthUnit.RomanFoot, UnitConverterLengthUnit.Arshin, UnitConverterLengthUnit.Vara, UnitConverterLengthUnit.Smoot, UnitConverterLengthUnit.Ken, UnitConverterLengthUnit.Shaku, UnitConverterLengthUnit.Ri, UnitConverterLengthUnit.LiChinese, UnitConverterLengthUnit.ChiChinese, UnitConverterLengthUnit.Quarter };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterLengthUnit.PointPostScript, UnitConverterLengthUnit.PicaPostScript, UnitConverterLengthUnit.Twip, UnitConverterLengthUnit.PrinterPoint, UnitConverterLengthUnit.PrinterPica, UnitConverterLengthUnit.RackUnit };
                default:
                    return new[] { UnitConverterLengthUnit.Femtometer, UnitConverterLengthUnit.Picometer, UnitConverterLengthUnit.Nanometer, UnitConverterLengthUnit.Micrometer, UnitConverterLengthUnit.Millimeter, UnitConverterLengthUnit.Centimeter, UnitConverterLengthUnit.Decimeter, UnitConverterLengthUnit.Meter, UnitConverterLengthUnit.Decameter, UnitConverterLengthUnit.Hectometer, UnitConverterLengthUnit.Kilometer, UnitConverterLengthUnit.Megameter, UnitConverterLengthUnit.Gigameter, UnitConverterLengthUnit.Angstrom, UnitConverterLengthUnit.Thou, UnitConverterLengthUnit.Inch, UnitConverterLengthUnit.Foot, UnitConverterLengthUnit.Yard, UnitConverterLengthUnit.Mile, UnitConverterLengthUnit.League, UnitConverterLengthUnit.Hand, UnitConverterLengthUnit.USSurveyInch, UnitConverterLengthUnit.USSurveyFoot, UnitConverterLengthUnit.USSurveyYard, UnitConverterLengthUnit.USSurveyMile, UnitConverterLengthUnit.Link, UnitConverterLengthUnit.Rod, UnitConverterLengthUnit.Chain, UnitConverterLengthUnit.Furlong, UnitConverterLengthUnit.Fathom, UnitConverterLengthUnit.Cable, UnitConverterLengthUnit.NauticalMile, UnitConverterLengthUnit.AstronomicalUnit, UnitConverterLengthUnit.LightYear, UnitConverterLengthUnit.Parsec, UnitConverterLengthUnit.Cubit, UnitConverterLengthUnit.Span, UnitConverterLengthUnit.Pace, UnitConverterLengthUnit.Ell, UnitConverterLengthUnit.Quectometer, UnitConverterLengthUnit.Rontometer, UnitConverterLengthUnit.Yoctometer, UnitConverterLengthUnit.Zeptometer, UnitConverterLengthUnit.Attometer, UnitConverterLengthUnit.Petameter, UnitConverterLengthUnit.Exameter, UnitConverterLengthUnit.Zettameter, UnitConverterLengthUnit.Yottameter, UnitConverterLengthUnit.Ronnameter, UnitConverterLengthUnit.Quettameter, UnitConverterLengthUnit.Fermi, UnitConverterLengthUnit.BohrRadius, UnitConverterLengthUnit.PlanckLength, UnitConverterLengthUnit.ClassicalElectronRadius, UnitConverterLengthUnit.EarthEquatorialRadius, UnitConverterLengthUnit.EarthMeanRadius, UnitConverterLengthUnit.SolarRadius, UnitConverterLengthUnit.LunarDistance, UnitConverterLengthUnit.PointPostScript, UnitConverterLengthUnit.PicaPostScript, UnitConverterLengthUnit.DidotPoint, UnitConverterLengthUnit.Cicero, UnitConverterLengthUnit.Barleycorn, UnitConverterLengthUnit.Nail, UnitConverterLengthUnit.Palm, UnitConverterLengthUnit.RomanFoot, UnitConverterLengthUnit.Arshin, UnitConverterLengthUnit.Vara, UnitConverterLengthUnit.Smoot, UnitConverterLengthUnit.NauticalLeague, UnitConverterLengthUnit.Twip, UnitConverterLengthUnit.PrinterPoint, UnitConverterLengthUnit.PrinterPica, UnitConverterLengthUnit.Ken, UnitConverterLengthUnit.Shaku, UnitConverterLengthUnit.Ri, UnitConverterLengthUnit.LiChinese, UnitConverterLengthUnit.ChiChinese, UnitConverterLengthUnit.Kiloparsec, UnitConverterLengthUnit.Megaparsec, UnitConverterLengthUnit.Gigaparsec, UnitConverterLengthUnit.LightSecond, UnitConverterLengthUnit.LightMinute, UnitConverterLengthUnit.LightHour, UnitConverterLengthUnit.LightDay, UnitConverterLengthUnit.LightWeek, UnitConverterLengthUnit.Microinch, UnitConverterLengthUnit.Nanoinch, UnitConverterLengthUnit.Caliber, UnitConverterLengthUnit.RackUnit, UnitConverterLengthUnit.Quarter };
            }
        }
    }
}
