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
            Dictionary<string, string> students = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                
                string[] inputToArray = input.Split(' ').ToArray();
                string firstName = inputToArray[0];
                string lastName = inputToArray[1];
                string fullName = firstName + " " + lastName;
                string email = inputToArray[2];
                if (!students.ContainsKey(fullName))
                {
                    students.Add(fullName, email);
                }
                input = Console.ReadLine();
            }
            var filteredStudents = students
                .Where(st => st.Value.StartsWith("02")|| st.Value.StartsWith("+3592"))
                .ToList();

            foreach (var item in filteredStudents)
            {
                sb.Append(item.Key).Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}