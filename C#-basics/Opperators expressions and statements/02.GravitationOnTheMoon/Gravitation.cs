using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Gravitation
    {
        static void Main()
        {
            Console.Write("Enter your weight on Earth: ");
            double a;
            a = Convert.ToDouble(Console.Read());
            double b = a * 17 / 100;
            Console.WriteLine("Your weight on the Moon is: "+ b + "kg");
        }
    }
