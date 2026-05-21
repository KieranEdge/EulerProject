using Problems.Interfaces;
using System.Numerics;

namespace Problems.Problems30_60;

public class Problem_48:IProblem
{
    public int ProblemNumber => 48;

    public string Solve()
    {
        BigInteger sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            sum += BigInteger.Pow(i, i);
        }
        return sum.ToString();
    }
}