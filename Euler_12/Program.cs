using Euler_12.Helpers;
using Euler_3.PrimeHelpers;

int divisorsOfTriangleNumber = 0;
int i = 1;

while(divisorsOfTriangleNumber <= 500)
{
    int triangleNumber = TriangleNumberGenerator.GenerateNextTriangleNumber(i);
    Console.WriteLine($"Triangle number {i}: {triangleNumber}");

    List<long> primeFactors = Factors.PrimeFactors(triangleNumber);
    divisorsOfTriangleNumber = Divisors.DivisorsInNumber(primeFactors);
    Console.WriteLine($"Is divisible by {divisorsOfTriangleNumber} integers");
    i++;
}