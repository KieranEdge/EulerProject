namespace Euler_23.Helpers;

public class Divisors
{
    public static int ReturnSumOfDivisors(int n)
    {
        int sumOfDivisors = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sumOfDivisors += i;
            }
        }
        
        return  sumOfDivisors;
    }
}