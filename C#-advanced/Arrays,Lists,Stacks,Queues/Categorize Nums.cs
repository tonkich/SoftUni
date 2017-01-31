using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class categorizeNums
    {
        static void Main()
        {

            string input = Console.ReadLine();
            double[] numbers = input.Split().Select(double.Parse).ToArray();
            List<double> roundNum = new List<double>();
            List<double> zeroFractNum = new List<double>();

            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 1 != 0)
                {
                    zeroFractNum.Add(numbers[a]);
                }
                else
                {
                    roundNum.Add(numbers[a]);
                }
            }
            Console.WriteLine("Non - Zero Fraction Numbers");
            zeroFractNum.ForEach(a => Console.Write(a + " "));
            Console.WriteLine("min -- {0}", zeroFractNum.Min());
            Console.WriteLine("max -- {0}", zeroFractNum.Max());
            Console.WriteLine("sum -- {0}", zeroFractNum.Sum());
            Console.WriteLine("average -- {0:f2}", zeroFractNum.Average());
            Console.WriteLine("Round Numbers");
            roundNum.ForEach(b => Console.Write(b + " "));
            Console.WriteLine("min -- {0}", roundNum.Min());
            Console.WriteLine("max -- {0}", roundNum.Max());
            Console.WriteLine("sum -- {0}", roundNum.Sum());
            Console.WriteLine("average -- {0:f2}", roundNum.Average());
        }
    }