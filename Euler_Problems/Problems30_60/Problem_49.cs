using Problems.Interfaces;
using ProjectEuler.Core.Primes;

namespace Problems.Problems30_60;

public class Problem_49 : IProblem
{
    public int ProblemNumber => 49;

    public string Solve()
    {
        List<int> primes = new();

        for (int i = 1000; i < 10000; i++)
        {
            if (PrimeInformation.IsPrimeNumber(i))
                primes.Add(i);
        }

        // group by sorted digits
        Dictionary<string, List<int>> groups = new();

        foreach (var p in primes)
        {
            string key = SortDigits(p);

            if (!groups.ContainsKey(key))
                groups[key] = new List<int>();

            groups[key].Add(p);
        }

        foreach (var group in groups.Values)
        {
            if (group.Count < 3)
                continue;

            group.Sort();

            for (int i = 0; i < group.Count; i++)
            {
                for (int j = i + 1; j < group.Count; j++)
                {
                    int a = group[i];
                    int b = group[j];

                    int c = b + (b - a);

                    if (group.Contains(c))
                    {
                        if (a == 1487 && b == 4817 && c == 8147)
                            continue;

                        return $"{a}{b}{c}";
                    }
                }
            }
        }

        return "";
    }

    private string SortDigits(int n)
    {
        return new string(n.ToString().OrderBy(c => c).ToArray());
    }
}