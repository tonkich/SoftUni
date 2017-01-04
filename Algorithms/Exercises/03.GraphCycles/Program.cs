using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GraphCycles
{
    class Program
    {
        static int n;
        static List<int>[] graph;
        static bool[,] hasEdge;

        static void Main(string[] args)
        {
            ReadGraph();
            FindCycles();
        }

        private static void FindCycles()
        {
            for (int u = 0; u < n; u++)
            {
                foreach (var v in graph[u])
                {
                    if(v>u)
                    {
                        foreach (var w in graph[v])
                        {
                            if(w>u)
                            {
                                if(hasEdge[w, u])
                                {
                                    Console.WriteLine("{" + $"{u} -> {v} -> {w}" + "}");
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void ReadGraph()
        {
            n = int.Parse(Console.ReadLine());
            graph = new List<int>[n];
            hasEdge = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Where(p => p != "->").Select(int.Parse).ToArray();
                int sourceNode = nums[0];
                graph[sourceNode] = new List<int>();
                for (int childIndex = 1; i < nums.Length; childIndex++)
                {
                    int destNode = nums[childIndex];
                    graph[sourceNode].Add(nums[childIndex]);
                    hasEdge[sourceNode, destNode] = true;
                }
                graph[sourceNode] = graph[sourceNode].Distinct().OrderBy(p => p).ToList();

            }
        }
    }
}
