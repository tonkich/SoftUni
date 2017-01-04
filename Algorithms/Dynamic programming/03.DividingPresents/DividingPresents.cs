using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DividingPresents
{
    class DividingPresents
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4,5,6,7,8 };
            MinimalDifference(array);
        }

        static void MinimalDifference(int[] array)
        {
            Array.Sort(array);
            int firstBrotherSum = 0;
            int secondBrotherSum = 0;
            List<int> firstBrother = new List<int>();
            List<int> secondBrother = new List<int>();
            firstBrother.Add(array[array.Length-1]);
            firstBrotherSum += array[array.Length-1];

            for (int i = array.Length-2; i >= 0; i--)
            {
                if(firstBrotherSum > secondBrotherSum)
                {
                    secondBrother.Add(array[i]);
                    secondBrotherSum += array[i];
                }
                else if (firstBrotherSum < secondBrotherSum)
                {
                    firstBrother.Add(array[i]);
                    firstBrotherSum += array[i];
                }
                else
                {
                    firstBrother.Add(array[i]);
                    firstBrotherSum += array[i];
                }
            }

            int difference = Math.Abs(firstBrotherSum - secondBrotherSum);

            Console.WriteLine("Difference: {0} \nAlan:{1} Bob:{2}", difference, firstBrotherSum, secondBrotherSum);
            Console.Write("Alan takes: ");
            WriteToConsole(firstBrother);
            Console.WriteLine("\nBob takes the rest");
        }

        public static void WriteToConsole(List<int> items)
        {
            foreach (int o in items)
            {
                Console.Write(o+" ");
            }
        }
    }
}
