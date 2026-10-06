namespace UnitConverter.Numbers
{
    using System;
    using System.Globalization;
    using System.Numerics;

    public static class ArbitraryScaleMath
    {
        public static ArbitraryScaleNumber Abs(
            ArbitraryScaleNumber value)
        {
            return value.Abs();
        }

        public static ArbitraryScaleNumber Min(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            return Compare(left, right) <= 0
                ? left
                : right;
        }

        public static ArbitraryScaleNumber Max(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            return Compare(left, right) >= 0
                ? left
                : right;
        }

        public static int Sign(
            ArbitraryScaleNumber value)
        {
            return value.Sign;
        }

        public static ArbitraryScaleNumber Pow(
            ArbitraryScaleNumber value,
            int exponent)
        {
            return ArbitraryScaleNumber.Pow(
                value,
                exponent);
        }

        public static void Abs(
            ArbitraryScaleNumber value,
            out ArbitraryScaleNumber result)
        {
            result = Abs(value);
        }

        public static void Abs(
            ArbitraryScaleNumber value,
            out double result)
        {
            result = ToDoubleChecked(
                Abs(value));
        }

        public static void Abs(
            ArbitraryScaleNumber value,
            out decimal result)
        {
            result = ToDecimalChecked(
                Abs(value));
        }

        public static void Abs(
            ArbitraryScaleNumber value,
            out BigInteger result)
        {
            result = ToBigIntegerChecked(
                Abs(value));
        }

        public static void Min(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right,
            out ArbitraryScaleNumber result)
        {
            result = Min(left, right);
        }

        public static void Min(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right,
            out double result)
        {
            result = ToDoubleChecked(
                Min(left, right));
        }

        public static void Max(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right,
            out ArbitraryScaleNumber result)
        {
            result = Max(left, right);
        }

        public static void Max(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right,
            out double result)
        {
            result = ToDoubleChecked(
                Max(left, right));
        }

        public static void Pow(
            ArbitraryScaleNumber value,
            int exponent,
            out ArbitraryScaleNumber result)
        {
            result = Pow(
                value,
                exponent);
        }

        public static void Pow(
            ArbitraryScaleNumber value,
            int exponent,
            out double result)
        {
            result = ToDoubleChecked(
                Pow(value, exponent));
        }

        public static void Pow(
            ArbitraryScaleNumber value,
            int exponent,
            out decimal result)
        {
            result = ToDecimalChecked(
                Pow(value, exponent));
        }

        public static void Pow(
            ArbitraryScaleNumber value,
            int exponent,
            out BigInteger result)
        {
            result = ToBigIntegerChecked(
                Pow(value, exponent));
        }

        public static bool TryPow(
            ArbitraryScaleNumber value,
            int exponent,
            out double result)
        {
            try
            {
                result = ToDoubleChecked(
                    Pow(value, exponent));

                return true;
            }
            catch (ArbitraryScaleOverflowException)
            {
                result = default(double);
                return false;
            }
        }

        public static bool TryPow(
            ArbitraryScaleNumber value,
            int exponent,
            out decimal result)
        {
            try
            {
                result = ToDecimalChecked(
                    Pow(value, exponent));

                return true;
            }
            catch (ArbitraryScaleOverflowException)
            {
                result = default(decimal);
                return false;
            }
        }

        public static double ToDoubleChecked(
            ArbitraryScaleNumber value)
        {
            double result;

            if (!double.TryParse(
                    value.ToScientific(),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out result) ||
                double.IsInfinity(result) ||
                double.IsNaN(result))
            {
                throw Overflow<double>();
            }

            return result;
        }

        public static decimal ToDecimalChecked(
            ArbitraryScaleNumber value)
        {
            try
            {
                string text =
                    value.ToDecimalString(64);

                return decimal.Parse(
                    text,
                    NumberStyles.Number |
                        NumberStyles.AllowExponent,
                    CultureInfo.InvariantCulture);
            }
            catch (Exception exception)
            {
                if (exception is OverflowException ||
                    exception is FormatException ||
                    exception is InvalidOperationException)
                {
                    throw Overflow<decimal>();
                }

                throw;
            }
        }

        public static BigInteger ToBigIntegerChecked(
            ArbitraryScaleNumber value)
        {
            try
            {
                string decimalText =
                    value.ToDecimalString();

                if (decimalText.IndexOf('.') >= 0)
                {
                    throw Overflow<BigInteger>();
                }

                return BigInteger.Parse(
                    decimalText,
                    CultureInfo.InvariantCulture);
            }
            catch (ArbitraryScaleOverflowException)
            {
                throw;
            }
            catch (Exception exception)
            {
                if (exception is FormatException ||
                    exception is InvalidOperationException)
                {
                    throw Overflow<BigInteger>();
                }

                throw;
            }
        }

        private static int Compare(
            ArbitraryScaleNumber left,
            ArbitraryScaleNumber right)
        {
            if (left == right)
            {
                return 0;
            }

            try
            {
                decimal leftValue =
                    decimal.Parse(
                        left.ToDecimalString(64),
                        CultureInfo.InvariantCulture);

                decimal rightValue =
                    decimal.Parse(
                        right.ToDecimalString(64),
                        CultureInfo.InvariantCulture);

                return leftValue.CompareTo(
                    rightValue);
            }
            catch (Exception exception)
            {
                if (exception is OverflowException ||
                    exception is InvalidOperationException)
                {
                    throw new NotSupportedException(
                        "Comparison of non-materializable sparse values is not implemented yet.",
                        exception);
                }

                throw;
            }
        }

        private static ArbitraryScaleOverflowException
            Overflow<T>()
        {
            return new ArbitraryScaleOverflowException(
                "The result cannot be represented as " +
                typeof(T).FullName +
                ". Use the ArbitraryScaleNumber output overload to preserve the result.");
        }
    }

    public sealed class ArbitraryScaleOverflowException
        : OverflowException
    {
        public ArbitraryScaleOverflowException(
            string message)
            : base(message)
        {
        }
    }
}
