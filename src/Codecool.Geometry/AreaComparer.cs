using Codecool.Geometry.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.Geometry
{
    public class AreaComparer: IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            // x, y
            // x > y => 1
            // x = y => 0
            // x < y => -1

            if (x.GetArea() > y.GetArea())
            {
                return 1;
            }

            return 0;

        }
    }
}
