using Euler_9.Helpers;
using System.ComponentModel.DataAnnotations;

int maxSearchFactor = 20;
List<double> matchingTriple = new List<double>();

for(int i = 1; i <= maxSearchFactor; i++)
{
    for(int j = 1; j <= maxSearchFactor; j++)
    {
        if(j < i)
        {
            List<double> triples = Triples.GeneratePythagoreanTriples(i, j);

            if(triples.Sum() == 1000)
            {
                matchingTriple = triples;
                break;
            }
        }
    }
}

if(matchingTriple.Count > 0)
{
    Console.WriteLine("Matching trible found");
    Console.WriteLine($"a = {matchingTriple[0]}");
    Console.WriteLine($"b = {matchingTriple[1]}");
    Console.WriteLine($"c = {matchingTriple[2]}");

    Console.WriteLine($"Product of factors = {matchingTriple[0] * matchingTriple[1] * matchingTriple[2]}");
}