using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateEquation
{
    class Equation
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double factorialN = 1;
            double powX = 1;
            double sum = 1;
            for (double i = 1; i <= n; i++)
            {
                    factorialN *= i;
                    powX *= x;
                    sum += factorialN / powX;
            }
            Console.WriteLine("Sum = {0:f5}", sum);
         } 
     }
}