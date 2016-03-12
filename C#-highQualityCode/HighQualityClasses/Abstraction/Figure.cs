using System;

namespace Abstraction
{
    internal abstract class Figure
    {
        private double width;
        private double height;
        private double radius;

        public virtual double Width
        {
            get
            {
                if(this.width <=0)
                {
                    throw new ArgumentOutOfRangeException("Width cant be negative!");
                }
                return this.width;
            }
            set { this.width = value; }
        }
        public virtual double Height
        {
            get
            {
                if (this.height <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cant be negative!");
                }
                return this.height;
            }
            set { this.height = value; }
        }
        public virtual double Radius
        {
            get
            {
                if (this.radius <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cant be negative!");
                }
                return this.radius;
            }
            set { this.radius = value; }
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }
        public virtual double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
