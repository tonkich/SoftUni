using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Program
    {

        static void Main(string[] args)
        {
            FillDictionary();
        }

        static void FillDictionary()
        {
            Dictionary<string, Dictionary<string, long>> popCounter = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] inputArray = input.Split('|');
                if (!popCounter.ContainsKey(inputArray[1]))
                {
                    popCounter.Add(inputArray[1], new Dictionary<string, long>());
                }
                if (!popCounter[inputArray[1]].ContainsKey(inputArray[0]))
                {
                    popCounter[inputArray[1]].Add(inputArray[0], 0);
                }
                popCounter[inputArray[1]][inputArray[0]] += long.Parse(inputArray[2]);
                input = Console.ReadLine();
            }

            WriteOutput(popCounter);
        }

        static void WriteOutput(Dictionary<string, Dictionary<string, long>> popCounter)
        {
            var myList = popCounter.ToList();
            myList.Sort((pair1, pair2) => pair2.Value.Sum(x => x.Value).CompareTo(pair1.Value.Sum(x => x.Value)));

            foreach (KeyValuePair<string, Dictionary<string, long>> kvp1 in myList)
            {
                Console.WriteLine("{0} (total population: {1})", kvp1.Key, kvp1.Value.Sum(x => x.Value));
                foreach (KeyValuePair<string, long> kvp2 in kvp1.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", kvp2.Key, kvp2.Value);
                }
            }
        }
    }
}