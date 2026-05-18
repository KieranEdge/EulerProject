using System.Numerics;
using Problems.Interfaces;

namespace Problems.Problems150_180;

public class Problem_168:IProblem
{
    public int ProblemNumber => 168;

    public string Solve()
    {
        List<BigInteger> integersWithFactors = new List<BigInteger>();
        BigInteger maxValue = BigInteger.Pow(10, 100);
        for (BigInteger i = 11; i < maxValue; i++)
        {
            Console.WriteLine($"Processing {i} of 10^100");
            BigInteger rightRotation = GenerateRightRotation(i);
            if (IsOriginalFactorOfRightRotation(i, rightRotation))
            {
                integersWithFactors.Add(i);
            }
        }

        BigInteger sum = 0;
        foreach (BigInteger factor in integersWithFactors)
        {
            sum += factor;
        }
        
        return sum.ToString();
    }

    private bool IsOriginalFactorOfRightRotation(BigInteger original,  BigInteger rightRotation)
    {
        if (rightRotation < original)
        {
            return false;
        }
        else
        {
            if (rightRotation % original == 0)
            {
                return true;
            }
            return false;
        }
    }

    private BigInteger GenerateRightRotation(BigInteger integer)
    {
        string bigIntAsString = integer.ToString();
        string bigIntAsStringWithoutFinalDigits = bigIntAsString.Remove(bigIntAsString.Length - 1, 1);
        char lastDigit = bigIntAsString[bigIntAsString.Length - 1];
        string rightRotationString = string.Concat(lastDigit, bigIntAsStringWithoutFinalDigits);
        BigInteger rightRotation = BigInteger.Parse(rightRotationString);
        return rightRotation;
    }
}