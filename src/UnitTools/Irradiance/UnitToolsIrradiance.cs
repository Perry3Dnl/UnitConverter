namespace UnitTools.Irradiance
{
    using UnitTools.Irradiance.Metric;
    using UnitTools.Irradiance.Scientific;
    using UnitTools.Irradiance.Imperial;

    public enum UnitToolsIrradianceUnit
    {
        WattPerSquareMeter = 0,
        KilowattPerSquareMeter = 1,
        MilliwattPerSquareCentimeter = 2,
        WattPerSquareCentimeter = 3,
        LangleyPerMinute = 4,
        MilliwattPerSquareMeter = 5,
        MicrowattPerSquareMeter = 6,
        WattPerSquareFoot = 7,
        WattPerSquareInch = 8,
        CaloriePerSquareCentimeterMinute = 9,
        LangleyPerHour = 10,
        NanowattPerSquareMeter = 11,
        MegawattPerSquareMeter = 12,
        CaloriePerSquareCentimeterSecond = 13,
        LangleyPerSecond = 14,
    }

    public static class UnitToolsIrradiance
    {
        public static double Convert(double value, UnitToolsIrradianceUnit from, UnitToolsIrradianceUnit to)
        {
            double baseValue = ToWattPerSquareMeter(value, from);
            return FromWattPerSquareMeter(baseValue, to);
        }

        public static double ToWattPerSquareMeter(double value, UnitToolsIrradianceUnit from)
        {
            switch (from)
            {
                case UnitToolsIrradianceUnit.WattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.KilowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.KilowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitToolsMetricIrradiance.MilliwattPerSquareCentimeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.WattPerSquareCentimeter:
                    return UnitToolsMetricIrradiance.WattPerSquareCentimeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.LangleyPerMinute:
                    return UnitToolsScientificIrradiance.LangleyPerMinuteToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitToolsMetricIrradiance.MilliwattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.MicrowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.WattPerSquareFoot:
                    return UnitToolsImperialIrradiance.WattPerSquareFootToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.WattPerSquareInch:
                    return UnitToolsImperialIrradiance.WattPerSquareInchToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitToolsMetricIrradiance.CaloriePerSquareCentimeterMinuteToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.LangleyPerHour:
                    return UnitToolsScientificIrradiance.LangleyPerHourToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.NanowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.NanowattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.MegawattPerSquareMeter:
                    return UnitToolsMetricIrradiance.MegawattPerSquareMeterToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitToolsMetricIrradiance.CaloriePerSquareCentimeterSecondToWattPerSquareMeter(value);
                case UnitToolsIrradianceUnit.LangleyPerSecond:
                    return UnitToolsScientificIrradiance.LangleyPerSecondToWattPerSquareMeter(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported irradiance unit.");
            }
        }

        public static double FromWattPerSquareMeter(double baseValue, UnitToolsIrradianceUnit to)
        {
            switch (to)
            {
                case UnitToolsIrradianceUnit.WattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToWattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.KilowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToKilowattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToMilliwattPerSquareCentimeter(baseValue);
                case UnitToolsIrradianceUnit.WattPerSquareCentimeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToWattPerSquareCentimeter(baseValue);
                case UnitToolsIrradianceUnit.LangleyPerMinute:
                    return UnitToolsScientificIrradiance.WattPerSquareMeterToLangleyPerMinute(baseValue);
                case UnitToolsIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToMilliwattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToMicrowattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.WattPerSquareFoot:
                    return UnitToolsImperialIrradiance.WattPerSquareMeterToWattPerSquareFoot(baseValue);
                case UnitToolsIrradianceUnit.WattPerSquareInch:
                    return UnitToolsImperialIrradiance.WattPerSquareMeterToWattPerSquareInch(baseValue);
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToCaloriePerSquareCentimeterMinute(baseValue);
                case UnitToolsIrradianceUnit.LangleyPerHour:
                    return UnitToolsScientificIrradiance.WattPerSquareMeterToLangleyPerHour(baseValue);
                case UnitToolsIrradianceUnit.NanowattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToNanowattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.MegawattPerSquareMeter:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToMegawattPerSquareMeter(baseValue);
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitToolsMetricIrradiance.WattPerSquareMeterToCaloriePerSquareCentimeterSecond(baseValue);
                case UnitToolsIrradianceUnit.LangleyPerSecond:
                    return UnitToolsScientificIrradiance.WattPerSquareMeterToLangleyPerSecond(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported irradiance unit.");
            }
        }

        public static string GetSymbol(UnitToolsIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIrradianceUnit.WattPerSquareMeter:
                    return "W/m²";
                case UnitToolsIrradianceUnit.KilowattPerSquareMeter:
                    return "kW/m²";
                case UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter:
                    return "mW/cm²";
                case UnitToolsIrradianceUnit.WattPerSquareCentimeter:
                    return "W/cm²";
                case UnitToolsIrradianceUnit.LangleyPerMinute:
                    return "Ly/min";
                case UnitToolsIrradianceUnit.MilliwattPerSquareMeter:
                    return "mW/m²";
                case UnitToolsIrradianceUnit.MicrowattPerSquareMeter:
                    return "µW/m²";
                case UnitToolsIrradianceUnit.WattPerSquareFoot:
                    return "W/ft²";
                case UnitToolsIrradianceUnit.WattPerSquareInch:
                    return "W/in²";
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return "cal/(cm²·min)";
                case UnitToolsIrradianceUnit.LangleyPerHour:
                    return "Ly/h";
                case UnitToolsIrradianceUnit.NanowattPerSquareMeter:
                    return "nW/m²";
                case UnitToolsIrradianceUnit.MegawattPerSquareMeter:
                    return "MW/m²";
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return "cal/(cm²·s)";
                case UnitToolsIrradianceUnit.LangleyPerSecond:
                    return "Ly/s";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIrradianceUnit.WattPerSquareMeter:
                    return "Watt Per Square Meter";
                case UnitToolsIrradianceUnit.KilowattPerSquareMeter:
                    return "Kilowatt Per Square Meter";
                case UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter:
                    return "Milliwatt Per Square Centimeter";
                case UnitToolsIrradianceUnit.WattPerSquareCentimeter:
                    return "Watt Per Square Centimeter";
                case UnitToolsIrradianceUnit.LangleyPerMinute:
                    return "Langley Per Minute";
                case UnitToolsIrradianceUnit.MilliwattPerSquareMeter:
                    return "Milliwatt Per Square Meter";
                case UnitToolsIrradianceUnit.MicrowattPerSquareMeter:
                    return "Microwatt Per Square Meter";
                case UnitToolsIrradianceUnit.WattPerSquareFoot:
                    return "Watt Per Square Foot";
                case UnitToolsIrradianceUnit.WattPerSquareInch:
                    return "Watt Per Square Inch";
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return "Calorie Per Square Centimeter Minute";
                case UnitToolsIrradianceUnit.LangleyPerHour:
                    return "Langley Per Hour";
                case UnitToolsIrradianceUnit.NanowattPerSquareMeter:
                    return "Nanowatt Per Square Meter";
                case UnitToolsIrradianceUnit.MegawattPerSquareMeter:
                    return "Megawatt Per Square Meter";
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return "Calorie Per Square Centimeter Second";
                case UnitToolsIrradianceUnit.LangleyPerSecond:
                    return "Langley Per Second";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsIrradianceUnit unit)
        {
            switch (unit)
            {
                case UnitToolsIrradianceUnit.WattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.KilowattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.WattPerSquareCentimeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.LangleyPerMinute:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsIrradianceUnit.MilliwattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.MicrowattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.WattPerSquareFoot:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsIrradianceUnit.WattPerSquareInch:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.LangleyPerHour:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsIrradianceUnit.NanowattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.MegawattPerSquareMeter:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsIrradianceUnit.LangleyPerSecond:
                    return UnitToolsUnitSystem.Scientific;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsIrradianceUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsIrradianceUnit.WattPerSquareMeter, UnitToolsIrradianceUnit.KilowattPerSquareMeter, UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter, UnitToolsIrradianceUnit.WattPerSquareCentimeter, UnitToolsIrradianceUnit.MilliwattPerSquareMeter, UnitToolsIrradianceUnit.MicrowattPerSquareMeter, UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute, UnitToolsIrradianceUnit.NanowattPerSquareMeter, UnitToolsIrradianceUnit.MegawattPerSquareMeter, UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond };
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsIrradianceUnit.LangleyPerMinute, UnitToolsIrradianceUnit.LangleyPerHour, UnitToolsIrradianceUnit.LangleyPerSecond };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsIrradianceUnit.WattPerSquareFoot, UnitToolsIrradianceUnit.WattPerSquareInch };
                default:
                    return new[] { UnitToolsIrradianceUnit.WattPerSquareMeter, UnitToolsIrradianceUnit.KilowattPerSquareMeter, UnitToolsIrradianceUnit.MilliwattPerSquareCentimeter, UnitToolsIrradianceUnit.WattPerSquareCentimeter, UnitToolsIrradianceUnit.LangleyPerMinute, UnitToolsIrradianceUnit.MilliwattPerSquareMeter, UnitToolsIrradianceUnit.MicrowattPerSquareMeter, UnitToolsIrradianceUnit.WattPerSquareFoot, UnitToolsIrradianceUnit.WattPerSquareInch, UnitToolsIrradianceUnit.CaloriePerSquareCentimeterMinute, UnitToolsIrradianceUnit.LangleyPerHour, UnitToolsIrradianceUnit.NanowattPerSquareMeter, UnitToolsIrradianceUnit.MegawattPerSquareMeter, UnitToolsIrradianceUnit.CaloriePerSquareCentimeterSecond, UnitToolsIrradianceUnit.LangleyPerSecond };
            }
        }
    }
}
