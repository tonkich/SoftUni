using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class biggerNumber
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int Max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(Max);
        }
        static int GetMax(int firstNumber, int secondNumber)
        {
            int greaterNumber = firstNumber;
            if (firstNumber < secondNumber)
            {
                greaterNumber = secondNumber;
            }
            return greaterNumber;
        }
    }
}
