using Problems.Interfaces;
using ProjectEuler.Core.Arithmetic;

namespace Problems.Problems30_60;

public class Problem_45:IProblem
{
    public int ProblemNumber => 45;

    public string Solve()
    {
        long currentNumber = 40766;
        long nextHexAndPentagonalNumber = 0;
        bool isHexAndPentagonal = false;

        while (!isHexAndPentagonal)
        {
            if (GeometricNumbers.IsPentagonal(currentNumber) && GeometricNumbers.IsHexagonal(currentNumber))
            {
                isHexAndPentagonal = true;
                nextHexAndPentagonalNumber = currentNumber;
            }
            
            currentNumber++;
        }
        
        return $"{nextHexAndPentagonalNumber}";
    }
}