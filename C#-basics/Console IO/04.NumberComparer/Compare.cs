using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class Compare
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater than {1}", num1, num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("{0} is greater than {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            Console.ReadLine();          
        }
    }
}
