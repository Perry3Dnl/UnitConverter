namespace UnitConverter.PowerDensity
{
    using UnitConverter.PowerDensity.Metric;
    using UnitConverter.PowerDensity.Imperial;

    public enum UnitConverterPowerDensityUnit
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

    public static class UnitConverterPowerDensity
    {
        public static double Convert(double value, UnitConverterPowerDensityUnit from, UnitConverterPowerDensityUnit to)
        {
            double baseValue = ToWattPerCubicMeter(value, from);
            return FromWattPerCubicMeter(baseValue, to);
        }

        public static double ToWattPerCubicMeter(double value, UnitConverterPowerDensityUnit from)
        {
            switch (from)
            {
                case UnitConverterPowerDensityUnit.WattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.KilowattPerCubicMeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.MegawattPerCubicMeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.WattPerLiter:
                    return UnitConverterMetricPowerDensity.WattPerLiterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitConverterImperialPowerDensity.HorsepowerPerCubicFootToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitConverterImperialPowerDensity.BtuPerHourCubicFootToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.MilliwattPerCubicMeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicCentimeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMillimeterToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitConverterImperialPowerDensity.KilowattPerCubicFootToWattPerCubicMeter(value);
                case UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitConverterImperialPowerDensity.BtuPerSecondCubicFootToWattPerCubicMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported power density unit.");
            }
        }

        public static double FromWattPerCubicMeter(double baseValue, UnitConverterPowerDensityUnit to)
        {
            switch (to)
            {
                case UnitConverterPowerDensityUnit.WattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToWattPerCubicMeter(baseValue);
                case UnitConverterPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToKilowattPerCubicMeter(baseValue);
                case UnitConverterPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToMegawattPerCubicMeter(baseValue);
                case UnitConverterPowerDensityUnit.WattPerLiter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToWattPerLiter(baseValue);
                case UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitConverterImperialPowerDensity.WattPerCubicMeterToHorsepowerPerCubicFoot(baseValue);
                case UnitConverterPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitConverterImperialPowerDensity.WattPerCubicMeterToBtuPerHourCubicFoot(baseValue);
                case UnitConverterPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToMilliwattPerCubicMeter(baseValue);
                case UnitConverterPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToWattPerCubicCentimeter(baseValue);
                case UnitConverterPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitConverterMetricPowerDensity.WattPerCubicMeterToWattPerCubicMillimeter(baseValue);
                case UnitConverterPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitConverterImperialPowerDensity.WattPerCubicMeterToKilowattPerCubicFoot(baseValue);
                case UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitConverterImperialPowerDensity.WattPerCubicMeterToBtuPerSecondCubicFoot(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported power density unit.");
            }
        }

        public static string GetSymbol(UnitConverterPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerDensityUnit.WattPerCubicMeter:
                    return "W/m³";
                case UnitConverterPowerDensityUnit.KilowattPerCubicMeter:
                    return "kW/m³";
                case UnitConverterPowerDensityUnit.MegawattPerCubicMeter:
                    return "MW/m³";
                case UnitConverterPowerDensityUnit.WattPerLiter:
                    return "W/L";
                case UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot:
                    return "hp/ft³";
                case UnitConverterPowerDensityUnit.BtuPerHourCubicFoot:
                    return "BTU/(h·ft³)";
                case UnitConverterPowerDensityUnit.MilliwattPerCubicMeter:
                    return "mW/m³";
                case UnitConverterPowerDensityUnit.WattPerCubicCentimeter:
                    return "W/cm³";
                case UnitConverterPowerDensityUnit.WattPerCubicMillimeter:
                    return "W/mm³";
                case UnitConverterPowerDensityUnit.KilowattPerCubicFoot:
                    return "kW/ft³";
                case UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot:
                    return "BTU/(s·ft³)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerDensityUnit.WattPerCubicMeter:
                    return "Watt Per Cubic Meter";
                case UnitConverterPowerDensityUnit.KilowattPerCubicMeter:
                    return "Kilowatt Per Cubic Meter";
                case UnitConverterPowerDensityUnit.MegawattPerCubicMeter:
                    return "Megawatt Per Cubic Meter";
                case UnitConverterPowerDensityUnit.WattPerLiter:
                    return "Watt Per Liter";
                case UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot:
                    return "Horsepower Per Cubic Foot";
                case UnitConverterPowerDensityUnit.BtuPerHourCubicFoot:
                    return "Btu Per Hour Cubic Foot";
                case UnitConverterPowerDensityUnit.MilliwattPerCubicMeter:
                    return "Milliwatt Per Cubic Meter";
                case UnitConverterPowerDensityUnit.WattPerCubicCentimeter:
                    return "Watt Per Cubic Centimeter";
                case UnitConverterPowerDensityUnit.WattPerCubicMillimeter:
                    return "Watt Per Cubic Millimeter";
                case UnitConverterPowerDensityUnit.KilowattPerCubicFoot:
                    return "Kilowatt Per Cubic Foot";
                case UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot:
                    return "Btu Per Second Cubic Foot";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterPowerDensityUnit unit)
        {
            switch (unit)
            {
                case UnitConverterPowerDensityUnit.WattPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.KilowattPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.MegawattPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.WattPerLiter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerDensityUnit.BtuPerHourCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerDensityUnit.MilliwattPerCubicMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.WattPerCubicCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.WattPerCubicMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterPowerDensityUnit.KilowattPerCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterPowerDensityUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterPowerDensityUnit.WattPerCubicMeter, UnitConverterPowerDensityUnit.KilowattPerCubicMeter, UnitConverterPowerDensityUnit.MegawattPerCubicMeter, UnitConverterPowerDensityUnit.WattPerLiter, UnitConverterPowerDensityUnit.MilliwattPerCubicMeter, UnitConverterPowerDensityUnit.WattPerCubicCentimeter, UnitConverterPowerDensityUnit.WattPerCubicMillimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot, UnitConverterPowerDensityUnit.BtuPerHourCubicFoot, UnitConverterPowerDensityUnit.KilowattPerCubicFoot, UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot };
                default:
                    return new[] { UnitConverterPowerDensityUnit.WattPerCubicMeter, UnitConverterPowerDensityUnit.KilowattPerCubicMeter, UnitConverterPowerDensityUnit.MegawattPerCubicMeter, UnitConverterPowerDensityUnit.WattPerLiter, UnitConverterPowerDensityUnit.HorsepowerPerCubicFoot, UnitConverterPowerDensityUnit.BtuPerHourCubicFoot, UnitConverterPowerDensityUnit.MilliwattPerCubicMeter, UnitConverterPowerDensityUnit.WattPerCubicCentimeter, UnitConverterPowerDensityUnit.WattPerCubicMillimeter, UnitConverterPowerDensityUnit.KilowattPerCubicFoot, UnitConverterPowerDensityUnit.BtuPerSecondCubicFoot };
            }
        }
    }
}
