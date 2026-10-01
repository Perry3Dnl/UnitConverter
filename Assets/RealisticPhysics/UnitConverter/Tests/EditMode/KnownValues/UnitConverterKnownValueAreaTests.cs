namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.Area;

    public sealed class UnitConverterKnownValueAreaTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Area_ToBaseUnit_ReturnsExpectedValue(UnitConverterAreaUnit unit, double input, double expected)
        {
            double result = UnitConverterArea.ToSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Area_FromBaseUnit_ReturnsExpectedValue(UnitConverterAreaUnit unit, double input, double expected)
        {
            double result = UnitConverterArea.FromSquareMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Area_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterAreaUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterArea.ToSquareMeter(input, unit);
            double result = UnitConverterArea.FromSquareMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMillimeter, 1d, 9.9999999999999995e-07d).SetName("Area_ToBase_SquareMillimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareCentimeter, 1d, 0.0001d).SetName("Area_ToBase_SquareCentimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMeter, 1d, 1.0d).SetName("Area_ToBase_SquareMeter");
            yield return new TestCaseData(UnitConverterAreaUnit.Are, 1d, 100.0d).SetName("Area_ToBase_Are");
            yield return new TestCaseData(UnitConverterAreaUnit.Hectare, 1d, 10000.0d).SetName("Area_ToBase_Hectare");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareKilometer, 1d, 1000000.0d).SetName("Area_ToBase_SquareKilometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareInch, 1d, 0.00064515999999999998d).SetName("Area_ToBase_SquareInch");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareFoot, 1d, 0.092903040000000006d).SetName("Area_ToBase_SquareFoot");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareYard, 1d, 0.83612735999999999d).SetName("Area_ToBase_SquareYard");
            yield return new TestCaseData(UnitConverterAreaUnit.Acre, 1d, 4046.8564224000002d).SetName("Area_ToBase_Acre");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMile, 1d, 2589988.1103360001d).SetName("Area_ToBase_SquareMile");
            yield return new TestCaseData(UnitConverterAreaUnit.Rood, 1d, 1011.7141056d).SetName("Area_ToBase_Rood");
            yield return new TestCaseData(UnitConverterAreaUnit.Township, 1d, 93239571.972095996d).SetName("Area_ToBase_Township");
            yield return new TestCaseData(UnitConverterAreaUnit.Barn, 1d, 9.9999999999999997e-29d).SetName("Area_ToBase_Barn");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareNanometer, 1d, 1.0000000000000001e-18d).SetName("Area_ToBase_SquareNanometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMicrometer, 1d, 9.9999999999999998e-13d).SetName("Area_ToBase_SquareMicrometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareDecimeter, 1d, 0.01d).SetName("Area_ToBase_SquareDecimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareDecameter, 1d, 100.0d).SetName("Area_ToBase_SquareDecameter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareHectometer, 1d, 10000.0d).SetName("Area_ToBase_SquareHectometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMegameter, 1d, 1000000000000.0d).SetName("Area_ToBase_SquareMegameter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareThou, 1d, 6.4515999999999997e-10d).SetName("Area_ToBase_SquareThou");
            yield return new TestCaseData(UnitConverterAreaUnit.CircularMil, 1d, 5.0670747909749771e-10d).SetName("Area_ToBase_CircularMil");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareRod, 1d, 25.29285264d).SetName("Area_ToBase_SquareRod");
            yield return new TestCaseData(UnitConverterAreaUnit.SquarePole, 1d, 25.29285264d).SetName("Area_ToBase_SquarePole");
            yield return new TestCaseData(UnitConverterAreaUnit.SquarePerch, 1d, 25.29285264d).SetName("Area_ToBase_SquarePerch");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareChain, 1d, 404.68564223999999d).SetName("Area_ToBase_SquareChain");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareFurlong, 1d, 40468.564224000002d).SetName("Area_ToBase_SquareFurlong");
            yield return new TestCaseData(UnitConverterAreaUnit.Section, 1d, 2589988.1103360001d).SetName("Area_ToBase_Section");
            yield return new TestCaseData(UnitConverterAreaUnit.Homestead, 1d, 647497.02758400002d).SetName("Area_ToBase_Homestead");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareLeague, 1d, 23309809.0d).SetName("Area_ToBase_SquareLeague");
            yield return new TestCaseData(UnitConverterAreaUnit.Dunam, 1d, 1000.0d).SetName("Area_ToBase_Dunam");
            yield return new TestCaseData(UnitConverterAreaUnit.Tatami, 1d, 1.653d).SetName("Area_ToBase_Tatami");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMillimeter, 1d, 1000000.0d).SetName("Area_FromBase_SquareMillimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareCentimeter, 1d, 10000.0d).SetName("Area_FromBase_SquareCentimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMeter, 1d, 1.0d).SetName("Area_FromBase_SquareMeter");
            yield return new TestCaseData(UnitConverterAreaUnit.Are, 1d, 0.01d).SetName("Area_FromBase_Are");
            yield return new TestCaseData(UnitConverterAreaUnit.Hectare, 1d, 0.0001d).SetName("Area_FromBase_Hectare");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareKilometer, 1d, 9.9999999999999995e-07d).SetName("Area_FromBase_SquareKilometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareInch, 1d, 1550.0031000062002d).SetName("Area_FromBase_SquareInch");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareFoot, 1d, 10.763910416709722d).SetName("Area_FromBase_SquareFoot");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareYard, 1d, 1.1959900463010802d).SetName("Area_FromBase_SquareYard");
            yield return new TestCaseData(UnitConverterAreaUnit.Acre, 1d, 0.00024710538146716532d).SetName("Area_FromBase_Acre");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMile, 1d, 3.8610215854244582e-07d).SetName("Area_FromBase_SquareMile");
            yield return new TestCaseData(UnitConverterAreaUnit.Rood, 1d, 0.00098842152586866129d).SetName("Area_FromBase_Rood");
            yield return new TestCaseData(UnitConverterAreaUnit.Township, 1d, 1.0725059959512385e-08d).SetName("Area_FromBase_Township");
            yield return new TestCaseData(UnitConverterAreaUnit.Barn, 1d, 9.9999999999999996e+27d).SetName("Area_FromBase_Barn");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareNanometer, 1d, 9.9999999999999987e+17d).SetName("Area_FromBase_SquareNanometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMicrometer, 1d, 1000000000000.0d).SetName("Area_FromBase_SquareMicrometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareDecimeter, 1d, 100.0d).SetName("Area_FromBase_SquareDecimeter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareDecameter, 1d, 0.01d).SetName("Area_FromBase_SquareDecameter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareHectometer, 1d, 0.0001d).SetName("Area_FromBase_SquareHectometer");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareMegameter, 1d, 9.9999999999999998e-13d).SetName("Area_FromBase_SquareMegameter");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareThou, 1d, 1550003100.0062001d).SetName("Area_FromBase_SquareThou");
            yield return new TestCaseData(UnitConverterAreaUnit.CircularMil, 1d, 1973525241.3899851d).SetName("Area_FromBase_CircularMil");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareRod, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquareRod");
            yield return new TestCaseData(UnitConverterAreaUnit.SquarePole, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquarePole");
            yield return new TestCaseData(UnitConverterAreaUnit.SquarePerch, 1d, 0.039536861034746455d).SetName("Area_FromBase_SquarePerch");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareChain, 1d, 0.0024710538146716535d).SetName("Area_FromBase_SquareChain");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareFurlong, 1d, 2.4710538146716532e-05d).SetName("Area_FromBase_SquareFurlong");
            yield return new TestCaseData(UnitConverterAreaUnit.Section, 1d, 3.8610215854244582e-07d).SetName("Area_FromBase_Section");
            yield return new TestCaseData(UnitConverterAreaUnit.Homestead, 1d, 1.5444086341697833e-06d).SetName("Area_FromBase_Homestead");
            yield return new TestCaseData(UnitConverterAreaUnit.SquareLeague, 1d, 4.2900394421936274e-08d).SetName("Area_FromBase_SquareLeague");
            yield return new TestCaseData(UnitConverterAreaUnit.Dunam, 1d, 0.001d).SetName("Area_FromBase_Dunam");
            yield return new TestCaseData(UnitConverterAreaUnit.Tatami, 1d, 0.60496067755595884d).SetName("Area_FromBase_Tatami");
        }
    }
}
