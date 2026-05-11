using Euler_23.Helpers;

int maxValue = 28123;
List<int> abundantNumbers = new List<int>();
List<int> sumOfTwoAbundantNumbers = new List<int>();

for(int i = 1;  i <= maxValue; i++)
{
    int sumOfDivisors = Divisors.ReturnSumOfDivisors(i);
    if (sumOfDivisors > i)
    {
        abundantNumbers.Add(i);
    }
}

for (int i = 0; i < abundantNumbers.Count(); i++)
{
    for (int j = i; j < abundantNumbers.Count(); j++)
    {
        sumOfTwoAbundantNumbers.Add(abundantNumbers[i] + abundantNumbers[j]);
    }
}

List<int> numbersNotExpressibleAsTheSumOfTwoAbundantNumbers = new List<int>();

for (int i = 1; i <= maxValue; i++)
{
    if (!sumOfTwoAbundantNumbers.Contains(i))
    {
        numbersNotExpressibleAsTheSumOfTwoAbundantNumbers.Add(i);
    }
}
Console.WriteLine(numbersNotExpressibleAsTheSumOfTwoAbundantNumbers.Sum());