namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.Tests.Utilities;
    using UnitTools.Length;
    using UnitTools.Mass;

    public sealed class UnitToolsExtensionMethodTests
    {
        [Test]
        public void DoubleExtension_UsesLengthConverter()
        {
            double value = 12.5d;

            double result = value.Convert(
                UnitToolsLengthUnit.Centimeter,
                UnitToolsLengthUnit.Millimeter);

            UnitToolsTestAssert.AreApproximatelyEqual(125d, result);
        }

        [Test]
        public void FloatExtension_UsesLengthConverter()
        {
            float value = 1f;

            float result = value.Convert(
                UnitToolsLengthUnit.Meter,
                UnitToolsLengthUnit.Centimeter);

            Assert.AreEqual(100f, result, 0.0001f);
        }

        [Test]
        public void IntegerExtension_ReturnsDoubleToPreserveFractionalResults()
        {
            int value = 1;

            double result = value.Convert(
                UnitToolsMassUnit.Pound,
                UnitToolsMassUnit.Kilogram);

            UnitToolsTestAssert.AreApproximatelyEqual(0.45359237d, result);
        }
    }
}
