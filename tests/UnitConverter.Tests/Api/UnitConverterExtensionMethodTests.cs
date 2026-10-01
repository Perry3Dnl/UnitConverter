namespace UnitConverter.Tests
{
    using NUnit.Framework;
    using UnitConverter.Tests.Utilities;
    using UnitConverter.Length;
    using UnitConverter.Mass;

    public sealed class UnitConverterExtensionMethodTests
    {
        [Test]
        public void DoubleExtension_UsesLengthConverter()
        {
            double value = 12.5d;

            double result = value.Convert(
                UnitConverterLengthUnit.Centimeter,
                UnitConverterLengthUnit.Millimeter);

            UnitConverterTestAssert.AreApproximatelyEqual(125d, result);
        }

        [Test]
        public void FloatExtension_UsesLengthConverter()
        {
            float value = 1f;

            float result = value.Convert(
                UnitConverterLengthUnit.Meter,
                UnitConverterLengthUnit.Centimeter);

            Assert.AreEqual(100f, result, 0.0001f);
        }

        [Test]
        public void IntegerExtension_ReturnsDoubleToPreserveFractionalResults()
        {
            int value = 1;

            double result = value.Convert(
                UnitConverterMassUnit.Pound,
                UnitConverterMassUnit.Kilogram);

            UnitConverterTestAssert.AreApproximatelyEqual(0.45359237d, result);
        }
    }
}
