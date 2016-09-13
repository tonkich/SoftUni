using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int index = 0;
            Stack<int> stack = new Stack<int>();
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Reverse(array, stack, index);
        }

        static void Reverse(int[] array, Stack<int> stack,int index)
        {
            if (index == array.Length)
            {
                foreach (int VARIABLE in stack)
                {
                    Console.Write(VARIABLE+" ");
                }
            }
            else
            {
                stack.Push(array[index]);
                Reverse(array, stack, index+1);
            }
        }
    }
}
