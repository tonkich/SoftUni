using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private decimal sum;
        private decimal interest;
        private int years;

        public InterestCalculator(decimal sum, decimal interest, int years, Func<decimal, decimal, int, decimal> interestCalculation)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.TotalSum = interestCalculation(sum, interest, years);
        }

        public decimal Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value cannot be a negative number!");
                }

                this.sum = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value cannot be a negative number!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value cannot be a negative number!");
                }

                this.years = value;
            }
        }

        public decimal TotalSum { get; set; }

        public override string ToString()
        {
            return string.Format("Money: {0}, Interest: {1}%, Years: {2}, Result: {3:F4}", this.Sum, this.Interest, this.Years, this.TotalSum);
        }
    }
}
