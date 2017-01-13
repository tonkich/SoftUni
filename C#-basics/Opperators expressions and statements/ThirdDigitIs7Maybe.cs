using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7maybe
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digit: ");
            long a = long.Parse(Console.ReadLine());
            long b = a / 100;
            long c = b % 10;

            bool isSeven = c == 7;

            Console.WriteLine("Third digit of this number is 7 = " + isSeven);

        }
    }
}
