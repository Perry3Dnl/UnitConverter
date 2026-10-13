namespace UnitTools.Snap
{
    using UnitTools.Snap.Metric;
    using UnitTools.Snap.Imperial;
    using UnitTools.Snap.Engineering;

    public enum UnitToolsSnapUnit
    {
        MeterPerSecondFourth = 0,
        CentimeterPerSecondFourth = 1,
        MillimeterPerSecondFourth = 2,
        FootPerSecondFourth = 3,
        KilometerPerSecondFourth = 4,
        DecimeterPerSecondFourth = 5,
        MicrometerPerSecondFourth = 6,
        InchPerSecondFourth = 7,
        YardPerSecondFourth = 8,
        StandardGravityPerSecondSquared = 9,
    }

    public static class UnitToolsSnap
    {
        public static double Convert(double value, UnitToolsSnapUnit from, UnitToolsSnapUnit to)
        {
            double baseValue = ToMeterPerSecondFourth(value, from);
            return FromMeterPerSecondFourth(baseValue, to);
        }

        public static double ToMeterPerSecondFourth(double value, UnitToolsSnapUnit from)
        {
            switch (from)
            {
                case UnitToolsSnapUnit.MeterPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.CentimeterPerSecondFourth:
                    return UnitToolsMetricSnap.CentimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.MillimeterPerSecondFourth:
                    return UnitToolsMetricSnap.MillimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.FootPerSecondFourth:
                    return UnitToolsImperialSnap.FootPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.KilometerPerSecondFourth:
                    return UnitToolsMetricSnap.KilometerPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.DecimeterPerSecondFourth:
                    return UnitToolsMetricSnap.DecimeterPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.MicrometerPerSecondFourth:
                    return UnitToolsMetricSnap.MicrometerPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.InchPerSecondFourth:
                    return UnitToolsImperialSnap.InchPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.YardPerSecondFourth:
                    return UnitToolsImperialSnap.YardPerSecondFourthToMeterPerSecondFourth(value);
                case UnitToolsSnapUnit.StandardGravityPerSecondSquared:
                    return UnitToolsEngineeringSnap.StandardGravityPerSecondSquaredToMeterPerSecondFourth(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported snap unit.");
            }
        }

        public static double FromMeterPerSecondFourth(double baseValue, UnitToolsSnapUnit to)
        {
            switch (to)
            {
                case UnitToolsSnapUnit.MeterPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToMeterPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.CentimeterPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToCentimeterPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.MillimeterPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToMillimeterPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.FootPerSecondFourth:
                    return UnitToolsImperialSnap.MeterPerSecondFourthToFootPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.KilometerPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToKilometerPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.DecimeterPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToDecimeterPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.MicrometerPerSecondFourth:
                    return UnitToolsMetricSnap.MeterPerSecondFourthToMicrometerPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.InchPerSecondFourth:
                    return UnitToolsImperialSnap.MeterPerSecondFourthToInchPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.YardPerSecondFourth:
                    return UnitToolsImperialSnap.MeterPerSecondFourthToYardPerSecondFourth(baseValue);
                case UnitToolsSnapUnit.StandardGravityPerSecondSquared:
                    return UnitToolsEngineeringSnap.MeterPerSecondFourthToStandardGravityPerSecondSquared(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported snap unit.");
            }
        }

        public static string GetSymbol(UnitToolsSnapUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSnapUnit.MeterPerSecondFourth:
                    return "m/s⁴";
                case UnitToolsSnapUnit.CentimeterPerSecondFourth:
                    return "cm/s⁴";
                case UnitToolsSnapUnit.MillimeterPerSecondFourth:
                    return "mm/s⁴";
                case UnitToolsSnapUnit.FootPerSecondFourth:
                    return "ft/s⁴";
                case UnitToolsSnapUnit.KilometerPerSecondFourth:
                    return "km/s⁴";
                case UnitToolsSnapUnit.DecimeterPerSecondFourth:
                    return "dm/s⁴";
                case UnitToolsSnapUnit.MicrometerPerSecondFourth:
                    return "µm/s⁴";
                case UnitToolsSnapUnit.InchPerSecondFourth:
                    return "in/s⁴";
                case UnitToolsSnapUnit.YardPerSecondFourth:
                    return "yd/s⁴";
                case UnitToolsSnapUnit.StandardGravityPerSecondSquared:
                    return "g₀/s²";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsSnapUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSnapUnit.MeterPerSecondFourth:
                    return "Meter Per Second Fourth";
                case UnitToolsSnapUnit.CentimeterPerSecondFourth:
                    return "Centimeter Per Second Fourth";
                case UnitToolsSnapUnit.MillimeterPerSecondFourth:
                    return "Millimeter Per Second Fourth";
                case UnitToolsSnapUnit.FootPerSecondFourth:
                    return "Foot Per Second Fourth";
                case UnitToolsSnapUnit.KilometerPerSecondFourth:
                    return "Kilometer Per Second Fourth";
                case UnitToolsSnapUnit.DecimeterPerSecondFourth:
                    return "Decimeter Per Second Fourth";
                case UnitToolsSnapUnit.MicrometerPerSecondFourth:
                    return "Micrometer Per Second Fourth";
                case UnitToolsSnapUnit.InchPerSecondFourth:
                    return "Inch Per Second Fourth";
                case UnitToolsSnapUnit.YardPerSecondFourth:
                    return "Yard Per Second Fourth";
                case UnitToolsSnapUnit.StandardGravityPerSecondSquared:
                    return "Standard Gravity Per Second Squared";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsSnapUnit unit)
        {
            switch (unit)
            {
                case UnitToolsSnapUnit.MeterPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.CentimeterPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.MillimeterPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.FootPerSecondFourth:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSnapUnit.KilometerPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.DecimeterPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.MicrometerPerSecondFourth:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsSnapUnit.InchPerSecondFourth:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSnapUnit.YardPerSecondFourth:
                    return UnitToolsUnitSystem.Imperial;
                case UnitToolsSnapUnit.StandardGravityPerSecondSquared:
                    return UnitToolsUnitSystem.Engineering;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsSnapUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsSnapUnit.MeterPerSecondFourth, UnitToolsSnapUnit.CentimeterPerSecondFourth, UnitToolsSnapUnit.MillimeterPerSecondFourth, UnitToolsSnapUnit.KilometerPerSecondFourth, UnitToolsSnapUnit.DecimeterPerSecondFourth, UnitToolsSnapUnit.MicrometerPerSecondFourth };
                case UnitToolsUnitSystem.Imperial:
                    return new[] { UnitToolsSnapUnit.FootPerSecondFourth, UnitToolsSnapUnit.InchPerSecondFourth, UnitToolsSnapUnit.YardPerSecondFourth };
                case UnitToolsUnitSystem.Engineering:
                    return new[] { UnitToolsSnapUnit.StandardGravityPerSecondSquared };
                default:
                    return new[] { UnitToolsSnapUnit.MeterPerSecondFourth, UnitToolsSnapUnit.CentimeterPerSecondFourth, UnitToolsSnapUnit.MillimeterPerSecondFourth, UnitToolsSnapUnit.FootPerSecondFourth, UnitToolsSnapUnit.KilometerPerSecondFourth, UnitToolsSnapUnit.DecimeterPerSecondFourth, UnitToolsSnapUnit.MicrometerPerSecondFourth, UnitToolsSnapUnit.InchPerSecondFourth, UnitToolsSnapUnit.YardPerSecondFourth, UnitToolsSnapUnit.StandardGravityPerSecondSquared };
            }
        }
    }
}
