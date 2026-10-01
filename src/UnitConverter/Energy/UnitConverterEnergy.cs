namespace UnitConverter.Energy
{
    using UnitConverter.Energy.Scientific;
    using UnitConverter.Energy.Metric;
    using UnitConverter.Energy.Imperial;
    using UnitConverter.Energy.ImperialUS;
    using UnitConverter.Energy.Engineering;
    using UnitConverter.Energy.ImperialUK;

    public enum UnitConverterEnergyUnit
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

    public static class UnitConverterEnergy
    {
        public static double Convert(double value, UnitConverterEnergyUnit from, UnitConverterEnergyUnit to)
        {
            double baseValue = ToJoule(value, from);
            return FromJoule(baseValue, to);
        }

        public static double ToJoule(double value, UnitConverterEnergyUnit from)
        {
            switch (from)
            {
                case UnitConverterEnergyUnit.ElectronVolt:
                    return UnitConverterScientificEnergy.ElectronVoltToJoule(value);
                case UnitConverterEnergyUnit.Joule:
                    return UnitConverterMetricEnergy.JouleToJoule(value);
                case UnitConverterEnergyUnit.Kilojoule:
                    return UnitConverterMetricEnergy.KilojouleToJoule(value);
                case UnitConverterEnergyUnit.Megajoule:
                    return UnitConverterMetricEnergy.MegajouleToJoule(value);
                case UnitConverterEnergyUnit.WattHour:
                    return UnitConverterMetricEnergy.WattHourToJoule(value);
                case UnitConverterEnergyUnit.KilowattHour:
                    return UnitConverterMetricEnergy.KilowattHourToJoule(value);
                case UnitConverterEnergyUnit.Calorie:
                    return UnitConverterMetricEnergy.CalorieToJoule(value);
                case UnitConverterEnergyUnit.Kilocalorie:
                    return UnitConverterMetricEnergy.KilocalorieToJoule(value);
                case UnitConverterEnergyUnit.BtuInternational:
                    return UnitConverterImperialEnergy.BtuInternationalToJoule(value);
                case UnitConverterEnergyUnit.ThermUS:
                    return UnitConverterImperialUSEnergy.ThermUSToJoule(value);
                case UnitConverterEnergyUnit.FootPound:
                    return UnitConverterImperialEnergy.FootPoundToJoule(value);
                case UnitConverterEnergyUnit.Erg:
                    return UnitConverterScientificEnergy.ErgToJoule(value);
                case UnitConverterEnergyUnit.TonTNT:
                    return UnitConverterScientificEnergy.TonTNTToJoule(value);
                case UnitConverterEnergyUnit.Nanojoule:
                    return UnitConverterMetricEnergy.NanojouleToJoule(value);
                case UnitConverterEnergyUnit.Microjoule:
                    return UnitConverterMetricEnergy.MicrojouleToJoule(value);
                case UnitConverterEnergyUnit.Millijoule:
                    return UnitConverterMetricEnergy.MillijouleToJoule(value);
                case UnitConverterEnergyUnit.Gigajoule:
                    return UnitConverterMetricEnergy.GigajouleToJoule(value);
                case UnitConverterEnergyUnit.Terajoule:
                    return UnitConverterMetricEnergy.TerajouleToJoule(value);
                case UnitConverterEnergyUnit.WattSecond:
                    return UnitConverterMetricEnergy.WattSecondToJoule(value);
                case UnitConverterEnergyUnit.KiloelectronVolt:
                    return UnitConverterScientificEnergy.KiloelectronVoltToJoule(value);
                case UnitConverterEnergyUnit.MegaelectronVolt:
                    return UnitConverterScientificEnergy.MegaelectronVoltToJoule(value);
                case UnitConverterEnergyUnit.GigaelectronVolt:
                    return UnitConverterScientificEnergy.GigaelectronVoltToJoule(value);
                case UnitConverterEnergyUnit.TeraelectronVolt:
                    return UnitConverterScientificEnergy.TeraelectronVoltToJoule(value);
                case UnitConverterEnergyUnit.HorsepowerHour:
                    return UnitConverterImperialEnergy.HorsepowerHourToJoule(value);
                case UnitConverterEnergyUnit.KilogramForceMeter:
                    return UnitConverterEngineeringEnergy.KilogramForceMeterToJoule(value);
                case UnitConverterEnergyUnit.Quad:
                    return UnitConverterImperialUSEnergy.QuadToJoule(value);
                case UnitConverterEnergyUnit.ThermEC:
                    return UnitConverterImperialEnergy.ThermECToJoule(value);
                case UnitConverterEnergyUnit.ThermUK:
                    return UnitConverterImperialUKEnergy.ThermUKToJoule(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported energy unit.");
            }
        }

        public static double FromJoule(double baseValue, UnitConverterEnergyUnit to)
        {
            switch (to)
            {
                case UnitConverterEnergyUnit.ElectronVolt:
                    return UnitConverterScientificEnergy.JouleToElectronVolt(baseValue);
                case UnitConverterEnergyUnit.Joule:
                    return UnitConverterMetricEnergy.JouleToJoule(baseValue);
                case UnitConverterEnergyUnit.Kilojoule:
                    return UnitConverterMetricEnergy.JouleToKilojoule(baseValue);
                case UnitConverterEnergyUnit.Megajoule:
                    return UnitConverterMetricEnergy.JouleToMegajoule(baseValue);
                case UnitConverterEnergyUnit.WattHour:
                    return UnitConverterMetricEnergy.JouleToWattHour(baseValue);
                case UnitConverterEnergyUnit.KilowattHour:
                    return UnitConverterMetricEnergy.JouleToKilowattHour(baseValue);
                case UnitConverterEnergyUnit.Calorie:
                    return UnitConverterMetricEnergy.JouleToCalorie(baseValue);
                case UnitConverterEnergyUnit.Kilocalorie:
                    return UnitConverterMetricEnergy.JouleToKilocalorie(baseValue);
                case UnitConverterEnergyUnit.BtuInternational:
                    return UnitConverterImperialEnergy.JouleToBtuInternational(baseValue);
                case UnitConverterEnergyUnit.ThermUS:
                    return UnitConverterImperialUSEnergy.JouleToThermUS(baseValue);
                case UnitConverterEnergyUnit.FootPound:
                    return UnitConverterImperialEnergy.JouleToFootPound(baseValue);
                case UnitConverterEnergyUnit.Erg:
                    return UnitConverterScientificEnergy.JouleToErg(baseValue);
                case UnitConverterEnergyUnit.TonTNT:
                    return UnitConverterScientificEnergy.JouleToTonTNT(baseValue);
                case UnitConverterEnergyUnit.Nanojoule:
                    return UnitConverterMetricEnergy.JouleToNanojoule(baseValue);
                case UnitConverterEnergyUnit.Microjoule:
                    return UnitConverterMetricEnergy.JouleToMicrojoule(baseValue);
                case UnitConverterEnergyUnit.Millijoule:
                    return UnitConverterMetricEnergy.JouleToMillijoule(baseValue);
                case UnitConverterEnergyUnit.Gigajoule:
                    return UnitConverterMetricEnergy.JouleToGigajoule(baseValue);
                case UnitConverterEnergyUnit.Terajoule:
                    return UnitConverterMetricEnergy.JouleToTerajoule(baseValue);
                case UnitConverterEnergyUnit.WattSecond:
                    return UnitConverterMetricEnergy.JouleToWattSecond(baseValue);
                case UnitConverterEnergyUnit.KiloelectronVolt:
                    return UnitConverterScientificEnergy.JouleToKiloelectronVolt(baseValue);
                case UnitConverterEnergyUnit.MegaelectronVolt:
                    return UnitConverterScientificEnergy.JouleToMegaelectronVolt(baseValue);
                case UnitConverterEnergyUnit.GigaelectronVolt:
                    return UnitConverterScientificEnergy.JouleToGigaelectronVolt(baseValue);
                case UnitConverterEnergyUnit.TeraelectronVolt:
                    return UnitConverterScientificEnergy.JouleToTeraelectronVolt(baseValue);
                case UnitConverterEnergyUnit.HorsepowerHour:
                    return UnitConverterImperialEnergy.JouleToHorsepowerHour(baseValue);
                case UnitConverterEnergyUnit.KilogramForceMeter:
                    return UnitConverterEngineeringEnergy.JouleToKilogramForceMeter(baseValue);
                case UnitConverterEnergyUnit.Quad:
                    return UnitConverterImperialUSEnergy.JouleToQuad(baseValue);
                case UnitConverterEnergyUnit.ThermEC:
                    return UnitConverterImperialEnergy.JouleToThermEC(baseValue);
                case UnitConverterEnergyUnit.ThermUK:
                    return UnitConverterImperialUKEnergy.JouleToThermUK(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported energy unit.");
            }
        }

        public static string GetSymbol(UnitConverterEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyUnit.ElectronVolt:
                    return "eV";
                case UnitConverterEnergyUnit.Joule:
                    return "J";
                case UnitConverterEnergyUnit.Kilojoule:
                    return "kJ";
                case UnitConverterEnergyUnit.Megajoule:
                    return "MJ";
                case UnitConverterEnergyUnit.WattHour:
                    return "Wh";
                case UnitConverterEnergyUnit.KilowattHour:
                    return "kWh";
                case UnitConverterEnergyUnit.Calorie:
                    return "cal";
                case UnitConverterEnergyUnit.Kilocalorie:
                    return "kcal";
                case UnitConverterEnergyUnit.BtuInternational:
                    return "BTU";
                case UnitConverterEnergyUnit.ThermUS:
                    return "therm US";
                case UnitConverterEnergyUnit.FootPound:
                    return "ft·lb";
                case UnitConverterEnergyUnit.Erg:
                    return "erg";
                case UnitConverterEnergyUnit.TonTNT:
                    return "ton TNT";
                case UnitConverterEnergyUnit.Nanojoule:
                    return "nJ";
                case UnitConverterEnergyUnit.Microjoule:
                    return "µJ";
                case UnitConverterEnergyUnit.Millijoule:
                    return "mJ";
                case UnitConverterEnergyUnit.Gigajoule:
                    return "GJ";
                case UnitConverterEnergyUnit.Terajoule:
                    return "TJ";
                case UnitConverterEnergyUnit.WattSecond:
                    return "W·s";
                case UnitConverterEnergyUnit.KiloelectronVolt:
                    return "keV";
                case UnitConverterEnergyUnit.MegaelectronVolt:
                    return "MeV";
                case UnitConverterEnergyUnit.GigaelectronVolt:
                    return "GeV";
                case UnitConverterEnergyUnit.TeraelectronVolt:
                    return "TeV";
                case UnitConverterEnergyUnit.HorsepowerHour:
                    return "hp·h";
                case UnitConverterEnergyUnit.KilogramForceMeter:
                    return "kgf·m";
                case UnitConverterEnergyUnit.Quad:
                    return "quad";
                case UnitConverterEnergyUnit.ThermEC:
                    return "therm EC";
                case UnitConverterEnergyUnit.ThermUK:
                    return "therm UK";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyUnit.ElectronVolt:
                    return "electronvolt";
                case UnitConverterEnergyUnit.Joule:
                    return "joule";
                case UnitConverterEnergyUnit.Kilojoule:
                    return "kilojoule";
                case UnitConverterEnergyUnit.Megajoule:
                    return "megajoule";
                case UnitConverterEnergyUnit.WattHour:
                    return "watt-hour";
                case UnitConverterEnergyUnit.KilowattHour:
                    return "kilowatt-hour";
                case UnitConverterEnergyUnit.Calorie:
                    return "calorie";
                case UnitConverterEnergyUnit.Kilocalorie:
                    return "kilocalorie";
                case UnitConverterEnergyUnit.BtuInternational:
                    return "BTU International";
                case UnitConverterEnergyUnit.ThermUS:
                    return "US therm";
                case UnitConverterEnergyUnit.FootPound:
                    return "foot-pound";
                case UnitConverterEnergyUnit.Erg:
                    return "erg";
                case UnitConverterEnergyUnit.TonTNT:
                    return "ton TNT";
                case UnitConverterEnergyUnit.Nanojoule:
                    return "Nanojoule";
                case UnitConverterEnergyUnit.Microjoule:
                    return "Microjoule";
                case UnitConverterEnergyUnit.Millijoule:
                    return "Millijoule";
                case UnitConverterEnergyUnit.Gigajoule:
                    return "Gigajoule";
                case UnitConverterEnergyUnit.Terajoule:
                    return "Terajoule";
                case UnitConverterEnergyUnit.WattSecond:
                    return "Watt Second";
                case UnitConverterEnergyUnit.KiloelectronVolt:
                    return "Kiloelectron Volt";
                case UnitConverterEnergyUnit.MegaelectronVolt:
                    return "Megaelectron Volt";
                case UnitConverterEnergyUnit.GigaelectronVolt:
                    return "Gigaelectron Volt";
                case UnitConverterEnergyUnit.TeraelectronVolt:
                    return "Teraelectron Volt";
                case UnitConverterEnergyUnit.HorsepowerHour:
                    return "Horsepower Hour";
                case UnitConverterEnergyUnit.KilogramForceMeter:
                    return "Kilogram Force Meter";
                case UnitConverterEnergyUnit.Quad:
                    return "Quad";
                case UnitConverterEnergyUnit.ThermEC:
                    return "Therm EC";
                case UnitConverterEnergyUnit.ThermUK:
                    return "Therm UK";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterEnergyUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyUnit.ElectronVolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.Joule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Kilojoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Megajoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.WattHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.KilowattHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Calorie:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Kilocalorie:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.BtuInternational:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyUnit.ThermUS:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterEnergyUnit.FootPound:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyUnit.Erg:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.TonTNT:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.Nanojoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Microjoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Millijoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Gigajoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.Terajoule:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.WattSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyUnit.KiloelectronVolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.MegaelectronVolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.GigaelectronVolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.TeraelectronVolt:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyUnit.HorsepowerHour:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyUnit.KilogramForceMeter:
                    return UnitConverterUnitSystem.Engineering;
                case UnitConverterEnergyUnit.Quad:
                    return UnitConverterUnitSystem.ImperialUS;
                case UnitConverterEnergyUnit.ThermEC:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyUnit.ThermUK:
                    return UnitConverterUnitSystem.ImperialUK;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterEnergyUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterEnergyUnit.ElectronVolt, UnitConverterEnergyUnit.Erg, UnitConverterEnergyUnit.TonTNT, UnitConverterEnergyUnit.KiloelectronVolt, UnitConverterEnergyUnit.MegaelectronVolt, UnitConverterEnergyUnit.GigaelectronVolt, UnitConverterEnergyUnit.TeraelectronVolt };
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterEnergyUnit.Joule, UnitConverterEnergyUnit.Kilojoule, UnitConverterEnergyUnit.Megajoule, UnitConverterEnergyUnit.WattHour, UnitConverterEnergyUnit.KilowattHour, UnitConverterEnergyUnit.Calorie, UnitConverterEnergyUnit.Kilocalorie, UnitConverterEnergyUnit.Nanojoule, UnitConverterEnergyUnit.Microjoule, UnitConverterEnergyUnit.Millijoule, UnitConverterEnergyUnit.Gigajoule, UnitConverterEnergyUnit.Terajoule, UnitConverterEnergyUnit.WattSecond };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterEnergyUnit.BtuInternational, UnitConverterEnergyUnit.FootPound, UnitConverterEnergyUnit.HorsepowerHour, UnitConverterEnergyUnit.ThermEC };
                case UnitConverterUnitSystem.ImperialUS:
                    return new[] { UnitConverterEnergyUnit.ThermUS, UnitConverterEnergyUnit.Quad };
                case UnitConverterUnitSystem.Engineering:
                    return new[] { UnitConverterEnergyUnit.KilogramForceMeter };
                case UnitConverterUnitSystem.ImperialUK:
                    return new[] { UnitConverterEnergyUnit.ThermUK };
                default:
                    return new[] { UnitConverterEnergyUnit.ElectronVolt, UnitConverterEnergyUnit.Joule, UnitConverterEnergyUnit.Kilojoule, UnitConverterEnergyUnit.Megajoule, UnitConverterEnergyUnit.WattHour, UnitConverterEnergyUnit.KilowattHour, UnitConverterEnergyUnit.Calorie, UnitConverterEnergyUnit.Kilocalorie, UnitConverterEnergyUnit.BtuInternational, UnitConverterEnergyUnit.ThermUS, UnitConverterEnergyUnit.FootPound, UnitConverterEnergyUnit.Erg, UnitConverterEnergyUnit.TonTNT, UnitConverterEnergyUnit.Nanojoule, UnitConverterEnergyUnit.Microjoule, UnitConverterEnergyUnit.Millijoule, UnitConverterEnergyUnit.Gigajoule, UnitConverterEnergyUnit.Terajoule, UnitConverterEnergyUnit.WattSecond, UnitConverterEnergyUnit.KiloelectronVolt, UnitConverterEnergyUnit.MegaelectronVolt, UnitConverterEnergyUnit.GigaelectronVolt, UnitConverterEnergyUnit.TeraelectronVolt, UnitConverterEnergyUnit.HorsepowerHour, UnitConverterEnergyUnit.KilogramForceMeter, UnitConverterEnergyUnit.Quad, UnitConverterEnergyUnit.ThermEC, UnitConverterEnergyUnit.ThermUK };
            }
        }
    }
}
