using System;

class CalculateFactorialFormula
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double factN = 1;
        double multiX = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            result += factN / multiX;
        }

        Console.WriteLine("{0:F5}", result);
    }
}