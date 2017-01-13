using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice
{
    class StudentSpecialty
    {
        public string specialtyName;
        public int facultyNumber;

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.specialtyName = specialtyName;
            this.facultyNumber = facultyNumber;
        }
        

    }
    class Student
    {
        public string studentName;
        public int facultyNumber;

        public Student(string studentName, int facultyNumber)
        {
            this.studentName = studentName;
            this.facultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            return this.studentName;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
            List<Student> studentsList = new List<Student>();

            string specialtyInput = Console.ReadLine();
            while (specialtyInput != "Students:")
            {
                string[] specialtyDetails = specialtyInput.Split();
                var specialty = new StudentSpecialty(specialtyDetails[0] + " " + specialtyDetails[1], int.Parse(specialtyDetails[2]));
                studentSpecialties.Add(specialty);
                specialtyInput = Console.ReadLine();
            }
            string studentInput = Console.ReadLine();
            while (studentInput != "END")
            {
                string[] studentDetails = studentInput.Split();
                var student = new Student(studentDetails[1] + " " + studentDetails[2], int.Parse(studentDetails[0]));
                studentsList.Add(student);
                studentInput = Console.ReadLine();

            }
            var joined = from st in studentsList
                         join sp in studentSpecialties on st.facultyNumber equals sp.facultyNumber
                         select new { name = st.studentName, facNumber = sp.facultyNumber, specialtyName = sp.specialtyName };

            foreach (var item in joined.OrderBy(x => x.name))
            {
                Console.WriteLine("{0} {1} {2}", item.name, item.facNumber, item.specialtyName);
            }
        }
    }
}