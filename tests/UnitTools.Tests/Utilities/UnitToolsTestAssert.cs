namespace UnitTools.Tests.Utilities
{
    using NUnit.Framework;

    public static class UnitToolsTestAssert
    {
        public static void AreApproximatelyEqual(
            double expected,
            double actual,
            double absoluteTolerance = 0.000001d,
            double relativeTolerance = 0.000001d)
        {
            double difference = System.Math.Abs(expected - actual);
            double allowed = System.Math.Max(absoluteTolerance, System.Math.Abs(expected) * relativeTolerance);

            Assert.LessOrEqual(
                difference,
                allowed,
                $"Expected {expected}, got {actual}. Difference {difference}, allowed {allowed}.");
        }

        public static void IsNotNullOrWhiteSpace(string value, string message = null)
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(value), message ?? "Expected a non-empty string.");
        }
    }
}
