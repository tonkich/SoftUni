using _01.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class ShapesArray
    {
        public static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]
            {
                new Rectangle(6.7, 7.4),
                new Rectangle(2.3, 3.5),
                new Rhombus(0.536, 0.57983),
                new Rhombus(4.4, 6.2),
                new Circle(0.56987),
                new Circle(13), 
            };
            foreach (var shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine("Shape: {0}, area: {1:F2}, circumference: {2:F2}\n", shape.GetType(),
                        shape.CalculateArea(), shape.CalculatePerimeter());
                }
                else
                {
                    Console.WriteLine("Shape: {0}, area: {1:F2}, perimeter: {2:F2}\n", shape.GetType(),
                           shape.CalculateArea(), shape.CalculatePerimeter());
                }
            }
        }
    }
}
