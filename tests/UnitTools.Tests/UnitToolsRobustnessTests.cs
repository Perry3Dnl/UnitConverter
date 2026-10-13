namespace UnitTools.Tests
{
    using System;
    using NUnit.Framework;
    using UnitTools.Length;

    public sealed class UnitToolsRobustnessTests
    {
        [Test]
        public void ExactTryConvert_UnsupportedEnumReturnsFalseInsteadOfTypeInitializationFailure()
        {
            decimal result;

            Assert.That(
                UnitToolsExact.TryConvert(
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
                UnitToolsExact.TryConvert(
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
            UnitToolsConversionResult result =
                UnitToolsParser.TryConvert(
                    "1 Monday",
                    DayOfWeek.Tuesday);

            Assert.That(result.Success, Is.False);
            Assert.That(result.ErrorMessage, Is.Not.Empty);
        }

        [Test]
        public void ParserTryConvert_InvalidTargetUnitReturnsFailure()
        {
            UnitToolsConversionResult result =
                UnitToolsParser.TryConvert(
                    "1 m",
                    (UnitToolsLengthUnit)int.MaxValue);

            Assert.That(result.Success, Is.False);
            Assert.That(result.ErrorMessage, Is.Not.Empty);
        }

        [Test]
        public void UnitValueTo_InvalidTargetUnitFailsBeforeConversion()
        {
            var value =
                new UnitValue<UnitToolsLengthUnit>(
                    1d,
                    UnitToolsLengthUnit.Meter);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                value.To((UnitToolsLengthUnit)int.MaxValue));
        }
    }
}
