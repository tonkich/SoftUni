using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class equation2
{
    static void Main()
    {
        int N, K;
        int divisor = 1;
        double result;
        Console.Write("Enter the first number N:");
        bool isNInt = int.TryParse(Console.ReadLine(), out N);
        Console.Write("Enter the second number K:");
        bool isKInt = int.TryParse(Console.ReadLine(), out K);
        if (isNInt && isKInt && (N < K) && (N > 1) && (K > 1))
        {
            for (int i = N + 1; i < K + 1; i++)
            {
                divisor = divisor * i;
            }

            result = 1.0 / (double)divisor;
            Console.WriteLine("result={0}", result);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}

