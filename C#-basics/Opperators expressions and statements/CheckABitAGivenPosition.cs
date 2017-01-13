using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckABitAGivenPosition
{
    class CheckABit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check bit of position: ");
            int position = int.Parse(Console.ReadLine());

            int moveBit = number >> position;
            int foundBit = moveBit & 1;

            bool isOne = foundBit == 1;

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("Bit of position {0} is '1' = {1}", position, isOne);
        }
    }
}
