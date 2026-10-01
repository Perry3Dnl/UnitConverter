namespace UnitConverter.Power
{
    using UnitConverter.Power.Metric;
    using UnitConverter.Power.Imperial;
    using UnitConverter.Power.Engineering;
    using UnitConverter.Power.ImperialUS;
    using UnitConverter.Power.Scientific;

    public enum UnitConverterPowerUnit
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

    public static class UnitConverterPower
    {
        public static double Convert(double value, UnitConverterPowerUnit from, UnitConverterPowerUnit to)
        {
            double baseValue = ToWatt(value, from);
            return FromWatt(baseValue, to);
        }

        public static double ToWatt(double value, UnitConverterPowerUnit from)
        {
            switch (from)
            {
                case UnitConverterPowerUnit.Microwatt:
                    return UnitConverterMetricPower.MicrowattToWatt(value);
                case UnitConverterPowerUnit.Milliwatt:
                    return UnitConverterMetricPower.MilliwattToWatt(value);
                case UnitConverterPowerUnit.Watt:
                    return UnitConverterMetricPower.WattToWatt(value);
                case UnitConverterPowerUnit.Kilowatt:
                    return UnitConverterMetricPower.KilowattToWatt(value);
                case UnitConverterPowerUnit.Megawatt:
                    return UnitConverterMetricPower.MegawattToWatt(value);
                case UnitConverterPowerUnit.Gigawatt:
                    return UnitConverterMetricPower.GigawattToWatt(value);
                case UnitConverterPowerUnit.HorsepowerMechanical:
                    return UnitConverterImperialPower.HorsepowerMechanicalToWatt(value);
                case UnitConverterPowerUnit.HorsepowerMetric:
                    return UnitConverterMetricPower.HorsepowerMetricToWatt(value);
                case UnitConverterPowerUnit.HorsepowerElectrical:
                    return UnitConverterEngineeringPower.HorsepowerElectricalToWatt(value);
                case UnitConverterPowerUnit.HorsepowerBoiler:
                    return UnitConverterImperialUSPower.HorsepowerBoilerToWatt(value);
                case UnitConverterPowerUnit.BtuPerHour:
                    return UnitConverterImperialPower.BtuPerHourToWatt(value);
                case UnitConverterPowerUnit.FootPoundPerSecond:
                    return UnitConverterImperialPower.FootPoundPerSecondToWatt(value);
                case UnitConverterPowerUnit.Picowatt:
                    return UnitConverterMetricPower.PicowattToWatt(value);
                case UnitConverterPowerUnit.Nanowatt:
                    return UnitConverterMetricPower.NanowattToWatt(value);
                case UnitConverterPowerUnit.Terawatt:
                    return UnitConverterMetricPower.TerawattToWatt(value);
                case UnitConverterPowerUnit.Petawatt:
                    return UnitConverterMetricPower.PetawattToWatt(value);
                case UnitConverterPowerUnit.ErgPerSecond:
                    return UnitConverterScientificPower.ErgPerSecondToWatt(value);
                case UnitConverterPowerUnit.CaloriePerSecond:
                    return UnitConverterMetricPower.CaloriePerSecondToWatt(value);
                case UnitConverterPowerUnit.KilocaloriePerHour:
                    return UnitConverterMetricPower.KilocaloriePerHourToWatt(value);
                case UnitConverterPowerUnit.TonOfRefrigeration:
                    return UnitConverterEngineeringPower.TonOfRefrigerationToWatt(value);
                case UnitConverterPowerUnit.VoltAmpere:
                    return UnitConverterEngineeringPower.VoltAmpereToWatt(value);
                case UnitConverterPowerUnit.KilovoltAmpere:
                    return UnitConverterEngineeringPower.KilovoltAmpereToWatt(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported power unit.");
            }
        }

        public static double FromWatt(double baseValue, UnitConverterPowerUnit to)
        {
            switch (to)
            {
                case UnitConverterPowerUnit.Microwatt:
                    return UnitConverterMetricPower.WattToMicrowatt(baseValue);
                case UnitConverterPowerUnit.Milliwatt:
                    return UnitConverterMetricPower.WattToMilliwatt(baseValue);
                case UnitConverterPowerUnit.Watt:
                    return UnitConverterMetricPower.WattToWatt(baseValue);
                case UnitConverterPowerUnit.Kilowatt:
                    return UnitConverterMetricPower.WattToKilowatt(baseValue);
                case UnitConverterPowerUnit.Megawatt:
                    return UnitConverterMetricPower.WattToMegawatt(baseValue);
                case UnitConverterPowerUnit.Gigawatt:
                    return UnitConverterMetricPower.WattToGigawatt(baseValue);
                case UnitConverterPowerUnit.HorsepowerMechanical:
                    return UnitConverterImperialPower.WattToHorsepowerMechanical(baseValue);
                case UnitConverterPowerUnit.HorsepowerMetric:
                    return UnitConverterMetricPower.WattToHorsepowerMetric(baseValue);
                case UnitConverterPowerUnit.HorsepowerElectrical:
                    return UnitConverterEngineeringPower.WattToHorsepowerElectrical(baseValue);
                case UnitConverterPowerUnit.HorsepowerBoiler:
                    return UnitConverterImperialUSPower.WattToHorsepowerBoiler(baseValue);
                case UnitConverterPowerUnit.BtuPerHour:
                    return UnitConverterImperialPower.WattToBtuPerHour(baseValue);
                case UnitConverterPowerUnit.FootPoundPerSecond:
                    return UnitConverterImperialPower.WattToFootPoundPerSecond(baseValue);
                case UnitConverterPowerUnit.Picowatt:
                    return UnitConverterMetricPower.WattToPicowatt(baseValue);
                case UnitConverterPowerUnit.Nanowatt:
                    return UnitConverterMetricPower.WattToNanowatt(baseValue);
                case UnitConverterPowerUnit.Terawatt:
                    return UnitConverterMetricPower.WattToTerawatt(baseValue);
                case UnitConverterPowerUnit.Petawatt:
                    return UnitConverterMetricPower.WattToPetawatt(baseValue);
                case UnitConverterPowerUnit.ErgPerSecond:
                    return UnitConverterScientificPower.WattToErgPerSecond(baseValue);
                case UnitConverterPowerUnit.CaloriePerSecond:
                    return UnitConverterMetricPower.WattToCaloriePerSecond(baseValue);
                case UnitConverterPowerUnit.KilocaloriePerHour:
                    return UnitConverterMetricPower.WattToKilocaloriePerHour(baseValue);
                case UnitConverterPowerUnit.TonOfRefrigeration:
                    return UnitConverterEngineeringPower.WattToTonOfRefrigeration(baseValue);
                case UnitConverterPowerUnit.VoltAmpere:
                    return UnitConverterEngineeringPower.WattToVoltAmpere(baseValue);
                case UnitConverterPowerUnit.KilovoltAmpere:
                    return UnitConverterEngineeringPower.WattToKilovoltAmpere(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported power unit.");
            }
        }

        public static string GetSymbol(UnitConverterPowerUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerUnit.Microwatt:
                    return "µW";
                case UnitConverterPowerUnit.Milliwatt:
                    return "mW";
                case UnitConverterPowerUnit.Watt:
                    return "W";
                case UnitConverterPowerUnit.Kilowatt:
                    return "kW";
                case UnitConverterPowerUnit.Megawatt:
                    return "MW";
                case UnitConverterPowerUnit.Gigawatt:
                    return "GW";
                case UnitConverterPowerUnit.HorsepowerMechanical:
                    return "hp";
                case UnitConverterPowerUnit.HorsepowerMetric:
                    return "PS";
                case UnitConverterPowerUnit.HorsepowerElectrical:
                    return "hp(E)";
                case UnitConverterPowerUnit.HorsepowerBoiler:
                    return "hp(S)";
                case UnitConverterPowerUnit.BtuPerHour:
                    return "BTU/h";
                case UnitConverterPowerUnit.FootPoundPerSecond:
                    return "ft·lb/s";
                case UnitConverterPowerUnit.Picowatt:
                    return "pW";
                case UnitConverterPowerUnit.Nanowatt:
                    return "nW";
                case UnitConverterPowerUnit.Terawatt:
                    return "TW";
                case UnitConverterPowerUnit.Petawatt:
                    return "PW";
                case UnitConverterPowerUnit.ErgPerSecond:
                    return "erg/s";
                case UnitConverterPowerUnit.CaloriePerSecond:
                    return "cal/s";
                case UnitConverterPowerUnit.KilocaloriePerHour:
                    return "kcal/h";
                case UnitConverterPowerUnit.TonOfRefrigeration:
                    return "TR";
                case UnitConverterPowerUnit.VoltAmpere:
                    return "VA";
                case UnitConverterPowerUnit.KilovoltAmpere:
                    return "kVA";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPowerUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerUnit.Microwatt:
                    return "microwatt";
                case UnitConverterPowerUnit.Milliwatt:
                    return "milliwatt";
                case UnitConverterPowerUnit.Watt:
                    return "watt";
                case UnitConverterPowerUnit.Kilowatt:
                    return "kilowatt";
                case UnitConverterPowerUnit.Megawatt:
                    return "megawatt";
                case UnitConverterPowerUnit.Gigawatt:
                    return "gigawatt";
                case UnitConverterPowerUnit.HorsepowerMechanical:
                    return "mechanical horsepower";
                case UnitConverterPowerUnit.HorsepowerMetric:
                    return "metric horsepower";
                case UnitConverterPowerUnit.HorsepowerElectrical:
                    return "electrical horsepower";
                case UnitConverterPowerUnit.HorsepowerBoiler:
                    return "boiler horsepower";
                case UnitConverterPowerUnit.BtuPerHour:
                    return "BTU per hour";
                case UnitConverterPowerUnit.FootPoundPerSecond:
                    return "foot-pound per second";
                case UnitConverterPowerUnit.Picowatt:
                    return "Picowatt";
                case UnitConverterPowerUnit.Nanowatt:
                    return "Nanowatt";
                case UnitConverterPowerUnit.Terawatt:
                    return "Terawatt";
                case UnitConverterPowerUnit.Petawatt:
                    return "Petawatt";
                case UnitConverterPowerUnit.ErgPerSecond:
                    return "Erg Per Second";
                case UnitConverterPowerUnit.CaloriePerSecond:
                    return "Calorie Per Second";
                case UnitConverterPowerUnit.KilocaloriePerHour:
                    return "Kilocalorie Per Hour";
                case UnitConverterPowerUnit.TonOfRefrigeration:
                    return "Ton Of Refrigeration";
                case UnitConverterPowerUnit.VoltAmpere:
                    return "Volt Ampere";
                case UnitConverterPowerUnit.KilovoltAmpere:
                    return "Kilovolt Ampere";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPowerUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerUnit.Microwatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Milliwatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Watt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Kilowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Megawatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Gigawatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.HorsepowerMechanical:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerUnit.HorsepowerMetric:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.HorsepowerElectrical:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPowerUnit.HorsepowerBoiler:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterPowerUnit.BtuPerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerUnit.FootPoundPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerUnit.Picowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Nanowatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Terawatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.Petawatt:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.ErgPerSecond:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterPowerUnit.CaloriePerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.KilocaloriePerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerUnit.TonOfRefrigeration:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPowerUnit.VoltAmpere:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterPowerUnit.KilovoltAmpere:
                    return UnitConverterUnitSystem.Engineering;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPowerUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPowerUnit.Microwatt, UnitConverterPowerUnit.Milliwatt, UnitConverterPowerUnit.Watt, UnitConverterPowerUnit.Kilowatt, UnitConverterPowerUnit.Megawatt, UnitConverterPowerUnit.Gigawatt, UnitConverterPowerUnit.HorsepowerMetric, UnitConverterPowerUnit.Picowatt, UnitConverterPowerUnit.Nanowatt, UnitConverterPowerUnit.Terawatt, UnitConverterPowerUnit.Petawatt, UnitConverterPowerUnit.CaloriePerSecond, UnitConverterPowerUnit.KilocaloriePerHour };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPowerUnit.HorsepowerMechanical, UnitConverterPowerUnit.BtuPerHour, UnitConverterPowerUnit.FootPoundPerSecond };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterPowerUnit.HorsepowerElectrical, UnitConverterPowerUnit.TonOfRefrigeration, UnitConverterPowerUnit.VoltAmpere, UnitConverterPowerUnit.KilovoltAmpere };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterPowerUnit.HorsepowerBoiler };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterPowerUnit.ErgPerSecond };
                default:
                    return new[] { UnitConverterPowerUnit.Microwatt, UnitConverterPowerUnit.Milliwatt, UnitConverterPowerUnit.Watt, UnitConverterPowerUnit.Kilowatt, UnitConverterPowerUnit.Megawatt, UnitConverterPowerUnit.Gigawatt, UnitConverterPowerUnit.HorsepowerMechanical, UnitConverterPowerUnit.HorsepowerMetric, UnitConverterPowerUnit.HorsepowerElectrical, UnitConverterPowerUnit.HorsepowerBoiler, UnitConverterPowerUnit.BtuPerHour, UnitConverterPowerUnit.FootPoundPerSecond, UnitConverterPowerUnit.Picowatt, UnitConverterPowerUnit.Nanowatt, UnitConverterPowerUnit.Terawatt, UnitConverterPowerUnit.Petawatt, UnitConverterPowerUnit.ErgPerSecond, UnitConverterPowerUnit.CaloriePerSecond, UnitConverterPowerUnit.KilocaloriePerHour, UnitConverterPowerUnit.TonOfRefrigeration, UnitConverterPowerUnit.VoltAmpere, UnitConverterPowerUnit.KilovoltAmpere };
            }
        }
    }
}
