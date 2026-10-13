namespace UnitTools.EnergyDensity
{
    using UnitTools.EnergyDensity.Metric;
    using UnitTools.EnergyDensity.Imperial;
    using UnitTools.EnergyDensity.Scientific;

    public enum UnitToolsEnergyDensityUnit
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

    public static class UnitToolsEnergyDensity
    {
        public static double Convert(double value, UnitToolsEnergyDensityUnit from, UnitToolsEnergyDensityUnit to)
        {
            double baseValue = ToJoulePerCubicMeter(value, from);
            return FromJoulePerCubicMeter(baseValue, to);
        }

        public static double ToJoulePerCubicMeter(double value, UnitToolsEnergyDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.KilojoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.MegajoulePerCubicMeterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.JoulePerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.WattHourPerLiter:
                    return UnitToolsMetricEnergyDensity.WattHourPerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.BtuPerCubicFootToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitToolsScientificEnergyDensity.ElectronVoltPerCubicNanometerToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.MegajoulePerLiter:
                    return UnitToolsMetricEnergyDensity.MegajoulePerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitToolsMetricEnergyDensity.KilowattHourPerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.CaloriePerLiter:
                    return UnitToolsMetricEnergyDensity.CaloriePerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitToolsMetricEnergyDensity.KilocaloriePerLiterToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.FootPoundPerCubicFootToJoulePerCubicMeter(value);
                case UnitToolsEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.ThermPerCubicFootToJoulePerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported energy density unit.");
            }
        }

        public static double FromJoulePerCubicMeter(double baseValue, UnitToolsEnergyDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToJoulePerCubicMeter(baseValue);
                case UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToKilojoulePerCubicMeter(baseValue);
                case UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToMegajoulePerCubicMeter(baseValue);
                case UnitToolsEnergyDensityUnit.JoulePerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToJoulePerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.WattHourPerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToWattHourPerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.JoulePerCubicMeterToBtuPerCubicFoot(baseValue);
                case UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitToolsScientificEnergyDensity.JoulePerCubicMeterToElectronVoltPerCubicNanometer(baseValue);
                case UnitToolsEnergyDensityUnit.MegajoulePerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToMegajoulePerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToKilowattHourPerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.CaloriePerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToCaloriePerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitToolsMetricEnergyDensity.JoulePerCubicMeterToKilocaloriePerLiter(baseValue);
                case UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.JoulePerCubicMeterToFootPoundPerCubicFoot(baseValue);
                case UnitToolsEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitToolsImperialEnergyDensity.JoulePerCubicMeterToThermPerCubicFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported energy density unit.");
            }
        }

        public static string GetSymbol(UnitToolsEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyDensityUnit.JoulePerCubicMeter:
                    return "J/m³";
                case UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter:
                    return "kJ/m³";
                case UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter:
                    return "MJ/m³";
                case UnitToolsEnergyDensityUnit.JoulePerLiter:
                    return "J/L";
                case UnitToolsEnergyDensityUnit.WattHourPerLiter:
                    return "Wh/L";
                case UnitToolsEnergyDensityUnit.BtuPerCubicFoot:
                    return "BTU/ft³";
                case UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return "eV/nm³";
                case UnitToolsEnergyDensityUnit.MegajoulePerLiter:
                    return "MJ/L";
                case UnitToolsEnergyDensityUnit.KilowattHourPerLiter:
                    return "kWh/L";
                case UnitToolsEnergyDensityUnit.CaloriePerLiter:
                    return "cal/L";
                case UnitToolsEnergyDensityUnit.KilocaloriePerLiter:
                    return "kcal/L";
                case UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot:
                    return "ft·lbf/ft³";
                case UnitToolsEnergyDensityUnit.ThermPerCubicFoot:
                    return "therm/ft³";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyDensityUnit.JoulePerCubicMeter:
                    return "Joule Per Cubic Meter";
                case UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter:
                    return "Kilojoule Per Cubic Meter";
                case UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter:
                    return "Megajoule Per Cubic Meter";
                case UnitToolsEnergyDensityUnit.JoulePerLiter:
                    return "Joule Per Liter";
                case UnitToolsEnergyDensityUnit.WattHourPerLiter:
                    return "Watt Hour Per Liter";
                case UnitToolsEnergyDensityUnit.BtuPerCubicFoot:
                    return "Btu Per Cubic Foot";
                case UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return "Electron Volt Per Cubic Nanometer";
                case UnitToolsEnergyDensityUnit.MegajoulePerLiter:
                    return "Megajoule Per Liter";
                case UnitToolsEnergyDensityUnit.KilowattHourPerLiter:
                    return "Kilowatt Hour Per Liter";
                case UnitToolsEnergyDensityUnit.CaloriePerLiter:
                    return "Calorie Per Liter";
                case UnitToolsEnergyDensityUnit.KilocaloriePerLiter:
                    return "Kilocalorie Per Liter";
                case UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot:
                    return "Foot Pound Per Cubic Foot";
                case UnitToolsEnergyDensityUnit.ThermPerCubicFoot:
                    return "Therm Per Cubic Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsEnergyDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsEnergyDensityUnit.JoulePerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.JoulePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.WattHourPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.BtuPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsEnergyDensityUnit.MegajoulePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.KilowattHourPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.CaloriePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.KilocaloriePerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsEnergyDensityUnit.ThermPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsEnergyDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsEnergyDensityUnit.JoulePerCubicMeter, UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter, UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter, UnitToolsEnergyDensityUnit.JoulePerLiter, UnitToolsEnergyDensityUnit.WattHourPerLiter, UnitToolsEnergyDensityUnit.MegajoulePerLiter, UnitToolsEnergyDensityUnit.KilowattHourPerLiter, UnitToolsEnergyDensityUnit.CaloriePerLiter, UnitToolsEnergyDensityUnit.KilocaloriePerLiter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsEnergyDensityUnit.BtuPerCubicFoot, UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot, UnitToolsEnergyDensityUnit.ThermPerCubicFoot };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer };
                default:
                    return new[] { UnitToolsEnergyDensityUnit.JoulePerCubicMeter, UnitToolsEnergyDensityUnit.KilojoulePerCubicMeter, UnitToolsEnergyDensityUnit.MegajoulePerCubicMeter, UnitToolsEnergyDensityUnit.JoulePerLiter, UnitToolsEnergyDensityUnit.WattHourPerLiter, UnitToolsEnergyDensityUnit.BtuPerCubicFoot, UnitToolsEnergyDensityUnit.ElectronVoltPerCubicNanometer, UnitToolsEnergyDensityUnit.MegajoulePerLiter, UnitToolsEnergyDensityUnit.KilowattHourPerLiter, UnitToolsEnergyDensityUnit.CaloriePerLiter, UnitToolsEnergyDensityUnit.KilocaloriePerLiter, UnitToolsEnergyDensityUnit.FootPoundPerCubicFoot, UnitToolsEnergyDensityUnit.ThermPerCubicFoot };
            }
        }
    }
}
