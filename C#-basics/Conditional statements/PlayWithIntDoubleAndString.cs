using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class numbers
{
        static void Main()
        {
            Console.WriteLine("Please choose a type:\r\n1 --> 'int'\r\n2 --> 'double'\r\n3 --> 'string'");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: Console.WriteLine("Please enter an integer: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = 1 + a;
                    Console.WriteLine("Result: {0}", b); break;
                case 2: Console.WriteLine("Please enter a double: ");
                    double c = double.Parse(Console.ReadLine());
                    double d = 1 + c;
                    Console.WriteLine("Result: {0}", d); break;
                case 3: Console.WriteLine("Please enter a string: ");
                    string e = Console.ReadLine();
                    Console.WriteLine("Result: {0}*", e); break;
            }


        }
}
