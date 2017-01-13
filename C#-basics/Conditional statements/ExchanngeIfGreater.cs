using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Exchannge
{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("{1} {0}", a, b);
            else
                Console.WriteLine("{0} {1}", a, b);

        }
}
