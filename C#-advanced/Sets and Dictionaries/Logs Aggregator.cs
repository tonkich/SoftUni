using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            SortedDictionary<string, Pair<int,SortedSet<string>>> logs = new SortedDictionary<string, Pair<int, SortedSet<string>>>();
            int numberOfLines = int.Parse(Console.ReadLine());
            string input = string.Empty;
            for (int j = 0; j < numberOfLines; j++)
            {
                 input = Console.ReadLine();
                var splittedInput = input.Split().ToArray();
                string IP = splittedInput[0];
                string user = splittedInput[1];
                int duaration = int.Parse(splittedInput[2]);
                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new Pair<int, SortedSet<string>>());
                    logs[user].Second = new SortedSet<string>();
                    logs[user].First += duaration;
                    logs[user].Second.Add(IP);
                }
                else
                {
                    logs[user].First += duaration;
                    logs[user].Second.Add(IP);
                }
            }
            foreach (KeyValuePair<string, Pair<int, SortedSet<string>>> log in logs)
            {
                sb.Append(log.Key).Append(": ").Append(log.Value.First).Append(' ').Append('[').Append(string.Join(", ",log.Value.Second)).Append(']').Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}