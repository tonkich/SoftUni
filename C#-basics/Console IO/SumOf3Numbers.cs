using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOf3Numbers
{
    class Sum
    {
        static void Main(string[] args)
        {
            double number1;  
            double number2;
            double number3;
            double sum;
            Console.Write( "a = " );
            number1 = Convert.ToDouble( Console.ReadLine() );
            Console.Write( "b = " ); 
            number2 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("c = ");
            number3 = Convert.ToDouble(Console.ReadLine());
            sum = number1 + number2 + number3;
            Console.WriteLine( "Sum = {0}", sum );
        }
    }
}
