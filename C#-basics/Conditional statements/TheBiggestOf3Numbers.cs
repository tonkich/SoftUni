using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class max
 {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Biggest: {0}", a);
            else if (b > a && b > c)
                Console.WriteLine("Biggest: {0}", b);
            else if (c > a && c > b)
                Console.WriteLine("Biggest: {0}", c);
            else Console.WriteLine("Equal numbers");
        }
}
