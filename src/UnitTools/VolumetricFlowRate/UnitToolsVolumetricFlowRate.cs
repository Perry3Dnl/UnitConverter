namespace UnitTools.VolumetricFlowRate
{
    using UnitTools.VolumetricFlowRate.Metric;
    using UnitTools.VolumetricFlowRate.ImperialUS;
    using UnitTools.VolumetricFlowRate.ImperialUK;
    using UnitTools.VolumetricFlowRate.Imperial;
    using UnitTools.VolumetricFlowRate.Survey;

    public enum UnitToolsVolumetricFlowRateUnit
    {
        CubicMeterPerSecond = 0,
        CubicMeterPerMinute = 1,
        CubicMeterPerHour = 2,
        LiterPerSecond = 3,
        LiterPerMinute = 4,
        LiterPerHour = 5,
        MilliliterPerSecond = 6,
        USGallonPerMinute = 7,
        USGallonPerHour = 8,
        ImperialGallonPerMinute = 9,
        CubicFootPerSecond = 10,
        CubicFootPerMinute = 11,
        CubicCentimeterPerSecond = 12,
        CubicCentimeterPerMinute = 13,
        MilliliterPerMinute = 14,
        MilliliterPerHour = 15,
        LiterPerDay = 16,
        CubicFootPerHour = 17,
        CubicInchPerSecond = 18,
        CubicInchPerMinute = 19,
        USGallonPerSecond = 20,
        USGallonPerDay = 21,
        ImperialGallonPerSecond = 22,
        ImperialGallonPerHour = 23,
        OilBarrelPerDay = 24,
        OilBarrelPerHour = 25,
        AcreFootPerDay = 26,
        MillionUSGallonsPerDay = 27,
        CubicMeterPerDay = 28,
        CubicCentimeterPerHour = 29,
        CubicMillimeterPerSecond = 30,
        CubicYardPerSecond = 31,
        CubicYardPerMinute = 32,
        CubicYardPerHour = 33,
        USFluidOuncePerSecond = 34,
        ImperialFluidOuncePerSecond = 35,
    }

    public static class UnitToolsVolumetricFlowRate
    {
        public static double Convert(double value, UnitToolsVolumetricFlowRateUnit from, UnitToolsVolumetricFlowRateUnit to)
        {
            double baseValue = ToCubicMeterPerSecond(value, from);
            return FromCubicMeterPerSecond(baseValue, to);
        }

        public static double ToCubicMeterPerSecond(double value, UnitToolsVolumetricFlowRateUnit from)
        {
            switch (from)
            {
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.LiterPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.LiterPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.LiterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.LiterPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.MilliliterPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitToolsImperialUSVolumetricFlowRate.USGallonPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitToolsImperialUSVolumetricFlowRate.USGallonPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitToolsImperialUKVolumetricFlowRate.ImperialGallonPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicFootPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicFootPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicCentimeterPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicCentimeterPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.MilliliterPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.MilliliterPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.LiterPerDay:
                    return UnitToolsMetricVolumetricFlowRate.LiterPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitToolsImperialVolumetricFlowRate.CubicFootPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicInchPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicInchPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitToolsImperialUSVolumetricFlowRate.USGallonPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.USGallonPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitToolsImperialUKVolumetricFlowRate.ImperialGallonPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitToolsImperialUKVolumetricFlowRate.ImperialGallonPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.OilBarrelPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitToolsImperialUSVolumetricFlowRate.OilBarrelPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitToolsSurveyVolumetricFlowRate.AcreFootPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.MillionUSGallonsPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerDayToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicCentimeterPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMillimeterPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicYardPerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicYardPerMinuteToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitToolsImperialVolumetricFlowRate.CubicYardPerHourToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitToolsImperialUSVolumetricFlowRate.USFluidOuncePerSecondToCubicMeterPerSecond(value);
                case UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitToolsImperialUKVolumetricFlowRate.ImperialFluidOuncePerSecondToCubicMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volumetric flow rate unit.");
            }
        }

        public static double FromCubicMeterPerSecond(double baseValue, UnitToolsVolumetricFlowRateUnit to)
        {
            switch (to)
            {
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.LiterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitToolsImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.LiterPerDay:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicInchPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicInchPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitToolsImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitToolsImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToOilBarrelPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToOilBarrelPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitToolsSurveyVolumetricFlowRate.CubicMeterPerSecondToAcreFootPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToMillionUSGallonsPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerDay(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitToolsMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMillimeterPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerMinute(baseValue);
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitToolsImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerHour(baseValue);
                case UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitToolsImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSFluidOuncePerSecond(baseValue);
                case UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitToolsImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialFluidOuncePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volumetric flow rate unit.");
            }
        }

        public static string GetSymbol(UnitToolsVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return "m³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return "m³/min";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour:
                    return "m³/h";
                case UnitToolsVolumetricFlowRateUnit.LiterPerSecond:
                    return "L/s";
                case UnitToolsVolumetricFlowRateUnit.LiterPerMinute:
                    return "L/min";
                case UnitToolsVolumetricFlowRateUnit.LiterPerHour:
                    return "L/h";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond:
                    return "mL/s";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerMinute:
                    return "gal/min US";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerHour:
                    return "gal/h US";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return "gal/min UK";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond:
                    return "ft³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute:
                    return "ft³/min";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return "cm³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return "cm³/min";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute:
                    return "mL/min";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerHour:
                    return "mL/h";
                case UnitToolsVolumetricFlowRateUnit.LiterPerDay:
                    return "L/d";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerHour:
                    return "ft³/h";
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond:
                    return "in³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute:
                    return "in³/min";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerSecond:
                    return "gal/s US";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerDay:
                    return "gal/d US";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return "gal/s imp";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return "gal/h imp";
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay:
                    return "bbl/d";
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour:
                    return "bbl/h";
                case UnitToolsVolumetricFlowRateUnit.AcreFootPerDay:
                    return "acre-ft/d";
                case UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return "MGD";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay:
                    return "m³/d";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return "cm³/h";
                case UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return "mm³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond:
                    return "yd³/s";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute:
                    return "yd³/min";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerHour:
                    return "yd³/h";
                case UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return "fl oz/s US";
                case UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return "fl oz/s imp";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return "cubic meter per second";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return "cubic meter per minute";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour:
                    return "cubic meter per hour";
                case UnitToolsVolumetricFlowRateUnit.LiterPerSecond:
                    return "liter per second";
                case UnitToolsVolumetricFlowRateUnit.LiterPerMinute:
                    return "liter per minute";
                case UnitToolsVolumetricFlowRateUnit.LiterPerHour:
                    return "liter per hour";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond:
                    return "milliliter per second";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerMinute:
                    return "US gallon per minute";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerHour:
                    return "US gallon per hour";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return "imperial gallon per minute";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond:
                    return "cubic foot per second";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute:
                    return "cubic foot per minute";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return "Cubic Centimeter Per Second";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return "Cubic Centimeter Per Minute";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute:
                    return "Milliliter Per Minute";
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerHour:
                    return "Milliliter Per Hour";
                case UnitToolsVolumetricFlowRateUnit.LiterPerDay:
                    return "Liter Per Day";
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerHour:
                    return "Cubic Foot Per Hour";
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond:
                    return "Cubic Inch Per Second";
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute:
                    return "Cubic Inch Per Minute";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerSecond:
                    return "US Gallon Per Second";
                case UnitToolsVolumetricFlowRateUnit.USGallonPerDay:
                    return "US Gallon Per Day";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return "Imperial Gallon Per Second";
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return "Imperial Gallon Per Hour";
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay:
                    return "Oil Barrel Per Day";
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour:
                    return "Oil Barrel Per Hour";
                case UnitToolsVolumetricFlowRateUnit.AcreFootPerDay:
                    return "Acre Foot Per Day";
                case UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return "Million US Gallons Per Day";
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay:
                    return "Cubic Meter Per Day";
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return "Cubic Centimeter Per Hour";
                case UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return "Cubic Millimeter Per Second";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond:
                    return "Cubic Yard Per Second";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute:
                    return "Cubic Yard Per Minute";
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerHour:
                    return "Cubic Yard Per Hour";
                case UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return "US Fluid Ounce Per Second";
                case UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return "Imperial Fluid Ounce Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.LiterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.LiterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitToolsUnitSystem.Survey;
                case UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitToolsUnitSystem.ImperialUK;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsVolumetricFlowRateUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute, UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour, UnitToolsVolumetricFlowRateUnit.LiterPerSecond, UnitToolsVolumetricFlowRateUnit.LiterPerMinute, UnitToolsVolumetricFlowRateUnit.LiterPerHour, UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute, UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute, UnitToolsVolumetricFlowRateUnit.MilliliterPerHour, UnitToolsVolumetricFlowRateUnit.LiterPerDay, UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour, UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsVolumetricFlowRateUnit.USGallonPerMinute, UnitToolsVolumetricFlowRateUnit.USGallonPerHour, UnitToolsVolumetricFlowRateUnit.USGallonPerSecond, UnitToolsVolumetricFlowRateUnit.USGallonPerDay, UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay, UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour, UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay, UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute, UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond, UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour, UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond, UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute, UnitToolsVolumetricFlowRateUnit.CubicFootPerHour, UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond, UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute, UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond, UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute, UnitToolsVolumetricFlowRateUnit.CubicYardPerHour };
                case UnitToolsUnitSystem.Survey:
                    return new[] { UnitToolsVolumetricFlowRateUnit.AcreFootPerDay };
                default:
                    return new[] { UnitToolsVolumetricFlowRateUnit.CubicMeterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicMeterPerMinute, UnitToolsVolumetricFlowRateUnit.CubicMeterPerHour, UnitToolsVolumetricFlowRateUnit.LiterPerSecond, UnitToolsVolumetricFlowRateUnit.LiterPerMinute, UnitToolsVolumetricFlowRateUnit.LiterPerHour, UnitToolsVolumetricFlowRateUnit.MilliliterPerSecond, UnitToolsVolumetricFlowRateUnit.USGallonPerMinute, UnitToolsVolumetricFlowRateUnit.USGallonPerHour, UnitToolsVolumetricFlowRateUnit.ImperialGallonPerMinute, UnitToolsVolumetricFlowRateUnit.CubicFootPerSecond, UnitToolsVolumetricFlowRateUnit.CubicFootPerMinute, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerMinute, UnitToolsVolumetricFlowRateUnit.MilliliterPerMinute, UnitToolsVolumetricFlowRateUnit.MilliliterPerHour, UnitToolsVolumetricFlowRateUnit.LiterPerDay, UnitToolsVolumetricFlowRateUnit.CubicFootPerHour, UnitToolsVolumetricFlowRateUnit.CubicInchPerSecond, UnitToolsVolumetricFlowRateUnit.CubicInchPerMinute, UnitToolsVolumetricFlowRateUnit.USGallonPerSecond, UnitToolsVolumetricFlowRateUnit.USGallonPerDay, UnitToolsVolumetricFlowRateUnit.ImperialGallonPerSecond, UnitToolsVolumetricFlowRateUnit.ImperialGallonPerHour, UnitToolsVolumetricFlowRateUnit.OilBarrelPerDay, UnitToolsVolumetricFlowRateUnit.OilBarrelPerHour, UnitToolsVolumetricFlowRateUnit.AcreFootPerDay, UnitToolsVolumetricFlowRateUnit.MillionUSGallonsPerDay, UnitToolsVolumetricFlowRateUnit.CubicMeterPerDay, UnitToolsVolumetricFlowRateUnit.CubicCentimeterPerHour, UnitToolsVolumetricFlowRateUnit.CubicMillimeterPerSecond, UnitToolsVolumetricFlowRateUnit.CubicYardPerSecond, UnitToolsVolumetricFlowRateUnit.CubicYardPerMinute, UnitToolsVolumetricFlowRateUnit.CubicYardPerHour, UnitToolsVolumetricFlowRateUnit.USFluidOuncePerSecond, UnitToolsVolumetricFlowRateUnit.ImperialFluidOuncePerSecond };
            }
        }
    }
}
