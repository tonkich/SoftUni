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
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                
                string[] inputToArray = input.Split(' ').ToArray();
                string firstName = inputToArray[0];
                string lastName = inputToArray[1];
                string fullName = firstName + " " + lastName;
                List<int> marks = new List<int>();
                for (int i = 2; i <= inputToArray.Length-1; i++)
                {
                    marks.Add(int.Parse(inputToArray[i]));
                }
                if (!students.ContainsKey(fullName))
                {
                    students.Add(fullName, marks);
                }
                input = Console.ReadLine();
            }
            var filteredStudents = students
                .Where(st=>st.Value.Contains(6))
                .ToList();

            foreach (var item in filteredStudents)
            {
                sb.Append(item.Key).Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}