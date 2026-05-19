using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_38:IProblem
{
    public int ProblemNumber => 38;

    public string Solve()
    {
        long maxPandigitalNumber = 0;
        for (int n = 1; n < 10000; n++)
        {
            int length = ReturnNumberOfDigits(n);
            int multiplier = 2;
            long number = n;
            
            while (length < 9)
            {
                number = NumberMultiplesConcatenated(number, n, multiplier);
                length =  ReturnNumberOfDigits(number);
                multiplier++;
            }
            
            if (length == 9)
            {
                if (IsNumberPandigital(number) && number > maxPandigitalNumber)
                {
                    maxPandigitalNumber = number;
                }
            }
        }
        return maxPandigitalNumber.ToString();
    }
    

    public long NumberMultiplesConcatenated(long currentNumber, int originalNumber, int multiplier)
    {
        int newMultiple = originalNumber * multiplier;
        string newNumber = string.Concat(currentNumber.ToString(), newMultiple.ToString());
        return long.Parse(newNumber);
    }
    public bool IsNumberPandigital(long number)
    {
        char[] digitsArray = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
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

    public int ReturnNumberOfDigits(long number)
    {
        string numberAsString = number.ToString();
        return numberAsString.Length;
    }
}