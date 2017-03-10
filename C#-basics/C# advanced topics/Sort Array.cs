using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SortArray
{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how much integers to read: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter integers: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Press enter to sort the integers: ");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
            {
                Array.Sort(array);
                foreach (int value in array)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
}
