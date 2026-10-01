namespace UnitConverter.FuelEconomy
{
    using UnitConverter.FuelEconomy.Common;
    using UnitConverter.FuelEconomy.Metric;
    using UnitConverter.FuelEconomy.Imperial;
    using UnitConverter.FuelEconomy.ImperialUS;
    using UnitConverter.FuelEconomy.ImperialUK;
    using UnitConverter.FuelEconomy.Nautical;

    public enum UnitConverterFuelEconomyUnit
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

    public static class UnitConverterFuelEconomy
    {
        public static double Convert(double value, UnitConverterFuelEconomyUnit from, UnitConverterFuelEconomyUnit to)
        {
            double baseValue = ToKilometerPerLiter(value, from);
            return FromKilometerPerLiter(baseValue, to);
        }

        public static double ToKilometerPerLiter(double value, UnitConverterFuelEconomyUnit from)
        {
            switch (from)
            {
                case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                    return UnitConverterCommonFuelEconomy.KilometerPerLiterToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitConverterCommonFuelEconomy.LiterPer100KilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                    return UnitConverterCommonFuelEconomy.MilePerUSGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                    return UnitConverterCommonFuelEconomy.MilePerImperialGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                    return UnitConverterMetricFuelEconomy.LiterPerKilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.LiterPerMile:
                    return UnitConverterImperialFuelEconomy.LiterPerMileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.USGallonPerMile:
                    return UnitConverterImperialUSFuelEconomy.USGallonPerMileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitConverterImperialUKFuelEconomy.ImperialGallonPerMileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MilePerLiter:
                    return UnitConverterImperialFuelEconomy.MilePerLiterToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitConverterNauticalFuelEconomy.NauticalMilePerUSGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MeterPerLiter:
                    return UnitConverterMetricFuelEconomy.MeterPerLiterToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitConverterImperialUSFuelEconomy.KilometerPerUSGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitConverterImperialUKFuelEconomy.KilometerPerImperialGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitConverterNauticalFuelEconomy.NauticalMilePerImperialGallonToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitConverterMetricFuelEconomy.MilliliterPerKilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitConverterMetricFuelEconomy.LiterPer10KilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                    return UnitConverterImperialFuelEconomy.LiterPer100MileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                    return UnitConverterImperialUSFuelEconomy.USGallonPer100MileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitConverterImperialUKFuelEconomy.ImperialGallonPer100MileToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitConverterImperialUSFuelEconomy.USGallonPer100KilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitConverterImperialUKFuelEconomy.ImperialGallonPer100KilometerToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitConverterMetricFuelEconomy.KilometerPerMilliliterToKilometerPerLiter(value);
                case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return UnitConverterMetricFuelEconomy.MeterPerMilliliterToKilometerPerLiter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported fuel economy unit.");
            }
        }

        public static double FromKilometerPerLiter(double baseValue, UnitConverterFuelEconomyUnit to)
        {
            switch (to)
            {
                case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                    return UnitConverterCommonFuelEconomy.KilometerPerLiterToKilometerPerLiter(baseValue);
                case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitConverterCommonFuelEconomy.KilometerPerLiterToLiterPer100Kilometer(baseValue);
                case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                    return UnitConverterCommonFuelEconomy.KilometerPerLiterToMilePerUSGallon(baseValue);
                case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                    return UnitConverterCommonFuelEconomy.KilometerPerLiterToMilePerImperialGallon(baseValue);
                case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToLiterPerKilometer(baseValue);
                case UnitConverterFuelEconomyUnit.LiterPerMile:
                    return UnitConverterImperialFuelEconomy.KilometerPerLiterToLiterPerMile(baseValue);
                case UnitConverterFuelEconomyUnit.USGallonPerMile:
                    return UnitConverterImperialUSFuelEconomy.KilometerPerLiterToUSGallonPerMile(baseValue);
                case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitConverterImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPerMile(baseValue);
                case UnitConverterFuelEconomyUnit.MilePerLiter:
                    return UnitConverterImperialFuelEconomy.KilometerPerLiterToMilePerLiter(baseValue);
                case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitConverterNauticalFuelEconomy.KilometerPerLiterToNauticalMilePerUSGallon(baseValue);
                case UnitConverterFuelEconomyUnit.MeterPerLiter:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToMeterPerLiter(baseValue);
                case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitConverterImperialUSFuelEconomy.KilometerPerLiterToKilometerPerUSGallon(baseValue);
                case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitConverterImperialUKFuelEconomy.KilometerPerLiterToKilometerPerImperialGallon(baseValue);
                case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitConverterNauticalFuelEconomy.KilometerPerLiterToNauticalMilePerImperialGallon(baseValue);
                case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToMilliliterPerKilometer(baseValue);
                case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToLiterPer10Kilometer(baseValue);
                case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                    return UnitConverterImperialFuelEconomy.KilometerPerLiterToLiterPer100Mile(baseValue);
                case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                    return UnitConverterImperialUSFuelEconomy.KilometerPerLiterToUSGallonPer100Mile(baseValue);
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitConverterImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPer100Mile(baseValue);
                case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitConverterImperialUSFuelEconomy.KilometerPerLiterToUSGallonPer100Kilometer(baseValue);
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitConverterImperialUKFuelEconomy.KilometerPerLiterToImperialGallonPer100Kilometer(baseValue);
                case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToKilometerPerMilliliter(baseValue);
                case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return UnitConverterMetricFuelEconomy.KilometerPerLiterToMeterPerMilliliter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported fuel economy unit.");
            }
        }

        public static string GetSymbol(UnitConverterFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                    return "km/L";
                case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                    return "L/100 km";
                case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                    return "mpg US";
                case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                    return "mpg imp";
                case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                    return "L/km";
                case UnitConverterFuelEconomyUnit.LiterPerMile:
                    return "L/mi";
                case UnitConverterFuelEconomyUnit.USGallonPerMile:
                    return "gal/mi US";
                case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                    return "gal/mi imp";
                case UnitConverterFuelEconomyUnit.MilePerLiter:
                    return "mi/L";
                case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                    return "nmi/gal US";
                case UnitConverterFuelEconomyUnit.MeterPerLiter:
                    return "m/L";
                case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                    return "km/gal US";
                case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                    return "km/gal imp";
                case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return "nmi/gal imp";
                case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                    return "mL/km";
                case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                    return "L/10 km";
                case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                    return "L/100 mi";
                case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                    return "gal/100 mi US";
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                    return "gal/100 mi imp";
                case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                    return "gal/100 km US";
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return "gal/100 km imp";
                case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                    return "km/mL";
                case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return "m/mL";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                    return "Kilometer Per Liter";
                case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                    return "Liter Per 100 Kilometer";
                case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                    return "Mile Per US Gallon";
                case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                    return "Mile Per Imperial Gallon";
                case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                    return "Liter Per Kilometer";
                case UnitConverterFuelEconomyUnit.LiterPerMile:
                    return "Liter Per Mile";
                case UnitConverterFuelEconomyUnit.USGallonPerMile:
                    return "US Gallon Per Mile";
                case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                    return "Imperial Gallon Per Mile";
                case UnitConverterFuelEconomyUnit.MilePerLiter:
                    return "Mile Per Liter";
                case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                    return "Nautical Mile Per US Gallon";
                case UnitConverterFuelEconomyUnit.MeterPerLiter:
                    return "Meter Per Liter";
                case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                    return "Kilometer Per US Gallon";
                case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                    return "Kilometer Per Imperial Gallon";
                case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return "Nautical Mile Per Imperial Gallon";
                case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                    return "Milliliter Per Kilometer";
                case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                    return "Liter Per 10 Kilometer";
                case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                    return "Liter Per 100 Mile";
                case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                    return "US Gallon Per 100 Mile";
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                    return "Imperial Gallon Per 100 Mile";
                case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                    return "US Gallon Per 100 Kilometer";
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return "Imperial Gallon Per 100 Kilometer";
                case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                    return "Kilometer Per Milliliter";
                case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return "Meter Per Milliliter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterFuelEconomyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterFuelEconomyUnit.KilometerPerLiter:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFuelEconomyUnit.LiterPer100Kilometer:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFuelEconomyUnit.MilePerUSGallon:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFuelEconomyUnit.MilePerImperialGallon:
                    return UnitConverterUnitSystem.Common;
                case UnitConverterFuelEconomyUnit.LiterPerKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFuelEconomyUnit.LiterPerMile:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterFuelEconomyUnit.USGallonPerMile:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterFuelEconomyUnit.ImperialGallonPerMile:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterFuelEconomyUnit.MilePerLiter:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterFuelEconomyUnit.MeterPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFuelEconomyUnit.KilometerPerUSGallon:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterFuelEconomyUnit.KilometerPerImperialGallon:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon:
                    return UnitConverterUnitSystem.Nautical;
                case UnitConverterFuelEconomyUnit.MilliliterPerKilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFuelEconomyUnit.LiterPer10Kilometer:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFuelEconomyUnit.LiterPer100Mile:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterFuelEconomyUnit.USGallonPer100Mile:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterFuelEconomyUnit.USGallonPer100Kilometer:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer:
                    return UnitConverterUnitSystem.ImperialUK;
                case UnitConverterFuelEconomyUnit.KilometerPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterFuelEconomyUnit.MeterPerMilliliter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterFuelEconomyUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Common:
                    return new[] { UnitConverterFuelEconomyUnit.KilometerPerLiter, UnitConverterFuelEconomyUnit.LiterPer100Kilometer, UnitConverterFuelEconomyUnit.MilePerUSGallon, UnitConverterFuelEconomyUnit.MilePerImperialGallon };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterFuelEconomyUnit.LiterPerKilometer, UnitConverterFuelEconomyUnit.MeterPerLiter, UnitConverterFuelEconomyUnit.MilliliterPerKilometer, UnitConverterFuelEconomyUnit.LiterPer10Kilometer, UnitConverterFuelEconomyUnit.KilometerPerMilliliter, UnitConverterFuelEconomyUnit.MeterPerMilliliter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterFuelEconomyUnit.LiterPerMile, UnitConverterFuelEconomyUnit.MilePerLiter, UnitConverterFuelEconomyUnit.LiterPer100Mile };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterFuelEconomyUnit.USGallonPerMile, UnitConverterFuelEconomyUnit.KilometerPerUSGallon, UnitConverterFuelEconomyUnit.USGallonPer100Mile, UnitConverterFuelEconomyUnit.USGallonPer100Kilometer };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterFuelEconomyUnit.ImperialGallonPerMile, UnitConverterFuelEconomyUnit.KilometerPerImperialGallon, UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile, UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer };
                case UnitConverterUnitSystem.Nautical:
                    return new[] { UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon, UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon };
                default:
                    return new[] { UnitConverterFuelEconomyUnit.KilometerPerLiter, UnitConverterFuelEconomyUnit.LiterPer100Kilometer, UnitConverterFuelEconomyUnit.MilePerUSGallon, UnitConverterFuelEconomyUnit.MilePerImperialGallon, UnitConverterFuelEconomyUnit.LiterPerKilometer, UnitConverterFuelEconomyUnit.LiterPerMile, UnitConverterFuelEconomyUnit.USGallonPerMile, UnitConverterFuelEconomyUnit.ImperialGallonPerMile, UnitConverterFuelEconomyUnit.MilePerLiter, UnitConverterFuelEconomyUnit.NauticalMilePerUSGallon, UnitConverterFuelEconomyUnit.MeterPerLiter, UnitConverterFuelEconomyUnit.KilometerPerUSGallon, UnitConverterFuelEconomyUnit.KilometerPerImperialGallon, UnitConverterFuelEconomyUnit.NauticalMilePerImperialGallon, UnitConverterFuelEconomyUnit.MilliliterPerKilometer, UnitConverterFuelEconomyUnit.LiterPer10Kilometer, UnitConverterFuelEconomyUnit.LiterPer100Mile, UnitConverterFuelEconomyUnit.USGallonPer100Mile, UnitConverterFuelEconomyUnit.ImperialGallonPer100Mile, UnitConverterFuelEconomyUnit.USGallonPer100Kilometer, UnitConverterFuelEconomyUnit.ImperialGallonPer100Kilometer, UnitConverterFuelEconomyUnit.KilometerPerMilliliter, UnitConverterFuelEconomyUnit.MeterPerMilliliter };
            }
        }
    }
}
