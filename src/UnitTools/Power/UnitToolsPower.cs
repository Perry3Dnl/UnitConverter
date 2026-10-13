namespace UnitTools.Power
{
    using UnitTools.Power.Metric;
    using UnitTools.Power.Imperial;
    using UnitTools.Power.Engineering;
    using UnitTools.Power.ImperialUS;
    using UnitTools.Power.Scientific;

    public enum UnitToolsPowerUnit
    {
        Microwatt = 0,
        Milliwatt = 1,
        Watt = 2,
        Kilowatt = 3,
        Megawatt = 4,
        Gigawatt = 5,
        HorsepowerMechanical = 6,
        HorsepowerMetric = 7,
        HorsepowerElectrical = 8,
        HorsepowerBoiler = 9,
        BtuPerHour = 10,
        FootPoundPerSecond = 11,
        Picowatt = 12,
        Nanowatt = 13,
        Terawatt = 14,
        Petawatt = 15,
        ErgPerSecond = 16,
        CaloriePerSecond = 17,
        KilocaloriePerHour = 18,
        TonOfRefrigeration = 19,
        VoltAmpere = 20,
        KilovoltAmpere = 21,
    }

    public static class UnitToolsPower
    {
        public static double Convert(double value, UnitToolsPowerUnit from, UnitToolsPowerUnit to)
        {
            double baseValue = ToWatt(value, from);
            return FromWatt(baseValue, to);
        }

        public static double ToWatt(double value, UnitToolsPowerUnit from)
        {
            switch (from)
            {
                case UnitToolsPowerUnit.Microwatt:
                    return UnitToolsMetricPower.MicrowattToWatt(value);
                case UnitToolsPowerUnit.Milliwatt:
                    return UnitToolsMetricPower.MilliwattToWatt(value);
                case UnitToolsPowerUnit.Watt:
                    return UnitToolsMetricPower.WattToWatt(value);
                case UnitToolsPowerUnit.Kilowatt:
                    return UnitToolsMetricPower.KilowattToWatt(value);
                case UnitToolsPowerUnit.Megawatt:
                    return UnitToolsMetricPower.MegawattToWatt(value);
                case UnitToolsPowerUnit.Gigawatt:
                    return UnitToolsMetricPower.GigawattToWatt(value);
                case UnitToolsPowerUnit.HorsepowerMechanical:
                    return UnitToolsImperialPower.HorsepowerMechanicalToWatt(value);
                case UnitToolsPowerUnit.HorsepowerMetric:
                    return UnitToolsMetricPower.HorsepowerMetricToWatt(value);
                case UnitToolsPowerUnit.HorsepowerElectrical:
                    return UnitToolsEngineeringPower.HorsepowerElectricalToWatt(value);
                case UnitToolsPowerUnit.HorsepowerBoiler:
                    return UnitToolsImperialUSPower.HorsepowerBoilerToWatt(value);
                case UnitToolsPowerUnit.BtuPerHour:
                    return UnitToolsImperialPower.BtuPerHourToWatt(value);
                case UnitToolsPowerUnit.FootPoundPerSecond:
                    return UnitToolsImperialPower.FootPoundPerSecondToWatt(value);
                case UnitToolsPowerUnit.Picowatt:
                    return UnitToolsMetricPower.PicowattToWatt(value);
                case UnitToolsPowerUnit.Nanowatt:
                    return UnitToolsMetricPower.NanowattToWatt(value);
                case UnitToolsPowerUnit.Terawatt:
                    return UnitToolsMetricPower.TerawattToWatt(value);
                case UnitToolsPowerUnit.Petawatt:
                    return UnitToolsMetricPower.PetawattToWatt(value);
                case UnitToolsPowerUnit.ErgPerSecond:
                    return UnitToolsScientificPower.ErgPerSecondToWatt(value);
                case UnitToolsPowerUnit.CaloriePerSecond:
                    return UnitToolsMetricPower.CaloriePerSecondToWatt(value);
                case UnitToolsPowerUnit.KilocaloriePerHour:
                    return UnitToolsMetricPower.KilocaloriePerHourToWatt(value);
                case UnitToolsPowerUnit.TonOfRefrigeration:
                    return UnitToolsEngineeringPower.TonOfRefrigerationToWatt(value);
                case UnitToolsPowerUnit.VoltAmpere:
                    return UnitToolsEngineeringPower.VoltAmpereToWatt(value);
                case UnitToolsPowerUnit.KilovoltAmpere:
                    return UnitToolsEngineeringPower.KilovoltAmpereToWatt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported power unit.");
            }
        }

        public static double FromWatt(double baseValue, UnitToolsPowerUnit to)
        {
            switch (to)
            {
                case UnitToolsPowerUnit.Microwatt:
                    return UnitToolsMetricPower.WattToMicrowatt(baseValue);
                case UnitToolsPowerUnit.Milliwatt:
                    return UnitToolsMetricPower.WattToMilliwatt(baseValue);
                case UnitToolsPowerUnit.Watt:
                    return UnitToolsMetricPower.WattToWatt(baseValue);
                case UnitToolsPowerUnit.Kilowatt:
                    return UnitToolsMetricPower.WattToKilowatt(baseValue);
                case UnitToolsPowerUnit.Megawatt:
                    return UnitToolsMetricPower.WattToMegawatt(baseValue);
                case UnitToolsPowerUnit.Gigawatt:
                    return UnitToolsMetricPower.WattToGigawatt(baseValue);
                case UnitToolsPowerUnit.HorsepowerMechanical:
                    return UnitToolsImperialPower.WattToHorsepowerMechanical(baseValue);
                case UnitToolsPowerUnit.HorsepowerMetric:
                    return UnitToolsMetricPower.WattToHorsepowerMetric(baseValue);
                case UnitToolsPowerUnit.HorsepowerElectrical:
                    return UnitToolsEngineeringPower.WattToHorsepowerElectrical(baseValue);
                case UnitToolsPowerUnit.HorsepowerBoiler:
                    return UnitToolsImperialUSPower.WattToHorsepowerBoiler(baseValue);
                case UnitToolsPowerUnit.BtuPerHour:
                    return UnitToolsImperialPower.WattToBtuPerHour(baseValue);
                case UnitToolsPowerUnit.FootPoundPerSecond:
                    return UnitToolsImperialPower.WattToFootPoundPerSecond(baseValue);
                case UnitToolsPowerUnit.Picowatt:
                    return UnitToolsMetricPower.WattToPicowatt(baseValue);
                case UnitToolsPowerUnit.Nanowatt:
                    return UnitToolsMetricPower.WattToNanowatt(baseValue);
                case UnitToolsPowerUnit.Terawatt:
                    return UnitToolsMetricPower.WattToTerawatt(baseValue);
                case UnitToolsPowerUnit.Petawatt:
                    return UnitToolsMetricPower.WattToPetawatt(baseValue);
                case UnitToolsPowerUnit.ErgPerSecond:
                    return UnitToolsScientificPower.WattToErgPerSecond(baseValue);
                case UnitToolsPowerUnit.CaloriePerSecond:
                    return UnitToolsMetricPower.WattToCaloriePerSecond(baseValue);
                case UnitToolsPowerUnit.KilocaloriePerHour:
                    return UnitToolsMetricPower.WattToKilocaloriePerHour(baseValue);
                case UnitToolsPowerUnit.TonOfRefrigeration:
                    return UnitToolsEngineeringPower.WattToTonOfRefrigeration(baseValue);
                case UnitToolsPowerUnit.VoltAmpere:
                    return UnitToolsEngineeringPower.WattToVoltAmpere(baseValue);
                case UnitToolsPowerUnit.KilovoltAmpere:
                    return UnitToolsEngineeringPower.WattToKilovoltAmpere(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported power unit.");
            }
        }

        public static string GetSymbol(UnitToolsPowerUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerUnit.Microwatt:
                    return "µW";
                case UnitToolsPowerUnit.Milliwatt:
                    return "mW";
                case UnitToolsPowerUnit.Watt:
                    return "W";
                case UnitToolsPowerUnit.Kilowatt:
                    return "kW";
                case UnitToolsPowerUnit.Megawatt:
                    return "MW";
                case UnitToolsPowerUnit.Gigawatt:
                    return "GW";
                case UnitToolsPowerUnit.HorsepowerMechanical:
                    return "hp";
                case UnitToolsPowerUnit.HorsepowerMetric:
                    return "PS";
                case UnitToolsPowerUnit.HorsepowerElectrical:
                    return "hp(E)";
                case UnitToolsPowerUnit.HorsepowerBoiler:
                    return "hp(S)";
                case UnitToolsPowerUnit.BtuPerHour:
                    return "BTU/h";
                case UnitToolsPowerUnit.FootPoundPerSecond:
                    return "ft·lb/s";
                case UnitToolsPowerUnit.Picowatt:
                    return "pW";
                case UnitToolsPowerUnit.Nanowatt:
                    return "nW";
                case UnitToolsPowerUnit.Terawatt:
                    return "TW";
                case UnitToolsPowerUnit.Petawatt:
                    return "PW";
                case UnitToolsPowerUnit.ErgPerSecond:
                    return "erg/s";
                case UnitToolsPowerUnit.CaloriePerSecond:
                    return "cal/s";
                case UnitToolsPowerUnit.KilocaloriePerHour:
                    return "kcal/h";
                case UnitToolsPowerUnit.TonOfRefrigeration:
                    return "TR";
                case UnitToolsPowerUnit.VoltAmpere:
                    return "VA";
                case UnitToolsPowerUnit.KilovoltAmpere:
                    return "kVA";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPowerUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerUnit.Microwatt:
                    return "microwatt";
                case UnitToolsPowerUnit.Milliwatt:
                    return "milliwatt";
                case UnitToolsPowerUnit.Watt:
                    return "watt";
                case UnitToolsPowerUnit.Kilowatt:
                    return "kilowatt";
                case UnitToolsPowerUnit.Megawatt:
                    return "megawatt";
                case UnitToolsPowerUnit.Gigawatt:
                    return "gigawatt";
                case UnitToolsPowerUnit.HorsepowerMechanical:
                    return "mechanical horsepower";
                case UnitToolsPowerUnit.HorsepowerMetric:
                    return "metric horsepower";
                case UnitToolsPowerUnit.HorsepowerElectrical:
                    return "electrical horsepower";
                case UnitToolsPowerUnit.HorsepowerBoiler:
                    return "boiler horsepower";
                case UnitToolsPowerUnit.BtuPerHour:
                    return "BTU per hour";
                case UnitToolsPowerUnit.FootPoundPerSecond:
                    return "foot-pound per second";
                case UnitToolsPowerUnit.Picowatt:
                    return "Picowatt";
                case UnitToolsPowerUnit.Nanowatt:
                    return "Nanowatt";
                case UnitToolsPowerUnit.Terawatt:
                    return "Terawatt";
                case UnitToolsPowerUnit.Petawatt:
                    return "Petawatt";
                case UnitToolsPowerUnit.ErgPerSecond:
                    return "Erg Per Second";
                case UnitToolsPowerUnit.CaloriePerSecond:
                    return "Calorie Per Second";
                case UnitToolsPowerUnit.KilocaloriePerHour:
                    return "Kilocalorie Per Hour";
                case UnitToolsPowerUnit.TonOfRefrigeration:
                    return "Ton Of Refrigeration";
                case UnitToolsPowerUnit.VoltAmpere:
                    return "Volt Ampere";
                case UnitToolsPowerUnit.KilovoltAmpere:
                    return "Kilovolt Ampere";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPowerUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerUnit.Microwatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Milliwatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Watt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Kilowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Megawatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Gigawatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.HorsepowerMechanical:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerUnit.HorsepowerMetric:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.HorsepowerElectrical:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPowerUnit.HorsepowerBoiler:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsPowerUnit.BtuPerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerUnit.FootPoundPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerUnit.Picowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Nanowatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Terawatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.Petawatt:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.ErgPerSecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsPowerUnit.CaloriePerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.KilocaloriePerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerUnit.TonOfRefrigeration:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPowerUnit.VoltAmpere:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsPowerUnit.KilovoltAmpere:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPowerUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPowerUnit.Microwatt, UnitToolsPowerUnit.Milliwatt, UnitToolsPowerUnit.Watt, UnitToolsPowerUnit.Kilowatt, UnitToolsPowerUnit.Megawatt, UnitToolsPowerUnit.Gigawatt, UnitToolsPowerUnit.HorsepowerMetric, UnitToolsPowerUnit.Picowatt, UnitToolsPowerUnit.Nanowatt, UnitToolsPowerUnit.Terawatt, UnitToolsPowerUnit.Petawatt, UnitToolsPowerUnit.CaloriePerSecond, UnitToolsPowerUnit.KilocaloriePerHour };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPowerUnit.HorsepowerMechanical, UnitToolsPowerUnit.BtuPerHour, UnitToolsPowerUnit.FootPoundPerSecond };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsPowerUnit.HorsepowerElectrical, UnitToolsPowerUnit.TonOfRefrigeration, UnitToolsPowerUnit.VoltAmpere, UnitToolsPowerUnit.KilovoltAmpere };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsPowerUnit.HorsepowerBoiler };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsPowerUnit.ErgPerSecond };
                default:
                    return new[] { UnitToolsPowerUnit.Microwatt, UnitToolsPowerUnit.Milliwatt, UnitToolsPowerUnit.Watt, UnitToolsPowerUnit.Kilowatt, UnitToolsPowerUnit.Megawatt, UnitToolsPowerUnit.Gigawatt, UnitToolsPowerUnit.HorsepowerMechanical, UnitToolsPowerUnit.HorsepowerMetric, UnitToolsPowerUnit.HorsepowerElectrical, UnitToolsPowerUnit.HorsepowerBoiler, UnitToolsPowerUnit.BtuPerHour, UnitToolsPowerUnit.FootPoundPerSecond, UnitToolsPowerUnit.Picowatt, UnitToolsPowerUnit.Nanowatt, UnitToolsPowerUnit.Terawatt, UnitToolsPowerUnit.Petawatt, UnitToolsPowerUnit.ErgPerSecond, UnitToolsPowerUnit.CaloriePerSecond, UnitToolsPowerUnit.KilocaloriePerHour, UnitToolsPowerUnit.TonOfRefrigeration, UnitToolsPowerUnit.VoltAmpere, UnitToolsPowerUnit.KilovoltAmpere };
            }
        }
    }
}
