using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        // /// <summary>
        // ///     Gets formula for the area of the rectangle as a string.
        // /// </summary>
        // public new static string AreaFormula => throw new NotImplementedException();
        //
        // /// <summary>
        // ///     Gets formula for the perimeter of the rectangle as a string.
        // /// </summary>
        // public new static string PerimeterFormula => throw new NotImplementedException();
        public Square(double A) : base (A, A)// wywołaj koknstruktor klasy bazowej
        {

        }
    
    }
}
