using Problems.Interfaces;


namespace Problems.Problems30_60;

public class Problem_40 : IProblem
{
    public int ProblemNumber => 40;

    public string Solve()
    {
        List<char> digitsList = new();

        int currentNumber = 1;

        while (digitsList.Count < 1000000)
        {
            foreach (char digit in currentNumber.ToString())
            {
                digitsList.Add(digit);
            }

            currentNumber++;
        }

        int product = 1;

        for (int i = 1; i <= 1000000; i *= 10)
        {
            product *= digitsList[i - 1] - '0';
        }

        return product.ToString();
    }
}