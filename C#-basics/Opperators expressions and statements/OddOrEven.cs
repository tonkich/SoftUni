using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class OddOrEven
{
    static void Main(string[] args)
    {

        Console.Write("Enter number: ");
        int number = Console.Read();
        {
            if (number % 2 == 0)
            { Console.WriteLine("The number is odd"); }
            else
            { Console.WriteLine("The number is even"); }
        }
    }
}