namespace RealisticPhysics.UnitConversion.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using RealisticPhysics.UnitConversion.Tests.Utilities;
    using RealisticPhysics.UnitConversion.Force;

    public sealed class UnitConverterKnownValueForceTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Force_ToBaseUnit_ReturnsExpectedValue(UnitConverterForceUnit unit, double input, double expected)
        {
            double result = UnitConverterForce.ToNewton(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Force_FromBaseUnit_ReturnsExpectedValue(UnitConverterForceUnit unit, double input, double expected)
        {
            double result = UnitConverterForce.FromNewton(input, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Force_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitConverterForceUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitConverterForce.ToNewton(input, unit);
            double result = UnitConverterForce.FromNewton(baseValue, unit);
            RealisticPhysicsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitConverterForceUnit.Micronewton, 1d, 9.9999999999999995e-07d).SetName("Force_ToBase_Micronewton");
            yield return new TestCaseData(UnitConverterForceUnit.Millinewton, 1d, 0.001d).SetName("Force_ToBase_Millinewton");
            yield return new TestCaseData(UnitConverterForceUnit.Newton, 1d, 1.0d).SetName("Force_ToBase_Newton");
            yield return new TestCaseData(UnitConverterForceUnit.Kilonewton, 1d, 1000.0d).SetName("Force_ToBase_Kilonewton");
            yield return new TestCaseData(UnitConverterForceUnit.Meganewton, 1d, 1000000.0d).SetName("Force_ToBase_Meganewton");
            yield return new TestCaseData(UnitConverterForceUnit.Dyne, 1d, 1.0000000000000001e-05d).SetName("Force_ToBase_Dyne");
            yield return new TestCaseData(UnitConverterForceUnit.PoundForce, 1d, 4.4482216152604996d).SetName("Force_ToBase_PoundForce");
            yield return new TestCaseData(UnitConverterForceUnit.OunceForce, 1d, 0.27801385095378123d).SetName("Force_ToBase_OunceForce");
            yield return new TestCaseData(UnitConverterForceUnit.Kip, 1d, 4448.2216152604997d).SetName("Force_ToBase_Kip");
            yield return new TestCaseData(UnitConverterForceUnit.Poundal, 1d, 0.13825495437599999d).SetName("Force_ToBase_Poundal");
            yield return new TestCaseData(UnitConverterForceUnit.KilogramForce, 1d, 9.8066499999999994d).SetName("Force_ToBase_KilogramForce");
            yield return new TestCaseData(UnitConverterForceUnit.TonForceUS, 1d, 8896.4432305209994d).SetName("Force_ToBase_TonForceUS");
            yield return new TestCaseData(UnitConverterForceUnit.TonForceUK, 1d, 9964.0164181835207d).SetName("Force_ToBase_TonForceUK");
            yield return new TestCaseData(UnitConverterForceUnit.Piconewton, 1d, 9.9999999999999998e-13d).SetName("Force_ToBase_Piconewton");
            yield return new TestCaseData(UnitConverterForceUnit.Nanonewton, 1d, 1.0000000000000001e-09d).SetName("Force_ToBase_Nanonewton");
            yield return new TestCaseData(UnitConverterForceUnit.GramForce, 1d, 0.0098066500000000001d).SetName("Force_ToBase_GramForce");
            yield return new TestCaseData(UnitConverterForceUnit.MilligramForce, 1d, 9.8066500000000004e-06d).SetName("Force_ToBase_MilligramForce");
            yield return new TestCaseData(UnitConverterForceUnit.Pond, 1d, 0.0098066500000000001d).SetName("Force_ToBase_Pond");
            yield return new TestCaseData(UnitConverterForceUnit.Sthene, 1d, 1000.0d).SetName("Force_ToBase_Sthene");
            yield return new TestCaseData(UnitConverterForceUnit.JoulePerMeter, 1d, 1.0d).SetName("Force_ToBase_JoulePerMeter");
            yield return new TestCaseData(UnitConverterForceUnit.PlanckForce, 1d, 1.2102699999999999e+44d).SetName("Force_ToBase_PlanckForce");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitConverterForceUnit.Micronewton, 1d, 1000000.0d).SetName("Force_FromBase_Micronewton");
            yield return new TestCaseData(UnitConverterForceUnit.Millinewton, 1d, 1000.0d).SetName("Force_FromBase_Millinewton");
            yield return new TestCaseData(UnitConverterForceUnit.Newton, 1d, 1.0d).SetName("Force_FromBase_Newton");
            yield return new TestCaseData(UnitConverterForceUnit.Kilonewton, 1d, 0.001d).SetName("Force_FromBase_Kilonewton");
            yield return new TestCaseData(UnitConverterForceUnit.Meganewton, 1d, 9.9999999999999995e-07d).SetName("Force_FromBase_Meganewton");
            yield return new TestCaseData(UnitConverterForceUnit.Dyne, 1d, 99999.999999999985d).SetName("Force_FromBase_Dyne");
            yield return new TestCaseData(UnitConverterForceUnit.PoundForce, 1d, 0.2248089430997105d).SetName("Force_FromBase_PoundForce");
            yield return new TestCaseData(UnitConverterForceUnit.OunceForce, 1d, 3.596943089595368d).SetName("Force_FromBase_OunceForce");
            yield return new TestCaseData(UnitConverterForceUnit.Kip, 1d, 0.0002248089430997105d).SetName("Force_FromBase_Kip");
            yield return new TestCaseData(UnitConverterForceUnit.Poundal, 1d, 7.2330138512098943d).SetName("Force_FromBase_Poundal");
            yield return new TestCaseData(UnitConverterForceUnit.KilogramForce, 1d, 0.10197162129779283d).SetName("Force_FromBase_KilogramForce");
            yield return new TestCaseData(UnitConverterForceUnit.TonForceUS, 1d, 0.00011240447154985525d).SetName("Force_FromBase_TonForceUS");
            yield return new TestCaseData(UnitConverterForceUnit.TonForceUK, 1d, 0.00010036113531237075d).SetName("Force_FromBase_TonForceUK");
            yield return new TestCaseData(UnitConverterForceUnit.Piconewton, 1d, 1000000000000.0d).SetName("Force_FromBase_Piconewton");
            yield return new TestCaseData(UnitConverterForceUnit.Nanonewton, 1d, 999999999.99999988d).SetName("Force_FromBase_Nanonewton");
            yield return new TestCaseData(UnitConverterForceUnit.GramForce, 1d, 101.97162129779282d).SetName("Force_FromBase_GramForce");
            yield return new TestCaseData(UnitConverterForceUnit.MilligramForce, 1d, 101971.62129779282d).SetName("Force_FromBase_MilligramForce");
            yield return new TestCaseData(UnitConverterForceUnit.Pond, 1d, 101.97162129779282d).SetName("Force_FromBase_Pond");
            yield return new TestCaseData(UnitConverterForceUnit.Sthene, 1d, 0.001d).SetName("Force_FromBase_Sthene");
            yield return new TestCaseData(UnitConverterForceUnit.JoulePerMeter, 1d, 1.0d).SetName("Force_FromBase_JoulePerMeter");
            yield return new TestCaseData(UnitConverterForceUnit.PlanckForce, 1d, 8.2626190849975632e-45d).SetName("Force_FromBase_PlanckForce");
        }
    }
}
