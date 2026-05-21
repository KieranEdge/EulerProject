using Problems.Interfaces;
namespace Problems.Problems30_60;

public class Problem_44 : IProblem
{
    public int ProblemNumber => 44;

    public string Solve()
    {
        const int limit = 5000;

        List<long> pentagonalNumbers = new();

        for (int i = 1; i <= limit; i++)
        {
            pentagonalNumbers.Add(Pentagonal(i));
        }

        long smallestDifference = long.MaxValue;

        for (int j = 0; j < pentagonalNumbers.Count; j++)
        {
            long pj = pentagonalNumbers[j];

            for (int k = j + 1; k < pentagonalNumbers.Count; k++)
            {
                long pk = pentagonalNumbers[k];

                long sum = pj + pk;
                long difference = pk - pj;

                if (IsPentagonal(sum) && IsPentagonal(difference))
                {
                    if (difference < smallestDifference)
                    {
                        smallestDifference = difference;
                    }
                }
            }
        }

        return smallestDifference.ToString();
    }

    private static long Pentagonal(long n)
    {
        return n * (3 * n - 1) / 2;
    }

    private static bool IsPentagonal(long x)
    {
        double n = (1 + Math.Sqrt(1 + 24 * x)) / 6;
        return n == Math.Floor(n);
    }
}