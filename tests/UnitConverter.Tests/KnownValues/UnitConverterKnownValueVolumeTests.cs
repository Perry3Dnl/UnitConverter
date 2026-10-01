namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Volume;

    public sealed class UnitConverterKnownValueVolumeTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Volume_ToBaseUnit_ReturnsExpectedValue(UnitConverterVolumeUnit unit, double input, double expected)
        {
            double result = UnitConverterVolume.ToLiter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Volume_FromBaseUnit_ReturnsExpectedValue(UnitConverterVolumeUnit unit, double input, double expected)
        {
            double result = UnitConverterVolume.FromLiter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Volume_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterVolumeUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterVolume.ToLiter(input, unit);
            double result = UnitConverterVolume.FromLiter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMillimeter, 1d, 9.9999999999999995e-07d).SetName("Volume_ToBase_CubicMillimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Milliliter, 1d, 0.001d).SetName("Volume_ToBase_Milliliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Centiliter, 1d, 0.01d).SetName("Volume_ToBase_Centiliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Deciliter, 1d, 0.10000000000000001d).SetName("Volume_ToBase_Deciliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Liter, 1d, 1.0d).SetName("Volume_ToBase_Liter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Decaliter, 1d, 10.0d).SetName("Volume_ToBase_Decaliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Hectoliter, 1d, 100.0d).SetName("Volume_ToBase_Hectoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Kiloliter, 1d, 1000.0d).SetName("Volume_ToBase_Kiloliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicCentimeter, 1d, 0.001d).SetName("Volume_ToBase_CubicCentimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMeter, 1d, 1000.0d).SetName("Volume_ToBase_CubicMeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.USTeaspoon, 1d, 0.0049289215937499999d).SetName("Volume_ToBase_USTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USTablespoon, 1d, 0.01478676478125d).SetName("Volume_ToBase_USTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USFluidOunce, 1d, 0.029573529562499999d).SetName("Volume_ToBase_USFluidOunce");
            yield return new TestCaseData(UnitConverterVolumeUnit.USCup, 1d, 0.23658823649999999d).SetName("Volume_ToBase_USCup");
            yield return new TestCaseData(UnitConverterVolumeUnit.USPint, 1d, 0.47317647299999999d).SetName("Volume_ToBase_USPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.USQuart, 1d, 0.94635294599999997d).SetName("Volume_ToBase_USQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.USGallon, 1d, 3.7854117839999999d).SetName("Volume_ToBase_USGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryPint, 1d, 0.55061047135749996d).SetName("Volume_ToBase_USDryPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryQuart, 1d, 1.1012209427149999d).SetName("Volume_ToBase_USDryQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryGallon, 1d, 4.4048837708599997d).SetName("Volume_ToBase_USDryGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USBushel, 1d, 35.239070166879998d).SetName("Volume_ToBase_USBushel");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialTeaspoon, 1d, 0.0059193880208333327d).SetName("Volume_ToBase_ImperialTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialTablespoon, 1d, 0.017758164062500002d).SetName("Volume_ToBase_ImperialTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialFluidOunce, 1d, 0.028413062499999999d).SetName("Volume_ToBase_ImperialFluidOunce");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialGill, 1d, 0.14206531250000001d).SetName("Volume_ToBase_ImperialGill");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialPint, 1d, 0.56826125000000005d).SetName("Volume_ToBase_ImperialPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialQuart, 1d, 1.1365225000000001d).SetName("Volume_ToBase_ImperialQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialGallon, 1d, 4.5460900000000004d).SetName("Volume_ToBase_ImperialGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialBushel, 1d, 36.368720000000003d).SetName("Volume_ToBase_ImperialBushel");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicInch, 1d, 0.016387064d).SetName("Volume_ToBase_CubicInch");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicFoot, 1d, 28.316846592000001d).SetName("Volume_ToBase_CubicFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicYard, 1d, 764.55485798400002d).SetName("Volume_ToBase_CubicYard");
            yield return new TestCaseData(UnitConverterVolumeUnit.OilBarrel, 1d, 158.98729492800001d).SetName("Volume_ToBase_OilBarrel");
            yield return new TestCaseData(UnitConverterVolumeUnit.BeerBarrelUS, 1d, 117.34776530400001d).SetName("Volume_ToBase_BeerBarrelUS");
            yield return new TestCaseData(UnitConverterVolumeUnit.RegisterTon, 1d, 2831.6846592000002d).SetName("Volume_ToBase_RegisterTon");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicNanometer, 1d, 9.9999999999999992e-25d).SetName("Volume_ToBase_CubicNanometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMicrometer, 1d, 1.0000000000000001e-15d).SetName("Volume_ToBase_CubicMicrometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.Microliter, 1d, 9.9999999999999995e-07d).SetName("Volume_ToBase_Microliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Nanoliter, 1d, 1.0000000000000001e-09d).SetName("Volume_ToBase_Nanoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Picoliter, 1d, 9.9999999999999998e-13d).SetName("Volume_ToBase_Picoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Femtoliter, 1d, 1.0000000000000001e-15d).SetName("Volume_ToBase_Femtoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicDecimeter, 1d, 1.0d).SetName("Volume_ToBase_CubicDecimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicKilometer, 1d, 1000000000000.0d).SetName("Volume_ToBase_CubicKilometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.Stere, 1d, 1000.0d).SetName("Volume_ToBase_Stere");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricTeaspoon, 1d, 0.0050000000000000001d).SetName("Volume_ToBase_MetricTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricTablespoon, 1d, 0.014999999999999999d).SetName("Volume_ToBase_MetricTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricCup, 1d, 0.25d).SetName("Volume_ToBase_MetricCup");
            yield return new TestCaseData(UnitConverterVolumeUnit.USGill, 1d, 0.11829411825d).SetName("Volume_ToBase_USGill");
            yield return new TestCaseData(UnitConverterVolumeUnit.USPeck, 1d, 8.8097675417199994d).SetName("Volume_ToBase_USPeck");
            yield return new TestCaseData(UnitConverterVolumeUnit.USHogshead, 1d, 238.480942392d).SetName("Volume_ToBase_USHogshead");
            yield return new TestCaseData(UnitConverterVolumeUnit.USMinim, 1d, 6.1611519921875006e-05d).SetName("Volume_ToBase_USMinim");
            yield return new TestCaseData(UnitConverterVolumeUnit.USFluidDram, 1d, 0.0036966911953124999d).SetName("Volume_ToBase_USFluidDram");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialPeck, 1d, 9.0921800000000008d).SetName("Volume_ToBase_ImperialPeck");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialHogshead, 1d, 327.31848000000002d).SetName("Volume_ToBase_ImperialHogshead");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialMinim, 1d, 5.9193880208333331e-05d).SetName("Volume_ToBase_ImperialMinim");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialFluidDram, 1d, 0.0035516328124999999d).SetName("Volume_ToBase_ImperialFluidDram");
            yield return new TestCaseData(UnitConverterVolumeUnit.BoardFoot, 1d, 2.3597372160000001d).SetName("Volume_ToBase_BoardFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.AcreFoot, 1d, 1233481.8375475199d).SetName("Volume_ToBase_AcreFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.Cord, 1d, 3624.5563637760001d).SetName("Volume_ToBase_Cord");
            yield return new TestCaseData(UnitConverterVolumeUnit.Drop, 1d, 5.0000000000000002e-05d).SetName("Volume_ToBase_Drop");
            yield return new TestCaseData(UnitConverterVolumeUnit.Dash, 1d, 0.00061611519921874998d).SetName("Volume_ToBase_Dash");
            yield return new TestCaseData(UnitConverterVolumeUnit.Pinch, 1d, 0.00030805759960937499d).SetName("Volume_ToBase_Pinch");
            yield return new TestCaseData(UnitConverterVolumeUnit.USShot, 1d, 0.044360294343750002d).SetName("Volume_ToBase_USShot");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialShot, 1d, 0.035516328125000003d).SetName("Volume_ToBase_ImperialShot");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDessertSpoon, 1d, 0.0098578431874999997d).SetName("Volume_ToBase_USDessertSpoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialDessertSpoon, 1d, 0.011838776041666671d).SetName("Volume_ToBase_ImperialDessertSpoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.OilBarrelPerThousand, 1d, 158.98729492800001d).SetName("Volume_ToBase_OilBarrelPerThousand");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMillimeter, 1d, 1000000.0d).SetName("Volume_FromBase_CubicMillimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Milliliter, 1d, 1000.0d).SetName("Volume_FromBase_Milliliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Centiliter, 1d, 100.0d).SetName("Volume_FromBase_Centiliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Deciliter, 1d, 10.0d).SetName("Volume_FromBase_Deciliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Liter, 1d, 1.0d).SetName("Volume_FromBase_Liter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Decaliter, 1d, 0.10000000000000001d).SetName("Volume_FromBase_Decaliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Hectoliter, 1d, 0.01d).SetName("Volume_FromBase_Hectoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Kiloliter, 1d, 0.001d).SetName("Volume_FromBase_Kiloliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicCentimeter, 1d, 1000.0d).SetName("Volume_FromBase_CubicCentimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMeter, 1d, 0.001d).SetName("Volume_FromBase_CubicMeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.USTeaspoon, 1d, 202.88413621105798d).SetName("Volume_FromBase_USTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USTablespoon, 1d, 67.628045403686002d).SetName("Volume_FromBase_USTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USFluidOunce, 1d, 33.814022701843001d).SetName("Volume_FromBase_USFluidOunce");
            yield return new TestCaseData(UnitConverterVolumeUnit.USCup, 1d, 4.2267528377303751d).SetName("Volume_FromBase_USCup");
            yield return new TestCaseData(UnitConverterVolumeUnit.USPint, 1d, 2.1133764188651876d).SetName("Volume_FromBase_USPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.USQuart, 1d, 1.0566882094325938d).SetName("Volume_FromBase_USQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.USGallon, 1d, 0.26417205235814845d).SetName("Volume_FromBase_USGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryPint, 1d, 1.8161659685377118d).SetName("Volume_FromBase_USDryPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryQuart, 1d, 0.90808298426885592d).SetName("Volume_FromBase_USDryQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDryGallon, 1d, 0.22702074606721398d).SetName("Volume_FromBase_USDryGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.USBushel, 1d, 0.028377593258401747d).SetName("Volume_FromBase_USBushel");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialTeaspoon, 1d, 168.93638269369944d).SetName("Volume_FromBase_ImperialTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialTablespoon, 1d, 56.312127564566467d).SetName("Volume_FromBase_ImperialTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialFluidOunce, 1d, 35.195079727854051d).SetName("Volume_FromBase_ImperialFluidOunce");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialGill, 1d, 7.0390159455708083d).SetName("Volume_FromBase_ImperialGill");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialPint, 1d, 1.7597539863927021d).SetName("Volume_FromBase_ImperialPint");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialQuart, 1d, 0.87987699319635104d).SetName("Volume_FromBase_ImperialQuart");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialGallon, 1d, 0.21996924829908776d).SetName("Volume_FromBase_ImperialGallon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialBushel, 1d, 0.02749615603738597d).SetName("Volume_FromBase_ImperialBushel");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicInch, 1d, 61.023744094732287d).SetName("Volume_FromBase_CubicInch");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicFoot, 1d, 0.035314666721488586d).SetName("Volume_FromBase_CubicFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicYard, 1d, 0.0013079506193143921d).SetName("Volume_FromBase_CubicYard");
            yield return new TestCaseData(UnitConverterVolumeUnit.OilBarrel, 1d, 0.0062898107704321051d).SetName("Volume_FromBase_OilBarrel");
            yield return new TestCaseData(UnitConverterVolumeUnit.BeerBarrelUS, 1d, 0.0085216791083273669d).SetName("Volume_FromBase_BeerBarrelUS");
            yield return new TestCaseData(UnitConverterVolumeUnit.RegisterTon, 1d, 0.00035314666721488586d).SetName("Volume_FromBase_RegisterTon");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicNanometer, 1d, 1.0000000000000001e+24d).SetName("Volume_FromBase_CubicNanometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicMicrometer, 1d, 999999999999999.88d).SetName("Volume_FromBase_CubicMicrometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.Microliter, 1d, 1000000.0d).SetName("Volume_FromBase_Microliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Nanoliter, 1d, 999999999.99999988d).SetName("Volume_FromBase_Nanoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Picoliter, 1d, 1000000000000.0d).SetName("Volume_FromBase_Picoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.Femtoliter, 1d, 999999999999999.88d).SetName("Volume_FromBase_Femtoliter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicDecimeter, 1d, 1.0d).SetName("Volume_FromBase_CubicDecimeter");
            yield return new TestCaseData(UnitConverterVolumeUnit.CubicKilometer, 1d, 9.9999999999999998e-13d).SetName("Volume_FromBase_CubicKilometer");
            yield return new TestCaseData(UnitConverterVolumeUnit.Stere, 1d, 0.001d).SetName("Volume_FromBase_Stere");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricTeaspoon, 1d, 200.0d).SetName("Volume_FromBase_MetricTeaspoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricTablespoon, 1d, 66.666666666666671d).SetName("Volume_FromBase_MetricTablespoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.MetricCup, 1d, 4.0d).SetName("Volume_FromBase_MetricCup");
            yield return new TestCaseData(UnitConverterVolumeUnit.USGill, 1d, 8.4535056754607503d).SetName("Volume_FromBase_USGill");
            yield return new TestCaseData(UnitConverterVolumeUnit.USPeck, 1d, 0.11351037303360699d).SetName("Volume_FromBase_USPeck");
            yield return new TestCaseData(UnitConverterVolumeUnit.USHogshead, 1d, 0.0041932071802880701d).SetName("Volume_FromBase_USHogshead");
            yield return new TestCaseData(UnitConverterVolumeUnit.USMinim, 1d, 16230.730896884637d).SetName("Volume_FromBase_USMinim");
            yield return new TestCaseData(UnitConverterVolumeUnit.USFluidDram, 1d, 270.51218161474401d).SetName("Volume_FromBase_USFluidDram");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialPeck, 1d, 0.10998462414954388d).SetName("Volume_FromBase_ImperialPeck");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialHogshead, 1d, 0.0030551284485984412d).SetName("Volume_FromBase_ImperialHogshead");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialMinim, 1d, 16893.638269369942d).SetName("Volume_FromBase_ImperialMinim");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialFluidDram, 1d, 281.5606378228324d).SetName("Volume_FromBase_ImperialFluidDram");
            yield return new TestCaseData(UnitConverterVolumeUnit.BoardFoot, 1d, 0.42377600065786308d).SetName("Volume_FromBase_BoardFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.AcreFoot, 1d, 8.1071319378991257e-07d).SetName("Volume_FromBase_AcreFoot");
            yield return new TestCaseData(UnitConverterVolumeUnit.Cord, 1d, 0.00027589583376162958d).SetName("Volume_FromBase_Cord");
            yield return new TestCaseData(UnitConverterVolumeUnit.Drop, 1d, 20000.0d).SetName("Volume_FromBase_Drop");
            yield return new TestCaseData(UnitConverterVolumeUnit.Dash, 1d, 1623.0730896884638d).SetName("Volume_FromBase_Dash");
            yield return new TestCaseData(UnitConverterVolumeUnit.Pinch, 1d, 3246.1461793769276d).SetName("Volume_FromBase_Pinch");
            yield return new TestCaseData(UnitConverterVolumeUnit.USShot, 1d, 22.542681801228664d).SetName("Volume_FromBase_USShot");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialShot, 1d, 28.156063782283233d).SetName("Volume_FromBase_ImperialShot");
            yield return new TestCaseData(UnitConverterVolumeUnit.USDessertSpoon, 1d, 101.44206810552899d).SetName("Volume_FromBase_USDessertSpoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.ImperialDessertSpoon, 1d, 84.468191346849679d).SetName("Volume_FromBase_ImperialDessertSpoon");
            yield return new TestCaseData(UnitConverterVolumeUnit.OilBarrelPerThousand, 1d, 0.0062898107704321051d).SetName("Volume_FromBase_OilBarrelPerThousand");
        }
    }
}
