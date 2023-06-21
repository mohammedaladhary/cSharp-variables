using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Shape
    {
        public abstract double CalculateArea();
    }

    internal class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
            }
    }

    internal class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    internal class Triangle : Shape
    {
        public double Width;
        public double Height;

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Width * Height;
        }
    }
}
