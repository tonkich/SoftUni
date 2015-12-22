using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    public static class Delegate
    {
        private const int InterestCompounded = 12;

        public static void Main()
        {
            Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = GetCompoundInterest;

            var acc1 = new InterestCalculator(500m, 5.6m, 10, compound);
            var acc2 = new InterestCalculator(2500m, 7.2m, 15, simple);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
        }

        private static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }

        private static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100 / InterestCompounded)), years * InterestCompounded);
        }
    }
}
