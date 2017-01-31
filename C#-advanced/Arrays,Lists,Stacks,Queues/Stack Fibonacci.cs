using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class StackFibonaci
{
    static void Main()
    {
        BigInteger n = int.Parse(Console.ReadLine());
        Stack<BigInteger> stack = new Stack<BigInteger>();

        if (n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            BigInteger num1 = 0;
            BigInteger num2 = 1;
            BigInteger sum = 1;

            stack.Push(num1);

            while (true)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                stack.Push(num2);
                if (stack.Count == n)
                {
                    break;
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}