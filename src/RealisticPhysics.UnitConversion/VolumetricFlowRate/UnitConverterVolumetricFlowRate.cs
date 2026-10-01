namespace RealisticPhysics.UnitConversion.VolumetricFlowRate
{
    using RealisticPhysics.UnitConversion.VolumetricFlowRate.Metric;
    using RealisticPhysics.UnitConversion.VolumetricFlowRate.ImperialUS;
    using RealisticPhysics.UnitConversion.VolumetricFlowRate.ImperialUK;
    using RealisticPhysics.UnitConversion.VolumetricFlowRate.Imperial;
    using RealisticPhysics.UnitConversion.VolumetricFlowRate.Survey;

    public enum UnitConverterVolumetricFlowRateUnit
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

    public static class UnitConverterVolumetricFlowRate
    {
        public static double Convert(double value, UnitConverterVolumetricFlowRateUnit from, UnitConverterVolumetricFlowRateUnit to)
        {
            double baseValue = ToCubicMeterPerSecond(value, from);
            return FromCubicMeterPerSecond(baseValue, to);
        }

        public static double ToCubicMeterPerSecond(double value, UnitConverterVolumetricFlowRateUnit from)
        {
            switch (from)
            {
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.LiterPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.LiterPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.LiterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.LiterPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.MilliliterPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitConverterImperialUSVolumetricFlowRate.USGallonPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitConverterImperialUSVolumetricFlowRate.USGallonPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitConverterImperialUKVolumetricFlowRate.ImperialGallonPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicFootPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicFootPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicCentimeterPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicCentimeterPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.MilliliterPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.MilliliterPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.LiterPerDay:
                    return UnitConverterMetricVolumetricFlowRate.LiterPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitConverterImperialVolumetricFlowRate.CubicFootPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicInchPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicInchPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitConverterImperialUSVolumetricFlowRate.USGallonPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.USGallonPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitConverterImperialUKVolumetricFlowRate.ImperialGallonPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitConverterImperialUKVolumetricFlowRate.ImperialGallonPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.OilBarrelPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitConverterImperialUSVolumetricFlowRate.OilBarrelPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitConverterSurveyVolumetricFlowRate.AcreFootPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.MillionUSGallonsPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerDayToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicCentimeterPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMillimeterPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicYardPerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicYardPerMinuteToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitConverterImperialVolumetricFlowRate.CubicYardPerHourToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitConverterImperialUSVolumetricFlowRate.USFluidOuncePerSecondToCubicMeterPerSecond(value);
                case UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitConverterImperialUKVolumetricFlowRate.ImperialFluidOuncePerSecondToCubicMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volumetric flow rate unit.");
            }
        }

        public static double FromCubicMeterPerSecond(double baseValue, UnitConverterVolumetricFlowRateUnit to)
        {
            switch (to)
            {
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.LiterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitConverterImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToMilliliterPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.LiterPerDay:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToLiterPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicFootPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicInchPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicInchPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSGallonPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitConverterImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitConverterImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialGallonPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToOilBarrelPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToOilBarrelPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitConverterSurveyVolumetricFlowRate.CubicMeterPerSecondToAcreFootPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToMillionUSGallonsPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMeterPerDay(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicCentimeterPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitConverterMetricVolumetricFlowRate.CubicMeterPerSecondToCubicMillimeterPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerMinute(baseValue);
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitConverterImperialVolumetricFlowRate.CubicMeterPerSecondToCubicYardPerHour(baseValue);
                case UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitConverterImperialUSVolumetricFlowRate.CubicMeterPerSecondToUSFluidOuncePerSecond(baseValue);
                case UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitConverterImperialUKVolumetricFlowRate.CubicMeterPerSecondToImperialFluidOuncePerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volumetric flow rate unit.");
            }
        }

        public static string GetSymbol(UnitConverterVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return "m³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return "m³/min";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour:
                    return "m³/h";
                case UnitConverterVolumetricFlowRateUnit.LiterPerSecond:
                    return "L/s";
                case UnitConverterVolumetricFlowRateUnit.LiterPerMinute:
                    return "L/min";
                case UnitConverterVolumetricFlowRateUnit.LiterPerHour:
                    return "L/h";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond:
                    return "mL/s";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerMinute:
                    return "gal/min US";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerHour:
                    return "gal/h US";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return "gal/min UK";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond:
                    return "ft³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute:
                    return "ft³/min";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return "cm³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return "cm³/min";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute:
                    return "mL/min";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerHour:
                    return "mL/h";
                case UnitConverterVolumetricFlowRateUnit.LiterPerDay:
                    return "L/d";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerHour:
                    return "ft³/h";
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond:
                    return "in³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute:
                    return "in³/min";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerSecond:
                    return "gal/s US";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerDay:
                    return "gal/d US";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return "gal/s imp";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return "gal/h imp";
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay:
                    return "bbl/d";
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour:
                    return "bbl/h";
                case UnitConverterVolumetricFlowRateUnit.AcreFootPerDay:
                    return "acre-ft/d";
                case UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return "MGD";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay:
                    return "m³/d";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return "cm³/h";
                case UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return "mm³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond:
                    return "yd³/s";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute:
                    return "yd³/min";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerHour:
                    return "yd³/h";
                case UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return "fl oz/s US";
                case UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return "fl oz/s imp";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return "cubic meter per second";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return "cubic meter per minute";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour:
                    return "cubic meter per hour";
                case UnitConverterVolumetricFlowRateUnit.LiterPerSecond:
                    return "liter per second";
                case UnitConverterVolumetricFlowRateUnit.LiterPerMinute:
                    return "liter per minute";
                case UnitConverterVolumetricFlowRateUnit.LiterPerHour:
                    return "liter per hour";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond:
                    return "milliliter per second";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerMinute:
                    return "US gallon per minute";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerHour:
                    return "US gallon per hour";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return "imperial gallon per minute";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond:
                    return "cubic foot per second";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute:
                    return "cubic foot per minute";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return "Cubic Centimeter Per Second";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return "Cubic Centimeter Per Minute";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute:
                    return "Milliliter Per Minute";
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerHour:
                    return "Milliliter Per Hour";
                case UnitConverterVolumetricFlowRateUnit.LiterPerDay:
                    return "Liter Per Day";
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerHour:
                    return "Cubic Foot Per Hour";
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond:
                    return "Cubic Inch Per Second";
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute:
                    return "Cubic Inch Per Minute";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerSecond:
                    return "US Gallon Per Second";
                case UnitConverterVolumetricFlowRateUnit.USGallonPerDay:
                    return "US Gallon Per Day";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return "Imperial Gallon Per Second";
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return "Imperial Gallon Per Hour";
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay:
                    return "Oil Barrel Per Day";
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour:
                    return "Oil Barrel Per Hour";
                case UnitConverterVolumetricFlowRateUnit.AcreFootPerDay:
                    return "Acre Foot Per Day";
                case UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return "Million US Gallons Per Day";
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay:
                    return "Cubic Meter Per Day";
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return "Cubic Centimeter Per Hour";
                case UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return "Cubic Millimeter Per Second";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond:
                    return "Cubic Yard Per Second";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute:
                    return "Cubic Yard Per Minute";
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerHour:
                    return "Cubic Yard Per Hour";
                case UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return "US Fluid Ounce Per Second";
                case UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return "Imperial Fluid Ounce Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterVolumetricFlowRateUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.LiterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.LiterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.LiterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.USGallonPerMinute:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.USGallonPerHour:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.MilliliterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.LiterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicFootPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.USGallonPerSecond:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.USGallonPerDay:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.AcreFootPerDay:
                    return UnitConverterUnitSystem.Survey;
                case UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.CubicYardPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond:
                    return UnitConverterUnitSystem.ImperialUK;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterVolumetricFlowRateUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute, UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour, UnitConverterVolumetricFlowRateUnit.LiterPerSecond, UnitConverterVolumetricFlowRateUnit.LiterPerMinute, UnitConverterVolumetricFlowRateUnit.LiterPerHour, UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute, UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute, UnitConverterVolumetricFlowRateUnit.MilliliterPerHour, UnitConverterVolumetricFlowRateUnit.LiterPerDay, UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour, UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterVolumetricFlowRateUnit.USGallonPerMinute, UnitConverterVolumetricFlowRateUnit.USGallonPerHour, UnitConverterVolumetricFlowRateUnit.USGallonPerSecond, UnitConverterVolumetricFlowRateUnit.USGallonPerDay, UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay, UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour, UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay, UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute, UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond, UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour, UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond, UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute, UnitConverterVolumetricFlowRateUnit.CubicFootPerHour, UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond, UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute, UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond, UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute, UnitConverterVolumetricFlowRateUnit.CubicYardPerHour };
                case UnitConverterUnitSystem.Survey:
                    return new[] { UnitConverterVolumetricFlowRateUnit.AcreFootPerDay };
                default:
                    return new[] { UnitConverterVolumetricFlowRateUnit.CubicMeterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicMeterPerMinute, UnitConverterVolumetricFlowRateUnit.CubicMeterPerHour, UnitConverterVolumetricFlowRateUnit.LiterPerSecond, UnitConverterVolumetricFlowRateUnit.LiterPerMinute, UnitConverterVolumetricFlowRateUnit.LiterPerHour, UnitConverterVolumetricFlowRateUnit.MilliliterPerSecond, UnitConverterVolumetricFlowRateUnit.USGallonPerMinute, UnitConverterVolumetricFlowRateUnit.USGallonPerHour, UnitConverterVolumetricFlowRateUnit.ImperialGallonPerMinute, UnitConverterVolumetricFlowRateUnit.CubicFootPerSecond, UnitConverterVolumetricFlowRateUnit.CubicFootPerMinute, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerMinute, UnitConverterVolumetricFlowRateUnit.MilliliterPerMinute, UnitConverterVolumetricFlowRateUnit.MilliliterPerHour, UnitConverterVolumetricFlowRateUnit.LiterPerDay, UnitConverterVolumetricFlowRateUnit.CubicFootPerHour, UnitConverterVolumetricFlowRateUnit.CubicInchPerSecond, UnitConverterVolumetricFlowRateUnit.CubicInchPerMinute, UnitConverterVolumetricFlowRateUnit.USGallonPerSecond, UnitConverterVolumetricFlowRateUnit.USGallonPerDay, UnitConverterVolumetricFlowRateUnit.ImperialGallonPerSecond, UnitConverterVolumetricFlowRateUnit.ImperialGallonPerHour, UnitConverterVolumetricFlowRateUnit.OilBarrelPerDay, UnitConverterVolumetricFlowRateUnit.OilBarrelPerHour, UnitConverterVolumetricFlowRateUnit.AcreFootPerDay, UnitConverterVolumetricFlowRateUnit.MillionUSGallonsPerDay, UnitConverterVolumetricFlowRateUnit.CubicMeterPerDay, UnitConverterVolumetricFlowRateUnit.CubicCentimeterPerHour, UnitConverterVolumetricFlowRateUnit.CubicMillimeterPerSecond, UnitConverterVolumetricFlowRateUnit.CubicYardPerSecond, UnitConverterVolumetricFlowRateUnit.CubicYardPerMinute, UnitConverterVolumetricFlowRateUnit.CubicYardPerHour, UnitConverterVolumetricFlowRateUnit.USFluidOuncePerSecond, UnitConverterVolumetricFlowRateUnit.ImperialFluidOuncePerSecond };
            }
        }
    }
}
