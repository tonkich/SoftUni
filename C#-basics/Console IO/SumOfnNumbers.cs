using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
class SumOfn
{
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            uint n;
            double sum = 0;
            double inputNumber;
            bool isValidEntry = true;
            Console.Write("Enter the number n:");
            bool isntInt = uint.TryParse(Console.ReadLine(), out n);
            if (isntInt)
            {
                for (int i = 0; i < n; i++)
                {
                    bool isInputNumberDouble = double.TryParse(Console.ReadLine(), out inputNumber);
                    if (isInputNumberDouble)
                    {
                        sum = sum + inputNumber;
                    }
                    else
                    {
                        Console.WriteLine("Not a number entry!");
                        isValidEntry = false;
                        break;
                    }
                }
                if (isValidEntry)
                {
                    Console.WriteLine("sum={0}", sum);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! The number n is not integer!");
            }
        }
}
