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
                List<int> marks = new List<int>();
                for (int i = 1; i <= inputToArray.Length - 1; i++)
                {
                    marks.Add(int.Parse(inputToArray[i]));
                }
                if (!students.ContainsKey(firstName))
                {
                    students.Add(firstName, marks);
                }
                input = Console.ReadLine();
            }
            var filteredStudents = students
                .Where(st => st.Key.EndsWith("14") || st.Key.EndsWith("15"))
                .ToList();

            foreach (KeyValuePair<string,List<int>> item in filteredStudents)
            {
                for (int i = 0; i <= item.Value.Count-1; i++)
                {
                    sb.Append(item.Value[i]+" ");
                }
                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
