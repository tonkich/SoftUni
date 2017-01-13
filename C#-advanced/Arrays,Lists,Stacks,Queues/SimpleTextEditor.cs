using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 105 || N <= 0)
            {
                return;
            }
            else
            {
                ModifyString(N);
            }
        }
        public static void ModifyString(int N)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> operationsCount = new Stack<int>();
            Stack<string> appendedString = new Stack<string>();
            Queue<string> dequeuedElements = new Queue<string>();
            StringBuilder myQueue = new StringBuilder();
            List<char> thirdOperationIntegers = new List<char>();
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    string[] splittedInput = input.Split().ToArray();

                    switch (int.Parse(splittedInput[0]))
                    {
                        case 1:
                            char[] splittedInputToChar = splittedInput[1].ToCharArray();
                            foreach (char item in splittedInputToChar)
                            {
                                if (myQueue.Length > 1000000)
                                {
                                    return;
                                }
                                myQueue.Append(item);
                            }
                            appendedString.Push(splittedInput[1]);
                            operationsCount.Push(1);
                            break;
                        case 2:
                            if (myQueue.Length>=int.Parse(splittedInput[1]))
                            {
                                int secondCounter = myQueue.Length - int.Parse(splittedInput[1]);
                                for (int j = secondCounter; j < myQueue.Length; j++)
                                {
                                    sb.Append(myQueue.ToString().ElementAt(j));

                                }
                                for (int j = myQueue.Length; secondCounter < myQueue.Length; j--)
                                {
                                    myQueue.Length--;
                                }
                            }
                            else
                            {
                                sb.Append(myQueue.ToString());
                                myQueue.Clear();
                            }
                            
                            dequeuedElements.Enqueue(sb.ToString());
                            sb.Clear();
                            operationsCount.Push(2);
                            break;
                        case 3:
                            thirdOperationIntegers.Add(myQueue.ToString().ElementAt(int.Parse(splittedInput[1]) - 1));
                            break;
                        case 4:
                            if (operationsCount.Peek() == 1)
                            {
                                string convertedStr = appendedString.Pop();
                                int counter = myQueue.Length - convertedStr.Length;
                                for (int k = myQueue.Length; counter < k; k--)
                                {
                                    if (myQueue.Length == 0)
                                    {
                                        break;
                                    }
                                    myQueue.Length--;
                                }
                                operationsCount.Pop();
                            }

                            else if (operationsCount.Peek() == 2)
                            {
                                string dequeuedString = dequeuedElements.Dequeue();
                                int k = dequeuedString.Length;
                                char[] dequeuedStringToChar = dequeuedString.ToCharArray();
                                for (int z = 0; z < k; z++)
                                {
                                    myQueue.Append(dequeuedStringToChar[z]);

                                }
                                operationsCount.Pop();
                            }
                            break;
                    }
                }
            }
            foreach (char item in thirdOperationIntegers)
            {
                Console.WriteLine(item);
            }
        }
    }
}