using System.Runtime.InteropServices.JavaScript;

namespace Euler_15.Helpers;

public class BinomialCoefficient
{
    public static double NumberOfPathsToPosition(int start_x, int start_y, int end_x, int end_y)
    {
        int positionN = end_x - start_x;
        int positionK = end_y - start_y;
        Console.WriteLine($"Paths going from ({start_x}, {start_y}) to ({end_x}, {end_y})");
        
        return BinomialCoefficientCalculator(positionN, positionK);
        
    }

    public static double FactorialCalculator(int n)
    {
        double factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public static double BinomialCoefficientCalculator(int n, int k)
    {
        // Defining the coefficients
        double topFactorial = FactorialCalculator(n + k);
        double bottomFactorial = FactorialCalculator(k) * FactorialCalculator(n);
        Console.WriteLine($"Binomial Coefficient of {topFactorial} and {bottomFactorial}");
        return topFactorial / bottomFactorial;
    }
}