using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Sign
{
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            double num = a + b + c;
            if (num < 0)
            {
                Console.WriteLine("-");
            }
            if (num > 0)
            {
                Console.WriteLine("+");
            }
            if (num == 0)
            {
                Console.WriteLine("0");
            }
        }
}
