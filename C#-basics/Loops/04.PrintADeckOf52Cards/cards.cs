using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class cards
{
        static void Main()
        {
            
            char a = '\u2663';
            char b = '\u2666';
            char c = '\u2665';
            char d = '\u2660';
            for (int i = 2; i < 10; i+=1)
            {
                Console.WriteLine("{0}{1}  {0}{2}  {0}{3}  {0}{4}", i, a, b, c, d);
           
            }
            Console.WriteLine("10{0} 10{1} 10{2} 10{3}", a, b, c, d);
            Console.WriteLine("J{0}  J{1}  J{2}  J{3}", a, b, c, d);
            Console.WriteLine("Q{0}  Q{1}  Q{2}  Q{3}", a, b, c, d);
            Console.WriteLine("K{0}  K{1}  K{2}  K{3}", a, b, c, d);
            Console.WriteLine("A{0}  A{1}  A{2}  A{3}", a, b, c, d);

        }
}
