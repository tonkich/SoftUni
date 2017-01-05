using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Quadratic
{
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            double diskrimin = (b * b) - 4 * a * c;
            double diskriminSqrt = Math.Sqrt(diskrimin);
            double x1 = (-b - diskriminSqrt) / (2 * a);
            double x2 = (-b + diskriminSqrt) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("x1= x2= {0}", x1);
            }
            else
            {
                Console.WriteLine("x1= {0}", x1);
                Console.WriteLine("x2= {0}", x2);
            }
        }
}
