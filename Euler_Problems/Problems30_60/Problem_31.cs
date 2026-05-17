using Problems.Interfaces;

namespace Problems.Problems30_60;

public class Problem_31 : IProblem
{
    public int ProblemNumber => 31;

    public string Solve()
    {
        int target = 200;
        int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };

        int[] dp = new int[target + 1];
        dp[0] = 1;

        foreach (int coin in coins)
        {
            for (int amount = coin; amount <= target; amount++)
            {
                dp[amount] += dp[amount - coin];
            }
        }

        return $"The amount of ways to make 2 pound equals: {dp[target]}";
    }
}