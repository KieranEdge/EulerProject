using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_9.Helpers
{
    internal class Triples
    {
        public static List<double> GeneratePythagoreanTriples(int m, int n)
        {
            List<double> result = new List<double>();

            if (m == n)
            {
                Console.WriteLine($"Factors cannot be the same");
                return result;
            }
            else if (m < n)
            {
                Console.WriteLine("m must be greater than n");
            }

            double a = Math.Pow(m, 2) - Math.Pow(n, 2);
            double b = 2 * m * n;
            double c = Math.Pow(m, 2) + Math.Pow(n, 2);

            result.Add(a);
            result.Add(b);
            result.Add(c);

            return result;
        }
    }
}
