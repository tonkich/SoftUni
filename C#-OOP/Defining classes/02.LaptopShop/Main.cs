using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class main
    {
        static void Main(string[] args)
        {
            Laptop temp1 = new Laptop("Lenovo Yoga 2 Pro", 2259.00, new BBattery("Li-Ion", 4.5), "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Console.WriteLine(temp1);
        }
    }
}
