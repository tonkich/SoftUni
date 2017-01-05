using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class numbers
{
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the first number n:");
            bool isntInt = int.TryParse(Console.ReadLine(), out n);

            if (isntInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! n is not an integer!");
            }
        }
}
