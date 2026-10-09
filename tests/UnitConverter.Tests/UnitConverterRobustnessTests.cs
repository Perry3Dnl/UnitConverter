namespace UnitConverter.Tests
{
    using System;
    using NUnit.Framework;
    using UnitConverter.Length;

    public sealed class UnitConverterRobustnessTests
    {
        [Test]
        public void ExactTryConvert_UnsupportedEnumReturnsFalseInsteadOfTypeInitializationFailure()
        {
            decimal result;

            Assert.That(
                UnitConverterExact.TryConvert(
                    1m,
                    DayOfWeek.Monday,
                    DayOfWeek.Tuesday,
                    out result),
                Is.False);
            Assert.That(result, Is.EqualTo(decimal.Zero));
        }

        [Test]
        public void ExactTryConvert_NonEnumStructReturnsFalse()
        {
            decimal result;

            Assert.That(
                UnitConverterExact.TryConvert(
                    1m,
                    1,
                    2,
                    out result),
                Is.False);
            Assert.That(result, Is.EqualTo(decimal.Zero));
        }

        [Test]
        public void ParserTryConvert_UnsupportedUnitTypeReturnsFailure()
        {
            UnitConverterConversionResult result =
                UnitConverterParser.TryConvert(
                    "1 Monday",
                    DayOfWeek.Tuesday);

            Assert.That(result.Success, Is.False);
            Assert.That(result.ErrorMessage, Is.Not.Empty);
        }

        [Test]
        public void ParserTryConvert_InvalidTargetUnitReturnsFailure()
        {
            UnitConverterConversionResult result =
                UnitConverterParser.TryConvert(
                    "1 m",
                    (UnitConverterLengthUnit)int.MaxValue);

            Assert.That(result.Success, Is.False);
            Assert.That(result.ErrorMessage, Is.Not.Empty);
        }

        [Test]
        public void UnitValueTo_InvalidTargetUnitFailsBeforeConversion()
        {
            var value =
                new UnitValue<UnitConverterLengthUnit>(
                    1d,
                    UnitConverterLengthUnit.Meter);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                value.To((UnitConverterLengthUnit)int.MaxValue));
        }
    }
}
