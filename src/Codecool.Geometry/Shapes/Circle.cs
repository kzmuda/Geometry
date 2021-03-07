using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : IShape, IComparable<Circle>
    {

        double r;

        public Circle(double r)
        {
            if (!Utils.CheckIfAllArePositive(r))
            {
                throw new ArgumentException("asdsad");
            }

            this.r = r;
        }

        public int CompareTo(Circle other)
        {
            // this, other
            // this > other => 1
            // this = other => 0
            // this < other => -1
            if (this.GetArea() > other.GetArea())
            {
                return 1;
            }

            if (this.GetArea() < other.GetArea())
            {
                return -1;
            }

            return 0;
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
