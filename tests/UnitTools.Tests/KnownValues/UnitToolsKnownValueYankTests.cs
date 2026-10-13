namespace UnitTools.Tests.KnownValues
{
    using System.Collections;
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Yank;

    public sealed class UnitToolsKnownValueYankTests
    {
        [TestCaseSource(nameof(ToBaseCases))]
        public void Yank_ToBaseUnit_ReturnsExpectedValue(UnitToolsYankUnit unit, double input, double expected)
        {
            double result = UnitToolsYank.ToNewtonPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(FromBaseCases))]
        public void Yank_FromBaseUnit_ReturnsExpectedValue(UnitToolsYankUnit unit, double input, double expected)
        {
            double result = UnitToolsYank.FromNewtonPerSecond(input, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(expected, result, absoluteTolerance: 0.000000001d, relativeTolerance: 0.000000001d);
        }

        [TestCaseSource(nameof(ToBaseCases))]
        public void Yank_RoundTripFromUnitToBaseAndBack_ReturnsOriginalValue(UnitToolsYankUnit unit, double input, double expectedBaseValue)
        {
            double baseValue = UnitToolsYank.ToNewtonPerSecond(input, unit);
            double result = UnitToolsYank.FromNewtonPerSecond(baseValue, unit);
            UnitToolsTestAssert.AreApproximatelyEqual(input, result, absoluteTolerance: 0.0000001d, relativeTolerance: 0.0000001d);
        }

        private static IEnumerable ToBaseCases()
        {
            yield return new TestCaseData(UnitToolsYankUnit.NewtonPerSecond, 1d, 1.0d).SetName("Yank_ToBase_NewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.KilonewtonPerSecond, 1d, 1000.0d).SetName("Yank_ToBase_KilonewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.DynePerSecond, 1d, 1.0000000000000001e-05d).SetName("Yank_ToBase_DynePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.PoundForcePerSecond, 1d, 4.4482216152604996d).SetName("Yank_ToBase_PoundForcePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MillinewtonPerSecond, 1d, 0.001d).SetName("Yank_ToBase_MillinewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MicronewtonPerSecond, 1d, 9.9999999999999995e-07d).SetName("Yank_ToBase_MicronewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MeganewtonPerSecond, 1d, 1000000.0d).SetName("Yank_ToBase_MeganewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.NewtonPerMinute, 1d, 0.016666666666666666d).SetName("Yank_ToBase_NewtonPerMinute");
            yield return new TestCaseData(UnitToolsYankUnit.PoundForcePerMinute, 1d, 0.074137026921008334d).SetName("Yank_ToBase_PoundForcePerMinute");
            yield return new TestCaseData(UnitToolsYankUnit.KilogramForcePerSecond, 1d, 9.8066499999999994d).SetName("Yank_ToBase_KilogramForcePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.OunceForcePerSecond, 1d, 0.27801385095378123d).SetName("Yank_ToBase_OunceForcePerSecond");
        }

        private static IEnumerable FromBaseCases()
        {
            yield return new TestCaseData(UnitToolsYankUnit.NewtonPerSecond, 1d, 1.0d).SetName("Yank_FromBase_NewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.KilonewtonPerSecond, 1d, 0.001d).SetName("Yank_FromBase_KilonewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.DynePerSecond, 1d, 99999.999999999985d).SetName("Yank_FromBase_DynePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.PoundForcePerSecond, 1d, 0.2248089430997105d).SetName("Yank_FromBase_PoundForcePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MillinewtonPerSecond, 1d, 1000.0d).SetName("Yank_FromBase_MillinewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MicronewtonPerSecond, 1d, 1000000.0d).SetName("Yank_FromBase_MicronewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.MeganewtonPerSecond, 1d, 9.9999999999999995e-07d).SetName("Yank_FromBase_MeganewtonPerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.NewtonPerMinute, 1d, 60.0d).SetName("Yank_FromBase_NewtonPerMinute");
            yield return new TestCaseData(UnitToolsYankUnit.PoundForcePerMinute, 1d, 13.488536585982629d).SetName("Yank_FromBase_PoundForcePerMinute");
            yield return new TestCaseData(UnitToolsYankUnit.KilogramForcePerSecond, 1d, 0.10197162129779283d).SetName("Yank_FromBase_KilogramForcePerSecond");
            yield return new TestCaseData(UnitToolsYankUnit.OunceForcePerSecond, 1d, 3.596943089595368d).SetName("Yank_FromBase_OunceForcePerSecond");
        }
    }
}
