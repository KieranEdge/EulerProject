using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_36:IProblem
{
    public int ProblemNumber => 36;

    public string Solve()
    {
        List<int> palindromicNumbers = new List<int>();
        
        for (int i = 1; i < 1000000; i++)
        {
            string numberAsString = i.ToString();
            string numberAsStringReversed = NumberReverser(numberAsString);
            
            string binaryNumber = Convert.ToString(i, 2);
            string binaryNumberReversed = NumberReverser(binaryNumber);

            if (numberAsString == numberAsStringReversed && binaryNumber == binaryNumberReversed)
            {
                palindromicNumbers.Add(i);
            }
        }
        
        return $"Sum of palndromic numbers in decimal and binary: {palindromicNumbers.Sum()}";
    }

    private string NumberReverser(string numberAsString)
    {
        char[] characterArray = numberAsString.ToCharArray();
        Array.Reverse(characterArray);
        return new string(characterArray);
    }
}