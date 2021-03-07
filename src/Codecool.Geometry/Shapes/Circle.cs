using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : IShape
    {

        double r;

        public Circle(double r)
        {
            this.r = r;
        }



        public double GetArea()
        {
            return Math.PI * Math.Pow(r,2);
        }

        public string GetAreaFormula()
        {
            return "Pi * r^2";
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }

        public string GetPerimeterForumla()
        {
            return "2 Pi r";
        }
    }
}
