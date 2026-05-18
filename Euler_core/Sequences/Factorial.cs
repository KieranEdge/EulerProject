namespace ProjectEuler.Core.Sequences;

public class Factorial
{
    public static int ReturnFactorial(int n)
    {
        int factorial = 1;
        if (n == 0)
        {
            return factorial;
        }
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public static long ReturnFactorial(long n)
    {
        long factorial = 1;
        if (n == 0)
        {
            return factorial;
        }
        for (long i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}