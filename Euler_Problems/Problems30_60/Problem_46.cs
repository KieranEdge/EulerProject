using Problems.Interfaces;
using ProjectEuler.Core.Arithmetic;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_46 : IProblem
{
    public int ProblemNumber => 46;

    public string Solve()
    {
        long current = 9;

        while (true)
        {
            // only odd composites
            if (!PrimeInformation.IsPrimeNumber(current))
            {
                bool works = false;

                for (long prime = 2; prime < current; prime++)
                {
                    if (!PrimeInformation.IsPrimeNumber(prime))
                        continue;

                    long remainder = current - prime;

                    if (remainder % 2 != 0)
                        continue;

                    long squarePart = remainder / 2;

                    if (Squares.IsSquare(squarePart))
                    {
                        works = true;
                        break;
                    }
                }

                if (!works)
                    return current.ToString();
            }

            current += 2;
        }
    }
}