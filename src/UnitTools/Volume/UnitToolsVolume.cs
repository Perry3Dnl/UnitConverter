namespace UnitTools.Volume
{
    using UnitTools.Volume.Metric;
    using UnitTools.Volume.ImperialUS;
    using UnitTools.Volume.ImperialUK;
    using UnitTools.Volume.Imperial;
    using UnitTools.Volume.Engineering;
    using UnitTools.Volume.Cooking;
    using UnitTools.Volume.Survey;
    using UnitTools.Volume.Common;

    public enum UnitToolsVolumeUnit
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

    public static class UnitToolsVolume
    {
        public static double Convert(double value, UnitToolsVolumeUnit from, UnitToolsVolumeUnit to)
        {
            double baseValue = ToLiter(value, from);
            return FromLiter(baseValue, to);
        }

        public static double ToLiter(double value, UnitToolsVolumeUnit from)
        {
            switch (from)
            {
                case UnitToolsVolumeUnit.CubicMillimeter:
                    return UnitToolsMetricVolume.CubicMillimeterToLiter(value);
                case UnitToolsVolumeUnit.Milliliter:
                    return UnitToolsMetricVolume.MilliliterToLiter(value);
                case UnitToolsVolumeUnit.Centiliter:
                    return UnitToolsMetricVolume.CentiliterToLiter(value);
                case UnitToolsVolumeUnit.Deciliter:
                    return UnitToolsMetricVolume.DeciliterToLiter(value);
                case UnitToolsVolumeUnit.Liter:
                    return UnitToolsMetricVolume.LiterToLiter(value);
                case UnitToolsVolumeUnit.Decaliter:
                    return UnitToolsMetricVolume.DecaliterToLiter(value);
                case UnitToolsVolumeUnit.Hectoliter:
                    return UnitToolsMetricVolume.HectoliterToLiter(value);
                case UnitToolsVolumeUnit.Kiloliter:
                    return UnitToolsMetricVolume.KiloliterToLiter(value);
                case UnitToolsVolumeUnit.CubicCentimeter:
                    return UnitToolsMetricVolume.CubicCentimeterToLiter(value);
                case UnitToolsVolumeUnit.CubicMeter:
                    return UnitToolsMetricVolume.CubicMeterToLiter(value);
                case UnitToolsVolumeUnit.USTeaspoon:
                    return UnitToolsImperialUSVolume.USTeaspoonToLiter(value);
                case UnitToolsVolumeUnit.USTablespoon:
                    return UnitToolsImperialUSVolume.USTablespoonToLiter(value);
                case UnitToolsVolumeUnit.USFluidOunce:
                    return UnitToolsImperialUSVolume.USFluidOunceToLiter(value);
                case UnitToolsVolumeUnit.USCup:
                    return UnitToolsImperialUSVolume.USCupToLiter(value);
                case UnitToolsVolumeUnit.USPint:
                    return UnitToolsImperialUSVolume.USPintToLiter(value);
                case UnitToolsVolumeUnit.USQuart:
                    return UnitToolsImperialUSVolume.USQuartToLiter(value);
                case UnitToolsVolumeUnit.USGallon:
                    return UnitToolsImperialUSVolume.USGallonToLiter(value);
                case UnitToolsVolumeUnit.USDryPint:
                    return UnitToolsImperialUSVolume.USDryPintToLiter(value);
                case UnitToolsVolumeUnit.USDryQuart:
                    return UnitToolsImperialUSVolume.USDryQuartToLiter(value);
                case UnitToolsVolumeUnit.USDryGallon:
                    return UnitToolsImperialUSVolume.USDryGallonToLiter(value);
                case UnitToolsVolumeUnit.USBushel:
                    return UnitToolsImperialUSVolume.USBushelToLiter(value);
                case UnitToolsVolumeUnit.ImperialTeaspoon:
                    return UnitToolsImperialUKVolume.ImperialTeaspoonToLiter(value);
                case UnitToolsVolumeUnit.ImperialTablespoon:
                    return UnitToolsImperialUKVolume.ImperialTablespoonToLiter(value);
                case UnitToolsVolumeUnit.ImperialFluidOunce:
                    return UnitToolsImperialUKVolume.ImperialFluidOunceToLiter(value);
                case UnitToolsVolumeUnit.ImperialGill:
                    return UnitToolsImperialUKVolume.ImperialGillToLiter(value);
                case UnitToolsVolumeUnit.ImperialPint:
                    return UnitToolsImperialUKVolume.ImperialPintToLiter(value);
                case UnitToolsVolumeUnit.ImperialQuart:
                    return UnitToolsImperialUKVolume.ImperialQuartToLiter(value);
                case UnitToolsVolumeUnit.ImperialGallon:
                    return UnitToolsImperialUKVolume.ImperialGallonToLiter(value);
                case UnitToolsVolumeUnit.ImperialBushel:
                    return UnitToolsImperialUKVolume.ImperialBushelToLiter(value);
                case UnitToolsVolumeUnit.CubicInch:
                    return UnitToolsImperialVolume.CubicInchToLiter(value);
                case UnitToolsVolumeUnit.CubicFoot:
                    return UnitToolsImperialVolume.CubicFootToLiter(value);
                case UnitToolsVolumeUnit.CubicYard:
                    return UnitToolsImperialVolume.CubicYardToLiter(value);
                case UnitToolsVolumeUnit.OilBarrel:
                    return UnitToolsEngineeringVolume.OilBarrelToLiter(value);
                case UnitToolsVolumeUnit.BeerBarrelUS:
                    return UnitToolsImperialUSVolume.BeerBarrelUSToLiter(value);
                case UnitToolsVolumeUnit.RegisterTon:
                    return UnitToolsEngineeringVolume.RegisterTonToLiter(value);
                case UnitToolsVolumeUnit.CubicNanometer:
                    return UnitToolsMetricVolume.CubicNanometerToLiter(value);
                case UnitToolsVolumeUnit.CubicMicrometer:
                    return UnitToolsMetricVolume.CubicMicrometerToLiter(value);
                case UnitToolsVolumeUnit.Microliter:
                    return UnitToolsMetricVolume.MicroliterToLiter(value);
                case UnitToolsVolumeUnit.Nanoliter:
                    return UnitToolsMetricVolume.NanoliterToLiter(value);
                case UnitToolsVolumeUnit.Picoliter:
                    return UnitToolsMetricVolume.PicoliterToLiter(value);
                case UnitToolsVolumeUnit.Femtoliter:
                    return UnitToolsMetricVolume.FemtoliterToLiter(value);
                case UnitToolsVolumeUnit.CubicDecimeter:
                    return UnitToolsMetricVolume.CubicDecimeterToLiter(value);
                case UnitToolsVolumeUnit.CubicKilometer:
                    return UnitToolsMetricVolume.CubicKilometerToLiter(value);
                case UnitToolsVolumeUnit.Stere:
                    return UnitToolsMetricVolume.StereToLiter(value);
                case UnitToolsVolumeUnit.MetricTeaspoon:
                    return UnitToolsCookingVolume.MetricTeaspoonToLiter(value);
                case UnitToolsVolumeUnit.MetricTablespoon:
                    return UnitToolsCookingVolume.MetricTablespoonToLiter(value);
                case UnitToolsVolumeUnit.MetricCup:
                    return UnitToolsCookingVolume.MetricCupToLiter(value);
                case UnitToolsVolumeUnit.USGill:
                    return UnitToolsImperialUSVolume.USGillToLiter(value);
                case UnitToolsVolumeUnit.USPeck:
                    return UnitToolsImperialUSVolume.USPeckToLiter(value);
                case UnitToolsVolumeUnit.USHogshead:
                    return UnitToolsImperialUSVolume.USHogsheadToLiter(value);
                case UnitToolsVolumeUnit.USMinim:
                    return UnitToolsImperialUSVolume.USMinimToLiter(value);
                case UnitToolsVolumeUnit.USFluidDram:
                    return UnitToolsImperialUSVolume.USFluidDramToLiter(value);
                case UnitToolsVolumeUnit.ImperialPeck:
                    return UnitToolsImperialUKVolume.ImperialPeckToLiter(value);
                case UnitToolsVolumeUnit.ImperialHogshead:
                    return UnitToolsImperialUKVolume.ImperialHogsheadToLiter(value);
                case UnitToolsVolumeUnit.ImperialMinim:
                    return UnitToolsImperialUKVolume.ImperialMinimToLiter(value);
                case UnitToolsVolumeUnit.ImperialFluidDram:
                    return UnitToolsImperialUKVolume.ImperialFluidDramToLiter(value);
                case UnitToolsVolumeUnit.BoardFoot:
                    return UnitToolsImperialVolume.BoardFootToLiter(value);
                case UnitToolsVolumeUnit.AcreFoot:
                    return UnitToolsSurveyVolume.AcreFootToLiter(value);
                case UnitToolsVolumeUnit.Cord:
                    return UnitToolsImperialVolume.CordToLiter(value);
                case UnitToolsVolumeUnit.Drop:
                    return UnitToolsCommonVolume.DropToLiter(value);
                case UnitToolsVolumeUnit.Dash:
                    return UnitToolsCookingVolume.DashToLiter(value);
                case UnitToolsVolumeUnit.Pinch:
                    return UnitToolsCookingVolume.PinchToLiter(value);
                case UnitToolsVolumeUnit.USShot:
                    return UnitToolsCookingVolume.USShotToLiter(value);
                case UnitToolsVolumeUnit.ImperialShot:
                    return UnitToolsCookingVolume.ImperialShotToLiter(value);
                case UnitToolsVolumeUnit.USDessertSpoon:
                    return UnitToolsCookingVolume.USDessertSpoonToLiter(value);
                case UnitToolsVolumeUnit.ImperialDessertSpoon:
                    return UnitToolsCookingVolume.ImperialDessertSpoonToLiter(value);
                case UnitToolsVolumeUnit.OilBarrelPerThousand:
                    return UnitToolsEngineeringVolume.OilBarrelPerThousandToLiter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volume unit.");
            }
        }

        public static double FromLiter(double baseValue, UnitToolsVolumeUnit to)
        {
            switch (to)
            {
                case UnitToolsVolumeUnit.CubicMillimeter:
                    return UnitToolsMetricVolume.LiterToCubicMillimeter(baseValue);
                case UnitToolsVolumeUnit.Milliliter:
                    return UnitToolsMetricVolume.LiterToMilliliter(baseValue);
                case UnitToolsVolumeUnit.Centiliter:
                    return UnitToolsMetricVolume.LiterToCentiliter(baseValue);
                case UnitToolsVolumeUnit.Deciliter:
                    return UnitToolsMetricVolume.LiterToDeciliter(baseValue);
                case UnitToolsVolumeUnit.Liter:
                    return UnitToolsMetricVolume.LiterToLiter(baseValue);
                case UnitToolsVolumeUnit.Decaliter:
                    return UnitToolsMetricVolume.LiterToDecaliter(baseValue);
                case UnitToolsVolumeUnit.Hectoliter:
                    return UnitToolsMetricVolume.LiterToHectoliter(baseValue);
                case UnitToolsVolumeUnit.Kiloliter:
                    return UnitToolsMetricVolume.LiterToKiloliter(baseValue);
                case UnitToolsVolumeUnit.CubicCentimeter:
                    return UnitToolsMetricVolume.LiterToCubicCentimeter(baseValue);
                case UnitToolsVolumeUnit.CubicMeter:
                    return UnitToolsMetricVolume.LiterToCubicMeter(baseValue);
                case UnitToolsVolumeUnit.USTeaspoon:
                    return UnitToolsImperialUSVolume.LiterToUSTeaspoon(baseValue);
                case UnitToolsVolumeUnit.USTablespoon:
                    return UnitToolsImperialUSVolume.LiterToUSTablespoon(baseValue);
                case UnitToolsVolumeUnit.USFluidOunce:
                    return UnitToolsImperialUSVolume.LiterToUSFluidOunce(baseValue);
                case UnitToolsVolumeUnit.USCup:
                    return UnitToolsImperialUSVolume.LiterToUSCup(baseValue);
                case UnitToolsVolumeUnit.USPint:
                    return UnitToolsImperialUSVolume.LiterToUSPint(baseValue);
                case UnitToolsVolumeUnit.USQuart:
                    return UnitToolsImperialUSVolume.LiterToUSQuart(baseValue);
                case UnitToolsVolumeUnit.USGallon:
                    return UnitToolsImperialUSVolume.LiterToUSGallon(baseValue);
                case UnitToolsVolumeUnit.USDryPint:
                    return UnitToolsImperialUSVolume.LiterToUSDryPint(baseValue);
                case UnitToolsVolumeUnit.USDryQuart:
                    return UnitToolsImperialUSVolume.LiterToUSDryQuart(baseValue);
                case UnitToolsVolumeUnit.USDryGallon:
                    return UnitToolsImperialUSVolume.LiterToUSDryGallon(baseValue);
                case UnitToolsVolumeUnit.USBushel:
                    return UnitToolsImperialUSVolume.LiterToUSBushel(baseValue);
                case UnitToolsVolumeUnit.ImperialTeaspoon:
                    return UnitToolsImperialUKVolume.LiterToImperialTeaspoon(baseValue);
                case UnitToolsVolumeUnit.ImperialTablespoon:
                    return UnitToolsImperialUKVolume.LiterToImperialTablespoon(baseValue);
                case UnitToolsVolumeUnit.ImperialFluidOunce:
                    return UnitToolsImperialUKVolume.LiterToImperialFluidOunce(baseValue);
                case UnitToolsVolumeUnit.ImperialGill:
                    return UnitToolsImperialUKVolume.LiterToImperialGill(baseValue);
                case UnitToolsVolumeUnit.ImperialPint:
                    return UnitToolsImperialUKVolume.LiterToImperialPint(baseValue);
                case UnitToolsVolumeUnit.ImperialQuart:
                    return UnitToolsImperialUKVolume.LiterToImperialQuart(baseValue);
                case UnitToolsVolumeUnit.ImperialGallon:
                    return UnitToolsImperialUKVolume.LiterToImperialGallon(baseValue);
                case UnitToolsVolumeUnit.ImperialBushel:
                    return UnitToolsImperialUKVolume.LiterToImperialBushel(baseValue);
                case UnitToolsVolumeUnit.CubicInch:
                    return UnitToolsImperialVolume.LiterToCubicInch(baseValue);
                case UnitToolsVolumeUnit.CubicFoot:
                    return UnitToolsImperialVolume.LiterToCubicFoot(baseValue);
                case UnitToolsVolumeUnit.CubicYard:
                    return UnitToolsImperialVolume.LiterToCubicYard(baseValue);
                case UnitToolsVolumeUnit.OilBarrel:
                    return UnitToolsEngineeringVolume.LiterToOilBarrel(baseValue);
                case UnitToolsVolumeUnit.BeerBarrelUS:
                    return UnitToolsImperialUSVolume.LiterToBeerBarrelUS(baseValue);
                case UnitToolsVolumeUnit.RegisterTon:
                    return UnitToolsEngineeringVolume.LiterToRegisterTon(baseValue);
                case UnitToolsVolumeUnit.CubicNanometer:
                    return UnitToolsMetricVolume.LiterToCubicNanometer(baseValue);
                case UnitToolsVolumeUnit.CubicMicrometer:
                    return UnitToolsMetricVolume.LiterToCubicMicrometer(baseValue);
                case UnitToolsVolumeUnit.Microliter:
                    return UnitToolsMetricVolume.LiterToMicroliter(baseValue);
                case UnitToolsVolumeUnit.Nanoliter:
                    return UnitToolsMetricVolume.LiterToNanoliter(baseValue);
                case UnitToolsVolumeUnit.Picoliter:
                    return UnitToolsMetricVolume.LiterToPicoliter(baseValue);
                case UnitToolsVolumeUnit.Femtoliter:
                    return UnitToolsMetricVolume.LiterToFemtoliter(baseValue);
                case UnitToolsVolumeUnit.CubicDecimeter:
                    return UnitToolsMetricVolume.LiterToCubicDecimeter(baseValue);
                case UnitToolsVolumeUnit.CubicKilometer:
                    return UnitToolsMetricVolume.LiterToCubicKilometer(baseValue);
                case UnitToolsVolumeUnit.Stere:
                    return UnitToolsMetricVolume.LiterToStere(baseValue);
                case UnitToolsVolumeUnit.MetricTeaspoon:
                    return UnitToolsCookingVolume.LiterToMetricTeaspoon(baseValue);
                case UnitToolsVolumeUnit.MetricTablespoon:
                    return UnitToolsCookingVolume.LiterToMetricTablespoon(baseValue);
                case UnitToolsVolumeUnit.MetricCup:
                    return UnitToolsCookingVolume.LiterToMetricCup(baseValue);
                case UnitToolsVolumeUnit.USGill:
                    return UnitToolsImperialUSVolume.LiterToUSGill(baseValue);
                case UnitToolsVolumeUnit.USPeck:
                    return UnitToolsImperialUSVolume.LiterToUSPeck(baseValue);
                case UnitToolsVolumeUnit.USHogshead:
                    return UnitToolsImperialUSVolume.LiterToUSHogshead(baseValue);
                case UnitToolsVolumeUnit.USMinim:
                    return UnitToolsImperialUSVolume.LiterToUSMinim(baseValue);
                case UnitToolsVolumeUnit.USFluidDram:
                    return UnitToolsImperialUSVolume.LiterToUSFluidDram(baseValue);
                case UnitToolsVolumeUnit.ImperialPeck:
                    return UnitToolsImperialUKVolume.LiterToImperialPeck(baseValue);
                case UnitToolsVolumeUnit.ImperialHogshead:
                    return UnitToolsImperialUKVolume.LiterToImperialHogshead(baseValue);
                case UnitToolsVolumeUnit.ImperialMinim:
                    return UnitToolsImperialUKVolume.LiterToImperialMinim(baseValue);
                case UnitToolsVolumeUnit.ImperialFluidDram:
                    return UnitToolsImperialUKVolume.LiterToImperialFluidDram(baseValue);
                case UnitToolsVolumeUnit.BoardFoot:
                    return UnitToolsImperialVolume.LiterToBoardFoot(baseValue);
                case UnitToolsVolumeUnit.AcreFoot:
                    return UnitToolsSurveyVolume.LiterToAcreFoot(baseValue);
                case UnitToolsVolumeUnit.Cord:
                    return UnitToolsImperialVolume.LiterToCord(baseValue);
                case UnitToolsVolumeUnit.Drop:
                    return UnitToolsCommonVolume.LiterToDrop(baseValue);
                case UnitToolsVolumeUnit.Dash:
                    return UnitToolsCookingVolume.LiterToDash(baseValue);
                case UnitToolsVolumeUnit.Pinch:
                    return UnitToolsCookingVolume.LiterToPinch(baseValue);
                case UnitToolsVolumeUnit.USShot:
                    return UnitToolsCookingVolume.LiterToUSShot(baseValue);
                case UnitToolsVolumeUnit.ImperialShot:
                    return UnitToolsCookingVolume.LiterToImperialShot(baseValue);
                case UnitToolsVolumeUnit.USDessertSpoon:
                    return UnitToolsCookingVolume.LiterToUSDessertSpoon(baseValue);
                case UnitToolsVolumeUnit.ImperialDessertSpoon:
                    return UnitToolsCookingVolume.LiterToImperialDessertSpoon(baseValue);
                case UnitToolsVolumeUnit.OilBarrelPerThousand:
                    return UnitToolsEngineeringVolume.LiterToOilBarrelPerThousand(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volume unit.");
            }
        }

        public static string GetSymbol(UnitToolsVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumeUnit.CubicMillimeter:
                    return "mm³";
                case UnitToolsVolumeUnit.Milliliter:
                    return "mL";
                case UnitToolsVolumeUnit.Centiliter:
                    return "cL";
                case UnitToolsVolumeUnit.Deciliter:
                    return "dL";
                case UnitToolsVolumeUnit.Liter:
                    return "L";
                case UnitToolsVolumeUnit.Decaliter:
                    return "daL";
                case UnitToolsVolumeUnit.Hectoliter:
                    return "hL";
                case UnitToolsVolumeUnit.Kiloliter:
                    return "kL";
                case UnitToolsVolumeUnit.CubicCentimeter:
                    return "cm³";
                case UnitToolsVolumeUnit.CubicMeter:
                    return "m³";
                case UnitToolsVolumeUnit.USTeaspoon:
                    return "tsp US";
                case UnitToolsVolumeUnit.USTablespoon:
                    return "tbsp US";
                case UnitToolsVolumeUnit.USFluidOunce:
                    return "fl oz US";
                case UnitToolsVolumeUnit.USCup:
                    return "cup US";
                case UnitToolsVolumeUnit.USPint:
                    return "pt US";
                case UnitToolsVolumeUnit.USQuart:
                    return "qt US";
                case UnitToolsVolumeUnit.USGallon:
                    return "gal US";
                case UnitToolsVolumeUnit.USDryPint:
                    return "dry pt US";
                case UnitToolsVolumeUnit.USDryQuart:
                    return "dry qt US";
                case UnitToolsVolumeUnit.USDryGallon:
                    return "dry gal US";
                case UnitToolsVolumeUnit.USBushel:
                    return "bu US";
                case UnitToolsVolumeUnit.ImperialTeaspoon:
                    return "tsp imp";
                case UnitToolsVolumeUnit.ImperialTablespoon:
                    return "tbsp imp";
                case UnitToolsVolumeUnit.ImperialFluidOunce:
                    return "fl oz imp";
                case UnitToolsVolumeUnit.ImperialGill:
                    return "gi imp";
                case UnitToolsVolumeUnit.ImperialPint:
                    return "pt imp";
                case UnitToolsVolumeUnit.ImperialQuart:
                    return "qt imp";
                case UnitToolsVolumeUnit.ImperialGallon:
                    return "gal imp";
                case UnitToolsVolumeUnit.ImperialBushel:
                    return "bu imp";
                case UnitToolsVolumeUnit.CubicInch:
                    return "in³";
                case UnitToolsVolumeUnit.CubicFoot:
                    return "ft³";
                case UnitToolsVolumeUnit.CubicYard:
                    return "yd³";
                case UnitToolsVolumeUnit.OilBarrel:
                    return "bbl";
                case UnitToolsVolumeUnit.BeerBarrelUS:
                    return "bbl beer US";
                case UnitToolsVolumeUnit.RegisterTon:
                    return "RT";
                case UnitToolsVolumeUnit.CubicNanometer:
                    return "nm³";
                case UnitToolsVolumeUnit.CubicMicrometer:
                    return "µm³";
                case UnitToolsVolumeUnit.Microliter:
                    return "µL";
                case UnitToolsVolumeUnit.Nanoliter:
                    return "nL";
                case UnitToolsVolumeUnit.Picoliter:
                    return "pL";
                case UnitToolsVolumeUnit.Femtoliter:
                    return "fL";
                case UnitToolsVolumeUnit.CubicDecimeter:
                    return "dm³";
                case UnitToolsVolumeUnit.CubicKilometer:
                    return "km³";
                case UnitToolsVolumeUnit.Stere:
                    return "st";
                case UnitToolsVolumeUnit.MetricTeaspoon:
                    return "metric tsp";
                case UnitToolsVolumeUnit.MetricTablespoon:
                    return "metric tbsp";
                case UnitToolsVolumeUnit.MetricCup:
                    return "metric cup";
                case UnitToolsVolumeUnit.USGill:
                    return "gi US";
                case UnitToolsVolumeUnit.USPeck:
                    return "pk US";
                case UnitToolsVolumeUnit.USHogshead:
                    return "hhd US";
                case UnitToolsVolumeUnit.USMinim:
                    return "min US";
                case UnitToolsVolumeUnit.USFluidDram:
                    return "fl dr US";
                case UnitToolsVolumeUnit.ImperialPeck:
                    return "pk imp";
                case UnitToolsVolumeUnit.ImperialHogshead:
                    return "hhd imp";
                case UnitToolsVolumeUnit.ImperialMinim:
                    return "min imp";
                case UnitToolsVolumeUnit.ImperialFluidDram:
                    return "fl dr imp";
                case UnitToolsVolumeUnit.BoardFoot:
                    return "fbm";
                case UnitToolsVolumeUnit.AcreFoot:
                    return "acre-ft";
                case UnitToolsVolumeUnit.Cord:
                    return "cord";
                case UnitToolsVolumeUnit.Drop:
                    return "drop";
                case UnitToolsVolumeUnit.Dash:
                    return "dash";
                case UnitToolsVolumeUnit.Pinch:
                    return "pinch";
                case UnitToolsVolumeUnit.USShot:
                    return "shot US";
                case UnitToolsVolumeUnit.ImperialShot:
                    return "shot imp";
                case UnitToolsVolumeUnit.USDessertSpoon:
                    return "dsp US";
                case UnitToolsVolumeUnit.ImperialDessertSpoon:
                    return "dsp imp";
                case UnitToolsVolumeUnit.OilBarrelPerThousand:
                    return "kbbl";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumeUnit.CubicMillimeter:
                    return "cubic millimeter";
                case UnitToolsVolumeUnit.Milliliter:
                    return "milliliter";
                case UnitToolsVolumeUnit.Centiliter:
                    return "centiliter";
                case UnitToolsVolumeUnit.Deciliter:
                    return "deciliter";
                case UnitToolsVolumeUnit.Liter:
                    return "liter";
                case UnitToolsVolumeUnit.Decaliter:
                    return "decaliter";
                case UnitToolsVolumeUnit.Hectoliter:
                    return "hectoliter";
                case UnitToolsVolumeUnit.Kiloliter:
                    return "kiloliter";
                case UnitToolsVolumeUnit.CubicCentimeter:
                    return "cubic centimeter";
                case UnitToolsVolumeUnit.CubicMeter:
                    return "cubic meter";
                case UnitToolsVolumeUnit.USTeaspoon:
                    return "US teaspoon";
                case UnitToolsVolumeUnit.USTablespoon:
                    return "US tablespoon";
                case UnitToolsVolumeUnit.USFluidOunce:
                    return "US fluid ounce";
                case UnitToolsVolumeUnit.USCup:
                    return "US cup";
                case UnitToolsVolumeUnit.USPint:
                    return "US pint";
                case UnitToolsVolumeUnit.USQuart:
                    return "US quart";
                case UnitToolsVolumeUnit.USGallon:
                    return "US gallon";
                case UnitToolsVolumeUnit.USDryPint:
                    return "US dry pint";
                case UnitToolsVolumeUnit.USDryQuart:
                    return "US dry quart";
                case UnitToolsVolumeUnit.USDryGallon:
                    return "US dry gallon";
                case UnitToolsVolumeUnit.USBushel:
                    return "US bushel";
                case UnitToolsVolumeUnit.ImperialTeaspoon:
                    return "imperial teaspoon";
                case UnitToolsVolumeUnit.ImperialTablespoon:
                    return "imperial tablespoon";
                case UnitToolsVolumeUnit.ImperialFluidOunce:
                    return "imperial fluid ounce";
                case UnitToolsVolumeUnit.ImperialGill:
                    return "imperial gill";
                case UnitToolsVolumeUnit.ImperialPint:
                    return "imperial pint";
                case UnitToolsVolumeUnit.ImperialQuart:
                    return "imperial quart";
                case UnitToolsVolumeUnit.ImperialGallon:
                    return "imperial gallon";
                case UnitToolsVolumeUnit.ImperialBushel:
                    return "imperial bushel";
                case UnitToolsVolumeUnit.CubicInch:
                    return "cubic inch";
                case UnitToolsVolumeUnit.CubicFoot:
                    return "cubic foot";
                case UnitToolsVolumeUnit.CubicYard:
                    return "cubic yard";
                case UnitToolsVolumeUnit.OilBarrel:
                    return "oil barrel";
                case UnitToolsVolumeUnit.BeerBarrelUS:
                    return "US beer barrel";
                case UnitToolsVolumeUnit.RegisterTon:
                    return "register ton";
                case UnitToolsVolumeUnit.CubicNanometer:
                    return "Cubic Nanometer";
                case UnitToolsVolumeUnit.CubicMicrometer:
                    return "Cubic Micrometer";
                case UnitToolsVolumeUnit.Microliter:
                    return "Microliter";
                case UnitToolsVolumeUnit.Nanoliter:
                    return "Nanoliter";
                case UnitToolsVolumeUnit.Picoliter:
                    return "Picoliter";
                case UnitToolsVolumeUnit.Femtoliter:
                    return "Femtoliter";
                case UnitToolsVolumeUnit.CubicDecimeter:
                    return "Cubic Decimeter";
                case UnitToolsVolumeUnit.CubicKilometer:
                    return "Cubic Kilometer";
                case UnitToolsVolumeUnit.Stere:
                    return "Stere";
                case UnitToolsVolumeUnit.MetricTeaspoon:
                    return "Metric Teaspoon";
                case UnitToolsVolumeUnit.MetricTablespoon:
                    return "Metric Tablespoon";
                case UnitToolsVolumeUnit.MetricCup:
                    return "Metric Cup";
                case UnitToolsVolumeUnit.USGill:
                    return "US Gill";
                case UnitToolsVolumeUnit.USPeck:
                    return "US Peck";
                case UnitToolsVolumeUnit.USHogshead:
                    return "US Hogshead";
                case UnitToolsVolumeUnit.USMinim:
                    return "US Minim";
                case UnitToolsVolumeUnit.USFluidDram:
                    return "US Fluid Dram";
                case UnitToolsVolumeUnit.ImperialPeck:
                    return "Imperial Peck";
                case UnitToolsVolumeUnit.ImperialHogshead:
                    return "Imperial Hogshead";
                case UnitToolsVolumeUnit.ImperialMinim:
                    return "Imperial Minim";
                case UnitToolsVolumeUnit.ImperialFluidDram:
                    return "Imperial Fluid Dram";
                case UnitToolsVolumeUnit.BoardFoot:
                    return "Board Foot";
                case UnitToolsVolumeUnit.AcreFoot:
                    return "Acre Foot";
                case UnitToolsVolumeUnit.Cord:
                    return "Cord";
                case UnitToolsVolumeUnit.Drop:
                    return "Drop";
                case UnitToolsVolumeUnit.Dash:
                    return "Dash";
                case UnitToolsVolumeUnit.Pinch:
                    return "Pinch";
                case UnitToolsVolumeUnit.USShot:
                    return "US Shot";
                case UnitToolsVolumeUnit.ImperialShot:
                    return "Imperial Shot";
                case UnitToolsVolumeUnit.USDessertSpoon:
                    return "US Dessert Spoon";
                case UnitToolsVolumeUnit.ImperialDessertSpoon:
                    return "Imperial Dessert Spoon";
                case UnitToolsVolumeUnit.OilBarrelPerThousand:
                    return "Oil Barrel Per Thousand";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsVolumeUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumeUnit.CubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Milliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Centiliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Deciliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Liter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Decaliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Hectoliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Kiloliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.CubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.CubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.USTeaspoon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USTablespoon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USFluidOunce:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USCup:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USPint:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USQuart:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USDryPint:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USDryQuart:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USDryGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USBushel:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.ImperialTeaspoon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialTablespoon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialFluidOunce:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialGill:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialPint:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialQuart:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialGallon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialBushel:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.CubicInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumeUnit.CubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumeUnit.CubicYard:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumeUnit.OilBarrel:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsVolumeUnit.BeerBarrelUS:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.RegisterTon:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsVolumeUnit.CubicNanometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.CubicMicrometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Microliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Nanoliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Picoliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Femtoliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.CubicDecimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.CubicKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.Stere:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumeUnit.MetricTeaspoon:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.MetricTablespoon:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.MetricCup:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.USGill:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USPeck:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USHogshead:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USMinim:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.USFluidDram:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumeUnit.ImperialPeck:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialHogshead:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialMinim:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.ImperialFluidDram:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumeUnit.BoardFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumeUnit.AcreFoot:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsVolumeUnit.Cord:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumeUnit.Drop:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsVolumeUnit.Dash:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.Pinch:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.USShot:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.ImperialShot:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.USDessertSpoon:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.ImperialDessertSpoon:
                    return UnitToolsUnitSystem.Cooking;
                case UnitToolsVolumeUnit.OilBarrelPerThousand:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsVolumeUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsVolumeUnit.CubicMillimeter, UnitToolsVolumeUnit.Milliliter, UnitToolsVolumeUnit.Centiliter, UnitToolsVolumeUnit.Deciliter, UnitToolsVolumeUnit.Liter, UnitToolsVolumeUnit.Decaliter, UnitToolsVolumeUnit.Hectoliter, UnitToolsVolumeUnit.Kiloliter, UnitToolsVolumeUnit.CubicCentimeter, UnitToolsVolumeUnit.CubicMeter, UnitToolsVolumeUnit.CubicNanometer, UnitToolsVolumeUnit.CubicMicrometer, UnitToolsVolumeUnit.Microliter, UnitToolsVolumeUnit.Nanoliter, UnitToolsVolumeUnit.Picoliter, UnitToolsVolumeUnit.Femtoliter, UnitToolsVolumeUnit.CubicDecimeter, UnitToolsVolumeUnit.CubicKilometer, UnitToolsVolumeUnit.Stere };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsVolumeUnit.USTeaspoon, UnitToolsVolumeUnit.USTablespoon, UnitToolsVolumeUnit.USFluidOunce, UnitToolsVolumeUnit.USCup, UnitToolsVolumeUnit.USPint, UnitToolsVolumeUnit.USQuart, UnitToolsVolumeUnit.USGallon, UnitToolsVolumeUnit.USDryPint, UnitToolsVolumeUnit.USDryQuart, UnitToolsVolumeUnit.USDryGallon, UnitToolsVolumeUnit.USBushel, UnitToolsVolumeUnit.BeerBarrelUS, UnitToolsVolumeUnit.USGill, UnitToolsVolumeUnit.USPeck, UnitToolsVolumeUnit.USHogshead, UnitToolsVolumeUnit.USMinim, UnitToolsVolumeUnit.USFluidDram };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsVolumeUnit.ImperialTeaspoon, UnitToolsVolumeUnit.ImperialTablespoon, UnitToolsVolumeUnit.ImperialFluidOunce, UnitToolsVolumeUnit.ImperialGill, UnitToolsVolumeUnit.ImperialPint, UnitToolsVolumeUnit.ImperialQuart, UnitToolsVolumeUnit.ImperialGallon, UnitToolsVolumeUnit.ImperialBushel, UnitToolsVolumeUnit.ImperialPeck, UnitToolsVolumeUnit.ImperialHogshead, UnitToolsVolumeUnit.ImperialMinim, UnitToolsVolumeUnit.ImperialFluidDram };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsVolumeUnit.CubicInch, UnitToolsVolumeUnit.CubicFoot, UnitToolsVolumeUnit.CubicYard, UnitToolsVolumeUnit.BoardFoot, UnitToolsVolumeUnit.Cord };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsVolumeUnit.OilBarrel, UnitToolsVolumeUnit.RegisterTon, UnitToolsVolumeUnit.OilBarrelPerThousand };
                case UnitToolsUnitSystem.Cooking:
                    return new[] { UnitToolsVolumeUnit.MetricTeaspoon, UnitToolsVolumeUnit.MetricTablespoon, UnitToolsVolumeUnit.MetricCup, UnitToolsVolumeUnit.Dash, UnitToolsVolumeUnit.Pinch, UnitToolsVolumeUnit.USShot, UnitToolsVolumeUnit.ImperialShot, UnitToolsVolumeUnit.USDessertSpoon, UnitToolsVolumeUnit.ImperialDessertSpoon };
                case UnitToolsUnitSystem.Survey:
                    return new[] { UnitToolsVolumeUnit.AcreFoot };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsVolumeUnit.Drop };
                default:
                    return new[] { UnitToolsVolumeUnit.CubicMillimeter, UnitToolsVolumeUnit.Milliliter, UnitToolsVolumeUnit.Centiliter, UnitToolsVolumeUnit.Deciliter, UnitToolsVolumeUnit.Liter, UnitToolsVolumeUnit.Decaliter, UnitToolsVolumeUnit.Hectoliter, UnitToolsVolumeUnit.Kiloliter, UnitToolsVolumeUnit.CubicCentimeter, UnitToolsVolumeUnit.CubicMeter, UnitToolsVolumeUnit.USTeaspoon, UnitToolsVolumeUnit.USTablespoon, UnitToolsVolumeUnit.USFluidOunce, UnitToolsVolumeUnit.USCup, UnitToolsVolumeUnit.USPint, UnitToolsVolumeUnit.USQuart, UnitToolsVolumeUnit.USGallon, UnitToolsVolumeUnit.USDryPint, UnitToolsVolumeUnit.USDryQuart, UnitToolsVolumeUnit.USDryGallon, UnitToolsVolumeUnit.USBushel, UnitToolsVolumeUnit.ImperialTeaspoon, UnitToolsVolumeUnit.ImperialTablespoon, UnitToolsVolumeUnit.ImperialFluidOunce, UnitToolsVolumeUnit.ImperialGill, UnitToolsVolumeUnit.ImperialPint, UnitToolsVolumeUnit.ImperialQuart, UnitToolsVolumeUnit.ImperialGallon, UnitToolsVolumeUnit.ImperialBushel, UnitToolsVolumeUnit.CubicInch, UnitToolsVolumeUnit.CubicFoot, UnitToolsVolumeUnit.CubicYard, UnitToolsVolumeUnit.OilBarrel, UnitToolsVolumeUnit.BeerBarrelUS, UnitToolsVolumeUnit.RegisterTon, UnitToolsVolumeUnit.CubicNanometer, UnitToolsVolumeUnit.CubicMicrometer, UnitToolsVolumeUnit.Microliter, UnitToolsVolumeUnit.Nanoliter, UnitToolsVolumeUnit.Picoliter, UnitToolsVolumeUnit.Femtoliter, UnitToolsVolumeUnit.CubicDecimeter, UnitToolsVolumeUnit.CubicKilometer, UnitToolsVolumeUnit.Stere, UnitToolsVolumeUnit.MetricTeaspoon, UnitToolsVolumeUnit.MetricTablespoon, UnitToolsVolumeUnit.MetricCup, UnitToolsVolumeUnit.USGill, UnitToolsVolumeUnit.USPeck, UnitToolsVolumeUnit.USHogshead, UnitToolsVolumeUnit.USMinim, UnitToolsVolumeUnit.USFluidDram, UnitToolsVolumeUnit.ImperialPeck, UnitToolsVolumeUnit.ImperialHogshead, UnitToolsVolumeUnit.ImperialMinim, UnitToolsVolumeUnit.ImperialFluidDram, UnitToolsVolumeUnit.BoardFoot, UnitToolsVolumeUnit.AcreFoot, UnitToolsVolumeUnit.Cord, UnitToolsVolumeUnit.Drop, UnitToolsVolumeUnit.Dash, UnitToolsVolumeUnit.Pinch, UnitToolsVolumeUnit.USShot, UnitToolsVolumeUnit.ImperialShot, UnitToolsVolumeUnit.USDessertSpoon, UnitToolsVolumeUnit.ImperialDessertSpoon, UnitToolsVolumeUnit.OilBarrelPerThousand };
            }
        }
    }
}
