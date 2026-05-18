using ProjectEuler.Core.Primes;
using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_37:IProblem
{
    public int ProblemNumber => 37;

    public string Solve()
    {
        int primeCounter = 0;
        List<int> primeList = new List<int>();
        int numberBeingExamined = 11;

        while (primeCounter < 11)
        {
            if (PrimeInformation.IsPrimeNumber(numberBeingExamined))
            {
                if (LeftToRightRemover(numberBeingExamined) && RightToLeftRemover(numberBeingExamined))
                {
                    primeList.Add(numberBeingExamined);
                    primeCounter++;
                }
            }
            numberBeingExamined++;
        }

        return $"Sum of cyclical primes: {primeList.Sum()}";
    }

    private bool LeftToRightRemover(int number)
    {
        string numberAsDigit = number.ToString();
        while (numberAsDigit.Length > 1)
        {
            string firstDigitRemoved = numberAsDigit.Substring(1);
            int newNumber = int.Parse(firstDigitRemoved);
            if (!PrimeInformation.IsPrimeNumber(newNumber))
            {
                return false;
            }
            numberAsDigit = firstDigitRemoved;
        }
        return true;
    }

    private bool RightToLeftRemover(int number)
    {
        string numberAsDigit = number.ToString();
        while (numberAsDigit.Length > 1)
        {
            string lastDigitRemoved = numberAsDigit.Remove(numberAsDigit.Length - 1);
            int newNumber = int.Parse(lastDigitRemoved);
            if (!PrimeInformation.IsPrimeNumber(newNumber))
            {
                return false;
            }
            numberAsDigit = lastDigitRemoved;
        }
        return true;
    }

}