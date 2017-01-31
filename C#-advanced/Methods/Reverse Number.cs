using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            decimal number = Int32.Parse(Console.ReadLine());
            Console.Write("Reversed: ");
            decimal reversed = ReverseDecimal(number);
            Console.Write(reversed);
        }

        static decimal ReverseDecimal(decimal number)
        {
            return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
        }
    }
