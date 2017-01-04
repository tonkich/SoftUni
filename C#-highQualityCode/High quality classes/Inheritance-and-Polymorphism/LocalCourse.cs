using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string courseName)
            :base(courseName)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            :base(courseName, teacherName)
        {
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            :base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public override string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.CourseName != null)
            {
                result.Append("LocalCourse { Name = ");
                result.Append(this.CourseName);
                result.Append(";");
            }
            if (this.TeacherName != null)
            {
                result.Append(" Teacher = ");
                result.Append(this.TeacherName);
                result.Append(";");

            }
            if (this.Students != null)
            {
                result.Append(" Students = ");
                result.Append(this.GetStudentsAsString());
            }
            if (this.Lab != null)
            {
                result.Append(" Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
