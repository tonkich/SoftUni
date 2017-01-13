using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class numbers
{
        static void Main(string[] args)
        {
            uint a, b;
            uint p = 0;
            Console.Write("Enter the first number a:");
            bool isaUint = uint.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbUint = uint.TryParse(Console.ReadLine(), out b);
            if (isaUint & isbUint)
            {
                if (a < b)
                {
                    for (uint i = a; i <= b; i++) { if (i % 5 == 0) { p = p + 1; } }
                }
                else if (a > b)
                {
                    for (uint i = b; i <= a; i++)
                    {
                        if (i % 5 == 0)
                        {
                            p = p + 1;
                        }
                    }
                }
                else
                {
                    if (a % 5 == 0)
                    {
                        p = p + 1;
                    }
                }
                Console.WriteLine("p({0},{1})={2}", a, b, p);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not unsigned integer!");
            }
        }
}
