namespace ProjectEuler.Core.Primes;

public static class Factors
{
    public static List<long> PrimeFactors(long number)
    {
        var factors = new List<long>();

        // Handle factor 2 separately
        while (number % 2 == 0)
        {
            factors.Add(2);
            number /= 2;
        }

        // Now check only odd numbers
        for (long i = 3; i * i <= number; i += 2)
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }

        // If anything remains, it's prime
        if (number > 1) factors.Add(number);

        return factors;
    }
}