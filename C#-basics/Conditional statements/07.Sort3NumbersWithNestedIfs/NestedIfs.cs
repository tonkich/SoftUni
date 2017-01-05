using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if ((a < b) && (a < c))
        {
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);

            }

        }
        else if ((b < c) && ((b < a)))
        {
            if (a < c)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, b);

            }
        }
        else if ((c < a) && (c < b))
        {
            if (b < a)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);

            }
        }
    }
}
