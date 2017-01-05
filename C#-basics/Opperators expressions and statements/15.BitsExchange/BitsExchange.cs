using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int fakeBitOne = 3;
            int fakeBitTwo = 24;

            for (int i = 0; i < 3; i++)
            {
                long maskOne = (number & (1 << fakeBitOne)) >> fakeBitOne;
                long maskTwo = (number & (1 << fakeBitTwo)) >> fakeBitTwo;

                //mask one
                if (maskOne == 0)
                {
                    number = number & (~(1 << fakeBitTwo));
                }
                else if (maskOne == 1)
                {
                    number = number | (1 << fakeBitTwo);
                }

                //mask two
                if (maskTwo == 0)
                {
                    number = number & (~(1 << fakeBitOne));
                }
                else if (maskTwo == 1)
                {
                    number = number | (1 << fakeBitOne);
                }

                fakeBitOne++;
                fakeBitTwo++;
            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}
