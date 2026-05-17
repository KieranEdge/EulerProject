using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_5.Helpers
{
    internal static class PrimeFactorization
    {
        public static List<int> ReturnPrimeFactors(int number)
        {
            List<int> factors = new List<int>();

            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            for (int i = 3; i * i <= number; i += 2)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            if (number > 1)
            {
                factors.Add(number);
            }
            return factors;
        }

        public static List<int> PrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();
            for(int i = start; i <= end; i++)
            {
                if (isPrime(i)) primes.Add(i);
            }
            return primes;
        }
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
