namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.Core.Tests;
    using RealisticPhysics.UnitConversion.PressureGradient;

    public sealed class UnitConverterKnownValuePressureGradientTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void PressureGradient_ToBaseUnit_ReturnsExpectedValue(UnitConverterPressureGradientUnit unit, double input, double expected)
        {
            double result = UnitConverterPressureGradient.ToPascalPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void PressureGradient_FromBaseUnit_ReturnsExpectedValue(UnitConverterPressureGradientUnit unit, double input, double expected)
        {
            double result = UnitConverterPressureGradient.FromPascalPerMeter(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void PressureGradient_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterPressureGradientUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterPressureGradient.ToPascalPerMeter(input, unit);
            double result = UnitConverterPressureGradient.FromPascalPerMeter(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerMeter, 1d, 1.0d).SetName("PressureGradient_ToBase_PascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.KilopascalPerMeter, 1d, 1000.0d).SetName("PressureGradient_ToBase_KilopascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerCentimeter, 1d, 100.0d).SetName("PressureGradient_ToBase_PascalPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.BarPerMeter, 1d, 100000.0d).SetName("PressureGradient_ToBase_BarPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter, 1d, 133.32238741500001d).SetName("PressureGradient_ToBase_MillimeterMercuryPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PsiPerFoot, 1d, 22620.594793858265d).SetName("PressureGradient_ToBase_PsiPerFoot");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerMillimeter, 1d, 1000.0d).SetName("PressureGradient_ToBase_PascalPerMillimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.MegapascalPerMeter, 1d, 1000000.0d).SetName("PressureGradient_ToBase_MegapascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.KilopascalPerCentimeter, 1d, 100000.0d).SetName("PressureGradient_ToBase_KilopascalPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.BarPerCentimeter, 1d, 10000000.0d).SetName("PressureGradient_ToBase_BarPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.AtmospherePerMeter, 1d, 101325.0d).SetName("PressureGradient_ToBase_AtmospherePerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PsiPerInch, 1d, 271447.13752629922d).SetName("PressureGradient_ToBase_PsiPerInch");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.InchMercuryPerFoot, 1d, 11110.197368405512d).SetName("PressureGradient_ToBase_InchMercuryPerFoot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerMeter, 1d, 1.0d).SetName("PressureGradient_FromBase_PascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.KilopascalPerMeter, 1d, 0.001d).SetName("PressureGradient_FromBase_KilopascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerCentimeter, 1d, 0.01d).SetName("PressureGradient_FromBase_PascalPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.BarPerMeter, 1d, 1.0000000000000001e-05d).SetName("PressureGradient_FromBase_BarPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.MillimeterMercuryPerMeter, 1d, 0.0075006157584565627d).SetName("PressureGradient_FromBase_MillimeterMercuryPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PsiPerFoot, 1d, 4.4207502460170088e-05d).SetName("PressureGradient_FromBase_PsiPerFoot");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PascalPerMillimeter, 1d, 0.001d).SetName("PressureGradient_FromBase_PascalPerMillimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.MegapascalPerMeter, 1d, 9.9999999999999995e-07d).SetName("PressureGradient_FromBase_MegapascalPerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.KilopascalPerCentimeter, 1d, 1.0000000000000001e-05d).SetName("PressureGradient_FromBase_KilopascalPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.BarPerCentimeter, 1d, 9.9999999999999995e-08d).SetName("PressureGradient_FromBase_BarPerCentimeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.AtmospherePerMeter, 1d, 9.8692326671601285e-06d).SetName("PressureGradient_FromBase_AtmospherePerMeter");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.PsiPerInch, 1d, 3.6839585383475071e-06d).SetName("PressureGradient_FromBase_PsiPerInch");
            yield return new TestCaseData(UnitConverterPressureGradientUnit.InchMercuryPerFoot, 1d, 9.0007401924626265e-05d).SetName("PressureGradient_FromBase_InchMercuryPerFoot");
        }
    }
}
