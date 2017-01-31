using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {

        static void Main(string[] args)
        {
            char[] splitter = new char[] { ' ','\t','\n' };
            string[] splittedInput = Console.ReadLine().Split(splitter,StringSplitOptions.RemoveEmptyEntries).ToArray();
            int a = int.Parse(splittedInput[0]);
            double b = double.Parse(splittedInput[1]);
            double c = double.Parse(splittedInput[2]);
            FormatNumbers(a, b, c);


        }
        static void FormatNumbers(int a, double b, double c)
        {

            string hexadecimalNumber = a.ToString("X");
            string result = "|" + hexadecimalNumber.PadRight(10)+"|";
            string binaryNumber = Convert.ToString(a,2);
            result = result + binaryNumber.PadLeft(10, '0').Substring(0, 10) + "|";
            result = result + b.ToString("0.00").PadLeft(10)+"|";
            result = result + c.ToString("0.000").PadRight(10) + "|";
            Console.WriteLine(result); 
        }
    }
}