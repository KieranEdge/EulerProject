using Problems.Interfaces;
using ProjectEuler.Core.Sequences;

namespace Problems.Problems30_60;

public class Problem_34 : IProblem
{
    public int ProblemNumber => 34;

    public string Solve()
    {
        Dictionary<int, int> factorialsDictionary = FactorialGenerator(9);
        List<int> curiousNumbers = new List<int>();

        for (int i = 3; i <= 2540160; i++)
        {
            int sumOfDigitFactorials = 0;
            string numberAsString = i.ToString();
            foreach (char c in numberAsString)
            {
                int digit = c - '0';
                sumOfDigitFactorials += factorialsDictionary[digit];
            }

            if (sumOfDigitFactorials == i)
            {
                curiousNumbers.Add(i);
            }
        }
        return $"Sum of curious numbers: {curiousNumbers.Sum()}";
    }

    public Dictionary<int, int> FactorialGenerator(int maxN)
    {
        Dictionary<int, int> factorialsDictionary = new Dictionary<int, int>();
        for (int i = 0; i <= maxN; i++)
        {
            factorialsDictionary.Add(i, Factorial.ReturnFactorial(i));
        }
        return factorialsDictionary;
    }
    
}