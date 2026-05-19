using Problems.Interfaces;
using ProjectEuler.Core.Primes;
using ProjectEuler.Core.Sequences;


namespace Problems.Problems30_60;

public class Problem_41:IProblem
{
    public int ProblemNumber => 41;

    public string Solve()
    {
        int maxPandigital = 7654321;
        
        for (int i = maxPandigital; i >= 0; i--)
        {
            if (PrimeInformation.IsPrimeNumber(i))
            {
                if (IsNumberPandigital(i))
                {
                    return i.ToString();
                };
            }
        }

        return "No primes found in range";
    }
    public static bool IsNumberPandigital(long number)
    {
        char[] digitsArray = ['1', '2', '3', '4', '5', '6', '7'];
        string numberAsString = number.ToString();

        if (numberAsString.Contains('0'))
        {
            return false;
        }

        foreach (char digit in digitsArray)
        {
            int digitCount = numberAsString.Count(c => c == digit);
            if (digitCount != 1)
            {
                return false;
            }
        }
        return true;
    }
}