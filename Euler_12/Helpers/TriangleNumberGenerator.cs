using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_12.Helpers
{
    internal class TriangleNumberGenerator
    {
        public static int GenerateNextTriangleNumber(int nextTriangleNumber)
        {
            int triangleNumber = 0;

            for (int i = 1; i <= nextTriangleNumber; i++)
            {
                triangleNumber += i;
            }

            return triangleNumber;
        }
    }
}
