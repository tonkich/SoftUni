using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Launcher
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> myQueue = new Queue<long>();
            List<long> result = new List<long>();
            myQueue.Enqueue(n);
            result.Add(n);
            while (result.Count<50)
            {
                long currentElement = myQueue.Dequeue();
                long firstNumber = currentElement + 1;
                long secondNumber = (currentElement*2)+1;
                long thirdNumber = currentElement + 2;
                myQueue.Enqueue(firstNumber);
                myQueue.Enqueue(secondNumber);
                myQueue.Enqueue(thirdNumber);
                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i]+" ");
            }
        }
    }
}