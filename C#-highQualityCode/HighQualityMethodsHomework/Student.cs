using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 11));
            DateTime secondDate =
                DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 11));
            if (firstDate < secondDate)
            {
                return firstDate < secondDate;
            }
            else
            {
                return false;
            }

        }
    }
}
