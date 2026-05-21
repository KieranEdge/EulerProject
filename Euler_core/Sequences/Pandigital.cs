namespace ProjectEuler.Core.Sequences;

public class Pandigital
{
    public static bool IsPandigital(long number, int minDigit, int maxDigit)
    {
        string s = number.ToString();

        int requiredLength = maxDigit - minDigit + 1;

        if (s.Length != requiredLength)
            return false;

        bool[] seen = new bool[10];

        foreach (char c in s)
        {
            int digit = c - '0';

            if (digit < minDigit || digit > maxDigit)
                return false;

            if (seen[digit])
                return false;

            seen[digit] = true;
        }

        for (int i = minDigit; i <= maxDigit; i++)
        {
            if (!seen[i])
                return false;
        }

        return true;
    }
}