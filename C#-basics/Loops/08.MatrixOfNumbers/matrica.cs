using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
        static void Main()
        {
            int N;
            Console.Write("Enter an integer number < 20:");
            bool isnInt = int.TryParse(Console.ReadLine(), out N);
            if (isnInt & N < 20 & N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 1; j < N + 1; j++)
                    {
                        if (j + i > 9)
                        {
                            Console.Write("{0} ", j + i);
                        }
                        else
                        {
                            Console.Write("{0}  ", j + i);
                        }
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Wrong entry!");
            }
        }
}
