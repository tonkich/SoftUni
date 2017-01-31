using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice
{
    class Student
    {
        public string name;
        public int groupNumber;

        public Student(string name, int groupNumber)
        {
            this.name = name;
            this.groupNumber = groupNumber;
        }
        public override string ToString()
        {
            return this.name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] studentDetails = input.Split();
                var student = new Student(studentDetails[0] + " " + studentDetails[1], int.Parse(studentDetails[2]));
                students.Add(student);
                input = Console.ReadLine();
            }
            var grouped = students.OrderBy(st => st.groupNumber).GroupBy(st => st.groupNumber);
            foreach (var group in grouped)
            {
                Console.WriteLine("{0} - {1}", group.Key, string.Join(", ",group));
            }
        }
    }
}