using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_30 : IProblem
{
    public int ProblemNumber => 30;
    public string Solve()
    {
        List<double> digitsToFifthPowerEqualsNumber = [];

        // 354294 is the sum for six digit numbers (6 * 9^5), seven digit sums are not possible
        for (double i = 2; i <= 354294; i++)
        {
            double sumOfDigitsToFifthPower = DigitsToFifthPowerSum(i);
            if (sumOfDigitsToFifthPower == i)
            {
                digitsToFifthPowerEqualsNumber.Add(i);
            }
        }
        
        return $"{digitsToFifthPowerEqualsNumber.Sum()} is the sum of all numbers where the rule is applied";
    }
    

    public double DigitsToFifthPowerSum(double n)
    {
        string intAsString = n.ToString();
        double sum = 0;
        foreach (char c in intAsString)
        {
            double digit  = c - '0';
            sum += Math.Pow(digit, 5);
        }

        return sum;
    }
}