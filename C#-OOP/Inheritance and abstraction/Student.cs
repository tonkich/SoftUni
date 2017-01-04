using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InheritanceAndAbstraction
{
        class Student : Human
        {
            private string facultyNumber;
            public Student(string firstName, string lastName, string facultyNumber)
                : base(firstName, lastName)
            {
                this.FacultyNumber = facultyNumber;
            }
            public string FacultyNumber
            {
                get { return this.facultyNumber; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Faculty number cannot be null or empty");
                    }
                    if (!Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                    {
                        throw new ArgumentException("Faculty number must contain 5-10 digits / letters");
                    }
                    this.facultyNumber = value;
                }
            }
        }
}
