namespace _01.reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();
                if (input != null)
                {
                    var array = input.Split(new char[]{' '},  StringSplitOptions.RemoveEmptyEntries).Select(p => Convert.ToInt32(p)).ToArray();
                    foreach (var num in array)
                    {
                        stack.Push(num);
                    }
                }
            
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            for (var i = 0; i < stack.Count; i++)
            {
                stack.Pop();
            }
           
        }
    }
}