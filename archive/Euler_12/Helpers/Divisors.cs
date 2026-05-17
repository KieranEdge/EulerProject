using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_12.Helpers
{
    internal class Divisors
    {
        public static int DivisorsInNumber(List<long> triangleNumberPrimeFactors)
        {
            // List for getting the multiplicity of the prime factors
            List<int> multiplicityOfPrimeFactors = new List<int>();

            // Distinct prime factors in the original list
            List<long> distinctPrimeFactors = triangleNumberPrimeFactors.Distinct().ToList();

            // Iterating over the prime factors in the original list to see how many times they occur
            foreach (long factor in distinctPrimeFactors)
            {
                int occurences = triangleNumberPrimeFactors.Count(x => x == factor);
                multiplicityOfPrimeFactors.Add(occurences + 1);
            }

            int divisors = 1;
            foreach(int occurence in multiplicityOfPrimeFactors)
            {
                divisors *= occurence;
            }

            return divisors;

        }
    }
}
