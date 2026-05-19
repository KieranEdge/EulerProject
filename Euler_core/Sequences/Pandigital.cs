namespace ProjectEuler.Core.Sequences;

public class Pandigital
{
    public static bool IsNumberPandigital(long number)
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
}