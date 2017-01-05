using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rectangle width = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter rectangle heigth = ");
            double b = double.Parse(Console.ReadLine());
            double perimeter = (2 * a) + (2 * b);
            Console.WriteLine("The rectangle perimeter is = " + perimeter);
            double area = a * b;
            Console.WriteLine("The rectangle area is = " + area);
            

        }
    }
}
