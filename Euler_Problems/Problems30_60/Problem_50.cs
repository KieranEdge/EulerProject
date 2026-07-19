using Problems.Interfaces;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_50 : IProblem
{
    public int ProblemNumber => 50;

    public string Solve()
    {
        const int limit = 1_000_000;

        // Sieve lookup for O(1) prime checks
        bool[] isPrime = EratosthenesSieve.PrimesUpToNAsBoolArray(limit);

        // Store all primes under limit
        List<int> primes = new();

        for (int i = 2; i < limit; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        int bestPrime = 0;
        int longestSequence = 0;

        // Try every starting position
        for (int start = 0; start < primes.Count; start++)
        {
            int rollingSum = 0;

            // Extend the sequence forward
            for (int end = start; end < primes.Count; end++)
            {
                rollingSum += primes[end];

                // No point continuing once we exceed the limit
                if (rollingSum >= limit)
                {
                    break;
                }

                int sequenceLength = end - start + 1;

                // Only update if:
                // 1. Sum is prime
                // 2. Sequence is longer than previous best
                if (sequenceLength > longestSequence &&
                    isPrime[rollingSum])
                {
                    longestSequence = sequenceLength;
                    bestPrime = rollingSum;
                }
            }
        }

        return bestPrime.ToString();
    }
}