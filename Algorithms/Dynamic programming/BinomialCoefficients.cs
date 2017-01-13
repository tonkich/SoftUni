namespace _01.BinomialCoefficients
{
    using System;

    class BinomialCoefficients
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());
            FindBinomialCoefficient(n, k);
        }

        static int FindBinomialCoefficient(int n , int k)
        {
            int[] memo = new int[k+1];
            memo[0] = 1;
            if (k > n) { return 0; }
            if (n == k) { return memo[0]; }
            if (k > n - k) { k = n - k; } 

            int c = 1;
            for (int i = 1; i < k+1; i++)
            {
                c *= n--;
                 c /= i;
                memo[i] = c;
            }

            Console.WriteLine(c);
            return memo[k];
        }
    }
}
