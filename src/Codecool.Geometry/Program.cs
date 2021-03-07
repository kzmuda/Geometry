using System;
using System.Collections.Generic;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {

        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            Circle circle = new Circle(3.5);
            Triangle triangle = new Triangle(1, -2, 3, 2.5);
            Square square = new Square(2);

            List<IShape> list = new List<IShape> { circle, triangle, square };

            list.Sort();

            // int[] ints = { 1,5,8};
            // Console.Out.WriteLine(Add(ints));
            // Console.Out.WriteLine(Add(1,7,9));
            // bool isRunning = true;
            // Square square = new Square(2);
            // Console.WriteLine(square.GetArea());
            //
            //
            // Circle circle = new Circle(3.5);
            // Console.WriteLine(circle.GetArea());
            // Console.WriteLine(circle.GetAreaFormula());
            // Console.WriteLine(circle.GetPerimeter());
            // Console.WriteLine(circle.GetPerimeterForumla());
            //
            //
            //
            // Triangle triangle = new Triangle(1, -2, 3, 2.5);
            // Console.WriteLine(triangle.GetArea());
            // Console.WriteLine(triangle.GetAreaFormula());
            // Console.WriteLine(triangle.GetPerimeter());
            // Console.WriteLine(triangle.GetPerimeterForumla());




            // while (isRunning)
            // {
            //     int option = 0;  // TODO read the keyboard here
            //
            //     switch (option)
            //     {
            //         case 1:
            //             // TODO Add new shape
            //             break;
            //         case 2:
            //             // TODO Show all shapes
            //             break;
            //         case 3:
            //             // TODO Show shape with the largest perimeter
            //             break;
            //         case 4:
            //             // TODO Show shape with the largest area
            //             break;
            //         case 5:
            //             // TODO Show formulas
            //             break;
            //         case 0:
            //             // TODO Exit
            //             break;
            //     }
            // }
        }
    }
}
