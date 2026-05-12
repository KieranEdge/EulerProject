using System.Numerics;

BigInteger termMinusTwo = 2;
BigInteger termMinusOne = 3;
int index = 4;
int numOfDigits = 0;

while (numOfDigits < 1000)
{
    FibonacciCalculator(termMinusTwo, termMinusOne);
    numOfDigits = BigIntegerToString(termMinusOne);
    index++;
}
Console.WriteLine(index);

void FibonacciCalculator(BigInteger n, BigInteger k)
{
    termMinusOne = n + k;
    termMinusTwo = k;
}

static int BigIntegerToString(BigInteger n)
{
    return n.ToString().Length;
}