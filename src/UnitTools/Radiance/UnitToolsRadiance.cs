namespace UnitTools.Radiance
{
    using UnitTools.Radiance.Metric;
    using UnitTools.Radiance.Imperial;
    using UnitTools.Radiance.Scientific;

    public enum UnitToolsRadianceUnit
    {
        WattPerSteradianSquareMeter = 0,
        KilowattPerSteradianSquareMeter = 1,
        WattPerSteradianSquareCentimeter = 2,
        WattPerSteradianSquareMillimeter = 3,
        MilliwattPerSteradianSquareMeter = 4,
        MegawattPerSteradianSquareMeter = 5,
        WattPerSteradianSquareFoot = 6,
        WattPerSteradianSquareInch = 7,
        ErgPerSecondSteradianSquareCentimeter = 8,
        MicrowattPerSteradianSquareMeter = 9,
        NanowattPerSteradianSquareMeter = 10,
        CaloriePerSecondSteradianSquareCentimeter = 11,
    }

    public static class UnitToolsRadiance
    {
        public static double Convert(double value, UnitToolsRadianceUnit from, UnitToolsRadianceUnit to)
        {
            double baseValue = ToWattPerSteradianSquareMeter(value, from);
            return FromWattPerSteradianSquareMeter(baseValue, to);
        }

        public static double ToWattPerSteradianSquareMeter(double value, UnitToolsRadianceUnit from)
        {
            switch (from)
            {
                case UnitToolsRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.KilowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMillimeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.MilliwattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.MegawattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitToolsImperialRadiance.WattPerSteradianSquareFootToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.WattPerSteradianSquareInch:
                    return UnitToolsImperialRadiance.WattPerSteradianSquareInchToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitToolsScientificRadiance.ErgPerSecondSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.MicrowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.NanowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitToolsMetricRadiance.CaloriePerSecondSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiance unit.");
            }
        }

        public static double FromWattPerSteradianSquareMeter(double baseValue, UnitToolsRadianceUnit to)
        {
            switch (to)
            {
                case UnitToolsRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToKilowattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareCentimeter(baseValue);
                case UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMillimeter(baseValue);
                case UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToMilliwattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToMegawattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitToolsImperialRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareFoot(baseValue);
                case UnitToolsRadianceUnit.WattPerSteradianSquareInch:
                    return UnitToolsImperialRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareInch(baseValue);
                case UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitToolsScientificRadiance.WattPerSteradianSquareMeterToErgPerSecondSteradianSquareCentimeter(baseValue);
                case UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToMicrowattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToNanowattPerSteradianSquareMeter(baseValue);
                case UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitToolsMetricRadiance.WattPerSteradianSquareMeterToCaloriePerSecondSteradianSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiance unit.");
            }
        }

        public static string GetSymbol(UnitToolsRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadianceUnit.WattPerSteradianSquareMeter:
                    return "W/(sr·m²)";
                case UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter:
                    return "kW/(sr·m²)";
                case UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter:
                    return "W/(sr·cm²)";
                case UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter:
                    return "W/(sr·mm²)";
                case UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return "mW/(sr·m²)";
                case UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter:
                    return "MW/(sr·m²)";
                case UnitToolsRadianceUnit.WattPerSteradianSquareFoot:
                    return "W/(sr·ft²)";
                case UnitToolsRadianceUnit.WattPerSteradianSquareInch:
                    return "W/(sr·in²)";
                case UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return "erg/(s·sr·cm²)";
                case UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return "µW/(sr·m²)";
                case UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter:
                    return "nW/(sr·m²)";
                case UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return "cal/(s·sr·cm²)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadianceUnit.WattPerSteradianSquareMeter:
                    return "Watt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter:
                    return "Kilowatt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter:
                    return "Watt Per Steradian Square Centimeter";
                case UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter:
                    return "Watt Per Steradian Square Millimeter";
                case UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return "Milliwatt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter:
                    return "Megawatt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.WattPerSteradianSquareFoot:
                    return "Watt Per Steradian Square Foot";
                case UnitToolsRadianceUnit.WattPerSteradianSquareInch:
                    return "Watt Per Steradian Square Inch";
                case UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return "Erg Per Second Steradian Square Centimeter";
                case UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return "Microwatt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter:
                    return "Nanowatt Per Steradian Square Meter";
                case UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return "Calorie Per Second Steradian Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsRadianceUnit.WattPerSteradianSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsRadianceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsRadianceUnit.WattPerSteradianSquareMeter, UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter, UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter, UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter, UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter, UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter, UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter, UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter, UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsRadianceUnit.WattPerSteradianSquareFoot, UnitToolsRadianceUnit.WattPerSteradianSquareInch };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter };
                default:
                    return new[] { UnitToolsRadianceUnit.WattPerSteradianSquareMeter, UnitToolsRadianceUnit.KilowattPerSteradianSquareMeter, UnitToolsRadianceUnit.WattPerSteradianSquareCentimeter, UnitToolsRadianceUnit.WattPerSteradianSquareMillimeter, UnitToolsRadianceUnit.MilliwattPerSteradianSquareMeter, UnitToolsRadianceUnit.MegawattPerSteradianSquareMeter, UnitToolsRadianceUnit.WattPerSteradianSquareFoot, UnitToolsRadianceUnit.WattPerSteradianSquareInch, UnitToolsRadianceUnit.ErgPerSecondSteradianSquareCentimeter, UnitToolsRadianceUnit.MicrowattPerSteradianSquareMeter, UnitToolsRadianceUnit.NanowattPerSteradianSquareMeter, UnitToolsRadianceUnit.CaloriePerSecondSteradianSquareCentimeter };
            }
        }
    }
}
