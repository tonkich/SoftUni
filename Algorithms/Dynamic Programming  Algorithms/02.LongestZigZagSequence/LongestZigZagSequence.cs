using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LongestZigZagSequence
{
    class LongestZigZagSequence
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 20, 12, 9, 11 };
            LongestSequence(array);
        }

        static void LongestSequence(int[] array)
        {
            List<int> sequence = new List<int>();
            if (array[0] < array[1] && array[1] > array[2])
            {
                sequence.Add(array[0]);
            }
            else if (array[0] > array[1] && array[1] < array[2])
            {
                sequence.Add(array[0]);
            }
            for (int i = 1; i < array.Length-2; i++)
            {
                if(Check(array, i)==true)
                {
                    sequence.Add(array[i]);
                }
            }
            foreach (int item in sequence)
            {
                Console.Write(item+" ");
            }
        }

        static bool Check(int[] array, int i)
        {
            if(array[i-1]<array[i] && array[i]>array[i+1])
            {
                return true;
            }
            else if (array[i-1] > array[i] && array[i] < array[i + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
