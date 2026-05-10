using System.Numerics;

BigInteger basePower = BigInteger.Pow(2, 1000);

string powerValueAsString = basePower.ToString();

List<int> individualDigits = new List<int>();

foreach (char c in powerValueAsString)
{
    individualDigits.Add(int.Parse(c.ToString()));
}

int sum = 0;

foreach (int d in individualDigits)
{
    sum += d;
}

Console.WriteLine(sum);