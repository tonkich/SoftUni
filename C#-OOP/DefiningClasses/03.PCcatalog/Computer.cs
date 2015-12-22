using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalogue
{
    class Computer
    {
        protected string name;
        protected double price = 0.0;
        List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name of the computer is mandatory!");
                this.name = value;
            }
        }

        private double calculatePrice()
        {
            foreach (var component in this.components)
            {
                this.price += component.CompPrice;
            }
            return this.price;
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("You have to add at least 1 component to the computer");
                this.components = value;
            }
        }

        public override string ToString()
        {
            string output = "Computer name: " + this.name + "\n\n";
            foreach (var component in this.components)
            {
                output += component.ToString();
            }
            double prc = calculatePrice();
            output += "Computer price: " + prc + " BGN\n----------------------------------------\n";
            return output;
        }
    }

    class Component
    {
        private string compName;
        private string compDescription;
        private double compPrice;

        public Component(string compName, double compPrice, string compDescription = null)
        {
            this.CompName = compName;
            this.CompDescription = compDescription;
            this.CompPrice = compPrice;
        }


        public string CompName
        {
            get { return this.compName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The component name is required!");
                this.compName = value;
            }
        }

        public string CompDescription
        {
            get { return this.compDescription; }
            set { this.compDescription = value; }
        }

        public double CompPrice
        {
            get { return this.compPrice; }
            set
            {
                if (value <= 0 || Double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Price must be > 0");
                this.compPrice = value;
            }
        }

        public override string ToString()
        {
            string output = "component name: " + this.compName + "\n";
            if (!String.IsNullOrEmpty(this.compDescription))
                output += "component desc.: " + this.compDescription + "\n";
            else
                output += "component desc.: (not specified)\n";
            output += "component price: " + this.compPrice + " BGN\n\n";
            return output;
        }
    }

    class _03_
    {
        static void Main(string[] args)
        {

            List<Computer> computers = AddComputers();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer.ToString());
            }

        }

        static List<Computer> AddComputers()
        {
            List<Computer> computers = new List<Computer>();
            string ch = null;

            do
            {
                Console.Write("Enter the computer name: ");
                string name = Console.ReadLine();

                List<Component> components = AddComponents();

                Computer computer = new Computer(name, components);
                computers.Add(computer);

                Console.Write("\nDo you want to add another computer (y/n)?");
                ch = Console.ReadLine();
                Console.WriteLine();
            }
            while (ch != "n" && ch != "N");


            return computers;
        }

        static List<Component> AddComponents()
        {
            List<Component> components = new List<Component>();
            string ch = null;

            do
            {
                Console.Write("Enter the component name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the component description (not mandatory): ");
                string desc = Console.ReadLine();
                Console.Write("Enter the component price: ");
                double price = Double.Parse(Console.ReadLine());

                Component component = new Component(name, price, desc);
                components.Add(component);

                Console.Write("\nDo you want to add another component (y/n)? ");
                ch = Console.ReadLine();
            }
            while (ch != "n" && ch != "N");

            return components;
        }

    }
}
