using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Divide
{
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
            if ((num % 5 == 0) && (num % 7 ==0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }   

        }
}
