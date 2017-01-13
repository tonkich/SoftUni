using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
class FractionCalculator
{
            
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new OverflowException("The numerator doesn't belong in the domain of long integers.");
                }
                this.numerator = value;
            }
        }
        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be 0.");
                }

                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new OverflowException("The denominator doesn't belong in the domain of long integers.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long numerator, denominator;
            numerator = first.Numerator * second.Denominator + first.Denominator * second.Numerator;
            denominator = first.Denominator * second.Denominator;
            Fraction result = new Fraction(numerator, denominator);

            return result;
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            long numerator, denominator;
            numerator = first.Numerator * second.Denominator - first.Denominator * second.Numerator;
            denominator = first.Denominator * second.Denominator;
            Fraction result = new Fraction(numerator, denominator);

            return result;
        }
        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;
            return result.ToString();
        }
    }
    static void Main()
    {
        Fraction fraction1 = new Fraction(22, 7);
        Fraction fraction2 = new Fraction(40, 4);
        Fraction result = fraction1 + fraction2;
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denominator);
        Console.WriteLine(result);

    }
}
}
