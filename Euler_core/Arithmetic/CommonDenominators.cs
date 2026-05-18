namespace ProjectEuler.Core.Arithmetic;

public class CommonDenominators
{
    public static int ReturnGCD(int a, int b)
    {
        int remainder;
        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}