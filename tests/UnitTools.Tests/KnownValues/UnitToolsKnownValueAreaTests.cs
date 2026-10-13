namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Area;

    public sealed class UnitToolsKnownValueAreaTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Area_ToBaseUnit_ReturnsExpectedValue(UnitToolsAreaUnit unit, double input, double expected)
        {
            double result = UnitToolsArea.ToSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Area_FromBaseUnit_ReturnsExpectedValue(UnitToolsAreaUnit unit, double input, double expected)
        {
            double result = UnitToolsArea.FromSquareMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Area_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsAreaUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsArea.ToSquareMeter(input, unit);
            double result = UnitToolsArea.FromSquareMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("Area_ToBase_SquareMillimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareCentimeter, 1d, 0.0001d).SetName("Area_ToBase_SquareCentimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMeter, 1d, 1.0d).SetName("Area_ToBase_SquareMeter");
            yield return new TestCaseData(UnitToolsAreaUnit.Are, 1d, 100.0d).SetName("Area_ToBase_Are");
            yield return new TestCaseData(UnitToolsAreaUnit.Hectare, 1d, 10000.0d).SetName("Area_ToBase_Hectare");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareKilometer, 1d, 1000000.0d).SetName("Area_ToBase_SquareKilometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareInch, 1d, 0.00064515999999999998d).SetName("Area_ToBase_SquareInch");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareFoot, 1d, 0.092903040000000006d).SetName("Area_ToBase_SquareFoot");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareYard, 1d, 0.83612735999999999d).SetName("Area_ToBase_SquareYard");
            yield return new TestCaseData(UnitToolsAreaUnit.Acre, 1d, 4046.8564224000002d).SetName("Area_ToBase_Acre");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMile, 1d, 2589988.1103360001d).SetName("Area_ToBase_SquareMile");
            yield return new TestCaseData(UnitToolsAreaUnit.Rood, 1d, 1011.7141056d).SetName("Area_ToBase_Rood");
            yield return new TestCaseData(UnitToolsAreaUnit.Township, 1d, 93239571.972095996d).SetName("Area_ToBase_Township");
            yield return new TestCaseData(UnitToolsAreaUnit.Barn, 1d, 9.9999999999999997e-29d).SetName("Area_ToBase_Barn");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareNanometer, 1d, 1.0000000000000001e-18d).SetName("Area_ToBase_SquareNanometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("Area_ToBase_SquareMicrometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareDecimeter, 1d, 0.01d).SetName("Area_ToBase_SquareDecimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareDecameter, 1d, 100.0d).SetName("Area_ToBase_SquareDecameter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareHectometer, 1d, 10000.0d).SetName("Area_ToBase_SquareHectometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMegameter, 1d, 1000000000000.0d).SetName("Area_ToBase_SquareMegameter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareThou, 1d, 6.4515999999999997e-10d).SetName("Area_ToBase_SquareThou");
            yield return new TestCaseData(UnitToolsAreaUnit.CircularMil, 1d, 5.0670747909749771e-10d).SetName("Area_ToBase_CircularMil");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareRod, 1d, 25.29285264d).SetName("Area_ToBase_SquareRod");
            yield return new TestCaseData(UnitToolsAreaUnit.SquarePole, 1d, 25.29285264d).SetName("Area_ToBase_SquarePole");
            yield return new TestCaseData(UnitToolsAreaUnit.SquarePerch, 1d, 25.29285264d).SetName("Area_ToBase_SquarePerch");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareChain, 1d, 404.68564223999999d).SetName("Area_ToBase_SquareChain");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareFurlong, 1d, 40468.564224000002d).SetName("Area_ToBase_SquareFurlong");
            yield return new TestCaseData(UnitToolsAreaUnit.Section, 1d, 2589988.1103360001d).SetName("Area_ToBase_Section");
            yield return new TestCaseData(UnitToolsAreaUnit.Homestead, 1d, 647497.02758400002d).SetName("Area_ToBase_Homestead");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareLeague, 1d, 23309809.0d).SetName("Area_ToBase_SquareLeague");
            yield return new TestCaseData(UnitToolsAreaUnit.Dunam, 1d, 1000.0d).SetName("Area_ToBase_Dunam");
            yield return new TestCaseData(UnitToolsAreaUnit.Tatami, 1d, 1.653d).SetName("Area_ToBase_Tatami");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMillimeter, 1d, 1000000.0d).SetName("Area_FromBase_SquareMillimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareCentimeter, 1d, 10000.0d).SetName("Area_FromBase_SquareCentimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMeter, 1d, 1.0d).SetName("Area_FromBase_SquareMeter");
            yield return new TestCaseData(UnitToolsAreaUnit.Are, 1d, 0.01d).SetName("Area_FromBase_Are");
            yield return new TestCaseData(UnitToolsAreaUnit.Hectare, 1d, 0.0001d).SetName("Area_FromBase_Hectare");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareKilometer, 1d, 9.9999999999999995e-07d).SetName("Area_FromBase_SquareKilometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareInch, 1d, 1550.0031000062002d).SetName("Area_FromBase_SquareInch");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareFoot, 1d, 10.763910416709722d).SetName("Area_FromBase_SquareFoot");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareYard, 1d, 1.1959900463010802d).SetName("Area_FromBase_SquareYard");
            yield return new TestCaseData(UnitToolsAreaUnit.Acre, 1d, 0.00024710538146716532d).SetName("Area_FromBase_Acre");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMile, 1d, 3.8610215854244582e-07d).SetName("Area_FromBase_SquareMile");
            yield return new TestCaseData(UnitToolsAreaUnit.Rood, 1d, 0.00098842152586866129d).SetName("Area_FromBase_Rood");
            yield return new TestCaseData(UnitToolsAreaUnit.Township, 1d, 1.0725059959512385e-08d).SetName("Area_FromBase_Township");
            yield return new TestCaseData(UnitToolsAreaUnit.Barn, 1d, 9.9999999999999996e+27d).SetName("Area_FromBase_Barn");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareNanometer, 1d, 9.9999999999999987e+17d).SetName("Area_FromBase_SquareNanometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMicrometer, 1d, 1000000000000.0d).SetName("Area_FromBase_SquareMicrometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareDecimeter, 1d, 100.0d).SetName("Area_FromBase_SquareDecimeter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareDecameter, 1d, 0.01d).SetName("Area_FromBase_SquareDecameter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareHectometer, 1d, 0.0001d).SetName("Area_FromBase_SquareHectometer");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareMegameter, 1d, 9.9999999999999998e-13d).SetName("Area_FromBase_SquareMegameter");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareThou, 1d, 1550003100.0062001d).SetName("Area_FromBase_SquareThou");
            yield return new TestCaseData(UnitToolsAreaUnit.CircularMil, 1d, 1973525241.3899851d).SetName("Area_FromBase_CircularMil");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareRod, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquareRod");
            yield return new TestCaseData(UnitToolsAreaUnit.SquarePole, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquarePole");
            yield return new TestCaseData(UnitToolsAreaUnit.SquarePerch, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquarePerch");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareChain, 1d, 0.0024710538146716535d).SetName("Area_FromBase_SquareChain");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareFurlong, 1d, 2.4710538146716532e-05d).SetName("Area_FromBase_SquareFurlong");
            yield return new TestCaseData(UnitToolsAreaUnit.Section, 1d, 3.8610215854244582e-07d).SetName("Area_FromBase_Section");
            yield return new TestCaseData(UnitToolsAreaUnit.Homestead, 1d, 1.5444086341697833e-06d).SetName("Area_FromBase_Homestead");
            yield return new TestCaseData(UnitToolsAreaUnit.SquareLeague, 1d, 4.2900394421936274e-08d).SetName("Area_FromBase_SquareLeague");
            yield return new TestCaseData(UnitToolsAreaUnit.Dunam, 1d, 0.001d).SetName("Area_FromBase_Dunam");
            yield return new TestCaseData(UnitToolsAreaUnit.Tatami, 1d, 0.60496067755595884d).SetName("Area_FromBase_Tatami");
        }
    }
}
