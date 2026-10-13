namespace UnitTools.Angle
{
    using UnitTools.Angle.Scientific;
    using UnitTools.Angle.Common;
    using UnitTools.Angle.Metric;
    using UnitTools.Angle.Astronomical;
    using UnitTools.Angle.Historical;
    using UnitTools.Angle.Nautical;

    public enum UnitToolsAngleUnit
    {
        Arcsecond = 0,
        Arcminute = 1,
        Degree = 2,
        Radian = 3,
        Milliradian = 4,
        Gradian = 5,
        Turn = 6,
        Quadrant = 7,
        Microradian = 8,
        Nanoradian = 9,
        Milliarcsecond = 10,
        Microarcsecond = 11,
        HourAngle = 12,
        MinuteOfTime = 13,
        SecondOfTime = 14,
        NatoMil = 15,
        ArtilleryMil = 16,
        BinaryDegree = 17,
        Sextant = 18,
        Sign = 19,
        CompassPoint = 20,
    }

    public static class UnitToolsAngle
    {
        public static double Convert(double value, UnitToolsAngleUnit from, UnitToolsAngleUnit to)
        {
            double baseValue = ToDegree(value, from);
            return FromDegree(baseValue, to);
        }

        public static double ToDegree(double value, UnitToolsAngleUnit from)
        {
            switch (from)
            {
                case UnitToolsAngleUnit.Arcsecond:
                    return UnitToolsScientificAngle.ArcsecondToDegree(value);
                case UnitToolsAngleUnit.Arcminute:
                    return UnitToolsScientificAngle.ArcminuteToDegree(value);
                case UnitToolsAngleUnit.Degree:
                    return UnitToolsCommonAngle.DegreeToDegree(value);
                case UnitToolsAngleUnit.Radian:
                    return UnitToolsScientificAngle.RadianToDegree(value);
                case UnitToolsAngleUnit.Milliradian:
                    return UnitToolsScientificAngle.MilliradianToDegree(value);
                case UnitToolsAngleUnit.Gradian:
                    return UnitToolsMetricAngle.GradianToDegree(value);
                case UnitToolsAngleUnit.Turn:
                    return UnitToolsCommonAngle.TurnToDegree(value);
                case UnitToolsAngleUnit.Quadrant:
                    return UnitToolsCommonAngle.QuadrantToDegree(value);
                case UnitToolsAngleUnit.Microradian:
                    return UnitToolsMetricAngle.MicroradianToDegree(value);
                case UnitToolsAngleUnit.Nanoradian:
                    return UnitToolsMetricAngle.NanoradianToDegree(value);
                case UnitToolsAngleUnit.Milliarcsecond:
                    return UnitToolsMetricAngle.MilliarcsecondToDegree(value);
                case UnitToolsAngleUnit.Microarcsecond:
                    return UnitToolsMetricAngle.MicroarcsecondToDegree(value);
                case UnitToolsAngleUnit.HourAngle:
                    return UnitToolsAstronomicalAngle.HourAngleToDegree(value);
                case UnitToolsAngleUnit.MinuteOfTime:
                    return UnitToolsAstronomicalAngle.MinuteOfTimeToDegree(value);
                case UnitToolsAngleUnit.SecondOfTime:
                    return UnitToolsAstronomicalAngle.SecondOfTimeToDegree(value);
                case UnitToolsAngleUnit.NatoMil:
                    return UnitToolsMetricAngle.NatoMilToDegree(value);
                case UnitToolsAngleUnit.ArtilleryMil:
                    return UnitToolsMetricAngle.ArtilleryMilToDegree(value);
                case UnitToolsAngleUnit.BinaryDegree:
                    return UnitToolsMetricAngle.BinaryDegreeToDegree(value);
                case UnitToolsAngleUnit.Sextant:
                    return UnitToolsHistoricalAngle.SextantToDegree(value);
                case UnitToolsAngleUnit.Sign:
                    return UnitToolsHistoricalAngle.SignToDegree(value);
                case UnitToolsAngleUnit.CompassPoint:
                    return UnitToolsNauticalAngle.CompassPointToDegree(value);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(from), from, "Unsupported angle unit.");
            }
        }

        public static double FromDegree(double baseValue, UnitToolsAngleUnit to)
        {
            switch (to)
            {
                case UnitToolsAngleUnit.Arcsecond:
                    return UnitToolsScientificAngle.DegreeToArcsecond(baseValue);
                case UnitToolsAngleUnit.Arcminute:
                    return UnitToolsScientificAngle.DegreeToArcminute(baseValue);
                case UnitToolsAngleUnit.Degree:
                    return UnitToolsCommonAngle.DegreeToDegree(baseValue);
                case UnitToolsAngleUnit.Radian:
                    return UnitToolsScientificAngle.DegreeToRadian(baseValue);
                case UnitToolsAngleUnit.Milliradian:
                    return UnitToolsScientificAngle.DegreeToMilliradian(baseValue);
                case UnitToolsAngleUnit.Gradian:
                    return UnitToolsMetricAngle.DegreeToGradian(baseValue);
                case UnitToolsAngleUnit.Turn:
                    return UnitToolsCommonAngle.DegreeToTurn(baseValue);
                case UnitToolsAngleUnit.Quadrant:
                    return UnitToolsCommonAngle.DegreeToQuadrant(baseValue);
                case UnitToolsAngleUnit.Microradian:
                    return UnitToolsMetricAngle.DegreeToMicroradian(baseValue);
                case UnitToolsAngleUnit.Nanoradian:
                    return UnitToolsMetricAngle.DegreeToNanoradian(baseValue);
                case UnitToolsAngleUnit.Milliarcsecond:
                    return UnitToolsMetricAngle.DegreeToMilliarcsecond(baseValue);
                case UnitToolsAngleUnit.Microarcsecond:
                    return UnitToolsMetricAngle.DegreeToMicroarcsecond(baseValue);
                case UnitToolsAngleUnit.HourAngle:
                    return UnitToolsAstronomicalAngle.DegreeToHourAngle(baseValue);
                case UnitToolsAngleUnit.MinuteOfTime:
                    return UnitToolsAstronomicalAngle.DegreeToMinuteOfTime(baseValue);
                case UnitToolsAngleUnit.SecondOfTime:
                    return UnitToolsAstronomicalAngle.DegreeToSecondOfTime(baseValue);
                case UnitToolsAngleUnit.NatoMil:
                    return UnitToolsMetricAngle.DegreeToNatoMil(baseValue);
                case UnitToolsAngleUnit.ArtilleryMil:
                    return UnitToolsMetricAngle.DegreeToArtilleryMil(baseValue);
                case UnitToolsAngleUnit.BinaryDegree:
                    return UnitToolsMetricAngle.DegreeToBinaryDegree(baseValue);
                case UnitToolsAngleUnit.Sextant:
                    return UnitToolsHistoricalAngle.DegreeToSextant(baseValue);
                case UnitToolsAngleUnit.Sign:
                    return UnitToolsHistoricalAngle.DegreeToSign(baseValue);
                case UnitToolsAngleUnit.CompassPoint:
                    return UnitToolsNauticalAngle.DegreeToCompassPoint(baseValue);
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(to), to, "Unsupported angle unit.");
            }
        }

        public static string GetSymbol(UnitToolsAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngleUnit.Arcsecond:
                    return "arcsec";
                case UnitToolsAngleUnit.Arcminute:
                    return "arcmin";
                case UnitToolsAngleUnit.Degree:
                    return "°";
                case UnitToolsAngleUnit.Radian:
                    return "rad";
                case UnitToolsAngleUnit.Milliradian:
                    return "mrad";
                case UnitToolsAngleUnit.Gradian:
                    return "gon";
                case UnitToolsAngleUnit.Turn:
                    return "turn";
                case UnitToolsAngleUnit.Quadrant:
                    return "quadrant";
                case UnitToolsAngleUnit.Microradian:
                    return "µrad";
                case UnitToolsAngleUnit.Nanoradian:
                    return "nrad";
                case UnitToolsAngleUnit.Milliarcsecond:
                    return "mas";
                case UnitToolsAngleUnit.Microarcsecond:
                    return "µas";
                case UnitToolsAngleUnit.HourAngle:
                    return "h angle";
                case UnitToolsAngleUnit.MinuteOfTime:
                    return "min time";
                case UnitToolsAngleUnit.SecondOfTime:
                    return "s time";
                case UnitToolsAngleUnit.NatoMil:
                    return "NATO mil";
                case UnitToolsAngleUnit.ArtilleryMil:
                    return "art mil";
                case UnitToolsAngleUnit.BinaryDegree:
                    return "brad";
                case UnitToolsAngleUnit.Sextant:
                    return "sextant";
                case UnitToolsAngleUnit.Sign:
                    return "sign";
                case UnitToolsAngleUnit.CompassPoint:
                    return "point";
                default:
                    return "?";
            }
        }

        public static string GetDisplayName(UnitToolsAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngleUnit.Arcsecond:
                    return "arcsecond";
                case UnitToolsAngleUnit.Arcminute:
                    return "arcminute";
                case UnitToolsAngleUnit.Degree:
                    return "degree";
                case UnitToolsAngleUnit.Radian:
                    return "radian";
                case UnitToolsAngleUnit.Milliradian:
                    return "milliradian";
                case UnitToolsAngleUnit.Gradian:
                    return "gradian";
                case UnitToolsAngleUnit.Turn:
                    return "turn";
                case UnitToolsAngleUnit.Quadrant:
                    return "quadrant";
                case UnitToolsAngleUnit.Microradian:
                    return "Microradian";
                case UnitToolsAngleUnit.Nanoradian:
                    return "Nanoradian";
                case UnitToolsAngleUnit.Milliarcsecond:
                    return "Milliarcsecond";
                case UnitToolsAngleUnit.Microarcsecond:
                    return "Microarcsecond";
                case UnitToolsAngleUnit.HourAngle:
                    return "Hour Angle";
                case UnitToolsAngleUnit.MinuteOfTime:
                    return "Minute Of Time";
                case UnitToolsAngleUnit.SecondOfTime:
                    return "Second Of Time";
                case UnitToolsAngleUnit.NatoMil:
                    return "Nato Mil";
                case UnitToolsAngleUnit.ArtilleryMil:
                    return "Artillery Mil";
                case UnitToolsAngleUnit.BinaryDegree:
                    return "Binary Degree";
                case UnitToolsAngleUnit.Sextant:
                    return "Sextant";
                case UnitToolsAngleUnit.Sign:
                    return "Sign";
                case UnitToolsAngleUnit.CompassPoint:
                    return "Compass Point";
                default:
                    return unit.ToString();
            }
        }

        public static UnitToolsUnitSystem GetUnitSystem(UnitToolsAngleUnit unit)
        {
            switch (unit)
            {
                case UnitToolsAngleUnit.Arcsecond:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngleUnit.Arcminute:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngleUnit.Degree:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngleUnit.Radian:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngleUnit.Milliradian:
                    return UnitToolsUnitSystem.Scientific;
                case UnitToolsAngleUnit.Gradian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.Turn:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngleUnit.Quadrant:
                    return UnitToolsUnitSystem.Common;
                case UnitToolsAngleUnit.Microradian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.Nanoradian:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.Milliarcsecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.Microarcsecond:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.HourAngle:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsAngleUnit.MinuteOfTime:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsAngleUnit.SecondOfTime:
                    return UnitToolsUnitSystem.Astronomical;
                case UnitToolsAngleUnit.NatoMil:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.ArtilleryMil:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.BinaryDegree:
                    return UnitToolsUnitSystem.Metric;
                case UnitToolsAngleUnit.Sextant:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsAngleUnit.Sign:
                    return UnitToolsUnitSystem.Historical;
                case UnitToolsAngleUnit.CompassPoint:
                    return UnitToolsUnitSystem.Nautical;
                default:
                    return UnitToolsUnitSystem.Unknown;
            }
        }

        public static UnitToolsAngleUnit[] GetUnitsForSystem(UnitToolsUnitSystem unitSystem)
        {
            switch (unitSystem)
            {
                case UnitToolsUnitSystem.Scientific:
                    return new[] { UnitToolsAngleUnit.Arcsecond, UnitToolsAngleUnit.Arcminute, UnitToolsAngleUnit.Radian, UnitToolsAngleUnit.Milliradian };
                case UnitToolsUnitSystem.Common:
                    return new[] { UnitToolsAngleUnit.Degree, UnitToolsAngleUnit.Turn, UnitToolsAngleUnit.Quadrant };
                case UnitToolsUnitSystem.Metric:
                    return new[] { UnitToolsAngleUnit.Gradian, UnitToolsAngleUnit.Microradian, UnitToolsAngleUnit.Nanoradian, UnitToolsAngleUnit.Milliarcsecond, UnitToolsAngleUnit.Microarcsecond, UnitToolsAngleUnit.NatoMil, UnitToolsAngleUnit.ArtilleryMil, UnitToolsAngleUnit.BinaryDegree };
                case UnitToolsUnitSystem.Astronomical:
                    return new[] { UnitToolsAngleUnit.HourAngle, UnitToolsAngleUnit.MinuteOfTime, UnitToolsAngleUnit.SecondOfTime };
                case UnitToolsUnitSystem.Historical:
                    return new[] { UnitToolsAngleUnit.Sextant, UnitToolsAngleUnit.Sign };
                case UnitToolsUnitSystem.Nautical:
                    return new[] { UnitToolsAngleUnit.CompassPoint };
                default:
                    return new[] { UnitToolsAngleUnit.Arcsecond, UnitToolsAngleUnit.Arcminute, UnitToolsAngleUnit.Degree, UnitToolsAngleUnit.Radian, UnitToolsAngleUnit.Milliradian, UnitToolsAngleUnit.Gradian, UnitToolsAngleUnit.Turn, UnitToolsAngleUnit.Quadrant, UnitToolsAngleUnit.Microradian, UnitToolsAngleUnit.Nanoradian, UnitToolsAngleUnit.Milliarcsecond, UnitToolsAngleUnit.Microarcsecond, UnitToolsAngleUnit.HourAngle, UnitToolsAngleUnit.MinuteOfTime, UnitToolsAngleUnit.SecondOfTime, UnitToolsAngleUnit.NatoMil, UnitToolsAngleUnit.ArtilleryMil, UnitToolsAngleUnit.BinaryDegree, UnitToolsAngleUnit.Sextant, UnitToolsAngleUnit.Sign, UnitToolsAngleUnit.CompassPoint };
            }
        }
    }
}
