namespace UnitTools.FuelEconomy
{
    using UnitTools.FuelEconomy.Common;
    using UnitTools.FuelEconomy.Metric;
    using UnitTools.FuelEconomy.Imperial;
    using UnitTools.FuelEconomy.ImperialUS;
    using UnitTools.FuelEconomy.ImperialUK;
    using UnitTools.FuelEconomy.Nautical;

    public enum UnitToolsFuelEconomyUnit
    {
        KilometerPerLiter = 0,
        LiterPer100Kilometer = 1,
        MilePerUSGallon = 2,
        MilePerImperialGallon = 3,
        LiterPerKilometer = 4,
        LiterPerMile = 5,
        USGallonPerMile = 6,
        ImperialGallonPerMile = 7,
        MilePerLiter = 8,
        NauticalMilePerUSGallon = 9,
        MeterPerLiter = 10,
        KilometerPerUSGallon = 11,
        KilometerPerImperialGallon = 12,
        NauticalMilePerImperialGallon = 13,
        MilliliterPerKilometer = 14,
        LiterPer10Kilometer = 15,
        LiterPer100Mile = 16,
        USGallonPer100Mile = 17,
        ImperialGallonPer100Mile = 18,
        USGallonPer100Kilometer = 19,
        ImperialGallonPer100Kilometer = 20,
        KilometerPerMilliliter = 21,
        MeterPerMilliliter = 22,
    }

    public static class UnitToolsFuelEconomy
    {
        public static double Convert(double value, UnitToolsFuelEconomyUnit from, UnitToolsFuelEconomyUnit to)
        {
            double baseValue = ToKilometerPerLiter(value, from);
            return FromKilometerPerLiter(baseValue, to);
        }

        public static double ToKilometerPerLiter(double value, UnitToolsFuelEconomyUnit from)
        {
            switch (from)
            {
                case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                    return UnitToolsCommonFuelEconomy.KilometerPerLiterToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitToolsCommonFuelEconomy.LiterPer100KilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                    return UnitToolsCommonFuelEconomy.MilePerUSGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                    return UnitToolsCommonFuelEconomy.MilePerImperialGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                    return UnitToolsMetricFuelEconomy.LiterPerKilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.LiterPerMile:
                    return UnitToolsImperialFuelEconomy.LiterPerMileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.USGallonPerMile:
                    return UnitToolsImperialUSFuelEconomy.USGallonPerMileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitToolsImperialUKFuelEconomy.ImperialGallonPerMileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MilePerLiter:
                    return UnitToolsImperialFuelEconomy.MilePerLiterToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitToolsNauticalFuelEconomy.NauticalMilePerUSGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MeterPerLiter:
                    return UnitToolsMetricFuelEconomy.MeterPerLiterToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitToolsImperialUSFuelEconomy.KilometerPerUSGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitToolsImperialUKFuelEconomy.KilometerPerImperialGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitToolsNauticalFuelEconomy.NauticalMilePerImperialGallonToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitToolsMetricFuelEconomy.MilliliterPerKilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitToolsMetricFuelEconomy.LiterPer10KilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                    return UnitToolsImperialFuelEconomy.LiterPer100MileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                    return UnitToolsImperialUSFuelEconomy.USGallonPer100MileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitToolsImperialUKFuelEconomy.ImperialGallonPer100MileToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitToolsImperialUSFuelEconomy.USGallonPer100KilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitToolsImperialUKFuelEconomy.ImperialGallonPer100KilometerToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitToolsMetricFuelEconomy.KilometerPerMilliliterToKilometerPerLiter(value);
                case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return UnitToolsMetricFuelEconomy.MeterPerMilliliterToKilometerPerLiter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported fuel economy unit.");
            }
        }

        public static double FromKilometerPerLiter(double baseValue, UnitToolsFuelEconomyUnit to)
        {
            switch (to)
            {
                case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                    return UnitToolsCommonFuelEconomy.KilometerPerLiterToKilometerPerLiter(baseValue);
                case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitToolsCommonFuelEconomy.KilometerPerLiterToLiterPer100Kilometer(baseValue);
                case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                    return UnitToolsCommonFuelEconomy.KilometerPerLiterToMilePerUSGallon(baseValue);
                case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                    return UnitToolsCommonFuelEconomy.KilometerPerLiterToMilePerImperialGallon(baseValue);
                case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToLiterPerKilometer(baseValue);
                case UnitToolsFuelEconomyUnit.LiterPerMile:
                    return UnitToolsImperialFuelEconomy.KilometerPerLiterToLiterPerMile(baseValue);
                case UnitToolsFuelEconomyUnit.USGallonPerMile:
                    return UnitToolsImperialUSFuelEconomy.KilometerPerLiterToUSGallonPerMile(baseValue);
                case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitToolsImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPerMile(baseValue);
                case UnitToolsFuelEconomyUnit.MilePerLiter:
                    return UnitToolsImperialFuelEconomy.KilometerPerLiterToMilePerLiter(baseValue);
                case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitToolsNauticalFuelEconomy.KilometerPerLiterToNauticalMilePerUSGallon(baseValue);
                case UnitToolsFuelEconomyUnit.MeterPerLiter:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToMeterPerLiter(baseValue);
                case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitToolsImperialUSFuelEconomy.KilometerPerLiterToKilometerPerUSGallon(baseValue);
                case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitToolsImperialUKFuelEconomy.KilometerPerLiterToKilometerPerImperialGallon(baseValue);
                case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitToolsNauticalFuelEconomy.KilometerPerLiterToNauticalMilePerImperialGallon(baseValue);
                case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToMilliliterPerKilometer(baseValue);
                case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToLiterPer10Kilometer(baseValue);
                case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                    return UnitToolsImperialFuelEconomy.KilometerPerLiterToLiterPer100Mile(baseValue);
                case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                    return UnitToolsImperialUSFuelEconomy.KilometerPerLiterToUSGallonPer100Mile(baseValue);
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitToolsImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPer100Mile(baseValue);
                case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitToolsImperialUSFuelEconomy.KilometerPerLiterToUSGallonPer100Kilometer(baseValue);
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitToolsImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPer100Kilometer(baseValue);
                case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToKilometerPerMilliliter(baseValue);
                case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return UnitToolsMetricFuelEconomy.KilometerPerLiterToMeterPerMilliliter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported fuel economy unit.");
            }
        }

        public static string GetSymbol(UnitToolsFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                    return "km/L";
                case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                    return "L/100 km";
                case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                    return "mpg US";
                case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                    return "mpg imp";
                case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                    return "L/km";
                case UnitToolsFuelEconomyUnit.LiterPerMile:
                    return "L/mi";
                case UnitToolsFuelEconomyUnit.USGallonPerMile:
                    return "gal/mi US";
                case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                    return "gal/mi imp";
                case UnitToolsFuelEconomyUnit.MilePerLiter:
                    return "mi/L";
                case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                    return "nmi/gal US";
                case UnitToolsFuelEconomyUnit.MeterPerLiter:
                    return "m/L";
                case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                    return "km/gal US";
                case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                    return "km/gal imp";
                case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return "nmi/gal imp";
                case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                    return "mL/km";
                case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                    return "L/10 km";
                case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                    return "L/100 mi";
                case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                    return "gal/100 mi US";
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                    return "gal/100 mi imp";
                case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                    return "gal/100 km US";
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return "gal/100 km imp";
                case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                    return "km/mL";
                case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return "m/mL";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                    return "Kilometer Per Liter";
                case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                    return "Liter Per 100 Kilometer";
                case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                    return "Mile Per US Gallon";
                case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                    return "Mile Per Imperial Gallon";
                case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                    return "Liter Per Kilometer";
                case UnitToolsFuelEconomyUnit.LiterPerMile:
                    return "Liter Per Mile";
                case UnitToolsFuelEconomyUnit.USGallonPerMile:
                    return "US Gallon Per Mile";
                case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                    return "Imperial Gallon Per Mile";
                case UnitToolsFuelEconomyUnit.MilePerLiter:
                    return "Mile Per Liter";
                case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                    return "Nautical Mile Per US Gallon";
                case UnitToolsFuelEconomyUnit.MeterPerLiter:
                    return "Meter Per Liter";
                case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                    return "Kilometer Per US Gallon";
                case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                    return "Kilometer Per Imperial Gallon";
                case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return "Nautical Mile Per Imperial Gallon";
                case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                    return "Milliliter Per Kilometer";
                case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                    return "Liter Per 10 Kilometer";
                case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                    return "Liter Per 100 Mile";
                case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                    return "US Gallon Per 100 Mile";
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                    return "Imperial Gallon Per 100 Mile";
                case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                    return "US Gallon Per 100 Kilometer";
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return "Imperial Gallon Per 100 Kilometer";
                case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                    return "Kilometer Per Milliliter";
                case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return "Meter Per Milliliter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsFuelEconomyUnit.KilometerPerLiter:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFuelEconomyUnit.MilePerUSGallon:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFuelEconomyUnit.MilePerImperialGallon:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsFuelEconomyUnit.LiterPerKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFuelEconomyUnit.LiterPerMile:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsFuelEconomyUnit.USGallonPerMile:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsFuelEconomyUnit.MilePerLiter:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsFuelEconomyUnit.MeterPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitToolsUnitSystem.Nautical;
                case UnitToolsFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFuelEconomyUnit.LiterPer100Mile:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsFuelEconomyUnit.USGallonPer100Mile:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitToolsUnitSystem.ImperialUK;
                case UnitToolsFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsFuelEconomyUnit.MeterPerMilliliter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsFuelEconomyUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsFuelEconomyUnit.KilometerPerLiter, UnitToolsFuelEconomyUnit.LiterPer100Kilometer, UnitToolsFuelEconomyUnit.MilePerUSGallon, UnitToolsFuelEconomyUnit.MilePerImperialGallon };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsFuelEconomyUnit.LiterPerKilometer, UnitToolsFuelEconomyUnit.MeterPerLiter, UnitToolsFuelEconomyUnit.MilliliterPerKilometer, UnitToolsFuelEconomyUnit.LiterPer10Kilometer, UnitToolsFuelEconomyUnit.KilometerPerMilliliter, UnitToolsFuelEconomyUnit.MeterPerMilliliter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsFuelEconomyUnit.LiterPerMile, UnitToolsFuelEconomyUnit.MilePerLiter, UnitToolsFuelEconomyUnit.LiterPer100Mile };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsFuelEconomyUnit.USGallonPerMile, UnitToolsFuelEconomyUnit.KilometerPerUSGallon, UnitToolsFuelEconomyUnit.USGallonPer100Mile, UnitToolsFuelEconomyUnit.USGallonPer100Kilometer };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsFuelEconomyUnit.ImperialGallonPerMile, UnitToolsFuelEconomyUnit.KilometerPerImperialGallon, UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile, UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer };
                case UnitToolsUnitSystem.Nautical:
                    return new[] { UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon, UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon };
                default:
                    return new[] { UnitToolsFuelEconomyUnit.KilometerPerLiter, UnitToolsFuelEconomyUnit.LiterPer100Kilometer, UnitToolsFuelEconomyUnit.MilePerUSGallon, UnitToolsFuelEconomyUnit.MilePerImperialGallon, UnitToolsFuelEconomyUnit.LiterPerKilometer, UnitToolsFuelEconomyUnit.LiterPerMile, UnitToolsFuelEconomyUnit.USGallonPerMile, UnitToolsFuelEconomyUnit.ImperialGallonPerMile, UnitToolsFuelEconomyUnit.MilePerLiter, UnitToolsFuelEconomyUnit.NauticalMilePerUSGallon, UnitToolsFuelEconomyUnit.MeterPerLiter, UnitToolsFuelEconomyUnit.KilometerPerUSGallon, UnitToolsFuelEconomyUnit.KilometerPerImperialGallon, UnitToolsFuelEconomyUnit.NauticalMilePerImperialGallon, UnitToolsFuelEconomyUnit.MilliliterPerKilometer, UnitToolsFuelEconomyUnit.LiterPer10Kilometer, UnitToolsFuelEconomyUnit.LiterPer100Mile, UnitToolsFuelEconomyUnit.USGallonPer100Mile, UnitToolsFuelEconomyUnit.ImperialGallonPer100Mile, UnitToolsFuelEconomyUnit.USGallonPer100Kilometer, UnitToolsFuelEconomyUnit.ImperialGallonPer100Kilometer, UnitToolsFuelEconomyUnit.KilometerPerMilliliter, UnitToolsFuelEconomyUnit.MeterPerMilliliter };
            }
        }
    }
}
