using System.Numerics;

int end = 100;

BigInteger factorialValue = 1;

for (int i = end; i > 0; i--)
{
    factorialValue *= i;
}

string result = factorialValue.ToString();
char[] chars = result.ToCharArray();

int sumOfDigits = 0;
foreach (char c in chars)
{
    sumOfDigits += c - '0';
}

Console.WriteLine($"{sumOfDigits}");