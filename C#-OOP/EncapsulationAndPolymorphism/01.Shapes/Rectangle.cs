using _01.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Rectangle : BasicShape
    {
        public Rectangle(double side,double secondSide)
            :base(side, secondSide)
        {
            this.Side = side;
            this.SecondSide = secondSide;
        }
        
    
        public override double CalculateArea()
        {
            return this.Side * this.SecondSide;
        }

        public override double CalculatePerimeter()
        {
            return this.Side * 2 + this.SecondSide * 2;
        }
    }
