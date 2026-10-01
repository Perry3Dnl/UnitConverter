namespace UnitConverter.Volume
{
    using UnitConverter.Volume.Metric;
    using UnitConverter.Volume.ImperialUS;
    using UnitConverter.Volume.ImperialUK;
    using UnitConverter.Volume.Imperial;
    using UnitConverter.Volume.Engineering;
    using UnitConverter.Volume.Cooking;
    using UnitConverter.Volume.Survey;
    using UnitConverter.Volume.Common;

    public enum UnitConverterVolumeUnit
    {
        CubicMillimeter = 0,
        Milliliter = 1,
        Centiliter = 2,
        Deciliter = 3,
        Liter = 4,
        Decaliter = 5,
        Hectoliter = 6,
        Kiloliter = 7,
        CubicCentimeter = 8,
        CubicMeter = 9,
        USTeaspoon = 10,
        USTablespoon = 11,
        USFluidOunce = 12,
        USCup = 13,
        USPint = 14,
        USQuart = 15,
        USGallon = 16,
        USDryPint = 17,
        USDryQuart = 18,
        USDryGallon = 19,
        USBushel = 20,
        ImperialTeaspoon = 21,
        ImperialTablespoon = 22,
        ImperialFluidOunce = 23,
        ImperialGill = 24,
        ImperialPint = 25,
        ImperialQuart = 26,
        ImperialGallon = 27,
        ImperialBushel = 28,
        CubicInch = 29,
        CubicFoot = 30,
        CubicYard = 31,
        OilBarrel = 32,
        BeerBarrelUS = 33,
        RegisterTon = 34,
        CubicNanometer = 35,
        CubicMicrometer = 36,
        Microliter = 37,
        Nanoliter = 38,
        Picoliter = 39,
        Femtoliter = 40,
        CubicDecimeter = 41,
        CubicKilometer = 42,
        Stere = 43,
        MetricTeaspoon = 44,
        MetricTablespoon = 45,
        MetricCup = 46,
        USGill = 47,
        USPeck = 48,
        USHogshead = 49,
        USMinim = 50,
        USFluidDram = 51,
        ImperialPeck = 52,
        ImperialHogshead = 53,
        ImperialMinim = 54,
        ImperialFluidDram = 55,
        BoardFoot = 56,
        AcreFoot = 57,
        Cord = 58,
        Drop = 59,
        Dash = 60,
        Pinch = 61,
        USShot = 62,
        ImperialShot = 63,
        USDessertSpoon = 64,
        ImperialDessertSpoon = 65,
        OilBarrelPerThousand = 66,
    }

    public static class UnitConverterVolume
    {
        public static double Convert(double value, UnitConverterVolumeUnit from, UnitConverterVolumeUnit to)
        {
            double baseValue = ToLiter(value, from);
            return FromLiter(baseValue, to);
        }

        public static double ToLiter(double value, UnitConverterVolumeUnit from)
        {
            switch (from)
            {
                case UnitConverterVolumeUnit.CubicMillimeter:
                    return UnitConverterMetricVolume.CubicMillimeterToLiter(value);
                case UnitConverterVolumeUnit.Milliliter:
                    return UnitConverterMetricVolume.MilliliterToLiter(value);
                case UnitConverterVolumeUnit.Centiliter:
                    return UnitConverterMetricVolume.CentiliterToLiter(value);
                case UnitConverterVolumeUnit.Deciliter:
                    return UnitConverterMetricVolume.DeciliterToLiter(value);
                case UnitConverterVolumeUnit.Liter:
                    return UnitConverterMetricVolume.LiterToLiter(value);
                case UnitConverterVolumeUnit.Decaliter:
                    return UnitConverterMetricVolume.DecaliterToLiter(value);
                case UnitConverterVolumeUnit.Hectoliter:
                    return UnitConverterMetricVolume.HectoliterToLiter(value);
                case UnitConverterVolumeUnit.Kiloliter:
                    return UnitConverterMetricVolume.KiloliterToLiter(value);
                case UnitConverterVolumeUnit.CubicCentimeter:
                    return UnitConverterMetricVolume.CubicCentimeterToLiter(value);
                case UnitConverterVolumeUnit.CubicMeter:
                    return UnitConverterMetricVolume.CubicMeterToLiter(value);
                case UnitConverterVolumeUnit.USTeaspoon:
                    return UnitConverterImperialUSVolume.USTeaspoonToLiter(value);
                case UnitConverterVolumeUnit.USTablespoon:
                    return UnitConverterImperialUSVolume.USTablespoonToLiter(value);
                case UnitConverterVolumeUnit.USFluidOunce:
                    return UnitConverterImperialUSVolume.USFluidOunceToLiter(value);
                case UnitConverterVolumeUnit.USCup:
                    return UnitConverterImperialUSVolume.USCupToLiter(value);
                case UnitConverterVolumeUnit.USPint:
                    return UnitConverterImperialUSVolume.USPintToLiter(value);
                case UnitConverterVolumeUnit.USQuart:
                    return UnitConverterImperialUSVolume.USQuartToLiter(value);
                case UnitConverterVolumeUnit.USGallon:
                    return UnitConverterImperialUSVolume.USGallonToLiter(value);
                case UnitConverterVolumeUnit.USDryPint:
                    return UnitConverterImperialUSVolume.USDryPintToLiter(value);
                case UnitConverterVolumeUnit.USDryQuart:
                    return UnitConverterImperialUSVolume.USDryQuartToLiter(value);
                case UnitConverterVolumeUnit.USDryGallon:
                    return UnitConverterImperialUSVolume.USDryGallonToLiter(value);
                case UnitConverterVolumeUnit.USBushel:
                    return UnitConverterImperialUSVolume.USBushelToLiter(value);
                case UnitConverterVolumeUnit.ImperialTeaspoon:
                    return UnitConverterImperialUKVolume.ImperialTeaspoonToLiter(value);
                case UnitConverterVolumeUnit.ImperialTablespoon:
                    return UnitConverterImperialUKVolume.ImperialTablespoonToLiter(value);
                case UnitConverterVolumeUnit.ImperialFluidOunce:
                    return UnitConverterImperialUKVolume.ImperialFluidOunceToLiter(value);
                case UnitConverterVolumeUnit.ImperialGill:
                    return UnitConverterImperialUKVolume.ImperialGillToLiter(value);
                case UnitConverterVolumeUnit.ImperialPint:
                    return UnitConverterImperialUKVolume.ImperialPintToLiter(value);
                case UnitConverterVolumeUnit.ImperialQuart:
                    return UnitConverterImperialUKVolume.ImperialQuartToLiter(value);
                case UnitConverterVolumeUnit.ImperialGallon:
                    return UnitConverterImperialUKVolume.ImperialGallonToLiter(value);
                case UnitConverterVolumeUnit.ImperialBushel:
                    return UnitConverterImperialUKVolume.ImperialBushelToLiter(value);
                case UnitConverterVolumeUnit.CubicInch:
                    return UnitConverterImperialVolume.CubicInchToLiter(value);
                case UnitConverterVolumeUnit.CubicFoot:
                    return UnitConverterImperialVolume.CubicFootToLiter(value);
                case UnitConverterVolumeUnit.CubicYard:
                    return UnitConverterImperialVolume.CubicYardToLiter(value);
                case UnitConverterVolumeUnit.OilBarrel:
                    return UnitConverterEngineeringVolume.OilBarrelToLiter(value);
                case UnitConverterVolumeUnit.BeerBarrelUS:
                    return UnitConverterImperialUSVolume.BeerBarrelUSToLiter(value);
                case UnitConverterVolumeUnit.RegisterTon:
                    return UnitConverterEngineeringVolume.RegisterTonToLiter(value);
                case UnitConverterVolumeUnit.CubicNanometer:
                    return UnitConverterMetricVolume.CubicNanometerToLiter(value);
                case UnitConverterVolumeUnit.CubicMicrometer:
                    return UnitConverterMetricVolume.CubicMicrometerToLiter(value);
                case UnitConverterVolumeUnit.Microliter:
                    return UnitConverterMetricVolume.MicroliterToLiter(value);
                case UnitConverterVolumeUnit.Nanoliter:
                    return UnitConverterMetricVolume.NanoliterToLiter(value);
                case UnitConverterVolumeUnit.Picoliter:
                    return UnitConverterMetricVolume.PicoliterToLiter(value);
                case UnitConverterVolumeUnit.Femtoliter:
                    return UnitConverterMetricVolume.FemtoliterToLiter(value);
                case UnitConverterVolumeUnit.CubicDecimeter:
                    return UnitConverterMetricVolume.CubicDecimeterToLiter(value);
                case UnitConverterVolumeUnit.CubicKilometer:
                    return UnitConverterMetricVolume.CubicKilometerToLiter(value);
                case UnitConverterVolumeUnit.Stere:
                    return UnitConverterMetricVolume.StereToLiter(value);
                case UnitConverterVolumeUnit.MetricTeaspoon:
                    return UnitConverterCookingVolume.MetricTeaspoonToLiter(value);
                case UnitConverterVolumeUnit.MetricTablespoon:
                    return UnitConverterCookingVolume.MetricTablespoonToLiter(value);
                case UnitConverterVolumeUnit.MetricCup:
                    return UnitConverterCookingVolume.MetricCupToLiter(value);
                case UnitConverterVolumeUnit.USGill:
                    return UnitConverterImperialUSVolume.USGillToLiter(value);
                case UnitConverterVolumeUnit.USPeck:
                    return UnitConverterImperialUSVolume.USPeckToLiter(value);
                case UnitConverterVolumeUnit.USHogshead:
                    return UnitConverterImperialUSVolume.USHogsheadToLiter(value);
                case UnitConverterVolumeUnit.USMinim:
                    return UnitConverterImperialUSVolume.USMinimToLiter(value);
                case UnitConverterVolumeUnit.USFluidDram:
                    return UnitConverterImperialUSVolume.USFluidDramToLiter(value);
                case UnitConverterVolumeUnit.ImperialPeck:
                    return UnitConverterImperialUKVolume.ImperialPeckToLiter(value);
                case UnitConverterVolumeUnit.ImperialHogshead:
                    return UnitConverterImperialUKVolume.ImperialHogsheadToLiter(value);
                case UnitConverterVolumeUnit.ImperialMinim:
                    return UnitConverterImperialUKVolume.ImperialMinimToLiter(value);
                case UnitConverterVolumeUnit.ImperialFluidDram:
                    return UnitConverterImperialUKVolume.ImperialFluidDramToLiter(value);
                case UnitConverterVolumeUnit.BoardFoot:
                    return UnitConverterImperialVolume.BoardFootToLiter(value);
                case UnitConverterVolumeUnit.AcreFoot:
                    return UnitConverterSurveyVolume.AcreFootToLiter(value);
                case UnitConverterVolumeUnit.Cord:
                    return UnitConverterImperialVolume.CordToLiter(value);
                case UnitConverterVolumeUnit.Drop:
                    return UnitConverterCommonVolume.DropToLiter(value);
                case UnitConverterVolumeUnit.Dash:
                    return UnitConverterCookingVolume.DashToLiter(value);
                case UnitConverterVolumeUnit.Pinch:
                    return UnitConverterCookingVolume.PinchToLiter(value);
                case UnitConverterVolumeUnit.USShot:
                    return UnitConverterCookingVolume.USShotToLiter(value);
                case UnitConverterVolumeUnit.ImperialShot:
                    return UnitConverterCookingVolume.ImperialShotToLiter(value);
                case UnitConverterVolumeUnit.USDessertSpoon:
                    return UnitConverterCookingVolume.USDessertSpoonToLiter(value);
                case UnitConverterVolumeUnit.ImperialDessertSpoon:
                    return UnitConverterCookingVolume.ImperialDessertSpoonToLiter(value);
                case UnitConverterVolumeUnit.OilBarrelPerThousand:
                    return UnitConverterEngineeringVolume.OilBarrelPerThousandToLiter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volume unit.");
            }
        }

        public static double FromLiter(double baseValue, UnitConverterVolumeUnit to)
        {
            switch (to)
            {
                case UnitConverterVolumeUnit.CubicMillimeter:
                    return UnitConverterMetricVolume.LiterToCubicMillimeter(baseValue);
                case UnitConverterVolumeUnit.Milliliter:
                    return UnitConverterMetricVolume.LiterToMilliliter(baseValue);
                case UnitConverterVolumeUnit.Centiliter:
                    return UnitConverterMetricVolume.LiterToCentiliter(baseValue);
                case UnitConverterVolumeUnit.Deciliter:
                    return UnitConverterMetricVolume.LiterToDeciliter(baseValue);
                case UnitConverterVolumeUnit.Liter:
                    return UnitConverterMetricVolume.LiterToLiter(baseValue);
                case UnitConverterVolumeUnit.Decaliter:
                    return UnitConverterMetricVolume.LiterToDecaliter(baseValue);
                case UnitConverterVolumeUnit.Hectoliter:
                    return UnitConverterMetricVolume.LiterToHectoliter(baseValue);
                case UnitConverterVolumeUnit.Kiloliter:
                    return UnitConverterMetricVolume.LiterToKiloliter(baseValue);
                case UnitConverterVolumeUnit.CubicCentimeter:
                    return UnitConverterMetricVolume.LiterToCubicCentimeter(baseValue);
                case UnitConverterVolumeUnit.CubicMeter:
                    return UnitConverterMetricVolume.LiterToCubicMeter(baseValue);
                case UnitConverterVolumeUnit.USTeaspoon:
                    return UnitConverterImperialUSVolume.LiterToUSTeaspoon(baseValue);
                case UnitConverterVolumeUnit.USTablespoon:
                    return UnitConverterImperialUSVolume.LiterToUSTablespoon(baseValue);
                case UnitConverterVolumeUnit.USFluidOunce:
                    return UnitConverterImperialUSVolume.LiterToUSFluidOunce(baseValue);
                case UnitConverterVolumeUnit.USCup:
                    return UnitConverterImperialUSVolume.LiterToUSCup(baseValue);
                case UnitConverterVolumeUnit.USPint:
                    return UnitConverterImperialUSVolume.LiterToUSPint(baseValue);
                case UnitConverterVolumeUnit.USQuart:
                    return UnitConverterImperialUSVolume.LiterToUSQuart(baseValue);
                case UnitConverterVolumeUnit.USGallon:
                    return UnitConverterImperialUSVolume.LiterToUSGallon(baseValue);
                case UnitConverterVolumeUnit.USDryPint:
                    return UnitConverterImperialUSVolume.LiterToUSDryPint(baseValue);
                case UnitConverterVolumeUnit.USDryQuart:
                    return UnitConverterImperialUSVolume.LiterToUSDryQuart(baseValue);
                case UnitConverterVolumeUnit.USDryGallon:
                    return UnitConverterImperialUSVolume.LiterToUSDryGallon(baseValue);
                case UnitConverterVolumeUnit.USBushel:
                    return UnitConverterImperialUSVolume.LiterToUSBushel(baseValue);
                case UnitConverterVolumeUnit.ImperialTeaspoon:
                    return UnitConverterImperialUKVolume.LiterToImperialTeaspoon(baseValue);
                case UnitConverterVolumeUnit.ImperialTablespoon:
                    return UnitConverterImperialUKVolume.LiterToImperialTablespoon(baseValue);
                case UnitConverterVolumeUnit.ImperialFluidOunce:
                    return UnitConverterImperialUKVolume.LiterToImperialFluidOunce(baseValue);
                case UnitConverterVolumeUnit.ImperialGill:
                    return UnitConverterImperialUKVolume.LiterToImperialGill(baseValue);
                case UnitConverterVolumeUnit.ImperialPint:
                    return UnitConverterImperialUKVolume.LiterToImperialPint(baseValue);
                case UnitConverterVolumeUnit.ImperialQuart:
                    return UnitConverterImperialUKVolume.LiterToImperialQuart(baseValue);
                case UnitConverterVolumeUnit.ImperialGallon:
                    return UnitConverterImperialUKVolume.LiterToImperialGallon(baseValue);
                case UnitConverterVolumeUnit.ImperialBushel:
                    return UnitConverterImperialUKVolume.LiterToImperialBushel(baseValue);
                case UnitConverterVolumeUnit.CubicInch:
                    return UnitConverterImperialVolume.LiterToCubicInch(baseValue);
                case UnitConverterVolumeUnit.CubicFoot:
                    return UnitConverterImperialVolume.LiterToCubicFoot(baseValue);
                case UnitConverterVolumeUnit.CubicYard:
                    return UnitConverterImperialVolume.LiterToCubicYard(baseValue);
                case UnitConverterVolumeUnit.OilBarrel:
                    return UnitConverterEngineeringVolume.LiterToOilBarrel(baseValue);
                case UnitConverterVolumeUnit.BeerBarrelUS:
                    return UnitConverterImperialUSVolume.LiterToBeerBarrelUS(baseValue);
                case UnitConverterVolumeUnit.RegisterTon:
                    return UnitConverterEngineeringVolume.LiterToRegisterTon(baseValue);
                case UnitConverterVolumeUnit.CubicNanometer:
                    return UnitConverterMetricVolume.LiterToCubicNanometer(baseValue);
                case UnitConverterVolumeUnit.CubicMicrometer:
                    return UnitConverterMetricVolume.LiterToCubicMicrometer(baseValue);
                case UnitConverterVolumeUnit.Microliter:
                    return UnitConverterMetricVolume.LiterToMicroliter(baseValue);
                case UnitConverterVolumeUnit.Nanoliter:
                    return UnitConverterMetricVolume.LiterToNanoliter(baseValue);
                case UnitConverterVolumeUnit.Picoliter:
                    return UnitConverterMetricVolume.LiterToPicoliter(baseValue);
                case UnitConverterVolumeUnit.Femtoliter:
                    return UnitConverterMetricVolume.LiterToFemtoliter(baseValue);
                case UnitConverterVolumeUnit.CubicDecimeter:
                    return UnitConverterMetricVolume.LiterToCubicDecimeter(baseValue);
                case UnitConverterVolumeUnit.CubicKilometer:
                    return UnitConverterMetricVolume.LiterToCubicKilometer(baseValue);
                case UnitConverterVolumeUnit.Stere:
                    return UnitConverterMetricVolume.LiterToStere(baseValue);
                case UnitConverterVolumeUnit.MetricTeaspoon:
                    return UnitConverterCookingVolume.LiterToMetricTeaspoon(baseValue);
                case UnitConverterVolumeUnit.MetricTablespoon:
                    return UnitConverterCookingVolume.LiterToMetricTablespoon(baseValue);
                case UnitConverterVolumeUnit.MetricCup:
                    return UnitConverterCookingVolume.LiterToMetricCup(baseValue);
                case UnitConverterVolumeUnit.USGill:
                    return UnitConverterImperialUSVolume.LiterToUSGill(baseValue);
                case UnitConverterVolumeUnit.USPeck:
                    return UnitConverterImperialUSVolume.LiterToUSPeck(baseValue);
                case UnitConverterVolumeUnit.USHogshead:
                    return UnitConverterImperialUSVolume.LiterToUSHogshead(baseValue);
                case UnitConverterVolumeUnit.USMinim:
                    return UnitConverterImperialUSVolume.LiterToUSMinim(baseValue);
                case UnitConverterVolumeUnit.USFluidDram:
                    return UnitConverterImperialUSVolume.LiterToUSFluidDram(baseValue);
                case UnitConverterVolumeUnit.ImperialPeck:
                    return UnitConverterImperialUKVolume.LiterToImperialPeck(baseValue);
                case UnitConverterVolumeUnit.ImperialHogshead:
                    return UnitConverterImperialUKVolume.LiterToImperialHogshead(baseValue);
                case UnitConverterVolumeUnit.ImperialMinim:
                    return UnitConverterImperialUKVolume.LiterToImperialMinim(baseValue);
                case UnitConverterVolumeUnit.ImperialFluidDram:
                    return UnitConverterImperialUKVolume.LiterToImperialFluidDram(baseValue);
                case UnitConverterVolumeUnit.BoardFoot:
                    return UnitConverterImperialVolume.LiterToBoardFoot(baseValue);
                case UnitConverterVolumeUnit.AcreFoot:
                    return UnitConverterSurveyVolume.LiterToAcreFoot(baseValue);
                case UnitConverterVolumeUnit.Cord:
                    return UnitConverterImperialVolume.LiterToCord(baseValue);
                case UnitConverterVolumeUnit.Drop:
                    return UnitConverterCommonVolume.LiterToDrop(baseValue);
                case UnitConverterVolumeUnit.Dash:
                    return UnitConverterCookingVolume.LiterToDash(baseValue);
                case UnitConverterVolumeUnit.Pinch:
                    return UnitConverterCookingVolume.LiterToPinch(baseValue);
                case UnitConverterVolumeUnit.USShot:
                    return UnitConverterCookingVolume.LiterToUSShot(baseValue);
                case UnitConverterVolumeUnit.ImperialShot:
                    return UnitConverterCookingVolume.LiterToImperialShot(baseValue);
                case UnitConverterVolumeUnit.USDessertSpoon:
                    return UnitConverterCookingVolume.LiterToUSDessertSpoon(baseValue);
                case UnitConverterVolumeUnit.ImperialDessertSpoon:
                    return UnitConverterCookingVolume.LiterToImperialDessertSpoon(baseValue);
                case UnitConverterVolumeUnit.OilBarrelPerThousand:
                    return UnitConverterEngineeringVolume.LiterToOilBarrelPerThousand(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volume unit.");
            }
        }

        public static string GetSymbol(UnitConverterVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumeUnit.CubicMillimeter:
                    return "mm³";
                case UnitConverterVolumeUnit.Milliliter:
                    return "mL";
                case UnitConverterVolumeUnit.Centiliter:
                    return "cL";
                case UnitConverterVolumeUnit.Deciliter:
                    return "dL";
                case UnitConverterVolumeUnit.Liter:
                    return "L";
                case UnitConverterVolumeUnit.Decaliter:
                    return "daL";
                case UnitConverterVolumeUnit.Hectoliter:
                    return "hL";
                case UnitConverterVolumeUnit.Kiloliter:
                    return "kL";
                case UnitConverterVolumeUnit.CubicCentimeter:
                    return "cm³";
                case UnitConverterVolumeUnit.CubicMeter:
                    return "m³";
                case UnitConverterVolumeUnit.USTeaspoon:
                    return "tsp US";
                case UnitConverterVolumeUnit.USTablespoon:
                    return "tbsp US";
                case UnitConverterVolumeUnit.USFluidOunce:
                    return "fl oz US";
                case UnitConverterVolumeUnit.USCup:
                    return "cup US";
                case UnitConverterVolumeUnit.USPint:
                    return "pt US";
                case UnitConverterVolumeUnit.USQuart:
                    return "qt US";
                case UnitConverterVolumeUnit.USGallon:
                    return "gal US";
                case UnitConverterVolumeUnit.USDryPint:
                    return "dry pt US";
                case UnitConverterVolumeUnit.USDryQuart:
                    return "dry qt US";
                case UnitConverterVolumeUnit.USDryGallon:
                    return "dry gal US";
                case UnitConverterVolumeUnit.USBushel:
                    return "bu US";
                case UnitConverterVolumeUnit.ImperialTeaspoon:
                    return "tsp imp";
                case UnitConverterVolumeUnit.ImperialTablespoon:
                    return "tbsp imp";
                case UnitConverterVolumeUnit.ImperialFluidOunce:
                    return "fl oz imp";
                case UnitConverterVolumeUnit.ImperialGill:
                    return "gi imp";
                case UnitConverterVolumeUnit.ImperialPint:
                    return "pt imp";
                case UnitConverterVolumeUnit.ImperialQuart:
                    return "qt imp";
                case UnitConverterVolumeUnit.ImperialGallon:
                    return "gal imp";
                case UnitConverterVolumeUnit.ImperialBushel:
                    return "bu imp";
                case UnitConverterVolumeUnit.CubicInch:
                    return "in³";
                case UnitConverterVolumeUnit.CubicFoot:
                    return "ft³";
                case UnitConverterVolumeUnit.CubicYard:
                    return "yd³";
                case UnitConverterVolumeUnit.OilBarrel:
                    return "bbl";
                case UnitConverterVolumeUnit.BeerBarrelUS:
                    return "bbl beer US";
                case UnitConverterVolumeUnit.RegisterTon:
                    return "RT";
                case UnitConverterVolumeUnit.CubicNanometer:
                    return "nm³";
                case UnitConverterVolumeUnit.CubicMicrometer:
                    return "µm³";
                case UnitConverterVolumeUnit.Microliter:
                    return "µL";
                case UnitConverterVolumeUnit.Nanoliter:
                    return "nL";
                case UnitConverterVolumeUnit.Picoliter:
                    return "pL";
                case UnitConverterVolumeUnit.Femtoliter:
                    return "fL";
                case UnitConverterVolumeUnit.CubicDecimeter:
                    return "dm³";
                case UnitConverterVolumeUnit.CubicKilometer:
                    return "km³";
                case UnitConverterVolumeUnit.Stere:
                    return "st";
                case UnitConverterVolumeUnit.MetricTeaspoon:
                    return "metric tsp";
                case UnitConverterVolumeUnit.MetricTablespoon:
                    return "metric tbsp";
                case UnitConverterVolumeUnit.MetricCup:
                    return "metric cup";
                case UnitConverterVolumeUnit.USGill:
                    return "gi US";
                case UnitConverterVolumeUnit.USPeck:
                    return "pk US";
                case UnitConverterVolumeUnit.USHogshead:
                    return "hhd US";
                case UnitConverterVolumeUnit.USMinim:
                    return "min US";
                case UnitConverterVolumeUnit.USFluidDram:
                    return "fl dr US";
                case UnitConverterVolumeUnit.ImperialPeck:
                    return "pk imp";
                case UnitConverterVolumeUnit.ImperialHogshead:
                    return "hhd imp";
                case UnitConverterVolumeUnit.ImperialMinim:
                    return "min imp";
                case UnitConverterVolumeUnit.ImperialFluidDram:
                    return "fl dr imp";
                case UnitConverterVolumeUnit.BoardFoot:
                    return "fbm";
                case UnitConverterVolumeUnit.AcreFoot:
                    return "acre-ft";
                case UnitConverterVolumeUnit.Cord:
                    return "cord";
                case UnitConverterVolumeUnit.Drop:
                    return "drop";
                case UnitConverterVolumeUnit.Dash:
                    return "dash";
                case UnitConverterVolumeUnit.Pinch:
                    return "pinch";
                case UnitConverterVolumeUnit.USShot:
                    return "shot US";
                case UnitConverterVolumeUnit.ImperialShot:
                    return "shot imp";
                case UnitConverterVolumeUnit.USDessertSpoon:
                    return "dsp US";
                case UnitConverterVolumeUnit.ImperialDessertSpoon:
                    return "dsp imp";
                case UnitConverterVolumeUnit.OilBarrelPerThousand:
                    return "kbbl";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumeUnit.CubicMillimeter:
                    return "cubic millimeter";
                case UnitConverterVolumeUnit.Milliliter:
                    return "milliliter";
                case UnitConverterVolumeUnit.Centiliter:
                    return "centiliter";
                case UnitConverterVolumeUnit.Deciliter:
                    return "deciliter";
                case UnitConverterVolumeUnit.Liter:
                    return "liter";
                case UnitConverterVolumeUnit.Decaliter:
                    return "decaliter";
                case UnitConverterVolumeUnit.Hectoliter:
                    return "hectoliter";
                case UnitConverterVolumeUnit.Kiloliter:
                    return "kiloliter";
                case UnitConverterVolumeUnit.CubicCentimeter:
                    return "cubic centimeter";
                case UnitConverterVolumeUnit.CubicMeter:
                    return "cubic meter";
                case UnitConverterVolumeUnit.USTeaspoon:
                    return "US teaspoon";
                case UnitConverterVolumeUnit.USTablespoon:
                    return "US tablespoon";
                case UnitConverterVolumeUnit.USFluidOunce:
                    return "US fluid ounce";
                case UnitConverterVolumeUnit.USCup:
                    return "US cup";
                case UnitConverterVolumeUnit.USPint:
                    return "US pint";
                case UnitConverterVolumeUnit.USQuart:
                    return "US quart";
                case UnitConverterVolumeUnit.USGallon:
                    return "US gallon";
                case UnitConverterVolumeUnit.USDryPint:
                    return "US dry pint";
                case UnitConverterVolumeUnit.USDryQuart:
                    return "US dry quart";
                case UnitConverterVolumeUnit.USDryGallon:
                    return "US dry gallon";
                case UnitConverterVolumeUnit.USBushel:
                    return "US bushel";
                case UnitConverterVolumeUnit.ImperialTeaspoon:
                    return "imperial teaspoon";
                case UnitConverterVolumeUnit.ImperialTablespoon:
                    return "imperial tablespoon";
                case UnitConverterVolumeUnit.ImperialFluidOunce:
                    return "imperial fluid ounce";
                case UnitConverterVolumeUnit.ImperialGill:
                    return "imperial gill";
                case UnitConverterVolumeUnit.ImperialPint:
                    return "imperial pint";
                case UnitConverterVolumeUnit.ImperialQuart:
                    return "imperial quart";
                case UnitConverterVolumeUnit.ImperialGallon:
                    return "imperial gallon";
                case UnitConverterVolumeUnit.ImperialBushel:
                    return "imperial bushel";
                case UnitConverterVolumeUnit.CubicInch:
                    return "cubic inch";
                case UnitConverterVolumeUnit.CubicFoot:
                    return "cubic foot";
                case UnitConverterVolumeUnit.CubicYard:
                    return "cubic yard";
                case UnitConverterVolumeUnit.OilBarrel:
                    return "oil barrel";
                case UnitConverterVolumeUnit.BeerBarrelUS:
                    return "US beer barrel";
                case UnitConverterVolumeUnit.RegisterTon:
                    return "register ton";
                case UnitConverterVolumeUnit.CubicNanometer:
                    return "Cubic Nanometer";
                case UnitConverterVolumeUnit.CubicMicrometer:
                    return "Cubic Micrometer";
                case UnitConverterVolumeUnit.Microliter:
                    return "Microliter";
                case UnitConverterVolumeUnit.Nanoliter:
                    return "Nanoliter";
                case UnitConverterVolumeUnit.Picoliter:
                    return "Picoliter";
                case UnitConverterVolumeUnit.Femtoliter:
                    return "Femtoliter";
                case UnitConverterVolumeUnit.CubicDecimeter:
                    return "Cubic Decimeter";
                case UnitConverterVolumeUnit.CubicKilometer:
                    return "Cubic Kilometer";
                case UnitConverterVolumeUnit.Stere:
                    return "Stere";
                case UnitConverterVolumeUnit.MetricTeaspoon:
                    return "Metric Teaspoon";
                case UnitConverterVolumeUnit.MetricTablespoon:
                    return "Metric Tablespoon";
                case UnitConverterVolumeUnit.MetricCup:
                    return "Metric Cup";
                case UnitConverterVolumeUnit.USGill:
                    return "US Gill";
                case UnitConverterVolumeUnit.USPeck:
                    return "US Peck";
                case UnitConverterVolumeUnit.USHogshead:
                    return "US Hogshead";
                case UnitConverterVolumeUnit.USMinim:
                    return "US Minim";
                case UnitConverterVolumeUnit.USFluidDram:
                    return "US Fluid Dram";
                case UnitConverterVolumeUnit.ImperialPeck:
                    return "Imperial Peck";
                case UnitConverterVolumeUnit.ImperialHogshead:
                    return "Imperial Hogshead";
                case UnitConverterVolumeUnit.ImperialMinim:
                    return "Imperial Minim";
                case UnitConverterVolumeUnit.ImperialFluidDram:
                    return "Imperial Fluid Dram";
                case UnitConverterVolumeUnit.BoardFoot:
                    return "Board Foot";
                case UnitConverterVolumeUnit.AcreFoot:
                    return "Acre Foot";
                case UnitConverterVolumeUnit.Cord:
                    return "Cord";
                case UnitConverterVolumeUnit.Drop:
                    return "Drop";
                case UnitConverterVolumeUnit.Dash:
                    return "Dash";
                case UnitConverterVolumeUnit.Pinch:
                    return "Pinch";
                case UnitConverterVolumeUnit.USShot:
                    return "US Shot";
                case UnitConverterVolumeUnit.ImperialShot:
                    return "Imperial Shot";
                case UnitConverterVolumeUnit.USDessertSpoon:
                    return "US Dessert Spoon";
                case UnitConverterVolumeUnit.ImperialDessertSpoon:
                    return "Imperial Dessert Spoon";
                case UnitConverterVolumeUnit.OilBarrelPerThousand:
                    return "Oil Barrel Per Thousand";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumeUnit.CubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Milliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Centiliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Deciliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Liter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Decaliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Hectoliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Kiloliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.CubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.CubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.USTeaspoon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USTablespoon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USFluidOunce:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USCup:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USPint:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USQuart:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USDryPint:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USDryQuart:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USDryGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USBushel:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.ImperialTeaspoon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialTablespoon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialFluidOunce:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialGill:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialPint:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialQuart:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialGallon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialBushel:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.CubicInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumeUnit.CubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumeUnit.CubicYard:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumeUnit.OilBarrel:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterVolumeUnit.BeerBarrelUS:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.RegisterTon:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterVolumeUnit.CubicNanometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.CubicMicrometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Microliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Nanoliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Picoliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Femtoliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.CubicDecimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.CubicKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.Stere:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumeUnit.MetricTeaspoon:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.MetricTablespoon:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.MetricCup:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.USGill:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USPeck:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USHogshead:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USMinim:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.USFluidDram:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumeUnit.ImperialPeck:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialHogshead:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialMinim:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.ImperialFluidDram:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumeUnit.BoardFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumeUnit.AcreFoot:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterVolumeUnit.Cord:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumeUnit.Drop:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterVolumeUnit.Dash:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.Pinch:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.USShot:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.ImperialShot:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.USDessertSpoon:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.ImperialDessertSpoon:
                    return UnitConverterUnitSystem.Cooking;
                case UnitConverterVolumeUnit.OilBarrelPerThousand:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterVolumeUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterVolumeUnit.CubicMillimeter, UnitConverterVolumeUnit.Milliliter, UnitConverterVolumeUnit.Centiliter, UnitConverterVolumeUnit.Deciliter, UnitConverterVolumeUnit.Liter, UnitConverterVolumeUnit.Decaliter, UnitConverterVolumeUnit.Hectoliter, UnitConverterVolumeUnit.Kiloliter, UnitConverterVolumeUnit.CubicCentimeter, UnitConverterVolumeUnit.CubicMeter, UnitConverterVolumeUnit.CubicNanometer, UnitConverterVolumeUnit.CubicMicrometer, UnitConverterVolumeUnit.Microliter, UnitConverterVolumeUnit.Nanoliter, UnitConverterVolumeUnit.Picoliter, UnitConverterVolumeUnit.Femtoliter, UnitConverterVolumeUnit.CubicDecimeter, UnitConverterVolumeUnit.CubicKilometer, UnitConverterVolumeUnit.Stere };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterVolumeUnit.USTeaspoon, UnitConverterVolumeUnit.USTablespoon, UnitConverterVolumeUnit.USFluidOunce, UnitConverterVolumeUnit.USCup, UnitConverterVolumeUnit.USPint, UnitConverterVolumeUnit.USQuart, UnitConverterVolumeUnit.USGallon, UnitConverterVolumeUnit.USDryPint, UnitConverterVolumeUnit.USDryQuart, UnitConverterVolumeUnit.USDryGallon, UnitConverterVolumeUnit.USBushel, UnitConverterVolumeUnit.BeerBarrelUS, UnitConverterVolumeUnit.USGill, UnitConverterVolumeUnit.USPeck, UnitConverterVolumeUnit.USHogshead, UnitConverterVolumeUnit.USMinim, UnitConverterVolumeUnit.USFluidDram };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterVolumeUnit.ImperialTeaspoon, UnitConverterVolumeUnit.ImperialTablespoon, UnitConverterVolumeUnit.ImperialFluidOunce, UnitConverterVolumeUnit.ImperialGill, UnitConverterVolumeUnit.ImperialPint, UnitConverterVolumeUnit.ImperialQuart, UnitConverterVolumeUnit.ImperialGallon, UnitConverterVolumeUnit.ImperialBushel, UnitConverterVolumeUnit.ImperialPeck, UnitConverterVolumeUnit.ImperialHogshead, UnitConverterVolumeUnit.ImperialMinim, UnitConverterVolumeUnit.ImperialFluidDram };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterVolumeUnit.CubicInch, UnitConverterVolumeUnit.CubicFoot, UnitConverterVolumeUnit.CubicYard, UnitConverterVolumeUnit.BoardFoot, UnitConverterVolumeUnit.Cord };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterVolumeUnit.OilBarrel, UnitConverterVolumeUnit.RegisterTon, UnitConverterVolumeUnit.OilBarrelPerThousand };
                case UnitConverterUnitSystem.Cooking:
                    return new[] { UnitConverterVolumeUnit.MetricTeaspoon, UnitConverterVolumeUnit.MetricTablespoon, UnitConverterVolumeUnit.MetricCup, UnitConverterVolumeUnit.Dash, UnitConverterVolumeUnit.Pinch, UnitConverterVolumeUnit.USShot, UnitConverterVolumeUnit.ImperialShot, UnitConverterVolumeUnit.USDessertSpoon, UnitConverterVolumeUnit.ImperialDessertSpoon };
                case UnitConverterUnitSystem.Survey:
                    return new[] { UnitConverterVolumeUnit.AcreFoot };
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterVolumeUnit.Drop };
                default:
                    return new[] { UnitConverterVolumeUnit.CubicMillimeter, UnitConverterVolumeUnit.Milliliter, UnitConverterVolumeUnit.Centiliter, UnitConverterVolumeUnit.Deciliter, UnitConverterVolumeUnit.Liter, UnitConverterVolumeUnit.Decaliter, UnitConverterVolumeUnit.Hectoliter, UnitConverterVolumeUnit.Kiloliter, UnitConverterVolumeUnit.CubicCentimeter, UnitConverterVolumeUnit.CubicMeter, UnitConverterVolumeUnit.USTeaspoon, UnitConverterVolumeUnit.USTablespoon, UnitConverterVolumeUnit.USFluidOunce, UnitConverterVolumeUnit.USCup, UnitConverterVolumeUnit.USPint, UnitConverterVolumeUnit.USQuart, UnitConverterVolumeUnit.USGallon, UnitConverterVolumeUnit.USDryPint, UnitConverterVolumeUnit.USDryQuart, UnitConverterVolumeUnit.USDryGallon, UnitConverterVolumeUnit.USBushel, UnitConverterVolumeUnit.ImperialTeaspoon, UnitConverterVolumeUnit.ImperialTablespoon, UnitConverterVolumeUnit.ImperialFluidOunce, UnitConverterVolumeUnit.ImperialGill, UnitConverterVolumeUnit.ImperialPint, UnitConverterVolumeUnit.ImperialQuart, UnitConverterVolumeUnit.ImperialGallon, UnitConverterVolumeUnit.ImperialBushel, UnitConverterVolumeUnit.CubicInch, UnitConverterVolumeUnit.CubicFoot, UnitConverterVolumeUnit.CubicYard, UnitConverterVolumeUnit.OilBarrel, UnitConverterVolumeUnit.BeerBarrelUS, UnitConverterVolumeUnit.RegisterTon, UnitConverterVolumeUnit.CubicNanometer, UnitConverterVolumeUnit.CubicMicrometer, UnitConverterVolumeUnit.Microliter, UnitConverterVolumeUnit.Nanoliter, UnitConverterVolumeUnit.Picoliter, UnitConverterVolumeUnit.Femtoliter, UnitConverterVolumeUnit.CubicDecimeter, UnitConverterVolumeUnit.CubicKilometer, UnitConverterVolumeUnit.Stere, UnitConverterVolumeUnit.MetricTeaspoon, UnitConverterVolumeUnit.MetricTablespoon, UnitConverterVolumeUnit.MetricCup, UnitConverterVolumeUnit.USGill, UnitConverterVolumeUnit.USPeck, UnitConverterVolumeUnit.USHogshead, UnitConverterVolumeUnit.USMinim, UnitConverterVolumeUnit.USFluidDram, UnitConverterVolumeUnit.ImperialPeck, UnitConverterVolumeUnit.ImperialHogshead, UnitConverterVolumeUnit.ImperialMinim, UnitConverterVolumeUnit.ImperialFluidDram, UnitConverterVolumeUnit.BoardFoot, UnitConverterVolumeUnit.AcreFoot, UnitConverterVolumeUnit.Cord, UnitConverterVolumeUnit.Drop, UnitConverterVolumeUnit.Dash, UnitConverterVolumeUnit.Pinch, UnitConverterVolumeUnit.USShot, UnitConverterVolumeUnit.ImperialShot, UnitConverterVolumeUnit.USDessertSpoon, UnitConverterVolumeUnit.ImperialDessertSpoon, UnitConverterVolumeUnit.OilBarrelPerThousand };
            }
        }
    }
}
