namespace Euler_22.Helpers;

public class WordSum
{
    public static int WordScoreValue(string word)
    {
        int sumOfLetters = 0;
        foreach (char c in word)
        {
            sumOfLetters += c - 'A' + 1;
        }
        return sumOfLetters;
    }
}