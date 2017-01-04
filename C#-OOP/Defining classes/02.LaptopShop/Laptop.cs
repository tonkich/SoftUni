using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        private BBattery battery;
        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, BBattery battery, string manufacturer)
            : this(model, price)
        {
            this.battery = battery;
            this.Manufacturer = manufacturer;
        }
        public Laptop(string model, double price, BBattery battery, string manufacturer = null, string processor = null,
            int ram = 0, string graphicsCard = null, string hdd = null, string screen = null)
            : this(model, price, battery, manufacturer)
        {
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The model of the laptop is mandatory!");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int RAM
        {
            get { return this.ram; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Ram must be positive number!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The price must be set and > 0");
                this.price = value;
            }
        }
        public void AddBattery(BBattery battery)
        {
            this.battery = battery;
        }
        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufacturer))
                output += "Manufacturer: " + this.manufacturer + "\n";
            if (!String.IsNullOrEmpty(this.processor))
                output += "Processor: " + this.processor + "\n";
            if (this.RAM != 0)
                output += "RAM: " + this.ram + " GB" + "\n";
            if (!String.IsNullOrEmpty(this.graphicsCard))
                output += "Graphics card: " + this.graphicsCard + "\n";
            if (!String.IsNullOrEmpty(this.hdd))
                output += "HDD: " + this.hdd + "\n";
            if (!String.IsNullOrEmpty(this.screen))
                output += "Screen: " + this.screen + "\n";
            output += battery + "\n";

            output += "Price: " + this.price + " lv.\n";
            return output;
        }
    }
}
