using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class longestArea
{
        static void Main()
        {
            Console.WriteLine("Enter how much strings to read: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter strings: ");
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
               strings[i] =  Console.ReadLine(); 
            }
            foreach (string value in strings)
            {
                Array.Sort(strings, StringComparer.InvariantCulture);
                Console.WriteLine(strings);
            }
                

        }
 }
