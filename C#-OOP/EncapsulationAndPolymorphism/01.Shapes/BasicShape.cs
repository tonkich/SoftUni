using _01.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double side;
        private double secondSide;
        protected BasicShape(double side, double secondSide)
        {
            this.Side = side;
            this.SecondSide = secondSide;
        }

        public double Side
        {
            get { return this.side; }
            set { this.side = value; }
        }

        public double SecondSide
        {
            get { return this.secondSide; }
            set { this.secondSide = value; }
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
