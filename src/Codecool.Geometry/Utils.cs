using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.Geometry
{
    public class Utils
    {
        public static bool CheckIfAllArePositive(params double[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
