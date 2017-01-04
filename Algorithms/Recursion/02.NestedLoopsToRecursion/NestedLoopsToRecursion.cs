using System;
using System.Linq;

namespace _02.NestedLoopsToRecursion
{
    class NestedLoopsToRecursion
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = n - 1;
            int[] array = new int[n];
            array = array.Select(i => 1).ToArray();
            GenerateVariations(array, k,n);
        }

        public static void GenerateVariations(int[] array,int k,int n)
        {
            if(array.All(element => element == n))
            { 
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                array[k]+=1;
                foreach (int item in array)
                {




                }
                if (array[k] == n)
                {
                    array[k] = 1;
                    array[k] = array[k-1];
                    array[k]+=1;
                }
                GenerateVariations(array, k,n);
            }
        }
    }
}
