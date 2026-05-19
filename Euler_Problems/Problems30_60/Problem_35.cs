using Problems.Interfaces;
using ProjectEuler.Core;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_35:IProblem
{
    public int ProblemNumber => 35;

    public string Solve()
    {
        // Getting the reference library
        Dictionary<int, bool> isNumberPrimeDictionary = EratosthenesSieve.PrimesUpToNAsDictionary(1000000);
        List<int> circularPrimes = [2];

        for (int i = 3; i < 1000000; i += 2)
        {
            List<bool> areCycleNumbersPrime = [];
            if (isNumberPrimeDictionary[i])
            {
                // Could move this into the method or find a better way
                string numberAsString = i.ToString();
                int digits = numberAsString.Length;
                
                // Iterating over the number cycler to populate the list
                for (int j = 1; j <= digits; j++)
                {
                    numberAsString = NumberCycler(numberAsString);
                    int numberAsInt = int.Parse(numberAsString);
                    if (isNumberPrimeDictionary[numberAsInt])
                    {
                        areCycleNumbersPrime.Add(true);
                    }
                    else
                    {
                        areCycleNumbersPrime.Add(false);
                    }
                }
                
            }

            if (areCycleNumbersPrime.Count > 0 && !areCycleNumbersPrime.Any(c => c == false))
            {
                circularPrimes.Add(i);
            }
        }

        return circularPrimes.Count.ToString();
    }

    public string NumberCycler(string n)
    {
        string numberWithoutLastDigit = n.Substring(0, n.Length - 1);
        char lastDigit = n[n.Length - 1];
        return String.Concat(lastDigit,  numberWithoutLastDigit);
    }

    public bool ContainsNumbersWithoutPrimes(string n)
    {
        string[] numbersToExclude = ["0", "2", "4", "5", "6", "8"];
        string intString = n;
        foreach (string digit in numbersToExclude)
        {
            if (intString.Contains(digit))
            {
                return false;
            }
        }
        return true;
    }
}