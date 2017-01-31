using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice
{
    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            List<string[]> students = new List<string[]>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputToArray = input.Split(' ').ToArray();

                string[] fullName = new string[2];
                fullName[0] = inputToArray[0];
                fullName[1] = inputToArray[1];
                students.Add(fullName);
                if (!students.Contains(fullName))
                {
                    students.Add(fullName);
                }
                input = Console.ReadLine();
            }
            foreach (string[] item in students.ToList())
            {
                int result = string.Compare(item[0], item[1]);
                if (result==1)
                {
                    students.Remove(item);
                }
                    

            }
            foreach (string[] item in students.ToList())
            {
                sb.Append(item[0] + " " + item[1]).Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}