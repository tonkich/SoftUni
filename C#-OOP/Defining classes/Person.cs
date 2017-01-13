using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    public  class Person
    {
        private string name;
        private int age;
        private string email;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Age must be between 0 and 100");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.email = "(not set)";
                else if (!value.Contains("@"))
                    throw new ArgumentException("The email must contain @");
                else
                    this.email = value;
            }
        }
        public Person(string name, int age)
            : this(name, age, null)
        {
        }
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.Name, this.Age, this.Email);
        }
    }
        class _01_
        {
            static void Main(string[] args)
            {
                Person one = new Person("Tonkich", 20, "tonkich@abv.bg");
                Person two = new Person("babaTemida", 90);

                Console.WriteLine(one);
                Console.WriteLine(two);
            }
        }
}

