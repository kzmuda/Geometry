using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : IShape
    {
        private double h;
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }

        public double GetArea()
        {
            return a * h * 0.5;
        }

        public string GetAreaFormula()
        {
            return "a * h / 2";
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public string GetPerimeterForumla()
        {
            return "a + b + c";
        }
    }
}
