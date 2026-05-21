namespace ProjectEuler.Core.Arithmetic;

public class GeometricNumbers
{
    public static bool isTriangle(long n)
    {
        double triangle = (-1 + Math.Sqrt(1 + 8 * n)) / 2;
        return triangle == Math.Floor(triangle);
    }
    
    public static bool IsHexagonal(long x)
    {
        double n = (1 + Math.Sqrt(1 + 8 * x)) / 4;
        return n == Math.Floor(n);
    }
    
    public static bool IsPentagonal(long x)
    {
        double n = (1 + Math.Sqrt(1 + 24 * x)) / 6;
        return n == Math.Floor(n);
    }
}