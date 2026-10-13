namespace UnitTools.Tests
{
    using System.Numerics;
    using NUnit.Framework;
    using UnitTools.Numbers;

    public sealed class GamingNumberNotationTests
    {
        [TestCase("a", "1e36")]
        [TestCase("b", "1e39")]
        [TestCase("z", "1e111")]
        [TestCase("aa", "1e114")]
        [TestCase("ab", "1e117")]
        [TestCase("az", "1e189")]
        [TestCase("ba", "1e192")]
        public void SuffixesHaveStablePowers(string suffix, string expected)
        {
            Assert.That(GamingNumberNotation.Parse("1" + suffix).ToScientific(),
                Is.EqualTo(expected));
        }

        [TestCase("1a")]
        [TestCase("2.5b")]
        [TestCase("-7aa")]
        [TestCase("999z")]
        [TestCase("0.001ab")]
        public void FormatAndParseRoundTrip(string input)
        {
            var number = GamingNumberNotation.Parse(input);
            Assert.That(GamingNumberNotation.Parse(
                GamingNumberNotation.Format(number)), Is.EqualTo(number));
        }

        [Test]
        public void LongSuffixesAreReversible()
        {
            BigInteger[] indices = { 0, 25, 26, 701, 702, 100000 };
            foreach (BigInteger index in indices)
            {
                BigInteger decoded;
                Assert.That(GamingNumberNotation.TryGetIndex(
                    GamingNumberNotation.GetSuffix(index), out decoded), Is.True);
                Assert.That(decoded, Is.EqualTo(index));
            }
        }

        [Test]
        public void InvalidInputIsRejected()
        {
            ArbitraryScaleNumber value;
            Assert.That(GamingNumberNotation.TryParse("1A", out value), Is.False);
            Assert.That(GamingNumberNotation.TryParse("hello", out value), Is.False);
            Assert.That(GamingNumberNotation.TryParse("1a2", out value), Is.False);
        }
    }
}
