namespace UnitTools.Energy
{
    using UnitTools.Energy.Scientific;
    using UnitTools.Energy.Metric;
    using UnitTools.Energy.Imperial;
    using UnitTools.Energy.ImperialUS;
    using UnitTools.Energy.Engineering;
    using UnitTools.Energy.ImperialUK;

    public enum UnitToolsEnergyUnit
    {
        ElectronVolt = 0,
        Joule = 1,
        Kilojoule = 2,
        Megajoule = 3,
        WattHour = 4,
        KilowattHour = 5,
        Calorie = 6,
        Kilocalorie = 7,
        BtuInternational = 8,
        ThermUS = 9,
        FootPound = 10,
        Erg = 11,
        TonTNT = 12,
        Nanojoule = 13,
        Microjoule = 14,
        Millijoule = 15,
        Gigajoule = 16,
        Terajoule = 17,
        WattSecond = 18,
        KiloelectronVolt = 19,
        MegaelectronVolt = 20,
        GigaelectronVolt = 21,
        TeraelectronVolt = 22,
        HorsepowerHour = 23,
        KilogramForceMeter = 24,
        Quad = 25,
        ThermEC = 26,
        ThermUK = 27,
    }

    public static class UnitToolsEnergy
    {
        public static double Convert(double value, UnitToolsEnergyUnit from, UnitToolsEnergyUnit to)
        {
            double baseValue = ToJoule(value, from);
            return FromJoule(baseValue, to);
        }

        public static double ToJoule(double value, UnitToolsEnergyUnit from)
        {
            switch (from)
            {
                case UnitToolsEnergyUnit.ElectronVolt:
                    return UnitToolsScientificEnergy.ElectronVoltToJoule(value);
                case UnitToolsEnergyUnit.Joule:
                    return UnitToolsMetricEnergy.JouleToJoule(value);
                case UnitToolsEnergyUnit.Kilojoule:
                    return UnitToolsMetricEnergy.KilojouleToJoule(value);
                case UnitToolsEnergyUnit.Megajoule:
                    return UnitToolsMetricEnergy.MegajouleToJoule(value);
                case UnitToolsEnergyUnit.WattHour:
                    return UnitToolsMetricEnergy.WattHourToJoule(value);
                case UnitToolsEnergyUnit.KilowattHour:
                    return UnitToolsMetricEnergy.KilowattHourToJoule(value);
                case UnitToolsEnergyUnit.Calorie:
                    return UnitToolsMetricEnergy.CalorieToJoule(value);
                case UnitToolsEnergyUnit.Kilocalorie:
                    return UnitToolsMetricEnergy.KilocalorieToJoule(value);
                case UnitToolsEnergyUnit.BtuInternational:
                    return UnitToolsImperialEnergy.BtuInternationalToJoule(value);
                case UnitToolsEnergyUnit.ThermUS:
                    return UnitToolsImperialUSEnergy.ThermUSToJoule(value);
                case UnitToolsEnergyUnit.FootPound:
                    return UnitToolsImperialEnergy.FootPoundToJoule(value);
                case UnitToolsEnergyUnit.Erg:
                    return UnitToolsScientificEnergy.ErgToJoule(value);
                case UnitToolsEnergyUnit.TonTNT:
                    return UnitToolsScientificEnergy.TonTNTToJoule(value);
                case UnitToolsEnergyUnit.Nanojoule:
                    return UnitToolsMetricEnergy.NanojouleToJoule(value);
                case UnitToolsEnergyUnit.Microjoule:
                    return UnitToolsMetricEnergy.MicrojouleToJoule(value);
                case UnitToolsEnergyUnit.Millijoule:
                    return UnitToolsMetricEnergy.MillijouleToJoule(value);
                case UnitToolsEnergyUnit.Gigajoule:
                    return UnitToolsMetricEnergy.GigajouleToJoule(value);
                case UnitToolsEnergyUnit.Terajoule:
                    return UnitToolsMetricEnergy.TerajouleToJoule(value);
                case UnitToolsEnergyUnit.WattSecond:
                    return UnitToolsMetricEnergy.WattSecondToJoule(value);
                case UnitToolsEnergyUnit.KiloelectronVolt:
                    return UnitToolsScientificEnergy.KiloelectronVoltToJoule(value);
                case UnitToolsEnergyUnit.MegaelectronVolt:
                    return UnitToolsScientificEnergy.MegaelectronVoltToJoule(value);
                case UnitToolsEnergyUnit.GigaelectronVolt:
                    return UnitToolsScientificEnergy.GigaelectronVoltToJoule(value);
                case UnitToolsEnergyUnit.TeraelectronVolt:
                    return UnitToolsScientificEnergy.TeraelectronVoltToJoule(value);
                case UnitToolsEnergyUnit.HorsepowerHour:
                    return UnitToolsImperialEnergy.HorsepowerHourToJoule(value);
                case UnitToolsEnergyUnit.KilogramForceMeter:
                    return UnitToolsEngineeringEnergy.KilogramForceMeterToJoule(value);
                case UnitToolsEnergyUnit.Quad:
                    return UnitToolsImperialUSEnergy.QuadToJoule(value);
                case UnitToolsEnergyUnit.ThermEC:
                    return UnitToolsImperialEnergy.ThermECToJoule(value);
                case UnitToolsEnergyUnit.ThermUK:
                    return UnitToolsImperialUKEnergy.ThermUKToJoule(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported energy unit.");
            }
        }

        public static double FromJoule(double baseValue, UnitToolsEnergyUnit to)
        {
            switch (to)
            {
                case UnitToolsEnergyUnit.ElectronVolt:
                    return UnitToolsScientificEnergy.JouleToElectronVolt(baseValue);
                case UnitToolsEnergyUnit.Joule:
                    return UnitToolsMetricEnergy.JouleToJoule(baseValue);
                case UnitToolsEnergyUnit.Kilojoule:
                    return UnitToolsMetricEnergy.JouleToKilojoule(baseValue);
                case UnitToolsEnergyUnit.Megajoule:
                    return UnitToolsMetricEnergy.JouleToMegajoule(baseValue);
                case UnitToolsEnergyUnit.WattHour:
                    return UnitToolsMetricEnergy.JouleToWattHour(baseValue);
                case UnitToolsEnergyUnit.KilowattHour:
                    return UnitToolsMetricEnergy.JouleToKilowattHour(baseValue);
                case UnitToolsEnergyUnit.Calorie:
                    return UnitToolsMetricEnergy.JouleToCalorie(baseValue);
                case UnitToolsEnergyUnit.Kilocalorie:
                    return UnitToolsMetricEnergy.JouleToKilocalorie(baseValue);
                case UnitToolsEnergyUnit.BtuInternational:
                    return UnitToolsImperialEnergy.JouleToBtuInternational(baseValue);
                case UnitToolsEnergyUnit.ThermUS:
                    return UnitToolsImperialUSEnergy.JouleToThermUS(baseValue);
                case UnitToolsEnergyUnit.FootPound:
                    return UnitToolsImperialEnergy.JouleToFootPound(baseValue);
                case UnitToolsEnergyUnit.Erg:
                    return UnitToolsScientificEnergy.JouleToErg(baseValue);
                case UnitToolsEnergyUnit.TonTNT:
                    return UnitToolsScientificEnergy.JouleToTonTNT(baseValue);
                case UnitToolsEnergyUnit.Nanojoule:
                    return UnitToolsMetricEnergy.JouleToNanojoule(baseValue);
                case UnitToolsEnergyUnit.Microjoule:
                    return UnitToolsMetricEnergy.JouleToMicrojoule(baseValue);
                case UnitToolsEnergyUnit.Millijoule:
                    return UnitToolsMetricEnergy.JouleToMillijoule(baseValue);
                case UnitToolsEnergyUnit.Gigajoule:
                    return UnitToolsMetricEnergy.JouleToGigajoule(baseValue);
                case UnitToolsEnergyUnit.Terajoule:
                    return UnitToolsMetricEnergy.JouleToTerajoule(baseValue);
                case UnitToolsEnergyUnit.WattSecond:
                    return UnitToolsMetricEnergy.JouleToWattSecond(baseValue);
                case UnitToolsEnergyUnit.KiloelectronVolt:
                    return UnitToolsScientificEnergy.JouleToKiloelectronVolt(baseValue);
                case UnitToolsEnergyUnit.MegaelectronVolt:
                    return UnitToolsScientificEnergy.JouleToMegaelectronVolt(baseValue);
                case UnitToolsEnergyUnit.GigaelectronVolt:
                    return UnitToolsScientificEnergy.JouleToGigaelectronVolt(baseValue);
                case UnitToolsEnergyUnit.TeraelectronVolt:
                    return UnitToolsScientificEnergy.JouleToTeraelectronVolt(baseValue);
                case UnitToolsEnergyUnit.HorsepowerHour:
                    return UnitToolsImperialEnergy.JouleToHorsepowerHour(baseValue);
                case UnitToolsEnergyUnit.KilogramForceMeter:
                    return UnitToolsEngineeringEnergy.JouleToKilogramForceMeter(baseValue);
                case UnitToolsEnergyUnit.Quad:
                    return UnitToolsImperialUSEnergy.JouleToQuad(baseValue);
                case UnitToolsEnergyUnit.ThermEC:
                    return UnitToolsImperialEnergy.JouleToThermEC(baseValue);
                case UnitToolsEnergyUnit.ThermUK:
                    return UnitToolsImperialUKEnergy.JouleToThermUK(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported energy unit.");
            }
        }

        public static string GetSymbol(UnitToolsEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyUnit.ElectronVolt:
                    return "eV";
                case UnitToolsEnergyUnit.Joule:
                    return "J";
                case UnitToolsEnergyUnit.Kilojoule:
                    return "kJ";
                case UnitToolsEnergyUnit.Megajoule:
                    return "MJ";
                case UnitToolsEnergyUnit.WattHour:
                    return "Wh";
                case UnitToolsEnergyUnit.KilowattHour:
                    return "kWh";
                case UnitToolsEnergyUnit.Calorie:
                    return "cal";
                case UnitToolsEnergyUnit.Kilocalorie:
                    return "kcal";
                case UnitToolsEnergyUnit.BtuInternational:
                    return "BTU";
                case UnitToolsEnergyUnit.ThermUS:
                    return "therm US";
                case UnitToolsEnergyUnit.FootPound:
                    return "ft·lb";
                case UnitToolsEnergyUnit.Erg:
                    return "erg";
                case UnitToolsEnergyUnit.TonTNT:
                    return "ton TNT";
                case UnitToolsEnergyUnit.Nanojoule:
                    return "nJ";
                case UnitToolsEnergyUnit.Microjoule:
                    return "µJ";
                case UnitToolsEnergyUnit.Millijoule:
                    return "mJ";
                case UnitToolsEnergyUnit.Gigajoule:
                    return "GJ";
                case UnitToolsEnergyUnit.Terajoule:
                    return "TJ";
                case UnitToolsEnergyUnit.WattSecond:
                    return "W·s";
                case UnitToolsEnergyUnit.KiloelectronVolt:
                    return "keV";
                case UnitToolsEnergyUnit.MegaelectronVolt:
                    return "MeV";
                case UnitToolsEnergyUnit.GigaelectronVolt:
                    return "GeV";
                case UnitToolsEnergyUnit.TeraelectronVolt:
                    return "TeV";
                case UnitToolsEnergyUnit.HorsepowerHour:
                    return "hp·h";
                case UnitToolsEnergyUnit.KilogramForceMeter:
                    return "kgf·m";
                case UnitToolsEnergyUnit.Quad:
                    return "quad";
                case UnitToolsEnergyUnit.ThermEC:
                    return "therm EC";
                case UnitToolsEnergyUnit.ThermUK:
                    return "therm UK";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyUnit.ElectronVolt:
                    return "electronvolt";
                case UnitToolsEnergyUnit.Joule:
                    return "joule";
                case UnitToolsEnergyUnit.Kilojoule:
                    return "kilojoule";
                case UnitToolsEnergyUnit.Megajoule:
                    return "megajoule";
                case UnitToolsEnergyUnit.WattHour:
                    return "watt-hour";
                case UnitToolsEnergyUnit.KilowattHour:
                    return "kilowatt-hour";
                case UnitToolsEnergyUnit.Calorie:
                    return "calorie";
                case UnitToolsEnergyUnit.Kilocalorie:
                    return "kilocalorie";
                case UnitToolsEnergyUnit.BtuInternational:
                    return "BTU International";
                case UnitToolsEnergyUnit.ThermUS:
                    return "US therm";
                case UnitToolsEnergyUnit.FootPound:
                    return "foot-pound";
                case UnitToolsEnergyUnit.Erg:
                    return "erg";
                case UnitToolsEnergyUnit.TonTNT:
                    return "ton TNT";
                case UnitToolsEnergyUnit.Nanojoule:
                    return "Nanojoule";
                case UnitToolsEnergyUnit.Microjoule:
                    return "Microjoule";
                case UnitToolsEnergyUnit.Millijoule:
                    return "Millijoule";
                case UnitToolsEnergyUnit.Gigajoule:
                    return "Gigajoule";
                case UnitToolsEnergyUnit.Terajoule:
                    return "Terajoule";
                case UnitToolsEnergyUnit.WattSecond:
                    return "Watt Second";
                case UnitToolsEnergyUnit.KiloelectronVolt:
                    return "Kiloelectron Volt";
                case UnitToolsEnergyUnit.MegaelectronVolt:
                    return "Megaelectron Volt";
                case UnitToolsEnergyUnit.GigaelectronVolt:
                    return "Gigaelectron Volt";
                case UnitToolsEnergyUnit.TeraelectronVolt:
                    return "Teraelectron Volt";
                case UnitToolsEnergyUnit.HorsepowerHour:
                    return "Horsepower Hour";
                case UnitToolsEnergyUnit.KilogramForceMeter:
                    return "Kilogram Force Meter";
                case UnitToolsEnergyUnit.Quad:
                    return "Quad";
                case UnitToolsEnergyUnit.ThermEC:
                    return "Therm EC";
                case UnitToolsEnergyUnit.ThermUK:
                    return "Therm UK";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyUnit.ElectronVolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.Joule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Kilojoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Megajoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.WattHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.KilowattHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Calorie:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Kilocalorie:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.BtuInternational:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyUnit.ThermUS:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsEnergyUnit.FootPound:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyUnit.Erg:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.TonTNT:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.Nanojoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Microjoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Millijoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Gigajoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.Terajoule:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.WattSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyUnit.KiloelectronVolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.MegaelectronVolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.GigaelectronVolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.TeraelectronVolt:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyUnit.HorsepowerHour:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyUnit.KilogramForceMeter:
                    return UnitToolsUnitSystem.Engineering;
                case UnitToolsEnergyUnit.Quad:
                    return UnitToolsUnitSystem.ImperialUS;
                case UnitToolsEnergyUnit.ThermEC:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyUnit.ThermUK:
                    return UnitToolsUnitSystem.ImperialUK;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsEnergyUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsEnergyUnit.ElectronVolt, UnitToolsEnergyUnit.Erg, UnitToolsEnergyUnit.TonTNT, UnitToolsEnergyUnit.KiloelectronVolt, UnitToolsEnergyUnit.MegaelectronVolt, UnitToolsEnergyUnit.GigaelectronVolt, UnitToolsEnergyUnit.TeraelectronVolt };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsEnergyUnit.Joule, UnitToolsEnergyUnit.Kilojoule, UnitToolsEnergyUnit.Megajoule, UnitToolsEnergyUnit.WattHour, UnitToolsEnergyUnit.KilowattHour, UnitToolsEnergyUnit.Calorie, UnitToolsEnergyUnit.Kilocalorie, UnitToolsEnergyUnit.Nanojoule, UnitToolsEnergyUnit.Microjoule, UnitToolsEnergyUnit.Millijoule, UnitToolsEnergyUnit.Gigajoule, UnitToolsEnergyUnit.Terajoule, UnitToolsEnergyUnit.WattSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsEnergyUnit.BtuInternational, UnitToolsEnergyUnit.FootPound, UnitToolsEnergyUnit.HorsepowerHour, UnitToolsEnergyUnit.ThermEC };
                case UnitToolsUnitSystem.ImperialUS:
                    return new[] { UnitToolsEnergyUnit.ThermUS, UnitToolsEnergyUnit.Quad };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsEnergyUnit.KilogramForceMeter };
                case UnitToolsUnitSystem.ImperialUK:
                    return new[] { UnitToolsEnergyUnit.ThermUK };
                default:
                    return new[] { UnitToolsEnergyUnit.ElectronVolt, UnitToolsEnergyUnit.Joule, UnitToolsEnergyUnit.Kilojoule, UnitToolsEnergyUnit.Megajoule, UnitToolsEnergyUnit.WattHour, UnitToolsEnergyUnit.KilowattHour, UnitToolsEnergyUnit.Calorie, UnitToolsEnergyUnit.Kilocalorie, UnitToolsEnergyUnit.BtuInternational, UnitToolsEnergyUnit.ThermUS, UnitToolsEnergyUnit.FootPound, UnitToolsEnergyUnit.Erg, UnitToolsEnergyUnit.TonTNT, UnitToolsEnergyUnit.Nanojoule, UnitToolsEnergyUnit.Microjoule, UnitToolsEnergyUnit.Millijoule, UnitToolsEnergyUnit.Gigajoule, UnitToolsEnergyUnit.Terajoule, UnitToolsEnergyUnit.WattSecond, UnitToolsEnergyUnit.KiloelectronVolt, UnitToolsEnergyUnit.MegaelectronVolt, UnitToolsEnergyUnit.GigaelectronVolt, UnitToolsEnergyUnit.TeraelectronVolt, UnitToolsEnergyUnit.HorsepowerHour, UnitToolsEnergyUnit.KilogramForceMeter, UnitToolsEnergyUnit.Quad, UnitToolsEnergyUnit.ThermEC, UnitToolsEnergyUnit.ThermUK };
            }
        }
    }
}
