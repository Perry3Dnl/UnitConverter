namespace UnitConverter
{
    using System;
    using System.Globalization;
    using System.Numerics;

    internal readonly struct UnitConverterRational : IEquatable<UnitConverterRational>
    {
        private static readonly BigInteger DecimalMaxCoefficient =
            BigInteger.Parse("79228162514264337593543950335", CultureInfo.InvariantCulture);

        public UnitConverterRational(BigInteger numerator, BigInteger denominator)
        {
            if (denominator.IsZero)
                throw new DivideByZeroException();

            if (numerator.IsZero)
            {
                Numerator = BigInteger.Zero;
                Denominator = BigInteger.One;
                return;
            }

            if (denominator.Sign < 0)
            {
                numerator = BigInteger.Negate(numerator);
                denominator = BigInteger.Negate(denominator);
            }

            BigInteger gcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(numerator), denominator);
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }

        public BigInteger Numerator { get; }
        public BigInteger Denominator { get; }

        public static UnitConverterRational Zero => new UnitConverterRational(BigInteger.Zero, BigInteger.One);
        public static UnitConverterRational One => new UnitConverterRational(BigInteger.One, BigInteger.One);

        public static UnitConverterRational FromInt64(long value)
            => new UnitConverterRational(new BigInteger(value), BigInteger.One);

        public static UnitConverterRational FromDouble(double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, "A finite conversion factor is required.");

            return Parse(value.ToString("R", CultureInfo.InvariantCulture));
        }

        public static UnitConverterRational FromDecimal(decimal value)
        {
            GetDecimalParts(value, out BigInteger numerator, out BigInteger denominator);
            return new UnitConverterRational(numerator, denominator);
        }

        public static UnitConverterRational Parse(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new FormatException("A rational decimal value is required.");

            string value = text.Trim();
            bool negative = false;
            if (value[0] == '+' || value[0] == '-')
            {
                negative = value[0] == '-';
                value = value.Substring(1);
            }

            int exponent = 0;
            int exponentIndex = value.IndexOf('E');
            if (exponentIndex < 0)
                exponentIndex = value.IndexOf('e');

            if (exponentIndex >= 0)
            {
                exponent = int.Parse(value.Substring(exponentIndex + 1), NumberStyles.Integer, CultureInfo.InvariantCulture);
                value = value.Substring(0, exponentIndex);
            }

            int decimalIndex = value.IndexOf('.');
            int fractionalDigits = decimalIndex < 0 ? 0 : value.Length - decimalIndex - 1;
            string digits = decimalIndex < 0 ? value : value.Remove(decimalIndex, 1);
            if (digits.Length == 0)
                throw new FormatException("A rational decimal value is required.");

            BigInteger numerator = BigInteger.Parse(digits, NumberStyles.None, CultureInfo.InvariantCulture);
            if (negative)
                numerator = BigInteger.Negate(numerator);

            int power = exponent - fractionalDigits;
            if (power >= 0)
                return new UnitConverterRational(numerator * BigInteger.Pow(10, power), BigInteger.One);

            return new UnitConverterRational(numerator, BigInteger.Pow(10, -power));
        }

        public UnitConverterRational Add(UnitConverterRational other)
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(Denominator, other.Denominator);
            BigInteger leftMultiplier = other.Denominator / gcd;
            BigInteger rightMultiplier = Denominator / gcd;
            return new UnitConverterRational(
                Numerator * leftMultiplier + other.Numerator * rightMultiplier,
                Denominator * leftMultiplier);
        }

        public UnitConverterRational Subtract(UnitConverterRational other)
            => Add(other.Negate());

        public UnitConverterRational Multiply(UnitConverterRational other)
        {
            BigInteger leftGcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(Numerator), other.Denominator);
            BigInteger rightGcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(other.Numerator), Denominator);
            return new UnitConverterRational(
                (Numerator / leftGcd) * (other.Numerator / rightGcd),
                (Denominator / rightGcd) * (other.Denominator / leftGcd));
        }

        public UnitConverterRational Divide(UnitConverterRational other)
        {
            if (other.Numerator.IsZero)
                throw new DivideByZeroException();

            return Multiply(new UnitConverterRational(other.Denominator, other.Numerator));
        }

        public UnitConverterRational Negate()
            => new UnitConverterRational(BigInteger.Negate(Numerator), Denominator);

        public decimal Apply(decimal value)
        {
            GetDecimalParts(value, out BigInteger valueNumerator, out BigInteger valueDenominator);
            return DivideToDecimal(valueNumerator * Numerator, valueDenominator * Denominator);
        }

        public decimal ApplyInverse(decimal value)
        {
            if (Numerator.IsZero)
                throw new DivideByZeroException();

            GetDecimalParts(value, out BigInteger valueNumerator, out BigInteger valueDenominator);
            return DivideToDecimal(valueNumerator * Denominator, valueDenominator * Numerator);
        }

        public decimal DivideBy(decimal value)
        {
            GetDecimalParts(value, out BigInteger valueNumerator, out BigInteger valueDenominator);
            if (valueNumerator.IsZero)
                throw new DivideByZeroException();

            return DivideToDecimal(Numerator * valueDenominator, Denominator * valueNumerator);
        }

        public decimal ToDecimal() => Apply(1m);

        public double ToDouble() => (double)Numerator / (double)Denominator;

#if NET8_0_OR_GREATER
        public T Apply<T>(T value) where T : IFloatingPoint<T>
        {
            if (typeof(T) == typeof(decimal))
                return (T)(object)Apply((decimal)(object)value);

            if (Numerator <= Denominator)
                return ApplyInteger(ApplyInteger(value, Numerator, true), Denominator, false);

            return ApplyInteger(ApplyInteger(value, Denominator, false), Numerator, true);
        }

        public T ApplyInverse<T>(T value) where T : IFloatingPoint<T>
        {
            if (typeof(T) == typeof(decimal))
                return (T)(object)ApplyInverse((decimal)(object)value);

            if (Numerator <= Denominator)
                return ApplyInteger(ApplyInteger(value, Denominator, true), Numerator, false);

            return ApplyInteger(ApplyInteger(value, Numerator, false), Denominator, true);
        }

        private static T ApplyInteger<T>(T value, BigInteger factor, bool multiply)
            where T : IFloatingPoint<T>
        {
            if (factor.Sign < 0)
            {
                value = -value;
                factor = BigInteger.Abs(factor);
            }

            if (factor.IsOne)
                return value;

            BigInteger chunkBase = new BigInteger(1_000_000_000_000_000_000L);
            while (factor > long.MaxValue)
            {
                BigInteger chunk = BigInteger.GreatestCommonDivisor(factor, chunkBase);
                if (chunk.IsOne)
                    throw new OverflowException("Rational factor contains an integer component too large for generic numeric conversion.");

                T convertedChunk = T.CreateChecked((long)chunk);
                value = multiply ? value * convertedChunk : value / convertedChunk;
                factor /= chunk;
            }

            if (!factor.IsOne)
            {
                T converted = T.CreateChecked((long)factor);
                value = multiply ? value * converted : value / converted;
            }

            return value;
        }
#endif

        public bool Equals(UnitConverterRational other)
            => Numerator.Equals(other.Numerator) && Denominator.Equals(other.Denominator);

        public override bool Equals(object obj)
            => obj is UnitConverterRational other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Numerator.GetHashCode() * 397) ^ Denominator.GetHashCode();
            }
        }

        private static void GetDecimalParts(decimal value, out BigInteger numerator, out BigInteger denominator)
        {
#if NET8_0_OR_GREATER
            Span<int> bits = stackalloc int[4];
            decimal.GetBits(value, bits);
#else
            int[] bits = decimal.GetBits(value);
#endif
            uint low = unchecked((uint)bits[0]);
            uint mid = unchecked((uint)bits[1]);
            uint high = unchecked((uint)bits[2]);
            int scale = (bits[3] >> 16) & 0x7F;
            bool negative = (bits[3] & unchecked((int)0x80000000)) != 0;

            numerator = low |
                (new BigInteger(mid) << 32) |
                (new BigInteger(high) << 64);
            if (negative)
                numerator = BigInteger.Negate(numerator);

            denominator = BigInteger.Pow(10, scale);
        }

        private static decimal DivideToDecimal(BigInteger numerator, BigInteger denominator)
        {
            if (denominator.IsZero)
                throw new DivideByZeroException();
            if (numerator.IsZero)
                return decimal.Zero;

            bool negative = numerator.Sign != denominator.Sign;
            BigInteger n = BigInteger.Abs(numerator);
            BigInteger d = BigInteger.Abs(denominator);
            BigInteger gcd = BigInteger.GreatestCommonDivisor(n, d);
            n /= gcd;
            d /= gcd;

            BigInteger coefficient = BigInteger.DivRem(n, d, out BigInteger remainder);
            if (coefficient > DecimalMaxCoefficient)
                throw new OverflowException("The exact rational result is outside the decimal range.");

            int scale = 0;
            while (!remainder.IsZero && scale < 28)
            {
                BigInteger scaledRemainder = remainder * 10;
                BigInteger digit = BigInteger.DivRem(scaledRemainder, d, out BigInteger nextRemainder);
                BigInteger nextCoefficient = coefficient * 10 + digit;

                if (nextCoefficient > DecimalMaxCoefficient)
                    break;

                coefficient = nextCoefficient;
                remainder = nextRemainder;
                scale++;
            }

            if (!remainder.IsZero)
            {
                int comparison = (remainder * 2).CompareTo(d);
                if (comparison > 0 || (comparison == 0 && !coefficient.IsEven))
                {
                    coefficient += BigInteger.One;
                    if (coefficient > DecimalMaxCoefficient)
                        throw new OverflowException("The rounded rational result is outside the decimal range.");
                }
            }

            uint low = (uint)(coefficient & uint.MaxValue);
            uint mid = (uint)((coefficient >> 32) & uint.MaxValue);
            uint high = (uint)((coefficient >> 64) & uint.MaxValue);
            return new decimal(
                unchecked((int)low),
                unchecked((int)mid),
                unchecked((int)high),
                negative,
                (byte)scale);
        }
    }
}
