namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Torque;

    public sealed class UnitToolsKnownValueTorqueTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Torque_ToBaseUnit_ReturnsExpectedValue(UnitToolsTorqueUnit unit, double input, double expected)
        {
            double result = UnitToolsTorque.ToNewtonMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Torque_FromBaseUnit_ReturnsExpectedValue(UnitToolsTorqueUnit unit, double input, double expected)
        {
            double result = UnitToolsTorque.FromNewtonMeter(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Torque_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsTorqueUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsTorque.ToNewtonMeter(input, unit);
            double result = UnitToolsTorque.FromNewtonMeter(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonMeter, 1d, 1.0d).SetName("Torque_ToBase_NewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilonewtonMeter, 1d, 1000.0d).SetName("Torque_ToBase_KilonewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.DyneCentimeter, 1d, 9.9999999999999995e-08d).SetName("Torque_ToBase_DyneCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceFoot, 1d, 1.3558179483314003d).SetName("Torque_ToBase_PoundForceFoot");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceInch, 1d, 0.1129848290276167d).SetName("Torque_ToBase_PoundForceInch");
            yield return new TestCaseData(UnitToolsTorqueUnit.OunceForceInch, 1d, 0.0070615518142260001d).SetName("Torque_ToBase_OunceForceInch");
            yield return new TestCaseData(UnitToolsTorqueUnit.MillinewtonMeter, 1d, 0.001d).SetName("Torque_ToBase_MillinewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.MicronewtonMeter, 1d, 9.9999999999999995e-07d).SetName("Torque_ToBase_MicronewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.MeganewtonMeter, 1d, 1000000.0d).SetName("Torque_ToBase_MeganewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonCentimeter, 1d, 0.01d).SetName("Torque_ToBase_NewtonCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonMillimeter, 1d, 0.001d).SetName("Torque_ToBase_NewtonMillimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilogramForceMeter, 1d, 9.8066499999999994d).SetName("Torque_ToBase_KilogramForceMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilogramForceCentimeter, 1d, 0.098066500000000001d).SetName("Torque_ToBase_KilogramForceCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.GramForceCentimeter, 1d, 9.80665e-05d).SetName("Torque_ToBase_GramForceCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.DyneMeter, 1d, 1.0000000000000001e-05d).SetName("Torque_ToBase_DyneMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceYard, 1d, 4.0674538449942013d).SetName("Torque_ToBase_PoundForceYard");
            yield return new TestCaseData(UnitToolsTorqueUnit.OunceForceFoot, 1d, 0.084738621770712522d).SetName("Torque_ToBase_OunceForceFoot");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundalFoot, 1d, 0.042140110093804799d).SetName("Torque_ToBase_PoundalFoot");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonMeter, 1d, 1.0d).SetName("Torque_FromBase_NewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilonewtonMeter, 1d, 0.001d).SetName("Torque_FromBase_KilonewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.DyneCentimeter, 1d, 10000000.0d).SetName("Torque_FromBase_DyneCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceFoot, 1d, 0.73756214927726538d).SetName("Torque_FromBase_PoundForceFoot");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceInch, 1d, 8.850745791327185d).SetName("Torque_FromBase_PoundForceInch");
            yield return new TestCaseData(UnitToolsTorqueUnit.OunceForceInch, 1d, 141.61193266123581d).SetName("Torque_FromBase_OunceForceInch");
            yield return new TestCaseData(UnitToolsTorqueUnit.MillinewtonMeter, 1d, 1000.0d).SetName("Torque_FromBase_MillinewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.MicronewtonMeter, 1d, 1000000.0d).SetName("Torque_FromBase_MicronewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.MeganewtonMeter, 1d, 9.9999999999999995e-07d).SetName("Torque_FromBase_MeganewtonMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonCentimeter, 1d, 100.0d).SetName("Torque_FromBase_NewtonCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.NewtonMillimeter, 1d, 1000.0d).SetName("Torque_FromBase_NewtonMillimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilogramForceMeter, 1d, 0.10197162129779283d).SetName("Torque_FromBase_KilogramForceMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.KilogramForceCentimeter, 1d, 10.197162129779283d).SetName("Torque_FromBase_KilogramForceCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.GramForceCentimeter, 1d, 10197.162129779283d).SetName("Torque_FromBase_GramForceCentimeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.DyneMeter, 1d, 99999.999999999985d).SetName("Torque_FromBase_DyneMeter");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundForceYard, 1d, 0.24585404975908845d).SetName("Torque_FromBase_PoundForceYard");
            yield return new TestCaseData(UnitToolsTorqueUnit.OunceForceFoot, 1d, 11.800994388436246d).SetName("Torque_FromBase_OunceForceFoot");
            yield return new TestCaseData(UnitToolsTorqueUnit.PoundalFoot, 1d, 23.730360404231938d).SetName("Torque_FromBase_PoundalFoot");
        }
    }
}
