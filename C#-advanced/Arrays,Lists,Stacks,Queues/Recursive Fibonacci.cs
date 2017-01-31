using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        public static long Fib(long n)
        {
            if (n < 2)
            {
                Console.WriteLine(n); return n;
            }
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            Console.WriteLine(f[n]); return f[n];
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Fib(number);
        }
        }
}