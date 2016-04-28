namespace Abstraction
{
    using System;

    internal class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Width cannot be negative");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Height cannot be negative");
                }
                this.height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}

//public override double Radius
//{
//    get
//    {
//        throw new NotImplementedException("Rectangle does not have Radius");
//    }
//    set
//    {
//        throw new NotImplementedException("Rectangle does not have Radius");
//    }
//}
