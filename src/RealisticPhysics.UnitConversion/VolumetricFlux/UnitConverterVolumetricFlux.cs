namespace RealisticPhysics.UnitConversion.VolumetricFlux
{
    using RealisticPhysics.UnitConversion.VolumetricFlux.Metric;
    using RealisticPhysics.UnitConversion.VolumetricFlux.Imperial;

    public enum UnitConverterVolumetricFluxUnit
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

    public static class UnitConverterVolumetricFlux
    {
        public static double Convert(double value, UnitConverterVolumetricFluxUnit from, UnitConverterVolumetricFluxUnit to)
        {
            double baseValue = ToMeterPerSecond(value, from);
            return FromMeterPerSecond(baseValue, to);
        }

        public static double ToMeterPerSecond(double value, UnitConverterVolumetricFluxUnit from)
        {
            switch (from)
            {
                case UnitConverterVolumetricFluxUnit.MeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.CentimeterPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.MillimeterPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.MeterPerHour:
                    return UnitConverterMetricVolumetricFlux.MeterPerHourToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.FootPerSecond:
                    return UnitConverterImperialVolumetricFlux.FootPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.FootPerMinute:
                    return UnitConverterImperialVolumetricFlux.FootPerMinuteToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitConverterMetricVolumetricFlux.MicrometerPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.MeterPerDay:
                    return UnitConverterMetricVolumetricFlux.MeterPerDayToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.MillimeterPerHour:
                    return UnitConverterMetricVolumetricFlux.MillimeterPerHourToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.CentimeterPerHour:
                    return UnitConverterMetricVolumetricFlux.CentimeterPerHourToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.InchPerSecond:
                    return UnitConverterImperialVolumetricFlux.InchPerSecondToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.InchPerMinute:
                    return UnitConverterImperialVolumetricFlux.InchPerMinuteToMeterPerSecond(value);
                case UnitConverterVolumetricFluxUnit.InchPerHour:
                    return UnitConverterImperialVolumetricFlux.InchPerHourToMeterPerSecond(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported volumetric flux unit.");
            }
        }

        public static double FromMeterPerSecond(double baseValue, UnitConverterVolumetricFluxUnit to)
        {
            switch (to)
            {
                case UnitConverterVolumetricFluxUnit.MeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMeterPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToCentimeterPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMillimeterPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.MeterPerHour:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMeterPerHour(baseValue);
                case UnitConverterVolumetricFluxUnit.FootPerSecond:
                    return UnitConverterImperialVolumetricFlux.MeterPerSecondToFootPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.FootPerMinute:
                    return UnitConverterImperialVolumetricFlux.MeterPerSecondToFootPerMinute(baseValue);
                case UnitConverterVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMicrometerPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.MeterPerDay:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMeterPerDay(baseValue);
                case UnitConverterVolumetricFluxUnit.MillimeterPerHour:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToMillimeterPerHour(baseValue);
                case UnitConverterVolumetricFluxUnit.CentimeterPerHour:
                    return UnitConverterMetricVolumetricFlux.MeterPerSecondToCentimeterPerHour(baseValue);
                case UnitConverterVolumetricFluxUnit.InchPerSecond:
                    return UnitConverterImperialVolumetricFlux.MeterPerSecondToInchPerSecond(baseValue);
                case UnitConverterVolumetricFluxUnit.InchPerMinute:
                    return UnitConverterImperialVolumetricFlux.MeterPerSecondToInchPerMinute(baseValue);
                case UnitConverterVolumetricFluxUnit.InchPerHour:
                    return UnitConverterImperialVolumetricFlux.MeterPerSecondToInchPerHour(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported volumetric flux unit.");
            }
        }

        public static string GetSymbol(UnitConverterVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFluxUnit.MeterPerSecond:
                    return "m/s";
                case UnitConverterVolumetricFluxUnit.CentimeterPerSecond:
                    return "cm/s";
                case UnitConverterVolumetricFluxUnit.MillimeterPerSecond:
                    return "mm/s";
                case UnitConverterVolumetricFluxUnit.MeterPerHour:
                    return "m/h";
                case UnitConverterVolumetricFluxUnit.FootPerSecond:
                    return "ft/s";
                case UnitConverterVolumetricFluxUnit.FootPerMinute:
                    return "ft/min";
                case UnitConverterVolumetricFluxUnit.MicrometerPerSecond:
                    return "µm/s";
                case UnitConverterVolumetricFluxUnit.MeterPerDay:
                    return "m/d";
                case UnitConverterVolumetricFluxUnit.MillimeterPerHour:
                    return "mm/h";
                case UnitConverterVolumetricFluxUnit.CentimeterPerHour:
                    return "cm/h";
                case UnitConverterVolumetricFluxUnit.InchPerSecond:
                    return "in/s";
                case UnitConverterVolumetricFluxUnit.InchPerMinute:
                    return "in/min";
                case UnitConverterVolumetricFluxUnit.InchPerHour:
                    return "in/h";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitConverterVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFluxUnit.MeterPerSecond:
                    return "Meter Per Second";
                case UnitConverterVolumetricFluxUnit.CentimeterPerSecond:
                    return "Centimeter Per Second";
                case UnitConverterVolumetricFluxUnit.MillimeterPerSecond:
                    return "Millimeter Per Second";
                case UnitConverterVolumetricFluxUnit.MeterPerHour:
                    return "Meter Per Hour";
                case UnitConverterVolumetricFluxUnit.FootPerSecond:
                    return "Foot Per Second";
                case UnitConverterVolumetricFluxUnit.FootPerMinute:
                    return "Foot Per Minute";
                case UnitConverterVolumetricFluxUnit.MicrometerPerSecond:
                    return "Micrometer Per Second";
                case UnitConverterVolumetricFluxUnit.MeterPerDay:
                    return "Meter Per Day";
                case UnitConverterVolumetricFluxUnit.MillimeterPerHour:
                    return "Millimeter Per Hour";
                case UnitConverterVolumetricFluxUnit.CentimeterPerHour:
                    return "Centimeter Per Hour";
                case UnitConverterVolumetricFluxUnit.InchPerSecond:
                    return "Inch Per Second";
                case UnitConverterVolumetricFluxUnit.InchPerMinute:
                    return "Inch Per Minute";
                case UnitConverterVolumetricFluxUnit.InchPerHour:
                    return "Inch Per Hour";
                default:
                    return unit.ToString();
            }
        }

        public static UnitConverterUnitSystem GetUnitSystem(UnitConverterVolumetricFluxUnit unit)
        {
            switch (unit)
            {
                case UnitConverterVolumetricFluxUnit.MeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.CentimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.MillimeterPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.MeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.FootPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFluxUnit.FootPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFluxUnit.MicrometerPerSecond:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.MeterPerDay:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.MillimeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.CentimeterPerHour:
                    return UnitConverterUnitSystem.Metric;
                case UnitConverterVolumetricFluxUnit.InchPerSecond:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFluxUnit.InchPerMinute:
                    return UnitConverterUnitSystem.Imperial;
                case UnitConverterVolumetricFluxUnit.InchPerHour:
                    return UnitConverterUnitSystem.Imperial;
                default:
                    return UnitConverterUnitSystem.Unknown;
            }
        }

        public static UnitConverterVolumetricFluxUnit[] GetUnitsForSystem(UnitConverterUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitConverterUnitSystem.Metric:
                    return new[] { UnitConverterVolumetricFluxUnit.MeterPerSecond, UnitConverterVolumetricFluxUnit.CentimeterPerSecond, UnitConverterVolumetricFluxUnit.MillimeterPerSecond, UnitConverterVolumetricFluxUnit.MeterPerHour, UnitConverterVolumetricFluxUnit.MicrometerPerSecond, UnitConverterVolumetricFluxUnit.MeterPerDay, UnitConverterVolumetricFluxUnit.MillimeterPerHour, UnitConverterVolumetricFluxUnit.CentimeterPerHour };
                case UnitConverterUnitSystem.Imperial:
                    return new[] { UnitConverterVolumetricFluxUnit.FootPerSecond, UnitConverterVolumetricFluxUnit.FootPerMinute, UnitConverterVolumetricFluxUnit.InchPerSecond, UnitConverterVolumetricFluxUnit.InchPerMinute, UnitConverterVolumetricFluxUnit.InchPerHour };
                default:
                    return new[] { UnitConverterVolumetricFluxUnit.MeterPerSecond, UnitConverterVolumetricFluxUnit.CentimeterPerSecond, UnitConverterVolumetricFluxUnit.MillimeterPerSecond, UnitConverterVolumetricFluxUnit.MeterPerHour, UnitConverterVolumetricFluxUnit.FootPerSecond, UnitConverterVolumetricFluxUnit.FootPerMinute, UnitConverterVolumetricFluxUnit.MicrometerPerSecond, UnitConverterVolumetricFluxUnit.MeterPerDay, UnitConverterVolumetricFluxUnit.MillimeterPerHour, UnitConverterVolumetricFluxUnit.CentimeterPerHour, UnitConverterVolumetricFluxUnit.InchPerSecond, UnitConverterVolumetricFluxUnit.InchPerMinute, UnitConverterVolumetricFluxUnit.InchPerHour };
            }
        }
    }
}
