using Problems.Interfaces;
using ProjectEuler.Core.Arithmetic;

namespace Problems.Problems30_60;

public class Problem_33:IProblem
{
    public int ProblemNumber => 33;

    public string Solve()
    {
        int numerator = 1;
        int denominator = 1;
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                for (int k = 1; k < 10; k++)
                {
                    if ((10 * i + j) * k == (10 * j + k) * i && i < k)
                    {
                        numerator *= i;
                        denominator *= k;
                    }
                }
            }
        }
        int value = denominator / CommonDenominators.ReturnGCD(numerator, denominator);
        return value.ToString();
    }
}