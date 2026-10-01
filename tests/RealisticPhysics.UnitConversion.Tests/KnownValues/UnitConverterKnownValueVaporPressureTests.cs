namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.VaporPressure;

    public sealed class UnitConverterKnownValueVaporPressureTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void VaporPressure_ToBaseUnit_ReturnsExpectedValue(UnitConverterVaporPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterVaporPressure.ToPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void VaporPressure_FromBaseUnit_ReturnsExpectedValue(UnitConverterVaporPressureUnit unit, double input, double expected)
        {
            double result = UnitConverterVaporPressure.FromPascal(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void VaporPressure_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterVaporPressureUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterVaporPressure.ToPascal(input, unit);
            double result = UnitConverterVaporPressure.FromPascal(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Pascal, 1d, 1.0d).SetName("VaporPressure_ToBase_Pascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Kilopascal, 1d, 1000.0d).SetName("VaporPressure_ToBase_Kilopascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Megapascal, 1d, 1000000.0d).SetName("VaporPressure_ToBase_Megapascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Bar, 1d, 100000.0d).SetName("VaporPressure_ToBase_Bar");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Millibar, 1d, 100.0d).SetName("VaporPressure_ToBase_Millibar");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Atmosphere, 1d, 101325.0d).SetName("VaporPressure_ToBase_Atmosphere");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Torr, 1d, 133.32236842105263d).SetName("VaporPressure_ToBase_Torr");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Psi, 1d, 6894.7572931679997d).SetName("VaporPressure_ToBase_Psi");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Hectopascal, 1d, 100.0d).SetName("VaporPressure_ToBase_Hectopascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Micropascal, 1d, 9.9999999999999995e-07d).SetName("VaporPressure_ToBase_Micropascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Millipascal, 1d, 0.001d).SetName("VaporPressure_ToBase_Millipascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter, 1d, 98066.5d).SetName("VaporPressure_ToBase_KilogramForcePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.InchMercury, 1d, 3386.38815789d).SetName("VaporPressure_ToBase_InchMercury");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.InchWater, 1d, 249.08891d).SetName("VaporPressure_ToBase_InchWater");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Pascal, 1d, 1.0d).SetName("VaporPressure_FromBase_Pascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Kilopascal, 1d, 0.001d).SetName("VaporPressure_FromBase_Kilopascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Megapascal, 1d, 9.9999999999999995e-07d).SetName("VaporPressure_FromBase_Megapascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Bar, 1d, 1.0000000000000001e-05d).SetName("VaporPressure_FromBase_Bar");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Millibar, 1d, 0.01d).SetName("VaporPressure_FromBase_Millibar");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Atmosphere, 1d, 9.8692326671601285e-06d).SetName("VaporPressure_FromBase_Atmosphere");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Torr, 1d, 0.0075006168270416972d).SetName("VaporPressure_FromBase_Torr");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Psi, 1d, 0.00014503773773021683d).SetName("VaporPressure_FromBase_Psi");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Hectopascal, 1d, 0.01d).SetName("VaporPressure_FromBase_Hectopascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Micropascal, 1d, 1000000.0d).SetName("VaporPressure_FromBase_Micropascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.Millipascal, 1d, 1000.0d).SetName("VaporPressure_FromBase_Millipascal");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.KilogramForcePerSquareCentimeter, 1d, 1.0197162129779282e-05d).SetName("VaporPressure_FromBase_KilogramForcePerSquareCentimeter");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.InchMercury, 1d, 0.00029529987508079483d).SetName("VaporPressure_FromBase_InchMercury");
            yield return new TestCaseData(UnitConverterVaporPressureUnit.InchWater, 1d, 0.0040146307597556229d).SetName("VaporPressure_FromBase_InchWater");
        }
    }
}
