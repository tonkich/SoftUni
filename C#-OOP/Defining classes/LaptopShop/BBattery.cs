using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    public class BBattery
    {
        private string battery;
        private double batteryLife;
        public BBattery(string battery = null ,double batteryLife = 0)
        {
            this.Battery = battery;
            this.batteryLife = batteryLife;
        }
        public string Battery
        {
            get { return this.battery;}
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.battery = null;
                this.battery = value;
            }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value must be > 0");
                this.batteryLife = value;
            }
        }
        public override string ToString()
        {
            return "Battery: " + this.Battery +"\n" +  "Battery life: " + this.BatteryLife + "hours";
        }
    }
}
