using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int shards = 0;
            int motes = 0;
            int fragments = 0;
            bool hasItem = false;
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            string[] resources = Console.ReadLine().Split();
            for (int j = 0; j < 10; j++)
            {
                while (hasItem == false)
                {

                
                for (int i = 1; i < resources.Length; i += 2)
                {
                    if (resources[i].ToLower() == "motes")
                    {

                        motes += int.Parse(resources[i - 1]);

                        if (motes >= 250)
                        {
                            sb.AppendLine("Dragonwrath obtained!");
                            hasItem = true;
                            motes -= 250;
                            break;
                        }

                    }
                    else if (resources[i].ToLower() == "fragments")
                    {

                        fragments += int.Parse(resources[i - 1])
                        ;

                        if (fragments >= 250)
                        {
                            sb.AppendLine("Valanyr obtained!");
                            hasItem = true;
                            fragments -= 250;
                            break;
                        }
                    }
                    else if (resources[i].ToLower() == "shards")
                    {

                        shards += int.Parse(resources[i - 1])
                        ;
                        if (shards >= 250)
                        {
                            sb.AppendLine("Shadowmourne obtained!");
                            hasItem = true;
                            shards -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(resources[i]))
                        {
                            junk[resources[i]] += int.Parse(resources[i - 1]);

                        }

                        else
                        {
                            junk.Add(resources[i], int.Parse(resources[i - 1]));

                        }
                    }
                }
                if (hasItem == true)
                {
                    break;
                }
                resources = Console.ReadLine().Split();
            }
            }


            List<Tuple<string, int>> orderedResources = new List<Tuple<string, int>>();
            orderedResources.Add(new Tuple<string, int>("fragments", fragments));
            orderedResources.Add(new Tuple<string, int>("motes", motes));
            orderedResources.Add(new Tuple<string, int>("shards", shards));
            var orderedTuples = orderedResources.OrderByDescending(x => x.Item2).ThenBy(x => x.Item1);
            foreach (Tuple<string, int> tuple in orderedTuples)
            {
                sb.AppendLine($"{tuple.Item1.ToString().ToLower()}: {tuple.Item2.ToString().ToLower()}");
            }

            var orderedjunk = junk.OrderBy(x => x.Key);
            foreach (KeyValuePair<string, int> garbage in orderedjunk)
            {
                sb.AppendLine($"{garbage.Key.ToString().ToLower()}: {garbage.Value.ToString().ToLower()}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}