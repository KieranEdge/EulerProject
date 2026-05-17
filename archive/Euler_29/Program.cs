using System.Numerics;

List<BigInteger> listOfPowerTerms = new List<BigInteger>();

// Iterate over a
for (int i = 2; i <= 100; i++)
{
    // Iterate over b
    for (int j = 2; j <= 100; j++)
    {
        listOfPowerTerms.Add(BigInteger.Pow(i, j));
    }
}
List<BigInteger> distinctPowerTerms = listOfPowerTerms.Distinct().ToList();
Console.WriteLine(distinctPowerTerms.Count);