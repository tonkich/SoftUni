namespace Application1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                int[] nums = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(p => Convert.ToInt32(p)).ToArray();
                int N = nums[0];
                int S = nums[1];
                int X = nums[2];
                string inputTwo = Console.ReadLine();
                int[] arr = inputTwo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => Convert.ToInt32(p)).ToArray();
                for (int i = 0; i != N; i++)
                {
                    queue.Enqueue(arr[i]);
                }


                for (int j = 0; j != S; j++)
                {
                    queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }
                }

                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    Console.WriteLine(queue.Min());
                    return;
                }
            }
        }
    }
}