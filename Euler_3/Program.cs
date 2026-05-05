using Euler_3.PrimeHelpers;

long startingNumber = 600851475143;

List<long> initialFactors = Factors.PrimeFactors(startingNumber);

foreach (long factor in initialFactors)
{
    Console.WriteLine(factor);
}
long sum = initialFactors.Sum();

Console.WriteLine(sum);