using Euler_10.Helper;

long max = 2000000;
List<long> primes = new List<long>();

for (long i = 2;  i <= max; i++)
{
    if (PrimeInformation.IsPrimeNumber(i))
    {
        primes.Add(i);
    }
}

Console.WriteLine($"Sum of all primes under {max}: {primes.Sum()}");