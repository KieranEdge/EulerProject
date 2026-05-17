using Euler_5;
using Euler_5.Helpers;

int min = 2;
int max = 20;

// Reference list for counting primes
List<int> primesInRange = PrimeFactorization.PrimesInRange(min, max);

// List of lists for prime factors
List<List<int>> primeFactorsInAllRange = new List<List<int>>();

// Creating a list of prime factors for every value in the range
for (int i = min;  i <= max; i++)
{
    List<int> primeFactors = PrimeFactorization.ReturnPrimeFactors(i);
    primeFactorsInAllRange.Add(primeFactors);
}

// Creating a dictionary for the number of times each prime appears at most
Dictionary<int, int> primesMaxMultiplicity = new Dictionary<int, int>();

// Iterating over each prime number
foreach (int primeFactor in primesInRange)
{
    // Counting the max occurence of each prime factor
    int maxNumber = 0;

    // Iterating over each list of prime factors
    foreach(List<int> listOfPrimeFactors in primeFactorsInAllRange)
    {
        // Counting the occurence of the prime in that list
        int counter = 0;
        foreach(int factor in listOfPrimeFactors)
        {
            if(factor == primeFactor)
            {
                counter++;
            }
        }

        if(counter > maxNumber)
        {
            maxNumber = counter;
        }
    }

    primesMaxMultiplicity.Add(primeFactor, maxNumber);
}

double sum = 1;

foreach (var item in primesMaxMultiplicity)
{
    double baseValue = item.Key;
    double powerValue = item.Value;

    sum *= Math.Pow(baseValue, powerValue);
}

Console.WriteLine($"Lowest Common Multiple: {sum}");