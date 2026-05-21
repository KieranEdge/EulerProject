using Problems.Interfaces;
using ProjectEuler.Core.Sequences;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_43:IProblem
{
    public int ProblemNumber => 43;

    public string Solve()
    {
        List<long> pandigitalNumbers = [];
        List<long> pandigitalNumbersWithDivisibleSubs = [];
        long minPandigital = 1023456789;
        long maxPandigital = 9876543210;

        for (long i = minPandigital; i <= maxPandigital; i++)
        {
            if (Pandigital.IsPandigital(i, 0, 9))
            {
                pandigitalNumbers.Add(i);
            }
        }

        foreach (long number in pandigitalNumbers)
        {
            bool[] aresubstringsDivisible = new bool[7];
            for(int i = 0; i < 7; i++)
            {
                aresubstringsDivisible[i] = IsSubDigitDivisible(number, i + 1, 3);
            }

            if (aresubstringsDivisible.All(x => x))
            {
                pandigitalNumbersWithDivisibleSubs.Add(number);
            }
        }
        
        return pandigitalNumbersWithDivisibleSubs.Sum().ToString();

    }

    public bool IsSubDigitDivisible(long pandigital, int startingIndex, int length)
    {
        string numberAsString = pandigital.ToString();
        string substring = numberAsString.Substring(startingIndex, length);
        int subNumber = int.Parse(substring);

        if (PrimeInformation.IsPrimeNumber(subNumber))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public List<long> PandigitalNumbersGenerator(char[] array, int size)
    {
        List<long> pandigitalCombinations = new List<long>();
        if (size == 1)
        {
            return pandigitalCombinations;
        }

        for (int i = 0; i < size; i++)
        {
            PandigitalNumbersGenerator(array, size - 1);

            int swapIndex = size % 2 == 1 ? 0 : i;

            (array[swapIndex], array[size - 1]) =
                (array[size - 1], array[swapIndex]);
        }
        return pandigitalCombinations;
    }
}