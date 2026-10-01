namespace RealisticPhysics.Core.Tests
{
    using NUnit.Framework;

    public sealed class RealisticPhysicsCoreTests
    {
        [Test]
        public void SuiteVersion_IsDefined()
        {
            RealisticPhysicsTestAssert.IsNotNullOrWhiteSpace(
                RealisticPhysicsSuiteVersion.Version,
                "RealisticPhysics suite version should always be defined.");
        }

        [Test]
        public void TestAssert_AcceptsCloseValues()
        {
            RealisticPhysicsTestAssert.AreApproximatelyEqual(
                1.0d,
                1.0000001d,
                absoluteTolerance: 0.000001d);
        }
    }
}
