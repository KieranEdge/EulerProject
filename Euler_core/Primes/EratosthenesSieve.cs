namespace ProjectEuler.Core.Primes;

public class EratosthenesSieve
{
    public static Dictionary<int, bool> PrimesUpToNAsDictionary(int n)
    {
        Dictionary<int, bool> primesUpToN = new Dictionary<int, bool>();
        
        // Handling the starting edge cases
        primesUpToN.Add(1, false);
        primesUpToN.Add(2, true);
        
        // Initialising the rest of the dictionary
        for (int i = 3; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                primesUpToN.Add(i, false);
            }
            else
            {
                primesUpToN.Add(i, true);
            }
        }
        
        // Applying the sieve to the rest of the dictionary up to the square root of n
        for (int i = 3; i * i <= n; i += 2)
        {
            if (primesUpToN[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primesUpToN[j] = false;
                }
            }
        }
        
        return primesUpToN;
    }
    public static bool[] PrimesUpToNAsBoolArray(int n)
    {
        bool[] isPrime = Enumerable.Repeat(true, n + 1).ToArray();

        isPrime[0] = false;
        isPrime[1] = false;

        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime;
    }
}