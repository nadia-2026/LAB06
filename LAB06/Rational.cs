namespace LAB06
{
    public class Rational
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set
            {
                numerator = value;
                Simplify();
            }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Знаменатель не может быть равен 0.");
                denominator = value;
                Simplify();
            }
        }

        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0) throw new DivideByZeroException("Знаменатель не может быть равен 0.");
            this.denominator = denominator;
            Simplify();
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void Simplify()
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            if (gcd != 0)
            {
                numerator /= gcd;
                denominator /= gcd;
            }
        }

        public override string ToString()
        {
            return $"Rational: {Numerator} / {Denominator}";
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        public static bool operator ==(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator == r2.Numerator * r1.Denominator;
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator;
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }

        public static bool operator >=(Rational r1, Rational r2) => r1 > r2 || r1 == r2;
        public static bool operator <=(Rational r1, Rational r2) => r1 < r2 || r1 == r2;
    }
}