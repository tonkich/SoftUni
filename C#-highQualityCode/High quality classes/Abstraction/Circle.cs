using System;

namespace Abstraction
{
    internal class Circle : Figure
    {
        public override double Radius { get; set; }
        
        public Circle(double radius)
            :base(radius )
        {
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
