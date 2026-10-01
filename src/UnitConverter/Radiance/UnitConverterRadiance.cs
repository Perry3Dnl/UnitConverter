namespace UnitConverter.Radiance
{
    using UnitConverter.Radiance.Metric;
    using UnitConverter.Radiance.Imperial;
    using UnitConverter.Radiance.Scientific;

    public enum UnitConverterRadianceUnit
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

    public static class UnitConverterRadiance
    {
        public static double Convert(double value, UnitConverterRadianceUnit from, UnitConverterRadianceUnit to)
        {
            double baseValue = ToWattPerSteradianSquareMeter(value, from);
            return FromWattPerSteradianSquareMeter(baseValue, to);
        }

        public static double ToWattPerSteradianSquareMeter(double value, UnitConverterRadianceUnit from)
        {
            switch (from)
            {
                case UnitConverterRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.KilowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMillimeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.MilliwattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.MegawattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitConverterImperialRadiance.WattPerSteradianSquareFootToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.WattPerSteradianSquareInch:
                    return UnitConverterImperialRadiance.WattPerSteradianSquareInchToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitConverterScientificRadiance.ErgPerSecondSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.MicrowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.NanowattPerSteradianSquareMeterToWattPerSteradianSquareMeter(value);
                case UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitConverterMetricRadiance.CaloriePerSecondSteradianSquareCentimeterToWattPerSteradianSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported radiance unit.");
            }
        }

        public static double FromWattPerSteradianSquareMeter(double baseValue, UnitConverterRadianceUnit to)
        {
            switch (to)
            {
                case UnitConverterRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToKilowattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareCentimeter(baseValue);
                case UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareMillimeter(baseValue);
                case UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToMilliwattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToMegawattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitConverterImperialRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareFoot(baseValue);
                case UnitConverterRadianceUnit.WattPerSteradianSquareInch:
                    return UnitConverterImperialRadiance.WattPerSteradianSquareMeterToWattPerSteradianSquareInch(baseValue);
                case UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitConverterScientificRadiance.WattPerSteradianSquareMeterToErgPerSecondSteradianSquareCentimeter(baseValue);
                case UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToMicrowattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToNanowattPerSteradianSquareMeter(baseValue);
                case UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitConverterMetricRadiance.WattPerSteradianSquareMeterToCaloriePerSecondSteradianSquareCentimeter(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported radiance unit.");
            }
        }

        public static string GetSymbol(UnitConverterRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadianceUnit.WattPerSteradianSquareMeter:
                    return "W/(sr·m²)";
                case UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter:
                    return "kW/(sr·m²)";
                case UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter:
                    return "W/(sr·cm²)";
                case UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter:
                    return "W/(sr·mm²)";
                case UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return "mW/(sr·m²)";
                case UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter:
                    return "MW/(sr·m²)";
                case UnitConverterRadianceUnit.WattPerSteradianSquareFoot:
                    return "W/(sr·ft²)";
                case UnitConverterRadianceUnit.WattPerSteradianSquareInch:
                    return "W/(sr·in²)";
                case UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return "erg/(s·sr·cm²)";
                case UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return "µW/(sr·m²)";
                case UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter:
                    return "nW/(sr·m²)";
                case UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return "cal/(s·sr·cm²)";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadianceUnit.WattPerSteradianSquareMeter:
                    return "Watt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter:
                    return "Kilowatt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter:
                    return "Watt Per Steradian Square Centimeter";
                case UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter:
                    return "Watt Per Steradian Square Millimeter";
                case UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return "Milliwatt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter:
                    return "Megawatt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.WattPerSteradianSquareFoot:
                    return "Watt Per Steradian Square Foot";
                case UnitConverterRadianceUnit.WattPerSteradianSquareInch:
                    return "Watt Per Steradian Square Inch";
                case UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return "Erg Per Second Steradian Square Centimeter";
                case UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return "Microwatt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter:
                    return "Nanowatt Per Steradian Square Meter";
                case UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return "Calorie Per Second Steradian Square Centimeter";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterRadianceUnit unit)
        {
            switch (unit)
            {
                case UnitConverterRadianceUnit.WattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.WattPerSteradianSquareFoot:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterRadianceUnit.WattPerSteradianSquareInch:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter:
                    return UnitConverterUnitSystem.Scientific;
                case UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter:
                    return UnitConverterUnitSystem.Metric;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterRadianceUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterRadianceUnit.WattPerSteradianSquareMeter, UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter, UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter, UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter, UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter, UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter, UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter, UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter, UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterRadianceUnit.WattPerSteradianSquareFoot, UnitConverterRadianceUnit.WattPerSteradianSquareInch };
                case UnitConverterUnitSystem.Scientific:
                    return new[] { UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter };
                default:
                    return new[] { UnitConverterRadianceUnit.WattPerSteradianSquareMeter, UnitConverterRadianceUnit.KilowattPerSteradianSquareMeter, UnitConverterRadianceUnit.WattPerSteradianSquareCentimeter, UnitConverterRadianceUnit.WattPerSteradianSquareMillimeter, UnitConverterRadianceUnit.MilliwattPerSteradianSquareMeter, UnitConverterRadianceUnit.MegawattPerSteradianSquareMeter, UnitConverterRadianceUnit.WattPerSteradianSquareFoot, UnitConverterRadianceUnit.WattPerSteradianSquareInch, UnitConverterRadianceUnit.ErgPerSecondSteradianSquareCentimeter, UnitConverterRadianceUnit.MicrowattPerSteradianSquareMeter, UnitConverterRadianceUnit.NanowattPerSteradianSquareMeter, UnitConverterRadianceUnit.CaloriePerSecondSteradianSquareCentimeter };
            }
        }
    }
}
