using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class max2
{
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
                Console.WriteLine("The biggest number is: {0}", a);
            else if (b > a && b > c && b > d && b > e)
                Console.WriteLine("The biggest number is: {0}", b);
            else if (c > b && c > a && c > d && c > e)
                Console.WriteLine("The biggest number is: {0}", c);
            else if (d > b && d > c && d > a && d > e)
                Console.WriteLine("The biggest number is: {0}", d);
            else if (e > b && e > c && e > d && e > a)
                Console.WriteLine("The biggest number is: {0}", e);

        }
}