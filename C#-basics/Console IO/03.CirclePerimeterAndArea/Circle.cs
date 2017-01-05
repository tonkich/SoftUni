using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle
{
        static void Main(string[] args)
        {
            double r;
            Console.Write("Enter the radius r: ");
            bool isrInt = double.TryParse(Console.ReadLine(), out r);
            if (isrInt)
            {
                Console.WriteLine("Perimeter = {0}", 2 * Math.PI * r);
                Console.WriteLine("Area = {0}", Math.PI * Math.Pow(r,2));
            }
            else
            {
                Console.WriteLine("Not a valid entry! r is not integer!");
            }
        }
}
