namespace ProjectEuler.Core.Arithmetic;

public class Squares
{
    public static bool IsSquare(long n)
    {
        double rootValue = Math.Sqrt(n);
        return rootValue == Math.Floor(rootValue);
    }
}