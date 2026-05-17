using System.Numerics;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\CSCourse\\ProjectEuler\\Euler_13\\Data.txt";
string[] linesInFile = File.ReadAllLines(filePath);
List<BigInteger> numbers = new List<BigInteger>();

foreach(string line in linesInFile)
{
    numbers.Add(BigInteger.Parse(line));
}

BigInteger Sum = BigInteger.Zero;

foreach(BigInteger number in numbers)
{
    Sum += number;
}

Console.WriteLine(Sum);