namespace UnitConverter.EnergyDensity
{
    using UnitConverter.EnergyDensity.Metric;
    using UnitConverter.EnergyDensity.Imperial;
    using UnitConverter.EnergyDensity.Scientific;

    public enum UnitConverterEnergyDensityUnit
    {
        JoulePerCubicMeter = 0,
        KilojoulePerCubicMeter = 1,
        MegajoulePerCubicMeter = 2,
        JoulePerLiter = 3,
        WattHourPerLiter = 4,
        BtuPerCubicFoot = 5,
        ElectronVoltPerCubicNanometer = 6,
        MegajoulePerLiter = 7,
        KilowattHourPerLiter = 8,
        CaloriePerLiter = 9,
        KilocaloriePerLiter = 10,
        FootPoundPerCubicFoot = 11,
        ThermPerCubicFoot = 12,
    }

    public static class UnitConverterEnergyDensity
    {
        public static double Convert(double value, UnitConverterEnergyDensityUnit from, UnitConverterEnergyDensityUnit to)
        {
            double baseValue = ToJoulePerCubicMeter(value, from);
            return FromJoulePerCubicMeter(baseValue, to);
        }

        public static double ToJoulePerCubicMeter(double value, UnitConverterEnergyDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.KilojoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.MegajoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.JoulePerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.WattHourPerLiter:
                    return UnitConverterMetricEnergyDensity.WattHourPerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.BtuPerCubicFootToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitConverterScientificEnergyDensity.ElectronVoltPerCubicNanometerToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.MegajoulePerLiter:
                    return UnitConverterMetricEnergyDensity.MegajoulePerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitConverterMetricEnergyDensity.KilowattHourPerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.CaloriePerLiter:
                    return UnitConverterMetricEnergyDensity.CaloriePerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitConverterMetricEnergyDensity.KilocaloriePerLiterToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.FootPoundPerCubicFootToJoulePerCubicMeter(value);
                case UnitConverterEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.ThermPerCubicFootToJoulePerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported energy density unit.");
            }
        }

        public static double FromJoulePerCubicMeter(double baseValue, UnitConverterEnergyDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToJoulePerCubicMeter(baseValue);
                case UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToKilojoulePerCubicMeter(baseValue);
                case UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToMegajoulePerCubicMeter(baseValue);
                case UnitConverterEnergyDensityUnit.JoulePerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToJoulePerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.WattHourPerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToWattHourPerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.JoulePerCubicMeterToBtuPerCubicFoot(baseValue);
                case UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitConverterScientificEnergyDensity.JoulePerCubicMeterToElectronVoltPerCubicNanometer(baseValue);
                case UnitConverterEnergyDensityUnit.MegajoulePerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToMegajoulePerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToKilowattHourPerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.CaloriePerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToCaloriePerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitConverterMetricEnergyDensity.JoulePerCubicMeterToKilocaloriePerLiter(baseValue);
                case UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.JoulePerCubicMeterToFootPoundPerCubicFoot(baseValue);
                case UnitConverterEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitConverterImperialEnergyDensity.JoulePerCubicMeterToThermPerCubicFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported energy density unit.");
            }
        }

        public static string GetSymbol(UnitConverterEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyDensityUnit.JoulePerCubicMeter:
                    return "J/m³";
                case UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter:
                    return "kJ/m³";
                case UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter:
                    return "MJ/m³";
                case UnitConverterEnergyDensityUnit.JoulePerLiter:
                    return "J/L";
                case UnitConverterEnergyDensityUnit.WattHourPerLiter:
                    return "Wh/L";
                case UnitConverterEnergyDensityUnit.BtuPerCubicFoot:
                    return "BTU/ft³";
                case UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return "eV/nm³";
                case UnitConverterEnergyDensityUnit.MegajoulePerLiter:
                    return "MJ/L";
                case UnitConverterEnergyDensityUnit.KilowattHourPerLiter:
                    return "kWh/L";
                case UnitConverterEnergyDensityUnit.CaloriePerLiter:
                    return "cal/L";
                case UnitConverterEnergyDensityUnit.KilocaloriePerLiter:
                    return "kcal/L";
                case UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot:
                    return "ft·lbf/ft³";
                case UnitConverterEnergyDensityUnit.ThermPerCubicFoot:
                    return "therm/ft³";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyDensityUnit.JoulePerCubicMeter:
                    return "Joule Per Cubic Meter";
                case UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter:
                    return "Kilojoule Per Cubic Meter";
                case UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter:
                    return "Megajoule Per Cubic Meter";
                case UnitConverterEnergyDensityUnit.JoulePerLiter:
                    return "Joule Per Liter";
                case UnitConverterEnergyDensityUnit.WattHourPerLiter:
                    return "Watt Hour Per Liter";
                case UnitConverterEnergyDensityUnit.BtuPerCubicFoot:
                    return "Btu Per Cubic Foot";
                case UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return "Electron Volt Per Cubic Nanometer";
                case UnitConverterEnergyDensityUnit.MegajoulePerLiter:
                    return "Megajoule Per Liter";
                case UnitConverterEnergyDensityUnit.KilowattHourPerLiter:
                    return "Kilowatt Hour Per Liter";
                case UnitConverterEnergyDensityUnit.CaloriePerLiter:
                    return "Calorie Per Liter";
                case UnitConverterEnergyDensityUnit.KilocaloriePerLiter:
                    return "Kilocalorie Per Liter";
                case UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot:
                    return "Foot Pound Per Cubic Foot";
                case UnitConverterEnergyDensityUnit.ThermPerCubicFoot:
                    return "Therm Per Cubic Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.JoulePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.WattHourPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterEnergyDensityUnit.MegajoulePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.CaloriePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterEnergyDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterEnergyDensityUnit.JoulePerCubicMeter, UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter, UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter, UnitConverterEnergyDensityUnit.JoulePerLiter, UnitConverterEnergyDensityUnit.WattHourPerLiter, UnitConverterEnergyDensityUnit.MegajoulePerLiter, UnitConverterEnergyDensityUnit.KilowattHourPerLiter, UnitConverterEnergyDensityUnit.CaloriePerLiter, UnitConverterEnergyDensityUnit.KilocaloriePerLiter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterEnergyDensityUnit.BtuPerCubicFoot, UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot, UnitConverterEnergyDensityUnit.ThermPerCubicFoot };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer };
                default:
                    return new[] { UnitConverterEnergyDensityUnit.JoulePerCubicMeter, UnitConverterEnergyDensityUnit.KilojoulePerCubicMeter, UnitConverterEnergyDensityUnit.MegajoulePerCubicMeter, UnitConverterEnergyDensityUnit.JoulePerLiter, UnitConverterEnergyDensityUnit.WattHourPerLiter, UnitConverterEnergyDensityUnit.BtuPerCubicFoot, UnitConverterEnergyDensityUnit.ElectronVoltPerCubicNanometer, UnitConverterEnergyDensityUnit.MegajoulePerLiter, UnitConverterEnergyDensityUnit.KilowattHourPerLiter, UnitConverterEnergyDensityUnit.CaloriePerLiter, UnitConverterEnergyDensityUnit.KilocaloriePerLiter, UnitConverterEnergyDensityUnit.FootPoundPerCubicFoot, UnitConverterEnergyDensityUnit.ThermPerCubicFoot };
            }
        }
    }
}
