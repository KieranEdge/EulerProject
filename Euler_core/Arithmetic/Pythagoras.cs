namespace ProjectEuler.Core.Arithmetic;

public class Pythagoras
{
    public double GetHypotenuse(double a, double b)
    {
        return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    }

    public static List<int> GenerateSquareNumbers(int max)
    {
        List<int> squareNumbers = [];
        for (int i = 1; i * i <= max; i++)
        {
            squareNumbers.Add(i * i);
        }
        return squareNumbers;
    }
}