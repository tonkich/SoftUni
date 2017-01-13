using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("Enter trapezoid's upper base: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter trapezoid's lower base: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter trapezoid's height: ");
            double c = double.Parse(Console.ReadLine());
            double d = ((a / 2) + (b / 2)) * c;
            Console.WriteLine("The trapezoid's area is: " + d);
        }
    }
}
