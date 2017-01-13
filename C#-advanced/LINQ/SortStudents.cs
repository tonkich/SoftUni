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
            Dictionary<string[], int> students = new Dictionary<string[], int>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] fullName = new string[3];
                string[] inputToArray = input.Split(' ').ToArray();
                string firstName = inputToArray[0];
                fullName[0] = firstName;
                fullName[1] = " ";
                string lastName = inputToArray[1];
                fullName[2] = lastName;
                if (!students.ContainsKey(fullName))
                {
                    students.Add(fullName, 0);
                }
                input = Console.ReadLine();
            }
            var filteredStudents = 
                students.Keys.OrderByDescending(k => k[2])
                .ThenBy(k=>k[0])
                .Reverse()
                .ToList();

            foreach (var item in filteredStudents)
            {
                sb.Append(item[0] + item[1] + item[2]).Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
