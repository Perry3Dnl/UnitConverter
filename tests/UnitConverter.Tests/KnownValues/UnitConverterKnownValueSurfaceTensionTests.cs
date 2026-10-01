namespace UnitConverter.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.SurfaceTension;

    public sealed class UnitConverterKnownValueSurfaceTensionTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void SurfaceTension_ToBaseUnit_ReturnsExpectedValue(UnitConverterSurfaceTensionUnit unit, double input, double expected)
        {
            double result = UnitConverterSurfaceTension.ToNewtonPerMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void SurfaceTension_FromBaseUnit_ReturnsExpectedValue(UnitConverterSurfaceTensionUnit unit, double input, double expected)
        {
            double result = UnitConverterSurfaceTension.FromNewtonPerMeter(input, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void SurfaceTension_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterSurfaceTensionUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterSurfaceTension.ToNewtonPerMeter(input, unit);
            double result = UnitConverterSurfaceTension.FromNewtonPerMeter(baseValue, unit);
            UnitConverterTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerMeter, 1d, 1.0d).SetName("SurfaceTension_ToBase_NewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MillinewtonPerMeter, 1d, 0.001d).SetName("SurfaceTension_ToBase_MillinewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MicronewtonPerMeter, 1d, 9.9999999999999995e-07d).SetName("SurfaceTension_ToBase_MicronewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.DynePerCentimeter, 1d, 0.001d).SetName("SurfaceTension_ToBase_DynePerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.GramForcePerCentimeter, 1d, 0.98066500000000001d).SetName("SurfaceTension_ToBase_GramForcePerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundForcePerFoot, 1d, 14.593902937206362d).SetName("SurfaceTension_ToBase_PoundForcePerFoot");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundForcePerInch, 1d, 175.12683524647636d).SetName("SurfaceTension_ToBase_PoundForcePerInch");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.JoulePerSquareMeter, 1d, 1.0d).SetName("SurfaceTension_ToBase_JoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter, 1d, 0.001d).SetName("SurfaceTension_ToBase_MillijoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter, 1d, 9.9999999999999995e-07d).SetName("SurfaceTension_ToBase_MicrojoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerCentimeter, 1d, 100.0d).SetName("SurfaceTension_ToBase_NewtonPerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerMillimeter, 1d, 1000.0d).SetName("SurfaceTension_ToBase_NewtonPerMillimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundalPerFoot, 1d, 0.45359236999999997d).SetName("SurfaceTension_ToBase_PoundalPerFoot");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.OunceForcePerFoot, 1d, 0.91211893357539764d).SetName("SurfaceTension_ToBase_OunceForcePerFoot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerMeter, 1d, 1.0d).SetName("SurfaceTension_FromBase_NewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MillinewtonPerMeter, 1d, 1000.0d).SetName("SurfaceTension_FromBase_MillinewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MicronewtonPerMeter, 1d, 1000000.0d).SetName("SurfaceTension_FromBase_MicronewtonPerMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.DynePerCentimeter, 1d, 1000.0d).SetName("SurfaceTension_FromBase_DynePerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.GramForcePerCentimeter, 1d, 1.0197162129779282d).SetName("SurfaceTension_FromBase_GramForcePerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundForcePerFoot, 1d, 0.068521765856791761d).SetName("SurfaceTension_FromBase_PoundForcePerFoot");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundForcePerInch, 1d, 0.0057101471547326465d).SetName("SurfaceTension_FromBase_PoundForcePerInch");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.JoulePerSquareMeter, 1d, 1.0d).SetName("SurfaceTension_FromBase_JoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MillijoulePerSquareMeter, 1d, 1000.0d).SetName("SurfaceTension_FromBase_MillijoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.MicrojoulePerSquareMeter, 1d, 1000000.0d).SetName("SurfaceTension_FromBase_MicrojoulePerSquareMeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerCentimeter, 1d, 0.01d).SetName("SurfaceTension_FromBase_NewtonPerCentimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.NewtonPerMillimeter, 1d, 0.001d).SetName("SurfaceTension_FromBase_NewtonPerMillimeter");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.PoundalPerFoot, 1d, 2.2046226218487761d).SetName("SurfaceTension_FromBase_PoundalPerFoot");
            yield return new TestCaseData(UnitConverterSurfaceTensionUnit.OunceForcePerFoot, 1d, 1.0963482537086682d).SetName("SurfaceTension_FromBase_OunceForcePerFoot");
        }
    }
}
