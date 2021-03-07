using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : IShape
    {
        protected double A;
        protected double B;
        
         public Rectangle(double A, double B)
         {
             if (!Utils.CheckIfAllArePositive(A,B))
             {
                 throw new ArgumentException("asdsad");
             }

            this.A = A;
             this.B = B;
         }
        // /// <summary>
        // ///     Gets formula for the area of the rectangle as a string.
        // /// </summary>
        // public new static string AreaFormula => throw new NotImplementedException();
        //
        // /// <summary>
        // ///     Gets formula for the perimeter of the rectangle as a string.
        // /// </summary>
        // public new static string PerimeterFormula => throw new NotImplementedException();
        //
        // /// <inheritdoc />
        // public override double Area => throw new NotImplementedException();
        //
        // /// <inheritdoc />
        // public override double Perimeter => throw new NotImplementedException();
        public double GetArea()
        {
            return this.A * this.B;
        }

        public double GetPerimeter()
        {
            return 2 * this.A + 2 * this.B;
        }

        public string GetAreaFormula()
        {
            return "A * B";
        }

        public string GetPerimeterForumla()
        {
            return "2A + 2B";
        }
    }
}
