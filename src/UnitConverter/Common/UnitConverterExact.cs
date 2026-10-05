namespace UnitConverter
{
    using System;
    using System.Globalization;
    using System.Numerics;

    // Exact rational intermediates prevent precision loss and avoid overflowing
    // a base unit when the final decimal result is representable.
    internal readonly struct UnitConverterExact
    {
        private readonly BigInteger numerator;
        private readonly BigInteger denominator;

        private UnitConverterExact(BigInteger numerator, BigInteger denominator)
        {
            if (denominator.IsZero) throw new DivideByZeroException("The conversion is undefined at this value.");
            if (denominator.Sign < 0) { numerator = -numerator; denominator = -denominator; }
            var gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        internal static UnitConverterExact FromDecimal(decimal value)
        {
            var bits = decimal.GetBits(value);
            var n = new BigInteger((uint)bits[0]) + (new BigInteger((uint)bits[1]) << 32) + (new BigInteger((uint)bits[2]) << 64);
            if (bits[3] < 0) n = -n;
            return new UnitConverterExact(n, BigInteger.Pow(10, (bits[3] >> 16) & 255));
        }

        internal UnitConverterExact Apply(string coefficients)
        {
            if (coefficients == null) throw new NotSupportedException("This conversion requires transcendental arithmetic. Use the double API.");
            var parts = coefficients.Split(',');
            var a = BigInteger.Parse(parts[0], CultureInfo.InvariantCulture);
            var b = BigInteger.Parse(parts[1], CultureInfo.InvariantCulture);
            var c = BigInteger.Parse(parts[2], CultureInfo.InvariantCulture);
            var d = BigInteger.Parse(parts[3], CultureInfo.InvariantCulture);
            return new UnitConverterExact(a * denominator + b * numerator, c * denominator + d * numerator);
        }

        internal decimal ToDecimal()
        {
            var n = BigInteger.Abs(numerator);
            var max = (BigInteger.One << 96) - 1;
            if (n > max * denominator) throw new OverflowException("The converted value is outside the decimal range.");
            for (var scale = 28; scale >= 0; scale--)
            {
                BigInteger remainder;
                var q = BigInteger.DivRem(n * BigInteger.Pow(10, scale), denominator, out remainder);
                var comparison = (remainder * 2).CompareTo(denominator);
                if (comparison > 0 || (comparison == 0 && !q.IsEven)) q++;
                if (q > max) continue;
                return new decimal((int)(uint)(q & uint.MaxValue), (int)(uint)((q >> 32) & uint.MaxValue),
                    (int)(uint)((q >> 64) & uint.MaxValue), numerator.Sign < 0, (byte)scale);
            }
            throw new OverflowException("The converted value is outside the decimal range.");
        }
    }
}
