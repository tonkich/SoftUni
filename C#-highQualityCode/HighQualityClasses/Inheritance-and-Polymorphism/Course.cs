using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string _courseName;
        private string _teacherName;
        private IList<string> _students;

        protected Course(string name)
        {
            this.CourseName = this._courseName;
        }

        protected Course(string courseName, string teacherName)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this._courseName;
            }
            set
            {
                this._courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this._teacherName;
            }
            set
            {
                this._teacherName = value;
            }
        }
        public IList<string> Students
        {
            get
            {
                return this._students;
            }
            set
            {
                this._students = value;
            }
        }

        public virtual string GetStudentsAsString()
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
    }
}
