namespace UnitTools.Tests
{
    using NUnit.Framework;
    using UnitTools.Numbers;

    public sealed class CompactNumberNotationTests
    {
        [TestCase("1K", "1e3")]
        [TestCase("1M", "1e6")]
        [TestCase("1B", "1e9")]
        [TestCase("1T", "1e12")]
        [TestCase("1Qa", "1e15")]
        [TestCase("1Qi", "1e18")]
        [TestCase("1Dc", "1e33")]
        public void SuffixesHaveStandardExponents(string text, string expected)
        {
            Assert.That(CompactNumberNotation.Parse(text).ToScientific(),
                Is.EqualTo(expected));
        }

        [TestCase("1.5M")]
        [TestCase("-3.25B")]
        [TestCase("999.9K")]
        [TestCase("12Dc")]
        [TestCase("2.5")]
        public void FormattingRoundTrips(string text)
        {
            var number = CompactNumberNotation.Parse(text);
            var output = CompactNumberNotation.Format(number);
            Assert.That(CompactNumberNotation.Parse(output), Is.EqualTo(number));
        }

        [Test]
        public void CaseSensitiveSymbolsDoNotConfuseMilliAndMillion()
        {
            ArbitraryScaleNumber number;
            Assert.That(CompactNumberNotation.TryParse("5m", out number), Is.False);
            Assert.That(CompactNumberNotation.Parse("5M").ToScientific(),
                Is.EqualTo("5e6"));
        }

        [Test]
        public void HugeNumberFallsBackToScientificNotation()
        {
            var number = ArbitraryScaleNumber.Parse("1e10000");
            Assert.That(CompactNumberNotation.Format(number),
                Is.EqualTo("1e10000"));
        }
    }
}
