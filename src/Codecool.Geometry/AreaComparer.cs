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

            var areaX = x.GetArea();
            var areaY = y.GetArea();

            if (areaX > areaY)
            {
                return 1;
            }

            if (areaX < areaY)
            {
                return -1;
            }

            return 0;

        }
    }
}
