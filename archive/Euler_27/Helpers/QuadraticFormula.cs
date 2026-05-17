namespace Euler_27.Helpers;

public class QuadraticFormula
{
    public static int QuadraticFormulaValue(int n, int a, int b)
    {
        int value = (n * n) + (a * n) + b;
        return value;
    }
}