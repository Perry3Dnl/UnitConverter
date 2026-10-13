namespace UnitTools.VolumetricFlux
{
    using UnitTools.VolumetricFlux.Metric;
    using UnitTools.VolumetricFlux.Imperial;

    public enum UnitToolsVolumetricFluxUnit
    {
        MeterPerSecond = 0,
        CentimeterPerSecond = 1,
        MillimeterPerSecond = 2,
        MeterPerHour = 3,
        FootPerSecond = 4,
        FootPerMinute = 5,
        MicrometerPerSecond = 6,
        MeterPerDay = 7,
        MillimeterPerHour = 8,
        CentimeterPerHour = 9,
        InchPerSecond = 10,
        InchPerMinute = 11,
        InchPerHour = 12,
    }

    public static class UnitToolsVolumetricFlux
    {
        public static double Convert(double value, UnitToolsVolumetricFluxUnit from, UnitToolsVolumetricFluxUnit to)
        {
            double baseValue = ToMeterPerSecond(value, from);
            return FromMeterPerSecond(baseValue, to);
        }

        public static double ToMeterPerSecond(double value, UnitToolsVolumetricFluxUnit from)
        {
            switch (from)
            {
                case UnitToolsVolumetricFluxUnit.MeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.CentimeterPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.MillimeterPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.MeterPerHour:
                    return UnitToolsMetricVolumetricFlux.MeterPerHourToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.FootPerSecond:
                    return UnitToolsImperialVolumetricFlux.FootPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.FootPerMinute:
                    return UnitToolsImperialVolumetricFlux.FootPerMinuteToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitToolsMetricVolumetricFlux.MicrometerPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.MeterPerDay:
                    return UnitToolsMetricVolumetricFlux.MeterPerDayToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.MillimeterPerHour:
                    return UnitToolsMetricVolumetricFlux.MillimeterPerHourToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.CentimeterPerHour:
                    return UnitToolsMetricVolumetricFlux.CentimeterPerHourToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.InchPerSecond:
                    return UnitToolsImperialVolumetricFlux.InchPerSecondToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.InchPerMinute:
                    return UnitToolsImperialVolumetricFlux.InchPerMinuteToMeterPerSecond(value);
                case UnitToolsVolumetricFluxUnit.InchPerHour:
                    return UnitToolsImperialVolumetricFlux.InchPerHourToMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volumetric flux unit.");
            }
        }

        public static double FromMeterPerSecond(double baseValue, UnitToolsVolumetricFluxUnit to)
        {
            switch (to)
            {
                case UnitToolsVolumetricFluxUnit.MeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMeterPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToCentimeterPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMillimeterPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.MeterPerHour:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMeterPerHour(baseValue);
                case UnitToolsVolumetricFluxUnit.FootPerSecond:
                    return UnitToolsImperialVolumetricFlux.MeterPerSecondToFootPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.FootPerMinute:
                    return UnitToolsImperialVolumetricFlux.MeterPerSecondToFootPerMinute(baseValue);
                case UnitToolsVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMicrometerPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.MeterPerDay:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMeterPerDay(baseValue);
                case UnitToolsVolumetricFluxUnit.MillimeterPerHour:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToMillimeterPerHour(baseValue);
                case UnitToolsVolumetricFluxUnit.CentimeterPerHour:
                    return UnitToolsMetricVolumetricFlux.MeterPerSecondToCentimeterPerHour(baseValue);
                case UnitToolsVolumetricFluxUnit.InchPerSecond:
                    return UnitToolsImperialVolumetricFlux.MeterPerSecondToInchPerSecond(baseValue);
                case UnitToolsVolumetricFluxUnit.InchPerMinute:
                    return UnitToolsImperialVolumetricFlux.MeterPerSecondToInchPerMinute(baseValue);
                case UnitToolsVolumetricFluxUnit.InchPerHour:
                    return UnitToolsImperialVolumetricFlux.MeterPerSecondToInchPerHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volumetric flux unit.");
            }
        }

        public static string GetSymbol(UnitToolsVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFluxUnit.MeterPerSecond:
                    return "m/s";
                case UnitToolsVolumetricFluxUnit.CentimeterPerSecond:
                    return "cm/s";
                case UnitToolsVolumetricFluxUnit.MillimeterPerSecond:
                    return "mm/s";
                case UnitToolsVolumetricFluxUnit.MeterPerHour:
                    return "m/h";
                case UnitToolsVolumetricFluxUnit.FootPerSecond:
                    return "ft/s";
                case UnitToolsVolumetricFluxUnit.FootPerMinute:
                    return "ft/min";
                case UnitToolsVolumetricFluxUnit.MicrometerPerSecond:
                    return "µm/s";
                case UnitToolsVolumetricFluxUnit.MeterPerDay:
                    return "m/d";
                case UnitToolsVolumetricFluxUnit.MillimeterPerHour:
                    return "mm/h";
                case UnitToolsVolumetricFluxUnit.CentimeterPerHour:
                    return "cm/h";
                case UnitToolsVolumetricFluxUnit.InchPerSecond:
                    return "in/s";
                case UnitToolsVolumetricFluxUnit.InchPerMinute:
                    return "in/min";
                case UnitToolsVolumetricFluxUnit.InchPerHour:
                    return "in/h";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFluxUnit.MeterPerSecond:
                    return "Meter Per Second";
                case UnitToolsVolumetricFluxUnit.CentimeterPerSecond:
                    return "Centimeter Per Second";
                case UnitToolsVolumetricFluxUnit.MillimeterPerSecond:
                    return "Millimeter Per Second";
                case UnitToolsVolumetricFluxUnit.MeterPerHour:
                    return "Meter Per Hour";
                case UnitToolsVolumetricFluxUnit.FootPerSecond:
                    return "Foot Per Second";
                case UnitToolsVolumetricFluxUnit.FootPerMinute:
                    return "Foot Per Minute";
                case UnitToolsVolumetricFluxUnit.MicrometerPerSecond:
                    return "Micrometer Per Second";
                case UnitToolsVolumetricFluxUnit.MeterPerDay:
                    return "Meter Per Day";
                case UnitToolsVolumetricFluxUnit.MillimeterPerHour:
                    return "Millimeter Per Hour";
                case UnitToolsVolumetricFluxUnit.CentimeterPerHour:
                    return "Centimeter Per Hour";
                case UnitToolsVolumetricFluxUnit.InchPerSecond:
                    return "Inch Per Second";
                case UnitToolsVolumetricFluxUnit.InchPerMinute:
                    return "Inch Per Minute";
                case UnitToolsVolumetricFluxUnit.InchPerHour:
                    return "Inch Per Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitToolsVolumetricFluxUnit.MeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.MeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.FootPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFluxUnit.FootPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.MeterPerDay:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.MillimeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.CentimeterPerHour:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsVolumetricFluxUnit.InchPerSecond:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFluxUnit.InchPerMinute:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsVolumetricFluxUnit.InchPerHour:
                    return UnitToolsUnitSystem.Imperial;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsVolumetricFluxUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsVolumetricFluxUnit.MeterPerSecond, UnitToolsVolumetricFluxUnit.CentimeterPerSecond, UnitToolsVolumetricFluxUnit.MillimeterPerSecond, UnitToolsVolumetricFluxUnit.MeterPerHour, UnitToolsVolumetricFluxUnit.MicrometerPerSecond, UnitToolsVolumetricFluxUnit.MeterPerDay, UnitToolsVolumetricFluxUnit.MillimeterPerHour, UnitToolsVolumetricFluxUnit.CentimeterPerHour };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsVolumetricFluxUnit.FootPerSecond, UnitToolsVolumetricFluxUnit.FootPerMinute, UnitToolsVolumetricFluxUnit.InchPerSecond, UnitToolsVolumetricFluxUnit.InchPerMinute, UnitToolsVolumetricFluxUnit.InchPerHour };
                default:
                    return new[] { UnitToolsVolumetricFluxUnit.MeterPerSecond, UnitToolsVolumetricFluxUnit.CentimeterPerSecond, UnitToolsVolumetricFluxUnit.MillimeterPerSecond, UnitToolsVolumetricFluxUnit.MeterPerHour, UnitToolsVolumetricFluxUnit.FootPerSecond, UnitToolsVolumetricFluxUnit.FootPerMinute, UnitToolsVolumetricFluxUnit.MicrometerPerSecond, UnitToolsVolumetricFluxUnit.MeterPerDay, UnitToolsVolumetricFluxUnit.MillimeterPerHour, UnitToolsVolumetricFluxUnit.CentimeterPerHour, UnitToolsVolumetricFluxUnit.InchPerSecond, UnitToolsVolumetricFluxUnit.InchPerMinute, UnitToolsVolumetricFluxUnit.InchPerHour };
            }
        }
    }
}
