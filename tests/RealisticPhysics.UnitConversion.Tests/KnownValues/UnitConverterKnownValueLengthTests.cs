namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Length;

    public sealed class UnitConverterKnownValueLengthTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Length_ToBaseUnit_ReturnsExpectedValue(UnitConverterLengthUnit unit, double input, double expected)
        {
            double result = UnitConverterLength.ToMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Length_FromBaseUnit_ReturnsExpectedValue(UnitConverterLengthUnit unit, double input, double expected)
        {
            double result = UnitConverterLength.FromMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Length_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterLengthUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterLength.ToMeter(input, unit);
            double result = UnitConverterLength.FromMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterLengthUnit.Femtometer, 1d, 1.0000000000000001e-15d).SetName("Length_ToBase_Femtometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Picometer, 1d, 9.9999999999999998e-13d).SetName("Length_ToBase_Picometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Nanometer, 1d, 1.0000000000000001e-09d).SetName("Length_ToBase_Nanometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Micrometer, 1d, 9.9999999999999995e-07d).SetName("Length_ToBase_Micrometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Millimeter, 1d, 0.001d).SetName("Length_ToBase_Millimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Centimeter, 1d, 0.01d).SetName("Length_ToBase_Centimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Decimeter, 1d, 0.10000000000000001d).SetName("Length_ToBase_Decimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Meter, 1d, 1.0d).SetName("Length_ToBase_Meter");
            yield return new TestCaseData(UnitConverterLengthUnit.Decameter, 1d, 10.0d).SetName("Length_ToBase_Decameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Hectometer, 1d, 100.0d).SetName("Length_ToBase_Hectometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Kilometer, 1d, 1000.0d).SetName("Length_ToBase_Kilometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Megameter, 1d, 1000000.0d).SetName("Length_ToBase_Megameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Gigameter, 1d, 1000000000.0d).SetName("Length_ToBase_Gigameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Angstrom, 1d, 1e-10d).SetName("Length_ToBase_Angstrom");
            yield return new TestCaseData(UnitConverterLengthUnit.Thou, 1d, 2.5400000000000001e-05d).SetName("Length_ToBase_Thou");
            yield return new TestCaseData(UnitConverterLengthUnit.Inch, 1d, 0.025399999999999999d).SetName("Length_ToBase_Inch");
            yield return new TestCaseData(UnitConverterLengthUnit.Foot, 1d, 0.30480000000000002d).SetName("Length_ToBase_Foot");
            yield return new TestCaseData(UnitConverterLengthUnit.Yard, 1d, 0.91439999999999999d).SetName("Length_ToBase_Yard");
            yield return new TestCaseData(UnitConverterLengthUnit.Mile, 1d, 1609.3440000000001d).SetName("Length_ToBase_Mile");
            yield return new TestCaseData(UnitConverterLengthUnit.League, 1d, 4828.0320000000002d).SetName("Length_ToBase_League");
            yield return new TestCaseData(UnitConverterLengthUnit.Hand, 1d, 0.1016d).SetName("Length_ToBase_Hand");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyInch, 1d, 0.0254000508001016d).SetName("Length_ToBase_USSurveyInch");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyFoot, 1d, 0.30480060960121919d).SetName("Length_ToBase_USSurveyFoot");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyYard, 1d, 0.91440182880365761d).SetName("Length_ToBase_USSurveyYard");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyMile, 1d, 1609.3472186944373d).SetName("Length_ToBase_USSurveyMile");
            yield return new TestCaseData(UnitConverterLengthUnit.Link, 1d, 0.20116800000000001d).SetName("Length_ToBase_Link");
            yield return new TestCaseData(UnitConverterLengthUnit.Rod, 1d, 5.0292000000000003d).SetName("Length_ToBase_Rod");
            yield return new TestCaseData(UnitConverterLengthUnit.Chain, 1d, 20.116800000000001d).SetName("Length_ToBase_Chain");
            yield return new TestCaseData(UnitConverterLengthUnit.Furlong, 1d, 201.16800000000001d).SetName("Length_ToBase_Furlong");
            yield return new TestCaseData(UnitConverterLengthUnit.Fathom, 1d, 1.8288d).SetName("Length_ToBase_Fathom");
            yield return new TestCaseData(UnitConverterLengthUnit.Cable, 1d, 185.19999999999999d).SetName("Length_ToBase_Cable");
            yield return new TestCaseData(UnitConverterLengthUnit.NauticalMile, 1d, 1852.0d).SetName("Length_ToBase_NauticalMile");
            yield return new TestCaseData(UnitConverterLengthUnit.AstronomicalUnit, 1d, 149597870700.0d).SetName("Length_ToBase_AstronomicalUnit");
            yield return new TestCaseData(UnitConverterLengthUnit.LightYear, 1d, 9460730472580800.0d).SetName("Length_ToBase_LightYear");
            yield return new TestCaseData(UnitConverterLengthUnit.Parsec, 1d, 30856775814913672.0d).SetName("Length_ToBase_Parsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Cubit, 1d, 0.4572d).SetName("Length_ToBase_Cubit");
            yield return new TestCaseData(UnitConverterLengthUnit.Span, 1d, 0.2286d).SetName("Length_ToBase_Span");
            yield return new TestCaseData(UnitConverterLengthUnit.Pace, 1d, 0.76200000000000001d).SetName("Length_ToBase_Pace");
            yield return new TestCaseData(UnitConverterLengthUnit.Ell, 1d, 1.143d).SetName("Length_ToBase_Ell");
            yield return new TestCaseData(UnitConverterLengthUnit.Quectometer, 1d, 1.0000000000000001e-30d).SetName("Length_ToBase_Quectometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Rontometer, 1d, 1e-27d).SetName("Length_ToBase_Rontometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Yoctometer, 1d, 9.9999999999999992e-25d).SetName("Length_ToBase_Yoctometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Zeptometer, 1d, 9.9999999999999991e-22d).SetName("Length_ToBase_Zeptometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Attometer, 1d, 1.0000000000000001e-18d).SetName("Length_ToBase_Attometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Petameter, 1d, 1000000000000000.0d).SetName("Length_ToBase_Petameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Exameter, 1d, 1e+18d).SetName("Length_ToBase_Exameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Zettameter, 1d, 1e+21d).SetName("Length_ToBase_Zettameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Yottameter, 1d, 9.9999999999999998e+23d).SetName("Length_ToBase_Yottameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Ronnameter, 1d, 1e+27d).SetName("Length_ToBase_Ronnameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Quettameter, 1d, 1e+30d).SetName("Length_ToBase_Quettameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Fermi, 1d, 1.0000000000000001e-15d).SetName("Length_ToBase_Fermi");
            yield return new TestCaseData(UnitConverterLengthUnit.BohrRadius, 1d, 5.2917721090299998e-11d).SetName("Length_ToBase_BohrRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.PlanckLength, 1d, 1.6162550000000001e-35d).SetName("Length_ToBase_PlanckLength");
            yield return new TestCaseData(UnitConverterLengthUnit.ClassicalElectronRadius, 1d, 2.8179403262e-15d).SetName("Length_ToBase_ClassicalElectronRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.EarthEquatorialRadius, 1d, 6378137.0d).SetName("Length_ToBase_EarthEquatorialRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.EarthMeanRadius, 1d, 6371008.7999999998d).SetName("Length_ToBase_EarthMeanRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.SolarRadius, 1d, 695700000.0d).SetName("Length_ToBase_SolarRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.LunarDistance, 1d, 384400000.0d).SetName("Length_ToBase_LunarDistance");
            yield return new TestCaseData(UnitConverterLengthUnit.PointPostScript, 1d, 0.00035277777777777776d).SetName("Length_ToBase_PointPostScript");
            yield return new TestCaseData(UnitConverterLengthUnit.PicaPostScript, 1d, 0.0042333333333333329d).SetName("Length_ToBase_PicaPostScript");
            yield return new TestCaseData(UnitConverterLengthUnit.DidotPoint, 1d, 0.0003759715104d).SetName("Length_ToBase_DidotPoint");
            yield return new TestCaseData(UnitConverterLengthUnit.Cicero, 1d, 0.0045116581248000002d).SetName("Length_ToBase_Cicero");
            yield return new TestCaseData(UnitConverterLengthUnit.Barleycorn, 1d, 0.0084666666666666657d).SetName("Length_ToBase_Barleycorn");
            yield return new TestCaseData(UnitConverterLengthUnit.Nail, 1d, 0.057149999999999999d).SetName("Length_ToBase_Nail");
            yield return new TestCaseData(UnitConverterLengthUnit.Palm, 1d, 0.076200000000000004d).SetName("Length_ToBase_Palm");
            yield return new TestCaseData(UnitConverterLengthUnit.RomanFoot, 1d, 0.29599999999999999d).SetName("Length_ToBase_RomanFoot");
            yield return new TestCaseData(UnitConverterLengthUnit.Arshin, 1d, 0.71120000000000005d).SetName("Length_ToBase_Arshin");
            yield return new TestCaseData(UnitConverterLengthUnit.Vara, 1d, 0.83590500000000001d).SetName("Length_ToBase_Vara");
            yield return new TestCaseData(UnitConverterLengthUnit.Smoot, 1d, 1.7018d).SetName("Length_ToBase_Smoot");
            yield return new TestCaseData(UnitConverterLengthUnit.NauticalLeague, 1d, 5556.0d).SetName("Length_ToBase_NauticalLeague");
            yield return new TestCaseData(UnitConverterLengthUnit.Twip, 1d, 1.7638888888888889e-05d).SetName("Length_ToBase_Twip");
            yield return new TestCaseData(UnitConverterLengthUnit.PrinterPoint, 1d, 0.00035145980351459799d).SetName("Length_ToBase_PrinterPoint");
            yield return new TestCaseData(UnitConverterLengthUnit.PrinterPica, 1d, 0.0042175176421751764d).SetName("Length_ToBase_PrinterPica");
            yield return new TestCaseData(UnitConverterLengthUnit.Ken, 1d, 1.818181818d).SetName("Length_ToBase_Ken");
            yield return new TestCaseData(UnitConverterLengthUnit.Shaku, 1d, 0.303030303d).SetName("Length_ToBase_Shaku");
            yield return new TestCaseData(UnitConverterLengthUnit.Ri, 1d, 3927.272727d).SetName("Length_ToBase_Ri");
            yield return new TestCaseData(UnitConverterLengthUnit.LiChinese, 1d, 500.0d).SetName("Length_ToBase_LiChinese");
            yield return new TestCaseData(UnitConverterLengthUnit.ChiChinese, 1d, 0.33333333333333331d).SetName("Length_ToBase_ChiChinese");
            yield return new TestCaseData(UnitConverterLengthUnit.Kiloparsec, 1d, 3.0856775814913671e+19d).SetName("Length_ToBase_Kiloparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Megaparsec, 1d, 3.0856775814913672e+22d).SetName("Length_ToBase_Megaparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Gigaparsec, 1d, 3.0856775814913673e+25d).SetName("Length_ToBase_Gigaparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.LightSecond, 1d, 299792458.0d).SetName("Length_ToBase_LightSecond");
            yield return new TestCaseData(UnitConverterLengthUnit.LightMinute, 1d, 17987547480.0d).SetName("Length_ToBase_LightMinute");
            yield return new TestCaseData(UnitConverterLengthUnit.LightHour, 1d, 1079252848800.0d).SetName("Length_ToBase_LightHour");
            yield return new TestCaseData(UnitConverterLengthUnit.LightDay, 1d, 25902068371200.0d).SetName("Length_ToBase_LightDay");
            yield return new TestCaseData(UnitConverterLengthUnit.LightWeek, 1d, 181314478598400.0d).SetName("Length_ToBase_LightWeek");
            yield return new TestCaseData(UnitConverterLengthUnit.Microinch, 1d, 2.5399999999999999e-08d).SetName("Length_ToBase_Microinch");
            yield return new TestCaseData(UnitConverterLengthUnit.Nanoinch, 1d, 2.5400000000000001e-11d).SetName("Length_ToBase_Nanoinch");
            yield return new TestCaseData(UnitConverterLengthUnit.Caliber, 1d, 0.00025399999999999999d).SetName("Length_ToBase_Caliber");
            yield return new TestCaseData(UnitConverterLengthUnit.RackUnit, 1d, 0.044450000000000003d).SetName("Length_ToBase_RackUnit");
            yield return new TestCaseData(UnitConverterLengthUnit.Quarter, 1d, 0.2286d).SetName("Length_ToBase_Quarter");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterLengthUnit.Femtometer, 1d, 999999999999999.88d).SetName("Length_FromBase_Femtometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Picometer, 1d, 1000000000000.0d).SetName("Length_FromBase_Picometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Nanometer, 1d, 999999999.99999988d).SetName("Length_FromBase_Nanometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Micrometer, 1d, 1000000.0d).SetName("Length_FromBase_Micrometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Millimeter, 1d, 1000.0d).SetName("Length_FromBase_Millimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Centimeter, 1d, 100.0d).SetName("Length_FromBase_Centimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Decimeter, 1d, 10.0d).SetName("Length_FromBase_Decimeter");
            yield return new TestCaseData(UnitConverterLengthUnit.Meter, 1d, 1.0d).SetName("Length_FromBase_Meter");
            yield return new TestCaseData(UnitConverterLengthUnit.Decameter, 1d, 0.10000000000000001d).SetName("Length_FromBase_Decameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Hectometer, 1d, 0.01d).SetName("Length_FromBase_Hectometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Kilometer, 1d, 0.001d).SetName("Length_FromBase_Kilometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Megameter, 1d, 9.9999999999999995e-07d).SetName("Length_FromBase_Megameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Gigameter, 1d, 1.0000000000000001e-09d).SetName("Length_FromBase_Gigameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Angstrom, 1d, 10000000000.0d).SetName("Length_FromBase_Angstrom");
            yield return new TestCaseData(UnitConverterLengthUnit.Thou, 1d, 39370.078740157478d).SetName("Length_FromBase_Thou");
            yield return new TestCaseData(UnitConverterLengthUnit.Inch, 1d, 39.370078740157481d).SetName("Length_FromBase_Inch");
            yield return new TestCaseData(UnitConverterLengthUnit.Foot, 1d, 3.280839895013123d).SetName("Length_FromBase_Foot");
            yield return new TestCaseData(UnitConverterLengthUnit.Yard, 1d, 1.0936132983377078d).SetName("Length_FromBase_Yard");
            yield return new TestCaseData(UnitConverterLengthUnit.Mile, 1d, 0.00062137119223733392d).SetName("Length_FromBase_Mile");
            yield return new TestCaseData(UnitConverterLengthUnit.League, 1d, 0.00020712373074577799d).SetName("Length_FromBase_League");
            yield return new TestCaseData(UnitConverterLengthUnit.Hand, 1d, 9.8425196850393704d).SetName("Length_FromBase_Hand");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyInch, 1d, 39.369999999999997d).SetName("Length_FromBase_USSurveyInch");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyFoot, 1d, 3.2808333333333337d).SetName("Length_FromBase_USSurveyFoot");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyYard, 1d, 1.0936111111111111d).SetName("Length_FromBase_USSurveyYard");
            yield return new TestCaseData(UnitConverterLengthUnit.USSurveyMile, 1d, 0.00062136994949494955d).SetName("Length_FromBase_USSurveyMile");
            yield return new TestCaseData(UnitConverterLengthUnit.Link, 1d, 4.9709695378986716d).SetName("Length_FromBase_Link");
            yield return new TestCaseData(UnitConverterLengthUnit.Rod, 1d, 0.19883878151594686d).SetName("Length_FromBase_Rod");
            yield return new TestCaseData(UnitConverterLengthUnit.Chain, 1d, 0.049709695378986715d).SetName("Length_FromBase_Chain");
            yield return new TestCaseData(UnitConverterLengthUnit.Furlong, 1d, 0.0049709695378986713d).SetName("Length_FromBase_Furlong");
            yield return new TestCaseData(UnitConverterLengthUnit.Fathom, 1d, 0.54680664916885391d).SetName("Length_FromBase_Fathom");
            yield return new TestCaseData(UnitConverterLengthUnit.Cable, 1d, 0.005399568034557236d).SetName("Length_FromBase_Cable");
            yield return new TestCaseData(UnitConverterLengthUnit.NauticalMile, 1d, 0.00053995680345572358d).SetName("Length_FromBase_NauticalMile");
            yield return new TestCaseData(UnitConverterLengthUnit.AstronomicalUnit, 1d, 6.6845871222684451e-12d).SetName("Length_FromBase_AstronomicalUnit");
            yield return new TestCaseData(UnitConverterLengthUnit.LightYear, 1d, 1.0570008340246154e-16d).SetName("Length_FromBase_LightYear");
            yield return new TestCaseData(UnitConverterLengthUnit.Parsec, 1d, 3.240779289444365e-17d).SetName("Length_FromBase_Parsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Cubit, 1d, 2.1872265966754156d).SetName("Length_FromBase_Cubit");
            yield return new TestCaseData(UnitConverterLengthUnit.Span, 1d, 4.3744531933508313d).SetName("Length_FromBase_Span");
            yield return new TestCaseData(UnitConverterLengthUnit.Pace, 1d, 1.3123359580052494d).SetName("Length_FromBase_Pace");
            yield return new TestCaseData(UnitConverterLengthUnit.Ell, 1d, 0.87489063867016625d).SetName("Length_FromBase_Ell");
            yield return new TestCaseData(UnitConverterLengthUnit.Quectometer, 1d, 9.9999999999999988e+29d).SetName("Length_FromBase_Quectometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Rontometer, 1d, 1e+27d).SetName("Length_FromBase_Rontometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Yoctometer, 1d, 1.0000000000000001e+24d).SetName("Length_FromBase_Yoctometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Zeptometer, 1d, 1.0000000000000001e+21d).SetName("Length_FromBase_Zeptometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Attometer, 1d, 9.9999999999999987e+17d).SetName("Length_FromBase_Attometer");
            yield return new TestCaseData(UnitConverterLengthUnit.Petameter, 1d, 1.0000000000000001e-15d).SetName("Length_FromBase_Petameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Exameter, 1d, 1.0000000000000001e-18d).SetName("Length_FromBase_Exameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Zettameter, 1d, 9.9999999999999991e-22d).SetName("Length_FromBase_Zettameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Yottameter, 1d, 1.0000000000000001e-24d).SetName("Length_FromBase_Yottameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Ronnameter, 1d, 1e-27d).SetName("Length_FromBase_Ronnameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Quettameter, 1d, 9.9999999999999991e-31d).SetName("Length_FromBase_Quettameter");
            yield return new TestCaseData(UnitConverterLengthUnit.Fermi, 1d, 999999999999999.88d).SetName("Length_FromBase_Fermi");
            yield return new TestCaseData(UnitConverterLengthUnit.BohrRadius, 1d, 18897261246.257702d).SetName("Length_FromBase_BohrRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.PlanckLength, 1d, 6.1871424991724697e+34d).SetName("Length_FromBase_PlanckLength");
            yield return new TestCaseData(UnitConverterLengthUnit.ClassicalElectronRadius, 1d, 354869118661750.62d).SetName("Length_FromBase_ClassicalElectronRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.EarthEquatorialRadius, 1d, 1.5678559428873979e-07d).SetName("Length_FromBase_EarthEquatorialRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.EarthMeanRadius, 1d, 1.5696101377226164e-07d).SetName("Length_FromBase_EarthMeanRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.SolarRadius, 1d, 1.4374011786689664e-09d).SetName("Length_FromBase_SolarRadius");
            yield return new TestCaseData(UnitConverterLengthUnit.LunarDistance, 1d, 2.6014568158168576e-09d).SetName("Length_FromBase_LunarDistance");
            yield return new TestCaseData(UnitConverterLengthUnit.PointPostScript, 1d, 2834.6456692913389d).SetName("Length_FromBase_PointPostScript");
            yield return new TestCaseData(UnitConverterLengthUnit.PicaPostScript, 1d, 236.22047244094492d).SetName("Length_FromBase_PicaPostScript");
            yield return new TestCaseData(UnitConverterLengthUnit.DidotPoint, 1d, 2659.7759998785268d).SetName("Length_FromBase_DidotPoint");
            yield return new TestCaseData(UnitConverterLengthUnit.Cicero, 1d, 221.64799998987723d).SetName("Length_FromBase_Cicero");
            yield return new TestCaseData(UnitConverterLengthUnit.Barleycorn, 1d, 118.11023622047246d).SetName("Length_FromBase_Barleycorn");
            yield return new TestCaseData(UnitConverterLengthUnit.Nail, 1d, 17.497812773403325d).SetName("Length_FromBase_Nail");
            yield return new TestCaseData(UnitConverterLengthUnit.Palm, 1d, 13.123359580052492d).SetName("Length_FromBase_Palm");
            yield return new TestCaseData(UnitConverterLengthUnit.RomanFoot, 1d, 3.3783783783783785d).SetName("Length_FromBase_RomanFoot");
            yield return new TestCaseData(UnitConverterLengthUnit.Arshin, 1d, 1.4060742407199098d).SetName("Length_FromBase_Arshin");
            yield return new TestCaseData(UnitConverterLengthUnit.Vara, 1d, 1.1963081929166592d).SetName("Length_FromBase_Vara");
            yield return new TestCaseData(UnitConverterLengthUnit.Smoot, 1d, 0.58761311552473849d).SetName("Length_FromBase_Smoot");
            yield return new TestCaseData(UnitConverterLengthUnit.NauticalLeague, 1d, 0.00017998560115190784d).SetName("Length_FromBase_NauticalLeague");
            yield return new TestCaseData(UnitConverterLengthUnit.Twip, 1d, 56692.913385826774d).SetName("Length_FromBase_Twip");
            yield return new TestCaseData(UnitConverterLengthUnit.PrinterPoint, 1d, 2845.2755905511813d).SetName("Length_FromBase_PrinterPoint");
            yield return new TestCaseData(UnitConverterLengthUnit.PrinterPica, 1d, 237.10629921259843d).SetName("Length_FromBase_PrinterPica");
            yield return new TestCaseData(UnitConverterLengthUnit.Ken, 1d, 0.55000000005500005d).SetName("Length_FromBase_Ken");
            yield return new TestCaseData(UnitConverterLengthUnit.Shaku, 1d, 3.3000000003299998d).SetName("Length_FromBase_Shaku");
            yield return new TestCaseData(UnitConverterLengthUnit.Ri, 1d, 0.00025462962964731224d).SetName("Length_FromBase_Ri");
            yield return new TestCaseData(UnitConverterLengthUnit.LiChinese, 1d, 0.002d).SetName("Length_FromBase_LiChinese");
            yield return new TestCaseData(UnitConverterLengthUnit.ChiChinese, 1d, 3.0d).SetName("Length_FromBase_ChiChinese");
            yield return new TestCaseData(UnitConverterLengthUnit.Kiloparsec, 1d, 3.2407792894443654e-20d).SetName("Length_FromBase_Kiloparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Megaparsec, 1d, 3.2407792894443649e-23d).SetName("Length_FromBase_Megaparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.Gigaparsec, 1d, 3.2407792894443653e-26d).SetName("Length_FromBase_Gigaparsec");
            yield return new TestCaseData(UnitConverterLengthUnit.LightSecond, 1d, 3.3356409519815204e-09d).SetName("Length_FromBase_LightSecond");
            yield return new TestCaseData(UnitConverterLengthUnit.LightMinute, 1d, 5.5594015866358675e-11d).SetName("Length_FromBase_LightMinute");
            yield return new TestCaseData(UnitConverterLengthUnit.LightHour, 1d, 9.2656693110597788e-13d).SetName("Length_FromBase_LightHour");
            yield return new TestCaseData(UnitConverterLengthUnit.LightDay, 1d, 3.8606955462749081e-14d).SetName("Length_FromBase_LightDay");
            yield return new TestCaseData(UnitConverterLengthUnit.LightWeek, 1d, 5.5152793518212969e-15d).SetName("Length_FromBase_LightWeek");
            yield return new TestCaseData(UnitConverterLengthUnit.Microinch, 1d, 39370078.740157485d).SetName("Length_FromBase_Microinch");
            yield return new TestCaseData(UnitConverterLengthUnit.Nanoinch, 1d, 39370078740.157478d).SetName("Length_FromBase_Nanoinch");
            yield return new TestCaseData(UnitConverterLengthUnit.Caliber, 1d, 3937.0078740157483d).SetName("Length_FromBase_Caliber");
            yield return new TestCaseData(UnitConverterLengthUnit.RackUnit, 1d, 22.497187851518557d).SetName("Length_FromBase_RackUnit");
            yield return new TestCaseData(UnitConverterLengthUnit.Quarter, 1d, 4.3744531933508313d).SetName("Length_FromBase_Quarter");
        }
    }
}
