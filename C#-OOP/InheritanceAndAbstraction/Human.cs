using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Invalid name input!");
                {
                    this.firstName = value;
                }
            }
            
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Invalid name input!");
                {
                    this.lastName = value;
                }
            }
        }
    }
}
