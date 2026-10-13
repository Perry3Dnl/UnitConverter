namespace UnitTools.PowerDensity
{
    using UnitTools.PowerDensity.Metric;
    using UnitTools.PowerDensity.Imperial;

    public enum UnitToolsPowerDensityUnit
    {
        WattPerCubicMeter = 0,
        KilowattPerCubicMeter = 1,
        MegawattPerCubicMeter = 2,
        WattPerLiter = 3,
        HorsepowerPerCubicFoot = 4,
        BtuPerHourCubicFoot = 5,
        MilliwattPerCubicMeter = 6,
        WattPerCubicCentimeter = 7,
        WattPerCubicMillimeter = 8,
        KilowattPerCubicFoot = 9,
        BtuPerSecondCubicFoot = 10,
    }

    public static class UnitToolsPowerDensity
    {
        public static double Convert(double value, UnitToolsPowerDensityUnit from, UnitToolsPowerDensityUnit to)
        {
            double baseValue = ToWattPerCubicMeter(value, from);
            return FromWattPerCubicMeter(baseValue, to);
        }

        public static double ToWattPerCubicMeter(double value, UnitToolsPowerDensityUnit from)
        {
            switch (from)
            {
                case UnitToolsPowerDensityUnit.WattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.KilowattPerCubicMeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.MegawattPerCubicMeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.WattPerLiter:
                    return UnitToolsMetricPowerDensity.WattPerLiterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitToolsImperialPowerDensity.HorsepowerPerCubicFootToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitToolsImperialPowerDensity.BtuPerHourCubicFootToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.MilliwattPerCubicMeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicCentimeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMillimeterToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitToolsImperialPowerDensity.KilowattPerCubicFootToWattPerCubicMeter(value);
                case UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitToolsImperialPowerDensity.BtuPerSecondCubicFootToWattPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported power density unit.");
            }
        }

        public static double FromWattPerCubicMeter(double baseValue, UnitToolsPowerDensityUnit to)
        {
            switch (to)
            {
                case UnitToolsPowerDensityUnit.WattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToWattPerCubicMeter(baseValue);
                case UnitToolsPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToKilowattPerCubicMeter(baseValue);
                case UnitToolsPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToMegawattPerCubicMeter(baseValue);
                case UnitToolsPowerDensityUnit.WattPerLiter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToWattPerLiter(baseValue);
                case UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitToolsImperialPowerDensity.WattPerCubicMeterToHorsepowerPerCubicFoot(baseValue);
                case UnitToolsPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitToolsImperialPowerDensity.WattPerCubicMeterToBtuPerHourCubicFoot(baseValue);
                case UnitToolsPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToMilliwattPerCubicMeter(baseValue);
                case UnitToolsPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToWattPerCubicCentimeter(baseValue);
                case UnitToolsPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitToolsMetricPowerDensity.WattPerCubicMeterToWattPerCubicMillimeter(baseValue);
                case UnitToolsPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitToolsImperialPowerDensity.WattPerCubicMeterToKilowattPerCubicFoot(baseValue);
                case UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitToolsImperialPowerDensity.WattPerCubicMeterToBtuPerSecondCubicFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported power density unit.");
            }
        }

        public static string GetSymbol(UnitToolsPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerDensityUnit.WattPerCubicMeter:
                    return "W/m³";
                case UnitToolsPowerDensityUnit.KilowattPerCubicMeter:
                    return "kW/m³";
                case UnitToolsPowerDensityUnit.MegawattPerCubicMeter:
                    return "MW/m³";
                case UnitToolsPowerDensityUnit.WattPerLiter:
                    return "W/L";
                case UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot:
                    return "hp/ft³";
                case UnitToolsPowerDensityUnit.BtuPerHourCubicFoot:
                    return "BTU/(h·ft³)";
                case UnitToolsPowerDensityUnit.MilliwattPerCubicMeter:
                    return "mW/m³";
                case UnitToolsPowerDensityUnit.WattPerCubicCentimeter:
                    return "W/cm³";
                case UnitToolsPowerDensityUnit.WattPerCubicMillimeter:
                    return "W/mm³";
                case UnitToolsPowerDensityUnit.KilowattPerCubicFoot:
                    return "kW/ft³";
                case UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot:
                    return "BTU/(s·ft³)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerDensityUnit.WattPerCubicMeter:
                    return "Watt Per Cubic Meter";
                case UnitToolsPowerDensityUnit.KilowattPerCubicMeter:
                    return "Kilowatt Per Cubic Meter";
                case UnitToolsPowerDensityUnit.MegawattPerCubicMeter:
                    return "Megawatt Per Cubic Meter";
                case UnitToolsPowerDensityUnit.WattPerLiter:
                    return "Watt Per Liter";
                case UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot:
                    return "Horsepower Per Cubic Foot";
                case UnitToolsPowerDensityUnit.BtuPerHourCubicFoot:
                    return "Btu Per Hour Cubic Foot";
                case UnitToolsPowerDensityUnit.MilliwattPerCubicMeter:
                    return "Milliwatt Per Cubic Meter";
                case UnitToolsPowerDensityUnit.WattPerCubicCentimeter:
                    return "Watt Per Cubic Centimeter";
                case UnitToolsPowerDensityUnit.WattPerCubicMillimeter:
                    return "Watt Per Cubic Millimeter";
                case UnitToolsPowerDensityUnit.KilowattPerCubicFoot:
                    return "Kilowatt Per Cubic Foot";
                case UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot:
                    return "Btu Per Second Cubic Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitToolsPowerDensityUnit.WattPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.WattPerLiter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsPowerDensityUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsPowerDensityUnit.WattPerCubicMeter, UnitToolsPowerDensityUnit.KilowattPerCubicMeter, UnitToolsPowerDensityUnit.MegawattPerCubicMeter, UnitToolsPowerDensityUnit.WattPerLiter, UnitToolsPowerDensityUnit.MilliwattPerCubicMeter, UnitToolsPowerDensityUnit.WattPerCubicCentimeter, UnitToolsPowerDensityUnit.WattPerCubicMillimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot, UnitToolsPowerDensityUnit.BtuPerHourCubicFoot, UnitToolsPowerDensityUnit.KilowattPerCubicFoot, UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot };
                default:
                    return new[] { UnitToolsPowerDensityUnit.WattPerCubicMeter, UnitToolsPowerDensityUnit.KilowattPerCubicMeter, UnitToolsPowerDensityUnit.MegawattPerCubicMeter, UnitToolsPowerDensityUnit.WattPerLiter, UnitToolsPowerDensityUnit.HorsepowerPerCubicFoot, UnitToolsPowerDensityUnit.BtuPerHourCubicFoot, UnitToolsPowerDensityUnit.MilliwattPerCubicMeter, UnitToolsPowerDensityUnit.WattPerCubicCentimeter, UnitToolsPowerDensityUnit.WattPerCubicMillimeter, UnitToolsPowerDensityUnit.KilowattPerCubicFoot, UnitToolsPowerDensityUnit.BtuPerSecondCubicFoot };
            }
        }
    }
}
