namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.RadiationExposure;

    public sealed class UnitToolsKnownValueRadiationExposureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationExposure_ToBaseUnit_ReturnsExpectedValue(UnitToolsRadiationExposureUnit unit, double input, double expected)
        {
            double result = UnitToolsRadiationExposure.ToCoulombPerKilogram(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void RadiationExposure_FromBaseUnit_ReturnsExpectedValue(UnitToolsRadiationExposureUnit unit, double input, double expected)
        {
            double result = UnitToolsRadiationExposure.FromCoulombPerKilogram(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void RadiationExposure_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsRadiationExposureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsRadiationExposure.ToCoulombPerKilogram(input, unit);
            double result = UnitToolsRadiationExposure.FromCoulombPerKilogram(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.CoulombPerKilogram, 1d, 1.0d).SetName("RadiationExposure_ToBase_CoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MillicoulombPerKilogram, 1d, 0.001d).SetName("RadiationExposure_ToBase_MillicoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram, 1d, 9.9999999999999995e-07d).SetName("RadiationExposure_ToBase_MicrocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Roentgen, 1d, 0.00025799999999999998d).SetName("RadiationExposure_ToBase_Roentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Milliroentgen, 1d, 2.5800000000000001e-07d).SetName("RadiationExposure_ToBase_Milliroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.NanocoulombPerKilogram, 1d, 1.0000000000000001e-09d).SetName("RadiationExposure_ToBase_NanocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.PicocoulombPerKilogram, 1d, 9.9999999999999998e-13d).SetName("RadiationExposure_ToBase_PicocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Kiloroentgen, 1d, 0.25800000000000001d).SetName("RadiationExposure_ToBase_Kiloroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Microroentgen, 1d, 2.5799999999999999e-10d).SetName("RadiationExposure_ToBase_Microroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Nanoroentgen, 1d, 2.5800000000000001e-13d).SetName("RadiationExposure_ToBase_Nanoroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Picoroentgen, 1d, 2.58e-16d).SetName("RadiationExposure_ToBase_Picoroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.CoulombPerGram, 1d, 1000.0d).SetName("RadiationExposure_ToBase_CoulombPerGram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MicrocoulombPerGram, 1d, 0.001d).SetName("RadiationExposure_ToBase_MicrocoulombPerGram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.StatcoulombPerGram, 1d, 3.3356409519815198e-07d).SetName("RadiationExposure_ToBase_StatcoulombPerGram");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.CoulombPerKilogram, 1d, 1.0d).SetName("RadiationExposure_FromBase_CoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MillicoulombPerKilogram, 1d, 1000.0d).SetName("RadiationExposure_FromBase_MillicoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MicrocoulombPerKilogram, 1d, 1000000.0d).SetName("RadiationExposure_FromBase_MicrocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Roentgen, 1d, 3875.9689922480625d).SetName("RadiationExposure_FromBase_Roentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Milliroentgen, 1d, 3875968.992248062d).SetName("RadiationExposure_FromBase_Milliroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.NanocoulombPerKilogram, 1d, 999999999.99999988d).SetName("RadiationExposure_FromBase_NanocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.PicocoulombPerKilogram, 1d, 1000000000000.0d).SetName("RadiationExposure_FromBase_PicocoulombPerKilogram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Kiloroentgen, 1d, 3.8759689922480618d).SetName("RadiationExposure_FromBase_Kiloroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Microroentgen, 1d, 3875968992.2480621d).SetName("RadiationExposure_FromBase_Microroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Nanoroentgen, 1d, 3875968992248.062d).SetName("RadiationExposure_FromBase_Nanoroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.Picoroentgen, 1d, 3875968992248062.0d).SetName("RadiationExposure_FromBase_Picoroentgen");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.CoulombPerGram, 1d, 0.001d).SetName("RadiationExposure_FromBase_CoulombPerGram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.MicrocoulombPerGram, 1d, 1000.0d).SetName("RadiationExposure_FromBase_MicrocoulombPerGram");
            yield return new TestCaseData(UnitToolsRadiationExposureUnit.StatcoulombPerGram, 1d, 2997924.5800000005d).SetName("RadiationExposure_FromBase_StatcoulombPerGram");
        }
    }
}
