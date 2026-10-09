namespace UnitConverter.Tests
{
    using System;
    using System.Globalization;
    using NUnit.Framework;
    using UnitConverter.Length;

    public sealed class UnitConverterParserAbuseTests
    {
        private static readonly string[] MalformedInputs =
        {
            "",
            " ",
            "\t\r\n",
            "km",
            "1",
            "--1 km",
            "++1 km",
            "1..2 km",
            "1e999999999 km",
            "NaN km",
            "Infinity km",
            "1 unknown-unit",
            "1 km\0m",
            "1 (((km",
            "1 km)))",
        };

        [Test]
        public void ParserTryApis_NeverThrowForDeterministicMalformedText()
        {
            foreach (string input in MalformedInputs)
            {
                Assert.DoesNotThrow(() =>
                {
                    double value;
                    UnitConverterLengthUnit unit;
                    UnitConverterParser.TryParse(input, CultureInfo.InvariantCulture, out value, out unit);
                    UnitConverterParser.TryConvert(input, UnitConverterLengthUnit.Meter, CultureInfo.InvariantCulture);
                }, input);
            }
        }

        [Test]
        public void ExpressionTryParse_NeverThrowsForMalformedGrammar()
        {
            string[] expressions =
            {
                "", " ", "*", "/", "^", "()", "(m", "m)", "m**s", "m//s",
                "m^^2", "m^", "m^+", "m^-", "m^999999999999999999999",
                "m/()", "(((((m))", "unknown*unit", "m\0/s",
            };

            foreach (string expression in expressions)
            {
                Assert.DoesNotThrow(() => UnitConverterExpressionParser.TryParse(expression), expression);
            }
        }

        [Test]
        public void ParserTryApis_HandleSeededUnicodeAndAsciiNoiseWithoutThrowing()
        {
            var random = new Random(20261009);
            char[] alphabet =
            {
                '0', '1', '9', '.', ',', '+', '-', 'e', 'E', ' ', '\t',
                'm', 'k', 'g', 's', '/', '*', '^', '(', ')', '²', '³', '·',
                '°', 'Ω', 'µ', 'μ', '_', '?', '!', '\u00A0', '\u202F',
            };

            for (int sample = 0; sample < 2000; sample++)
            {
                int length = random.Next(0, 129);
                char[] chars = new char[length];
                for (int index = 0; index < chars.Length; index++)
                    chars[index] = alphabet[random.Next(alphabet.Length)];

                string input = new string(chars);
                Assert.DoesNotThrow(() =>
                {
                    double value;
                    UnitConverterLengthUnit unit;
                    UnitConverterParser.TryParse(input, CultureInfo.InvariantCulture, out value, out unit);
                    UnitConverterExpressionParser.TryParse(input);
                }, "Seeded sample " + sample);
            }
        }

        [Test]
        public void ExtremelyLongInvalidInputFailsWithoutStackGrowthOrUnexpectedExceptions()
        {
            string longUnit = "1 " + new string('x', 32768);
            double value;
            UnitConverterLengthUnit unit;

            Assert.That(
                UnitConverterParser.TryParse(longUnit, out value, out unit),
                Is.False);
            Assert.That(UnitConverterExpressionParser.TryParse(new string('(', 4096)).Success, Is.False);
        }
    }
}
