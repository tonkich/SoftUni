using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TowerOfHanoi
{
    class Program
    {
        private static int stepsTaken = 0;
        static void Main(string[] args)
        {
            int numberOfDisks = int.Parse(Console.ReadLine());
            var source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            var destination = new Stack<int>();
            var spare = new Stack<int>();
            PrintRods(source,destination,spare);
            MoveDisks(numberOfDisks, source, destination, spare);
        }

        private static void MoveDisks(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod)
        {
            if (bottomDisk < 1)
            {
                return;
            }

            else
            {
                MoveDisks(bottomDisk - 1, sourceRod, spareRod, destinationRod);
                stepsTaken++;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
                PrintRods(sourceRod, destinationRod, spareRod);
                destinationRod.Push(bottomDisk);
                sourceRod.Pop();
                stepsTaken++;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
                PrintRods(sourceRod,destinationRod,spareRod);
                MoveDisks(bottomDisk - 1, spareRod, destinationRod, sourceRod);
            }
        }


        private static void PrintRods(Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine();
        }
    }
}

